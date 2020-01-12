using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string BirthDate { get; set; }
        public bool Verified { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

    }
}
