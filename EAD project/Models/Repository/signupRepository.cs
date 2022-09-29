using Microsoft.Data.SqlClient;
using EAD_project.Models.Interface;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace EAD_project.Models
{
    public class signupRepository : ISignUp
    {
        private readonly UserManager<IdentityUser> _usermanager;
        public signupRepository(UserManager<IdentityUser> usermanager)
        {
            _usermanager = usermanager;
        }
        public async Task<IdentityResult> createUser(SignUp signup)
        {
            var user = new IdentityUser()
            {
                UserName = signup.UserName,
                Email = signup.Email
            };
            var result =await _usermanager.CreateAsync(user, signup.Password);
            return result;
        }
        public void checksignUp(SignUp signup)
        {
            var context=new online_BookshopContext();
            context.SignUps.Add(signup);
            context.SaveChanges();
        }
        public List<SignUp> index()
        {
            var context = new online_BookshopContext();
            var signup = context.SignUps;
            return signup.ToList();
        }
        public SignUp Edit(int? id)
        {
            var context = new online_BookshopContext();
            var s = context.SignUps.Find(id);
            return s;
        }
        public SignUp Details(int? id)
        {
            var context = new online_BookshopContext();
            var Products = context.SignUps.FirstOrDefault(x => x.Id == id);
            return Products;
        }
        public void Update(SignUp s)
        {
            var context = new online_BookshopContext();
            context.SignUps.Update(s);
            context.SaveChanges();
        }
        public bool productExist(int id)
        {
            var context = new online_BookshopContext();
            return context.SignUps.Any(e => e.Id == id);
        }
        public SignUp delete(int? id)
        {
            var context = new online_BookshopContext();
            var Products = context.SignUps.FirstOrDefault(x => x.Id == id);
            return Products;
        }
        public void deleteConfirmed(int id)
        {
            var context = new online_BookshopContext();
            var product = context.SignUps.Find(id);
            if (product != null)
            {
                context.SignUps.Remove(product);
            }

            context.SaveChangesAsync();
        }
    }
}
