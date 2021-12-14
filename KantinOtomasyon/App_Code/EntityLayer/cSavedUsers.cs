using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]

public class cSavedUsers : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int FrenchiseId { get; set; }
    public int UserTypes { get; set; }
    public int AboutId { get; set; }
    public string CardNumber { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }
    public int Status { get; set; }


    public string StudentName { get; set; }
    public string StudentSurname { get; set; }

    public double KalanBakiye { get; set; }

    #endregion

    #region Methods
    public static List<cSavedUsers> GetSavedUserByCardNumber(int pFrenchiseId, string pCardNumber)
    {
        DataTable dt = new DataTable();
        List<cSavedUsers> List = new List<cSavedUsers>();

        dt = DAL.GetSavedUserByCardNumber(pFrenchiseId, pCardNumber);

        foreach (DataRow row in dt.Rows)
        {
            cSavedUsers item = new cSavedUsers();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.UserTypes = int.Parse(row["UserTypes"].ToString());
                item.AboutId = int.Parse(row["AboutId"].ToString());
                item.CardNumber = row["CardNumber"].ToString();
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.UpdateBy = !string.IsNullOrEmpty(row["UpdateBy"].ToString()) ? int.Parse(row["UpdateBy"].ToString()) : -1;
                item.UpdateDate = !string.IsNullOrEmpty(row["UpdateDate"].ToString()) ? DateTime.Parse(row["UpdateDate"].ToString()) : DateTime.MinValue;
                item.Status = int.Parse(row["Status"].ToString());
                item.StudentName = row["StudentName"].ToString();
                item.StudentSurname = row["StudentSurname"].ToString();
            }
            List.Add(item);
        }
        return List;
    }
    public static List<cSavedUsers> GetSavedUserCreditByCardNumber(int pSavedIserId)
    {
        DataTable dt = new DataTable();
        List<cSavedUsers> List = new List<cSavedUsers>();

        dt = DAL.GetSavedUserCreditByCardNumber(pSavedIserId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedUsers item = new cSavedUsers();
            {
                item.KalanBakiye = double.Parse(row["KalanBakiye"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    //
    public static void InsertSavedUsers(int pFrenchiseId, int pUserTypes, int pAboutId, string pCardNumber, int pInsertBy)
    {
        //(UserItem[0].FrenchiseId, txtName.Text, txtSurname.Text, txtParentName.Text, txtClassName.Text, txtSchoolName.Text, txtCardNumber.Text, UserItem[0].Id, 1)
        DAL.InsertSavedUsers(pFrenchiseId, pUserTypes, pAboutId, pCardNumber, pInsertBy);
    }
    #endregion
}
public partial class DataAccessLayer
{
    public DataTable GetSavedUserByCardNumber(int pFrenchiseId, string pCardNumber)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetSavedUserByCardNumber,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pCardNumber));
    }
    public DataTable GetSavedUserCreditByCardNumber(int pSavedIserId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetSavedUserCreditByCardNumber,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pSavedIserId));
    }
    public void InsertSavedUsers(int pFrenchiseId, int pUserTypes, int pAboutId, string pCardNumber, int pInsertBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertSavedUsers,
         MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pUserTypes, pAboutId, pCardNumber, pInsertBy));
    }
}
