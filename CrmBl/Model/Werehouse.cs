
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Werehouse
    {
        public int WerehouseId { set; get; }
        public string NameWerehouse { set; get; }
        public string AddressWerehouse { set; get; }


        //this is collection thet tie up with class Product
            //public virtual ICollection<Product> Products { set; get; }
  

        public override string ToString()
        {
            return NameWerehouse;
        }
    }
}
