using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Entities.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    
        public ICollection<Product> Products { get; set; }
        
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
