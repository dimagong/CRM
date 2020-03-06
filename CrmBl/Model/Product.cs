
using System;

namespace CrmBl.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string NameProduct { get; set; }
        public decimal PriceBase { get; set; }
        public decimal PriceReal { get; set; }
        public string Category { get; set; }
        public decimal Currency { get; set; }
        public int BarCodeItem { get; set; }
        
        //public DateTime? Created { get; set; }


        // this is virtual property to getting data from class Werehouse
            //public virtual Werehouse Werehouse { get; set; }
            //public int WerehouseId { get; set; }


        // this is virtual property to getting data from class CurrentRate
          //public virtual CurrentRate CurrentRates { get; set; }
          //public int CurrentRateId { get; set; }
          //public decimal CurrentValue { get; set; }


        public override string ToString()
        {
            //return $"This number id {ProductId} was created{Created.ToString("dd.MM.yy hh:mm:ss")}";
            return NameProduct;
        }
    }
}
