using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercial.Entities.Concrete
{
    public class Company:BaseEntity
    {
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set;}
        public string CompanyAddress { get; set;}
        public string CompanyCity { get; set;}
        public string CompanyState { get; set;}
        public string CompanyEmail { get; set;}
        public string CompanyPhone { get; set;}
        public string CompanyDetail { get; set;}
        public string WhoWeAre {  get; set;}

    }
}
