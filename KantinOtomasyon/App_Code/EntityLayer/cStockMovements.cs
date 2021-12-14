using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cStockMovements : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int FrenchiseId { get; set; }
    public int InputOutput { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double TotalPrice { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    public static List<cStockMovements> GetStockByAll(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cStockMovements> List = new List<cStockMovements>();

        dt = DAL.GetStockByAll(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cStockMovements item = new cStockMovements();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.InputOutput = int.Parse(row["InputOutput"].ToString());
                item.ProductId = int.Parse(row["ProductId"].ToString());
                item.Quantity = int.Parse(row["Quantity"].ToString());
                item.UnitPrice = double.Parse(row["UnitPrice"].ToString());
                item.TotalPrice = double.Parse(row["TotalPrice"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
    }
    public static List<cStockMovements> GetListProductsByStockCount(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cStockMovements> List = new List<cStockMovements>();

        dt = DAL.GetStockByAll(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cStockMovements item = new cStockMovements();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.InputOutput = int.Parse(row["InputOutput"].ToString());
                item.ProductId = int.Parse(row["ProductId"].ToString());
                item.Quantity = int.Parse(row["Quantity"].ToString());
                item.UnitPrice = double.Parse(row["UnitPrice"].ToString());
                item.TotalPrice = double.Parse(row["TotalPrice"].ToString());
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    //(UserItem[0].FrenchiseId,1,int.Parse(cbProducts.ValueMember.ToString()),quantity,unitPrice,totalPrice
    public static void InsertStockMovements(int pFrenchiseId, int pInputOutput, int pProductId,int pQuantity, double pUnitPrice, double pTotalPrice,int pInsertBy)
    {
        DAL.InsertStockMovements(pFrenchiseId, pInputOutput, pProductId, pQuantity, pUnitPrice, pTotalPrice, pInsertBy);
    }
    //InsertStockMovements
    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetStockByAll(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetStockByAll,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }
    public void InsertStockMovements(int pFrenchiseId, int pInputOutput, int pProductId,int pQuantity, double pUnitPrice, double pTotalPrice,int pInsertBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertStockMovements,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pInputOutput, pProductId, pQuantity, pUnitPrice, pTotalPrice, pInsertBy));
    }
}
