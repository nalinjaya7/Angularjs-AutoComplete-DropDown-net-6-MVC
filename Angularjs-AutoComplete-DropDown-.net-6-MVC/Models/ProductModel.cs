using System.ComponentModel.DataAnnotations;

namespace Angularjs_AutoComplete_DropDown_net_6_MVC.Models
{
    public class ProductModel
    {
        public ProductModel(int iD,int productSubCategoryID,string name,string barCode,int reOrderLevel,bool taxInclude,decimal taxRate,decimal unitPrice,decimal quantity, ProductSubCategoryModel productSubCategory)
        {
            ID = iD;
            ProductSubCategoryID = productSubCategoryID; 
            Name = name;
            BarCode = barCode;
            TaxRate = taxRate;
            ReOrderLevel = reOrderLevel;
            TaxInclude = taxInclude;
            UnitPrice = unitPrice;
            Quantity = quantity;
            ProductSubCategory = productSubCategory;           
        }

        public int ID { get; set; }
        [Required]
        [Display(Name = "Product SubCategory")]
        public int ProductSubCategoryID { get; set; }        
        [Required]
        [StringLength(200)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(20)] 
        public string BarCode { get; set; }         
        [Required]
        [Display(Name = "Re-Order Level")]
        public int ReOrderLevel { get; set; }
        [Required]
        [Display(Name = "Tax Include")]
        public bool TaxInclude { get; set; }
        [Display(Name = "Tax Rate")]
        public decimal TaxRate { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Quantity")]
        public decimal Quantity { get; set; }
        public virtual ProductSubCategoryModel ProductSubCategory { get; set; } 

    }

    public partial class ProductCategoryModel 
    {
        public ProductCategoryModel(int iD,string name)
        {
            ID = iD;
            Name = name;
            productSubCategories = new List<ProductSubCategoryModel>();
        }
        public int ID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [StringLength(100)] 
        public string Name { get; set; }
        public virtual List<ProductSubCategoryModel> productSubCategories { get; set; }
    }

    public partial class ProductSubCategoryModel 
    {
        public ProductSubCategoryModel(int iD,int productCategoryID,string name, ProductCategoryModel productCategory)
        {
            ID= iD;
            ProductCategoryID= productCategoryID;
            Name= name;
            ProductCategory = productCategory;
        }

        public int ID { get; set; }
        [Required]
        public int ProductCategoryID { get; set; }
        [Required]
        [Display(Name = "Sub Category Name")]
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ProductCategoryModel ProductCategory { get; set; }
        public virtual List<ProductModel>? Products { get; set; }
    }

}
