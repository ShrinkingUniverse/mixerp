/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/

using System.Diagnostics.CodeAnalysis;
using System.Threading;
using MixERP.Net.Common;
using MixERP.Net.DBFactory;
using Npgsql;
using System;
/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;

namespace MixERP.Net.WebControls.ScrudFactory.Data
{
    public static class FormHelper
    {
        public static DataTable GetView(string tableSchema, string tableName, string orderBy, int limit, int offset)
        {
            return DBFactory.FormHelper.GetView(tableSchema, tableName, orderBy, limit, offset);
        }
        
        public static DataTable GetTable(string tableSchema, string tableName)
        {
            return DBFactory.FormHelper.GetTable(tableSchema, tableName);
        }

        public static DataTable GetTable(string tableSchema, string tableName, string columnNames, string columnValues)
        {
            return DBFactory.FormHelper.GetTable(tableSchema, tableName, columnNames, columnValues);
        }

        public static DataTable GetTable(string tableSchema, string tableName, string columnNames, string columnValuesLike, int limit)
        {
            return DBFactory.FormHelper.GetTable(tableSchema, tableName, columnNames, columnValuesLike, limit);
        }

        public static int GetTotalRecords(string tableSchema, string tableName)
        {
            return DBFactory.FormHelper.GetTotalRecords(tableSchema, tableName);
        }

        [SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times"), SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static long InsertRecord(int userId, string tableSchema, string tableName, Collection<KeyValuePair<string, string>> data, string imageColumn)
        {
            if (data == null)
            {
                return 0;
            }

            string columns = string.Empty;
            string columnParamters = string.Empty;

            int counter = 0;

            foreach (KeyValuePair<string, string> pair in data)
            {
                counter++;

                if (counter.Equals(1))
                {
                    columns += DBFactory.Sanitizer.SanitizeIdentifierName(pair.Key);
                    columnParamters += "@" + pair.Key;
                }
                else
                {
                    columns += ", " + DBFactory.Sanitizer.SanitizeIdentifierName(pair.Key);
                    columnParamters += ", @" + pair.Key;
                }
            }

            string sql = "INSERT INTO @TableSchema.@TableName(" + columns + ", audit_user_id) SELECT " + columnParamters + ", @AuditUserId;SELECT LASTVAL();";
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                sql = sql.Replace("@TableSchema", DBFactory.Sanitizer.SanitizeIdentifierName(tableSchema));
                sql = sql.Replace("@TableName", DBFactory.Sanitizer.SanitizeIdentifierName(tableName));

                command.CommandText = sql;

                foreach (KeyValuePair<string, string> pair in data)
                {
                    if (string.IsNullOrWhiteSpace(pair.Value))
                    {
                        command.Parameters.AddWithValue("@" + pair.Key, DBNull.Value);
                    }
                    else
                    {
                        if (pair.Key.Equals(imageColumn))
                        {
                            using (FileStream stream = new FileStream(pair.Value, FileMode.Open, FileAccess.Read))
                            {
                                using (BinaryReader reader = new BinaryReader(new BufferedStream(stream)))
                                {
                                    byte[] byteArray = reader.ReadBytes(Convert.ToInt32(stream.Length));
                                    command.Parameters.AddWithValue("@" + pair.Key, byteArray);
                                }
                            }
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }
                    }
                }

                command.Parameters.AddWithValue("@AuditUserId", userId);

                return Conversion.TryCastLong(DbOperations.GetScalarValue(command));
            }
        }

        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static bool UpdateRecord(int userId, string tableSchema, string tableName, Collection<KeyValuePair<string, string>> data, string keyColumn, string keyColumnValue, string imageColumn)
        {
            if (data == null)
            {
                return false;
            }

            string columns = string.Empty;

            int counter = 0;

            //Adding the current user to the column collection.
            KeyValuePair<string, string> auditUserId = new KeyValuePair<string, string>("audit_user_id", userId.ToString(Thread.CurrentThread.CurrentCulture));
            data.Add(auditUserId);

            foreach (KeyValuePair<string, string> pair in data)
            {
                counter++;

                if (counter.Equals(1))
                {
                    columns += DBFactory.Sanitizer.SanitizeIdentifierName(pair.Key) + "=@" + pair.Key;
                }
                else
                {
                    columns += ", " + DBFactory.Sanitizer.SanitizeIdentifierName(pair.Key) + "=@" + pair.Key;
                }
            }

            string sql = "UPDATE @TableSchema.@TableName SET " + columns + " WHERE @KeyColumn=@KeyValue;";

            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                sql = sql.Replace("@TableSchema", DBFactory.Sanitizer.SanitizeIdentifierName(tableSchema));
                sql = sql.Replace("@TableName", DBFactory.Sanitizer.SanitizeIdentifierName(tableName));
                sql = sql.Replace("@KeyColumn", DBFactory.Sanitizer.SanitizeIdentifierName(keyColumn));

                command.CommandText = sql;

                foreach (KeyValuePair<string, string> pair in data)
                {
                    if (string.IsNullOrWhiteSpace(pair.Value))
                    {
                        command.Parameters.AddWithValue("@" + pair.Key, DBNull.Value);
                    }
                    else
                    {
                        if (pair.Key.Equals(imageColumn))
                        {
                            FileStream stream = new FileStream(pair.Value, FileMode.Open, FileAccess.Read);
                            try
                            {

                                using (BinaryReader reader = new BinaryReader(new BufferedStream(stream)))
                                {
                                    byte[] byteArray = reader.ReadBytes(Convert.ToInt32(stream.Length));
                                    command.Parameters.AddWithValue("@" + pair.Key, byteArray);
                                }
                            }
                            finally
                            {
                                stream.Close();
                            }
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@" + pair.Key, pair.Value);
                        }
                    }
                }

                command.Parameters.AddWithValue("@KeyValue", keyColumnValue);

                return DbOperations.ExecuteNonQuery(command);
            }
        }

        public static bool DeleteRecord(string tableSchema, string tableName, string keyColumn, string keyColumnValue)
        {
            string sql = "DELETE FROM @TableSchema.@TableName WHERE @KeyColumn=@KeyValue";

            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                sql = sql.Replace("@TableSchema", DBFactory.Sanitizer.SanitizeIdentifierName(tableSchema));
                sql = sql.Replace("@TableName", DBFactory.Sanitizer.SanitizeIdentifierName(tableName));
                sql = sql.Replace("@KeyColumn", DBFactory.Sanitizer.SanitizeIdentifierName(keyColumn));
                command.CommandText = sql;

                command.Parameters.AddWithValue("@KeyValue", keyColumnValue);

                return DbOperations.ExecuteNonQuery(command);
            }
        }
    }
}
