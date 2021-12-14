
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cPurchaseProducts : DataAccess
{
    #region Properties
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    public int InsertBy { get; set; }
    public DateTime InsertDate { get; set; }
    public int UpdateBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public int Status { get; set; }
    #endregion

    #region Methods

    #endregion
}

public partial class DataAccessLayer
{

}