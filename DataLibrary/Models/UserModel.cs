using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public string Birthday { get; set; }
        public bool Verified { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}