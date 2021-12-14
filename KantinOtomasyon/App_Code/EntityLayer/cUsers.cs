using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cUsers : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int FrenchiseId { get; set; }
    public int UserType { get; set; }
    public string CardNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public int AuthType { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public int Status { get; set; }
    public DateTime LicencesEndDate { get; set; }
    public string UserTypeName { get; set; }

    #endregion

    #region Methods

    public static List<cUsers> LoginUsers(string pUserName, string pPassword)
    {
        DataTable dt = new DataTable();
        List<cUsers> List = new List<cUsers>();

        dt = DAL.LoginUsers(pUserName, pPassword);

        foreach (DataRow row in dt.Rows)
        {
            cUsers item = new cUsers();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.UserType = int.Parse(row["UserType"].ToString());
                item.CardNumber = row["CardNumber"].ToString();
                item.Name = row["Name"].ToString();
                item.Surname = row["Surname"].ToString();
                item.AuthType = int.Parse(row["AuthType"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                //item.UpdateDate = !string.IsNullOrEmpty(row["UpdateDate"].ToString()) ? DateTime.Parse(row["UpdateDate"].ToString()) : DateTime.Parse(null);
                item.Status = int.Parse(row["Status"].ToString());
                item.LicencesEndDate = DateTime.Parse(row["LicencesEndDate"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cUsers> GetListByUsers(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cUsers> List = new List<cUsers>();

        dt = DAL.GetListByUsers(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cUsers item = new cUsers();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.UserType = int.Parse(row["UserType"].ToString());
                item.CardNumber = row["CardNumber"].ToString();
                item.Name = row["Name"].ToString();
                item.UserName = row["UserName"].ToString();
                item.Surname = row["Surname"].ToString();
                item.AuthType = int.Parse(row["AuthType"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                //item.UpdateDate = !string.IsNullOrEmpty(row["UpdateDate"].ToString()) ? DateTime.Parse(row["UpdateDate"].ToString()) : DateTime.Parse(null);
                item.Status = int.Parse(row["Status"].ToString());
                item.UserTypeName = row["UserTypeName"].ToString();
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cUsers> GetUsersById(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cUsers> List = new List<cUsers>();

        dt = DAL.GetUsersById(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cUsers item = new cUsers();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.UserType = int.Parse(row["UserType"].ToString());
                item.CardNumber = row["CardNumber"].ToString();
                item.Name = row["Name"].ToString();
                item.UserName = row["UserName"].ToString();
                item.Surname = row["Surname"].ToString();
                item.AuthType = int.Parse(row["AuthType"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                //item.UpdateDate = !string.IsNullOrEmpty(row["UpdateDate"].ToString()) ? DateTime.Parse(row["UpdateDate"].ToString()) : DateTime.Parse(null);
                item.Status = int.Parse(row["Status"].ToString());
                //item.UserTypeName = row["UserTypeName"].ToString();
            }
            List.Add(item);
        }
        return List;
    }

    public static void UpdateUsers(int pId, string pName, string pSurname, string pUserName, string pCardNumber)
    {
        //userId, txtName.Text, txtSurname.Text, txtUserName.Text, txtCardNumber.Text, UserItem[0].Id
        DAL.UpdateUsers(pId, pName, pSurname, pUserName, pCardNumber);
    }
    public static void InsertUsers(int pFrenchiseId, string pName, string pSurname, string pUserName, string pCardNumber, string pPassword,int pUserType,int pInsertBy)
    {
        //int pFrenchiseId, string pName, string pManufacturer, string pBarcode, double pPrice, int pInsertBy
        //userId, txtName.Text, txtSurname.Text, txtUserName.Text, txtCardNumber.Text, UserItem[0].Id
        DAL.InsertUsers(pFrenchiseId, pName, pSurname, pUserName, pCardNumber, pPassword, pUserType, pInsertBy);
    }
    #endregion
}

public partial class DataAccessLayer
{
    public DataTable LoginUsers(string pUserName, string pPassword)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.LoginUsers,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pUserName, pPassword));
    }
    public DataTable GetListByUsers(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetListByUsers,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }

    public DataTable GetUsersById(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetUsersById,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public void UpdateUsers(int pId, string pName, string pSurname, string pUserName, string pCardNumber)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.UpdateUsers,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId, pName, pSurname, pUserName, pCardNumber));
    }
    public void InsertUsers(int pFrenchiseId, string pName, string pSurname, string pUserName, string pCardNumber,string pPassword,int pUserType,int pInsertBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertUsers,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pName, pSurname, pUserName, pCardNumber, pPassword, pUserType, pInsertBy));
    }
}
