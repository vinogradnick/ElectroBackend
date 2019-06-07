using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace ElectroBackend.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
