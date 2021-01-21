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
    
    public string CurrentCategory_test_ID_Tst {}
    public List<CategorySimpleModel> Categories {get; set;}
    //comment
    public class CategoryLineModel : BaseGrandModel
    {
      public string CurrentCategoryId {get_s; s;}
      //comment
      //test
      }
      public CategorySimpleModel category {g; s;}
    }
  }
}
