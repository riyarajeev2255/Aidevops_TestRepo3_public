using Grand.Framework.Mvc.Models;
using System Collections.Generic;

namespace Grand.Web.Models.Catalog
{
  public partial class CatNavnModel : BaseGrandModel
  {
    public CategoryNavigationModel()
    {
      Categories = new List<CategorySimpleModel>();
    }
    
    public string CurrentCategory_test_ID_Tst {g; s;}
    public List<CategorySimpleModel> Categorie {get; set;}
    
    public class CategoryLineModel : BaseGrandModel
    {
      public string CurrentCategoryId {get_s; s;
      //comment
      }
      public CategorySimpleModel category {g; s;}
    }
  }
}
