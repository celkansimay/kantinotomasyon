using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cProductSales : DataAccess
{
    #region Properties
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public int SalesBy { get; set; }
    public DateTime SalesDate { get; set; }
    public int Status { get; set; }
    #endregion

    #region Methods
    public static List<cProductSales> GetProductSalesByStock(int pProductId)
    {
        DataTable dt = new DataTable();
        List<cProductSales> List = new List<cProductSales>();

        dt = DAL.GetProductSalesByStock(pProductId);

        foreach (DataRow row in dt.Rows)
        {
            cProductSales item = new cProductSales();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.ProductId = int.Parse(row["ProductId"].ToString());
                item.UserId = int.Parse(row["UserId"].ToString());
                item.Price = double.Parse(row["Price"].ToString());
                item.Quantity = int.Parse(row["Quantity"].ToString());
                item.SalesBy = int.Parse(row["SalesBy"].ToString());
                item.SalesDate = DateTime.Parse(row["SalesDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());

            }
            List.Add(item);
        }
        return List;
    }

    public static void InsertProductSales(int pProductId, int pUserId, int pQuantity, double pPrice, int pSalesBy)
    //productItem[0].Id, productItem[0].Barcode, productItem[0].Manufacturer, productItem[0].Name, 1, productItem[0].Price, productItem[0].Price, UserItem[0].Id
    {
        DAL.InsertProductSales( pProductId,  pUserId,  pQuantity,  pPrice,  pSalesBy);
    }
    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetProductSalesByStock(int pProductId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetProductsByStockCount,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pProductId));
    }

    public void InsertProductSales(int pProductId, int pUserId, int pQuantity, double pPrice, int pSalesBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertProductSales,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pProductId, pUserId, pQuantity, pPrice, pSalesBy));
    }
}