using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSecu.Enums;

namespace ProjetSecu.Structures
{
    public struct User
    {
        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
        public User(int id, string username, string password, string email, string address, int age, SexEnum sex)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Address = address;
            Age = age;
            Sex = sex;
        }
    }
}
