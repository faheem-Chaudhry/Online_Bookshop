using Microsoft.AspNetCore.Http;

namespace EAD_project.Models
{
    public class ViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double? OldPrice { get; set; }
        public double? NewPrice { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
    }
}
