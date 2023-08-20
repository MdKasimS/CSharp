using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Packt.Shared
{
    public class Category
    {
        private int categoryID;
        private string categoryName;
        private string description;
        private ICollection<Product> products;
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        [Column(TypeName = "ntext")]
        public string Description { get => description; set => description = value; }
        public virtual ICollection<Product> Products { get => products; set => products = value; }

        public Category()
        {
            this.Products = new List<Product>();
        }
    }
}