using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection;


public class MsSqlHelper
{

    public static void ExecuteNonQuery(string strConnection, string commandText, params SqlParameter[] sqlParameters)
    {
        SqlConnection connection = new SqlConnection(strConnection);
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }

        SqlCommand command = new SqlCommand();
        if (connection.State != ConnectionState.Open)
            connection.Open();
        command.Connection = connection;
        command.CommandTimeout = 600;
        command.CommandText = commandText;
        command.CommandType = CommandType.StoredProcedure;
        if (sqlParameters != null)
        {
            foreach (SqlParameter sqlParameter in sqlParameters)
            {
                if (sqlParameter.Direction == ParameterDirection.InputOutput && sqlParameter.Value == null)
                    sqlParameter.Value = (object)DBNull.Value;
                command.Parameters.Add(sqlParameter);
            }
        }

        int num = command.ExecuteNonQuery();
        command.Parameters.Clear();
        connection.Close();
    }

    public static DataTable ExecuteDataTable(string strConnection, string commandText, params SqlParameter[] sqlParameters)
    {
        SqlConnection connection = new SqlConnection(strConnection);
        if (connection.State == ConnectionState.Open)
        {
            connection.Close();
        }
        

        SqlCommand command = new SqlCommand();

        if (connection.State != ConnectionState.Open)
            connection.Open();
        command.Connection = connection;
        command.CommandText = commandText;
        command.CommandType = CommandType.StoredProcedure;
        if (sqlParameters != null)
        {
            foreach (SqlParameter sqlParameter in sqlParameters)
            {
                if (sqlParameter.Direction == ParameterDirection.InputOutput && sqlParameter.Value == null)
                    sqlParameter.Value = (object)DBNull.Value;
                command.Parameters.Add(sqlParameter);
            }
        }
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
        DataSet dataSet = new DataSet();
        ((DataAdapter)sqlDataAdapter).Fill(dataSet);
        command.Parameters.Clear();
        connection.Close();
        return dataSet.Tables[0];
    }

    public static SqlParameter[] sqlParameterMethod(MethodInfo methodInfo, params object[] objectValues)
    {
        int index = 0;
        SqlParameter[] sqlParameter = new SqlParameter[objectValues.Length];
        ParameterInfo[] methodParameters = methodInfo.GetParameters();
        foreach (ParameterInfo paramInfo in methodParameters)
        {
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@" + paramInfo.Name;
            parameter.Value = objectValues[index];
            sqlParameter[index] = parameter;
            index++;
        }
        return sqlParameter;
    }
}