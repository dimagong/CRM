
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class CurrentRate
    {
        public int CurrentRateId { set; get; }
        public string NameCurrent { set; get; }
        public string CodeCurrent { set; get; }
        public decimal CurrentValue { set; get; }
        public string DataCurrentUpdate { set; get; }

        //this is collection thet tie up with class Product
           //public virtual ICollection<Product> Products { set; get; }

        public override string ToString()
        {
            return NameCurrent;
        }
    }
}
