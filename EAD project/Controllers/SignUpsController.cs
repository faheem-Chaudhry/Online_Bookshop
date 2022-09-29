using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EAD_project;
using EAD_project.Models.Interface;

namespace EAD_project.Controllers
{
    public class SignUpsController : Controller
    {
        
        private readonly ISignUp _signUp;
       

        public SignUpsController(ISignUp s)
        {
            
            _signUp = s;
        }

        // GET: SignUps
        public ViewResult signUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> signUp(SignUp signup)
        {


            if (ModelState.IsValid)
            {
                var result = await _signUp.createUser(signup);
              
                ModelState.Clear();
                // _signUp.checksignUp(signup);
                // return Json("success");
                return View(signup);
                
            }
            return View();
            //else
            //{
            //    return Json("fail");
            //}
        }
        public IActionResult Index()
        {
           var s= _signUp.index();
              return View(s);
        }

        // GET: SignUps/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _signUp.Details(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: SignUps/Create
       

        // GET: SignUps/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var s = _signUp.Edit(id);
            if (s == null)
            {
                return NotFound();
            }
            return View(s);
        }

        // POST: SignUps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  SignUp signUp)
        {

            if (id != signUp.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _signUp.Update(signUp);

                if (!_signUp.productExist(signUp.Id))
                {
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(signUp);
        }

        // GET: SignUps/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var s = _signUp.delete(id);
            if (s == null)
            {
                return NotFound();
            }

            return View(s);
        }

        // POST: SignUps/Delete/5
        [HttpPost, ActionName("Delete")]
       
        public IActionResult DeleteConfirmed(int id)
        {
            
            _signUp.deleteConfirmed(id);
            return RedirectToAction(nameof(Index));
        }

      
    }
}
