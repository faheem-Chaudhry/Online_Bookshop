using Microsoft.Data.SqlClient;
using EAD_project.Models.Interface;
using System.Linq;
namespace EAD_project.Models
{
    public class LoginRepository: ILogin
    {
        public bool login(Login L)
        {
            var context = new online_BookshopContext();
           var a= context.SignUps.Where(x => x.UserName == L.Username && x.Password == L.Password);
            if (a.Any())
            {
                
                return true;
            }
            else
            {
                return false;
            }
  //          context.SaveChanges();
            //var context = new online_BookshopContext();
            //context.SaveChanges();

            //   string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=online_Bookshop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //   SqlConnection con = new SqlConnection(connString);
            //   con.Open();
            //   string query = $"select * from signUp " +
            //       $"where userName = @u and password = @p";

            //   SqlParameter P1 = new SqlParameter("u", L.username);
            //   SqlParameter P2 = new SqlParameter("p", L.password);
            //   SqlCommand cmd = new SqlCommand(query, con);
            //   cmd.Parameters.Add(P1);
            //   cmd.Parameters.Add(P2);
            //   SqlDataReader dr = cmd.ExecuteReader();

            //   if (dr.HasRows)
            //   {
            //       con.Close();
            //       return true;

            //   }
            //   else
            //   {
            //       con.Close();
            //       return false;
            //   }


            ////   con.Close();
        }
        
    }
    
}
