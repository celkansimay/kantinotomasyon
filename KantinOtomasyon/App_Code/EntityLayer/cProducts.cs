using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cProducts : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public int FrenchiseId { get; set; }
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }
    public string Barcode { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public int Status { get; set; }
    public int StockCount { get; set; }
    public double TotalMaliyet { get; set; }
    public double TotalGelir { get; set; }
    public double RafUrunToplam { get; set; }
    public double ToplamOngorulenKar { get; set; }
    public string StatusText { get; set; }

    #endregion

    #region Methods

    public static List<cProducts> GetProductsByAll(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsByAll(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.Name = row["Name"].ToString();
                item.Manufacturer = row["Manufacturer"].ToString();
                item.Price = double.Parse(row["Price"].ToString());
                item.Barcode = row["Barcode"].ToString();
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cProducts> GetProductsById(int pProductId)
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsById(pProductId);

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.Name = row["Name"].ToString();
                item.Manufacturer = row["Manufacturer"].ToString();
                item.Price = double.Parse(row["Price"].ToString());
                item.Barcode = row["Barcode"].ToString();
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cProducts> GetProductsByBarcode(string pBarcode)
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsByBarcode(pBarcode);

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.FrenchiseId = int.Parse(row["FrenchiseId"].ToString());
                item.Name = row["Name"].ToString();
                item.Manufacturer = row["Manufacturer"].ToString();
                item.Price = double.Parse(row["Price"].ToString());
                item.Barcode = row["Barcode"].ToString();
                item.InsertBy = int.Parse(row["InsertBy"].ToString());
                item.InsertDate = DateTime.Parse(row["InsertDate"].ToString());
                item.Status = int.Parse(row["Status"].ToString());
            }
            List.Add(item);
        }
        return List;
    }

    public static List<cProducts> GetProductsByStockCount(int pFrenchiseId)
    {
        DataTable dt = new DataTable();
        List<cProducts> List = new List<cProducts>();

        dt = DAL.GetProductsByStockCount(pFrenchiseId);

        foreach (DataRow row in dt.Rows)
        {
            cProducts item = new cProducts();
            {
                item.Id = int.Parse(row["Id"].ToString());
                item.Name = row["Name"].ToString();
                item.Manufacturer = row["Manufacturer"].ToString();
                item.Barcode = row["Barcode"].ToString();
                item.Price = double.Parse(row["Price"].ToString());
                item.StockCount = int.Parse(row["StockCount"].ToString());
                item.TotalMaliyet = double.Parse(row["TotalMaliyet"].ToString());
                item.TotalGelir = double.Parse(row["TotalGelir"].ToString());
                item.RafUrunToplam = double.Parse(row["RafUrunToplam"].ToString());
                item.ToplamOngorulenKar = double.Parse(row["ToplamOngorulenKar"].ToString());
                item.StatusText = row["StatusText"].ToString();

            }
            List.Add(item);
        }
        return List;
    }

    public static void UpdateProducts(int pId, string pName, string pManufacturer, string pBarcode, double pPrice, int pUpdateBy)
    {
        DAL.UpdateProducts(pId, pName, pManufacturer, pBarcode, pPrice, pUpdateBy);
    }

    public static void InsertProducts (int pFrenchiseId, string pName, string pManufacturer, string pBarcode, double pPrice, int pInsertBy)
    {
        DAL.InsertProducts(pFrenchiseId, pName, pManufacturer, pBarcode, pPrice, pInsertBy);
    }

    #endregion
}

public partial class DataAccessLayer
{
    public DataTable GetProductsByAll(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetProductsByAll,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }

    public DataTable GetProductsById(int pProductId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetProductsById,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pProductId));
    }

    public DataTable GetProductsByBarcode(string pBarcode)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetProductsByBarcode,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pBarcode));
    }

    public void UpdateProducts(int pId, string pName, string pManufacturer, string pBarcode, double pPrice, int pUpdateBy)
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.UpdateProducts,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pId, pName, pManufacturer, pBarcode, pPrice, pUpdateBy));
    }

    public DataTable GetProductsByStockCount(int pFrenchiseId)
    {
        return (DataTable)MsSqlHelper.ExecuteDataTable(conStringKantin(), SpNameCollection.GetProductsByStockCount,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId));
    }

    public void InsertProducts(int pFrenchiseId, string pName, string pManufacturer, string pBarcode, double pPrice, int pInsertBy )
    {
        MsSqlHelper.ExecuteNonQuery(conStringKantin(), SpNameCollection.InsertProducts,
            MsSqlHelper.sqlParameterMethod((MethodInfo)MethodBase.GetCurrentMethod(), pFrenchiseId, pName, pManufacturer, pBarcode, pPrice, pInsertBy));
    }
}
