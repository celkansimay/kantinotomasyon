using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
public partial class DataAccessLayer
{
    public DataAccessLayer()
    {
    }

    public static string conString()
    {
        string connection = @"server=185.131.49.115\MSSQLSERVER2014;database=oybs;uid=oybs_user;password=Hro4?8c0;";
        return connection;
    }

    public static string conStringKantin()
    {
        string connection = @"server=185.131.49.115\MSSQLSERVER2014;database=flamingo_kantin;uid=kantin_user;password=L%z1m7c5;";
        return connection;
    }
}