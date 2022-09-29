using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EAD_project;
using System.IO;
using EAD_project.Models;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using EAD_project.Models.Interface;
using AutoMapper;

namespace EAD_project.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IWebHostEnvironment Environment;
        
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductsController(IWebHostEnvironment environment, IProduct p, IMapper m)
        {
            Environment = environment;
            _product = p;
            _mapper = m;
           
        }

      
        public ViewResult Index()
        {
           var list= _product.productList();
            return View(list);
        }
        public IActionResult GetSearchData(string SearchBy, string SearchValue)
        {
            List<Product> products = new List<Product>();
            if(SearchBy == "Price")
            {
                int Price = Convert.ToInt32(SearchValue);
                products = _product.searchbyPrice(Price, SearchValue);  
                var json = JsonSerializer.Serialize(products);
                return Json(json);
            }
            else
            {
                products = _product.searchbyTitle(SearchValue);       
                var json = JsonSerializer.Serialize(products);
                return Json(json);
            }

        }

        
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _product.Details(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost]
        public ViewResult Create(ViewModel product)
        {
            Product pro = new Product();

            //     if(product.Image != null)
            // {
            var fileN = Path.GetFileName(product.Image.FileName);
            string filename = "images/plots/" + fileN;
            string serverfilename = Path.Combine(Environment.WebRootPath, filename);
            //      string filename = this.Environment.WebRootPath;
            //    string serverfilename = Path.Combine(filename,"Uploads");
            //      string filename = "images/" + product.Image.FileName;
            //      string serverfilename = Path.Combine(Environment.WebRootPath, filename);
            //if (!Directory.Exists(serverfilename))
            //{
            //    Directory.CreateDirectory(serverfilename);
            //}
            //      FileStream f = new FileStream(serverfilename, FileMode.Create);
            product.Image.CopyTo(new FileStream(serverfilename, FileMode.Create));
            //    f.Close();
            //pro.Image = filename;

            ////     }

            //pro.Title = product.Title;
            //pro.NewPrice = product.NewPrice;
            //pro.OldPrice = product.OldPrice;
            //pro.Description= product.Description;
          
            _product.createProduct(pro);
            pro=_mapper.Map<Product>(product);
            return View("Create");
        }
        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }
      

       
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _product.Edit(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);


        }

       
        [HttpPost]
        public IActionResult Edit(int id,  Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {              
                _product.Update(product);
                
                    if (!_product.productExist(product.Id))
                    {
                        return NotFound();
                    }
                   
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _product.delete(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

       
        [HttpPost, ActionName("Delete")]
        
        public IActionResult DeleteConfirmed(int id)
        {
           
           _product.deleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
