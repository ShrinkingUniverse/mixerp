using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MixERP.Net.DatabaseLayer.EF.Core
{
    public class MenuService
    {
        //public static DataTable GetMenuTable(string path, short level, int userId, int officeId, string culture)
        //{
        //    if (userId.Equals(0))
        //    {
        //        return null;
        //    }

        //    if (officeId.Equals(0))
        //    {
        //        return null;
        //    }

        //    const string sql = "SELECT * FROM policy.get_menu(@UserId, @OfficeId, @Culture) WHERE parent_menu_id=(SELECT menu_id FROM core.menus WHERE url=@Url) AND level=@Level ORDER BY menu_id;";
        //    using (NpgsqlCommand command = new NpgsqlCommand(sql))
        //    {
        //        command.Parameters.AddWithValue("@UserId", userId);
        //        command.Parameters.AddWithValue("@OfficeId", officeId);
        //        command.Parameters.AddWithValue("@Culture", culture);
        //        command.Parameters.AddWithValue("@Url", path);
        //        command.Parameters.AddWithValue("@Level", level);

        //        return DbOperations.GetDataTable(command);
        //    }
        //}

        //public static DataTable GetRootMenuTable(string path, int userId, int officeId, string culture)
        //{
        //    if (userId.Equals(0))
        //    {
        //        return null;
        //    }

        //    if (officeId.Equals(0))
        //    {
        //        return null;
        //    }

        //    const string sql = "SELECT * FROM policy.get_menu(@UserId, @OfficeId, @Culture) WHERE parent_menu_id=core.get_root_parent_menu_id(@Url) ORDER BY menu_id;";
        //    using (NpgsqlCommand command = new NpgsqlCommand(sql))
        //    {
        //        command.Parameters.AddWithValue("@UserId", userId);
        //        command.Parameters.AddWithValue("@OfficeId", officeId);
        //        command.Parameters.AddWithValue("@Culture", culture);
        //        command.Parameters.AddWithValue("@Url", path);
        //        return DbOperations.GetDataTable(command);
        //    }
        //}

        //public static DataTable GetMenuTable(int parentMenuId, short level, int userId, int officeId, string culture)
        //{
        //    if (userId.Equals(0))
        //    {
        //        return null;
        //    }

        //    if (officeId.Equals(0))
        //    {
        //        return null;
        //    }

        //    string sql = "SELECT * FROM policy.get_menu(@UserId, @OfficeId, @Culture) WHERE parent_menu_id is null ORDER BY menu_id;";

        //    if (parentMenuId > 0)
        //    {
        //        sql = "SELECT * FROM policy.get_menu(@UserId, @OfficeId, @Culture) WHERE parent_menu_id=@ParentMenuId AND level=@Level ORDER BY menu_id;";
        //    }

        //    using (NpgsqlCommand command = new NpgsqlCommand(sql))
        //    {
        //        command.Parameters.AddWithValue("@UserId", userId);
        //        command.Parameters.AddWithValue("@OfficeId", officeId);
        //        command.Parameters.AddWithValue("@Culture", culture);

        //        if (parentMenuId > 0)
        //        {
        //            command.Parameters.AddWithValue("@ParentMenuId", parentMenuId);
        //            command.Parameters.AddWithValue("@Level", level);
        //        }


        //        return DbOperations.GetDataTable(command);
        //    }
        //}
    }
}
