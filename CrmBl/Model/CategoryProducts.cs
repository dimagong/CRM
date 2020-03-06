
namespace CrmBl.Model
{
    public class CategoryProducts
    {
       
        public int CategoryProductsId { get; set; }
        public string NameProducts { get; set; }

        public override string ToString()
        {
            return NameProducts;
        }
    }
}
