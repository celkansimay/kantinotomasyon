using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cSavedUsersCredit : DataAccess
{
    #region Properties
    public int Id { get; set; }
    public int SavedUserId { get; set; }
    public float Amount { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int Status { get; set; }

    #endregion
    #region Methods
    public static List<cSavedUsersCredit> GetSavedUsersCredit(int pSavedUserId)
    {
        DataTable dt = new DataTable();
        List<cSavedUsersCredit> List = new List<cSavedUsersCredit>();

        dt = DAL.GetSavedUsersCredit(pSavedUserId);

        foreach (DataRow row in dt.Rows)
        {
            cSavedUsersCredit item = new cSavedUsersCredit();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.SavedUserId = int.Parse(row["SavedUserId"].ToString());
                item.Amount = int.Parse(row["Amount"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());

            }
            List.Add(item);
        }
        return List;
    }
    public static void InsertAmount(int pSavedUserId, double pAmount, int pInsertBy)
    {
        DAL.InsertAmount(pSavedUserId, pAmount, pInsertBy);
    }
    #endregion

}
public partial class DataAccessLayer
{
    public DataTable GetSavedUsersCredit(int pSavedUserId)

    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetSavedUsersCredit,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pSavedUserId));
    }
    public void InsertAmount(int pSavedUserId, double pAmount, int pInsertBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertAmount,
         MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pSavedUserId, pAmount,  pInsertBy));
    }
}