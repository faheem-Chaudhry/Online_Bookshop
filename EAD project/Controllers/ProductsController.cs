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
        // private readonly online_BookshopContext _context;
       // online_BookshopContext _context = new online_BookshopContext();
        private readonly IProduct _product;
        private readonly IMapper _mapper;

        public ProductsController(IWebHostEnvironment environment, IProduct p, IMapper m)
        {
            Environment = environment;
            _product = p;
            _mapper = m;
            //  _context = context;
        }

        // GET: Products
        //public async Task<IActionResult> Index()
        //{
        //      return View(await _context.Products.ToListAsync());
        //}
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
                products = _product.searchbyPrice(Price, SearchValue);  //_context.Products.Where(x => x.NewPrice == Price || SearchValue == null).ToList();
                var json = JsonSerializer.Serialize(products);
                return Json(json);
            }
            else
            {
                products = _product.searchbyTitle(SearchValue);        //_context.Products.Where(x => x.Title.Contains(SearchValue) || SearchValue == null).ToList();
                var json = JsonSerializer.Serialize(products);
                return Json(json);
            }

        }

        // GET: Products/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Products == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Products
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(product);
        //}
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
            pro.Image = filename;

            //     }

            pro.Title = product.Title;
            pro.NewPrice = product.NewPrice;
            pro.OldPrice = product.OldPrice;
            pro.Description= product.Description;
          
            _product.createProduct(pro);
            return View("Create");
        }
        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }
        // GET: Products/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Products/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Title,OldPrice,NewPrice,Image,Description")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(product);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(product);
        //}

        // GET: Products/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Products == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Products.FindAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(product);
        //}
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

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,OldPrice,NewPrice,Image,Description")] Product product)
        //{
        //    if (id != product.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(product);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ProductExists(product.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(product);
        //}
        [HttpPost]
        public IActionResult Edit(int id, /*[Bind("Id,Title,OldPrice,NewPrice,Image,Description")]*/ Product product)
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

        // POST: Products/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Products == null)
        //    {
        //        return Problem("Entity set 'online_BookshopContext.Products'  is null.");
        //    }
        //    var product = await _context.Products.FindAsync(id);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //    }
            
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost, ActionName("Delete")]
        
        public IActionResult DeleteConfirmed(int id)
        {
            if (!_product.productExist(id))
            {
                return Problem("Entity set 'online_BookshopContext.Products'  is null.");
            }
           _product.deleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

        //private bool ProductExists(int id)
        //{
        //  return _context.Products.Any(e => e.Id == id);
        //}
    }
}
