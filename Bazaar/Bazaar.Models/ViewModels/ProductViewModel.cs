using System.Collections.Generic;

namespace Bazaar.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CategoryList { get; set; }

    }
}
