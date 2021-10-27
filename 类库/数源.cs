using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数据库扩展.类库
{
    public enum 数源种类
    {
        Access,
        Excel,
        MySql,
        Npgsql,
        Odbc,
        OleDb,
        SqlClient,
        SQLite,
        NullSql
    }
    class 数源
    {
        public static DbProviderFactory 提供者(数源种类 源类型)
        {
            return 源类型 switch
            {
                数源种类.Odbc => System.Data.Odbc.OdbcFactory.Instance,
                数源种类.OleDb => System.Data.OleDb.OleDbFactory.Instance,
                数源种类.SqlClient => System.Data.SqlClient.SqlClientFactory.Instance,
                数源种类.MySql => MySql.Data.MySqlClient.MySqlClientFactory.Instance,
                数源种类.Npgsql => Npgsql.NpgsqlFactory.Instance,
                数源种类.NullSql => null,
                _ => System.Data.OleDb.OleDbFactory.Instance,
            };
        }
        public static DbProviderFactory 提供者(String 源类型)
        {
            return 提供者(转枚举(源类型));
        }
        private static 数源种类 转枚举(string 源类型)
        {
            if(String.IsNullOrEmpty(源类型)) return 数源种类.NullSql;
            数源种类 Result;
            if(Enum.TryParse<数源种类>(源类型, out Result)) return Result;
            else return 数源种类.NullSql;
        }
        public static DbCommand 命令器(数源种类 源类型) => 提供者(源类型)?.CreateCommand();
        public static DbCommandBuilder 命令生成器(数源种类 源类型) => 提供者(源类型)?.CreateCommandBuilder();
        public static DbConnection 连接器(数源种类 源类型) => 提供者(源类型)?.CreateConnection();
        public static DbConnectionStringBuilder 连接串生成器(数源种类 源类型) => 提供者(源类型)?.CreateConnectionStringBuilder();
        public static DbDataAdapter 适配器(数源种类 源类型) => 提供者(源类型)?.CreateDataAdapter();
        public static DbDataSourceEnumerator 命令(数源种类 源类型) => 提供者(源类型)?.CreateDataSourceEnumerator();
        public static DbParameter 命令参数(数源种类 源类型) => 提供者(源类型)?.CreateParameter();



        public static String 生成连接串(数源种类 源类型, string 驱动名, string 服务器, string 数据库, string 用户, string 密码, bool 集成验证 = false)
        {

            var builder = 连接串生成器(源类型);

            //驱动软件设置："Provider"，"Driver"
            builder["Provider"] = 驱动名;

            //数源服务器设置："Data Source"，"Server"
            //本地用名称，远程用IP+PORT
            builder["Server"] = 服务器;

            //数据库设置："Initial Catalog","Database"
            builder["Initial Catalog"] = 数据库;

            //信任连接设置："Integrated Security"，"Trusted_Connection"
            if(集成验证)
            {
                builder["Integrated Security"] = "SSIP";
            }
            else
            {
                builder["User ID"] = 用户;
                builder["Password"] = 密码;
            }
            builder["Pooling"] = true;
            builder["Min Pool Size"] = 10;
            builder["Max Pool Size"] = 100;
            builder["Connection Timeout"] = 1000;
            return builder.ConnectionString;
        }

        public static DbConnection 连接器(String 源类型, String 连接串)
        {
            if(String.IsNullOrEmpty(源类型) || String.IsNullOrEmpty(连接串)) return null;

            var conn = 连接器(转枚举(源类型));
            conn.ConnectionString = 连接串;
            return conn;
        }
        public static DbCommand 命令器(String 源类型, String 命令串)
        {
            if(String.IsNullOrEmpty(源类型) || String.IsNullOrEmpty(命令串)) return null;

            var comm = 命令器(转枚举(源类型));
            comm.CommandText = 命令串;
            return comm;
        }
        public static DbCommand 命令器(String 源类型, String 连接串, String 命令串)
        {
            if(String.IsNullOrEmpty(源类型) || String.IsNullOrEmpty(连接串) || String.IsNullOrEmpty(命令串)) return null;

            var conn = 连接器(源类型, 连接串);
            var comm = conn.CreateCommand();
            comm.CommandText = 命令串;
            return comm;
        }
        public static DbDataAdapter 适配器(String 源类型, String 连接串, String 命令串)
        {
            if(String.IsNullOrEmpty(源类型) || String.IsNullOrEmpty(连接串) || String.IsNullOrEmpty(命令串)) return null;

            var adapter = 适配器(转枚举(源类型));
            var comm = 命令器( 源类型,  连接串,  命令串);
            adapter.SelectCommand = comm;
            var cmdb = 命令生成器(转枚举(源类型));
            cmdb.DataAdapter = adapter;
            //据说以下三条可以不写，cmdb与ad一对一绑定，自动生成！
            //adapter.DeleteCommand = cmdb.GetDeleteCommand();
            //adapter.InsertCommand = cmdb.GetInsertCommand();
            //adapter.UpdateCommand = cmdb.GetUpdateCommand();
            //cmdb.RefreshSchema();
            return adapter;
        }

    }
    class 数源集 : List<数源>
    {

    }

}
