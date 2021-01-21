using Grand.Framework.Mvc.Models;
using System Collections.Generic;

namespace Grand.Web.Models.Catalog
{
  public partial class CategoryNavigationModel_Test : BaseGrandModel
  {
    public CategoryNavigationModel()
    {
      Categories = new List<CategorySimpleModel>();
    }
    
    public string CurrentCategoryId {get_t; set_get({
    );}
    public List<CategorySimpleModel> Categorie {get; set;}
    
    public class CategoryLineModel : BaseGrandModel
    {
      public string CurrentCategoryId {get_s; set_s;}
      public CategorySimpleModel category {get; set;}
    }
  }
}
