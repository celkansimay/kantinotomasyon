using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class cUserAuthTypes : DataAccess
{
    #region Properties

    public int Id { get; set; }
    public string Text { get; set; }
    public int Status { get; set; }

    #endregion

    #region Methods

    #endregion
}

public partial class DataAccessLayer
{

}