using EAD_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using EAD_project.Models.Interface;


namespace EAD_project.Controllers
{

    public class HomeController : Controller
    {
    ////    private readonly online_BookshopContext _context;
    //    online_BookshopContext _context=new online_BookshopContext();
        List<SignUp> signupList = new List<SignUp>();
        List<Product> pro = new List<Product>();
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment Environment;
        private readonly ISignUp _signUp;
        online_BookshopContext _context = new online_BookshopContext();
        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment, ISignUp s)
        {
            _signUp = s;
            _logger = logger;
            Environment = environment;
        //    _context = context;
        }
        private void FetchData()
        {
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=online_Bookshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //SqlConnection con = new SqlConnection(connString);
            //con.Open();
            //string query = "select [userName], [email], [password] from [signUp]";
            //SqlCommand cmd = new SqlCommand(query, con);
            
            //SqlDataReader dr = cmd.ExecuteReader();
            //while(dr.Read())
            //{
            //    signupList.Add(new SignUp() { UserName = dr["userName"].ToString()
            //    ,Email=dr["email"].ToString()
            //    ,Password=dr["password"].ToString()});
            //}
            //con.Close();
        }
       

       

        
      //  [HttpPost]
      //  public ViewResult Product(ViewModel product)
      //  {
      //      Product pro=new Product();

      //      //     if(product.Image != null)
      //      // {
      //       var fileN = Path.GetFileName(product.Image.FileName);
      //       string filename = "images/plots/" + fileN;
      //       string serverfilename = Path.Combine(Environment.WebRootPath,filename);
      //  //      string filename = this.Environment.WebRootPath;
      //    //    string serverfilename = Path.Combine(filename,"Uploads");
      ////      string filename = "images/" + product.Image.FileName;
      ////      string serverfilename = Path.Combine(Environment.WebRootPath, filename);
      //      //if (!Directory.Exists(serverfilename))
      //      //{
      //      //    Directory.CreateDirectory(serverfilename);
      //      //}
      ////      FileStream f = new FileStream(serverfilename, FileMode.Create);
      //          product.Image.CopyTo(new FileStream(serverfilename, FileMode.Create));
      //      //    f.Close();
      //          pro.Image = filename;

      //      //     }
           
      //      pro.Title=product.Title;
      //      pro.NewPrice = product.NewPrice;
      //      pro.OldPrice = product.OldPrice;
      //      ProductRepository productRepository = new ProductRepository();
      //      productRepository.checksignUp(pro);
      //      return View("Product");
      //  }
      //  [HttpGet]
      //  public ViewResult Product()
      //  {
          
      //      return View();
      //  }
        public ViewResult Welcome()
        {
            FetchData();
            return View(signupList);
        }
        public ViewResult productDetail(int? id)
        {
            var product = _context.Products.Where(m => m.Id == id).FirstOrDefault();
            return View(product);
        }
        public ViewResult ShoeProduct()
        {
            
            return View(pro);
        }

        public ViewResult About()
        {
            return View();
        }
        public PartialViewResult validation()
        {
            return PartialView();
        }
        public ViewResult Home()
        {
            ProductRepository productRepository = new ProductRepository();
            productRepository.addtoList(pro);
            ViewBag.cookie = HttpContext.Request.Cookies["first_request"];
            return View(pro);
        }
        public ViewResult notWelcome()
        {
            return View();
        }
        public ViewResult Index()
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
