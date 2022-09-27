using Microsoft.Data.SqlClient;
using EAD_project.Models.Interface;
namespace EAD_project.Models
{
    public class signupRepository : ISignUp
    {
        public void checksignUp(SignUp signup)
        {
            var context=new online_BookshopContext();
            context.SignUps.Add(signup);
            context.SaveChanges();
        }
    }
}
