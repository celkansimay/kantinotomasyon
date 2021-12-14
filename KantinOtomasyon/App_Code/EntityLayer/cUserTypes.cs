using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cUserTypes : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Text { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods
    public static List<cUserTypes> GetUserTypesByAll()
    {
        DataTable dt = new DataTable();
        List<cUserTypes> List = new List<cUserTypes>();

        dt = DAL.GetUserTypesByAll();

        foreach (DataRow row in dt.Rows)
        {
            cUserTypes item = new cUserTypes();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.Text = row["Text"].ToString();
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
        
    }
    #endregion
}
public partial class DataAccessLayer
{
    public DataTable GetUserTypesByAll()
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetUserTypesByAll,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod()));
    }
}