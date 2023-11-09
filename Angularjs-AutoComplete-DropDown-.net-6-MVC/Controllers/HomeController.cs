using Angularjs_AutoComplete_DropDown_net_6_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Angularjs_AutoComplete_DropDown_net_6_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ProductSubCategoryModel subCategoryModel1 = new ProductSubCategoryModel(1, 1, "Accessories", new ProductCategoryModel(1, "Electronics"));
            ProductSubCategoryModel subCategoryModel2 = new ProductSubCategoryModel(2, 1, "Camera", new ProductCategoryModel(1, "Electronics"));
            ProductSubCategoryModel subCategoryModel3 = new ProductSubCategoryModel(3, 1, "Computers", new ProductCategoryModel(1, "Electronics"));
            ProductSubCategoryModel subCategoryModel4 = new ProductSubCategoryModel(4, 1, "Headphones & Earbuds", new ProductCategoryModel(1, "Electronics"));
            ProductSubCategoryModel subCategoryModel5 = new ProductSubCategoryModel(5, 1, "Televisions & Video Products", new ProductCategoryModel(1, "Electronics"));

            List<ProductModel> products = new List<ProductModel>();
            products.Add(new ProductModel(1,1, "Airpods Pro 2019 Charging Case", "ITM00001", 100, true, 3.50m,570.00m,340.00m,subCategoryModel1));
            products.Add(new ProductModel(2, 1, "Screen Protector", "ITM00002", 100, true, 3.50m,4000.00m,50.00m, subCategoryModel1));
            products.Add(new ProductModel(3, 1, "Double-Faced Silicone Suction Phone Case", "ITM00003", 100, true, 3.50m,40.00m,800.00m,subCategoryModel1));
            products.Add(new ProductModel(4, 1, "JBL Tune Wireless In-Ear Noise Cancelling Headphones", "ITM00004", 100, true, 3.50m,3500.00m,500.00m, subCategoryModel1));
            products.Add(new ProductModel(5, 1, "HP 952 Cyan", "ITM00005", 100, true, 3.50m,460.00m,654.00m, subCategoryModel1));
            products.Add(new ProductModel(6, 1, "Extendable Cell Phone Holder", "ITM00006", 100, true, 3.50m,1200.00m,600.00m, subCategoryModel1));
            products.Add(new ProductModel(7, 1, "HP 962 Cyan, Magenta, Yellow Ink Cartridges", "ITM00007", 100, true, 3.50m,80.00m,450.00m, subCategoryModel1));
            products.Add(new ProductModel(8, 1, "iPhone Charger [MFi Certified]", "ITM00008", 100, true, 3.50m,500.00m,560.00m, subCategoryModel1));

            products.Add(new ProductModel(9,2, "WYZE Camera Pan v3", "ITM00009", 100, true,3.950m, 5700.00m, 340.00m, subCategoryModel2));
            products.Add(new ProductModel(10,2, "Instant Print Camera", "ITM00010", 100, true, 3.50m, 7000.00m, 50.00m, subCategoryModel2));
            products.Add(new ProductModel(11,2, "Drone with 1080P Dual HD Camera", "ITM00011", 100, true, 3.50m, 840.00m, 800.00m, subCategoryModel2));
            products.Add(new ProductModel(12,2, "Digital Camera 2.7K Ultra HD Mini Camera", "ITM00012", 100, true, 3.50m, 30500.00m, 500.00m, subCategoryModel2));
            products.Add(new ProductModel(13,2, "Kids Waterproof Underwater Camera", "ITM00013", 100, true, 3.50m, 4160.00m, 654.00m, subCategoryModel2));
            products.Add(new ProductModel(14,2, "Kasa Indoor Pan/Tilt Smart Security Camera", "ITM00014", 100, true, 3.50m, 8200.00m, 600.00m, subCategoryModel2));
            products.Add(new ProductModel(15,2, "RADCLO Mini Drone with Camera", "ITM00015", 100, true, 3.50m,8880.00m, 450.00m, subCategoryModel2));
            products.Add(new ProductModel(16,2, "Floodlight Security Camera", "ITM00016", 100, true, 3.50m, 5500.00m, 560.00m, subCategoryModel2));

            products.Add(new ProductModel(17,3, "JCSKY 17-32inch Computer", "ITM00017", 10, true, 3.50m, 9500.00m, 560.00m, subCategoryModel3));
            products.Add(new ProductModel(18,3, "POULEASTER 14\" Ultral Light Laptop", "ITM00018", 190, true, 3.50m, 55550.00m, 560.00m, subCategoryModel3));
            products.Add(new ProductModel(19,3, "G-Anica Laptop Computer", "ITM00019", 970, true, 3.50m, 1200.00m, 560.00m, subCategoryModel3));

            products.Add(new ProductModel(20,4, "JBL Tune Flex - True Wireless Noise Cancelling Earbuds", "ITM00020",100, true, 3.50m,6500.00m, 50.00m, subCategoryModel4));
            products.Add(new ProductModel(21,4, "CXK Wireless Earbuds", "ITM00021", 100, true, 3.50m,8760.00m, 60.00m, subCategoryModel4));
            products.Add(new ProductModel(22,4, "TOZO T10 Bluetooth 5.3 Wireless Earbuds", "ITM00022", 100, true, 3.50m, 1900.00m, 90.00m, subCategoryModel4));
            products.Add(new ProductModel(23,4, "Bluetooth Headphones Wireless Earbuds", "ITM00023", 100, true, 3.50m, 8700.00m, 210.00m, subCategoryModel4));
            products.Add(new ProductModel(24, 4, "JBL Tune 660NC: Wireless On-Ear Headphone", "ITM00024", 100, true, 3.50m, 3300.00m, 50.00m, subCategoryModel4));
            products.Add(new ProductModel(25, 4, "Sony WH-1000XM4 Wireless Premium Noise Canceling Overhead Headphone", "ITM00025", 100, true, 3.50m, 160.00m, 60.00m, subCategoryModel4));
            products.Add(new ProductModel(26, 4, "Soundcore Anker Life Q20 Hybrid Active Noise Cancelling Headphone", "ITM00026", 100, true, 3.50m, 190.00m, 90.00m, subCategoryModel4));
            products.Add(new ProductModel(27, 4, "PRTUKYT 6S Bluetooth Headphones", "ITM00027", 100, true, 3.50m, 870.00m, 210.00m, subCategoryModel4));

            products.Add(new ProductModel(28, 5, "Full Motion TV Monitor", "ITM00028",200, true, 3.50m, 8790.00m, 50.00m, subCategoryModel5));
            products.Add(new ProductModel(29, 5, "VIZIO 40-inch D-Series Full HD 1080p Smart TV", "ITM00029", 200, true, 3.50m, 8960.00m, 60.00m, subCategoryModel5));
            products.Add(new ProductModel(30, 5, "Anker USB C Charger", "ITM00030", 200, true, 3.50m,5900.00m, 90.00m, subCategoryModel5));
            products.Add(new ProductModel(31, 5, "Mounting Dream UL Listed TV", "ITM00031", 200, true, 3.50m, 87700.00m, 210.00m, subCategoryModel5));
            products.Add(new ProductModel(32, 5, "Five Star [Newest 2020] HDTV", "ITM00032", 200, true, 3.50m,53300.00m, 50.00m, subCategoryModel5));
            products.Add(new ProductModel(33, 5, "Apple USB C to USB C Charging Cable", "ITM00033", 200, true, 3.50m, 2160.00m, 60.00m, subCategoryModel5));
            products.Add(new ProductModel(34, 5, "Amazon Basics High-Speed HDMI Cable", "ITM00034", 200, true, 3.50m, 6190.00m, 90.00m, subCategoryModel5));
            products.Add(new ProductModel(35, 5, "SYUKUYU RF Remote Control", "ITM00035", 200, true, 3.50m,9876.00m, 210.00m, subCategoryModel5));

            ViewData["Productlist"] = products;
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}