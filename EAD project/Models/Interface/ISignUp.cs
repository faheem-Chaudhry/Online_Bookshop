using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EAD_project.Models.Interface
{
    public interface ISignUp
    {
        public Task<IdentityResult> createUser(SignUp signup);
        public void checksignUp(SignUp signup);
        public List<SignUp> index();
        public SignUp Edit(int? id);
        public SignUp Details(int? id);
        public void Update(SignUp s);
        public bool productExist(int id);
        public SignUp delete(int? id);
        public void deleteConfirmed(int id);
    }
}
