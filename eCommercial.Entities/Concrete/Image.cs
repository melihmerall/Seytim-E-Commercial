using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Entities.Concrete
{
    public partial class Image : BaseEntity
    {
        public long ProductId { get; set; }
        public virtual Product Products { get; set; }
        public string ImagePath { get; set; }
    }
}
