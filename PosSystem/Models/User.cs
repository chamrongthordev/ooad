using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Models
{
    public class User
    {
        public User() {}
        public User(int iD, string firstName, string lastName, string username, string password, string gender, string role)
        {
            _ID = iD;
            _FirstName = firstName;
            _LastName = lastName;
            _Username = username;
            _Password = password;
            _Gender = gender;
            _Role = role;
        }

        public int _ID { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _Username { get; set; }
        public string _Password { get; set; }
        public string _Gender { get; set; }
        public string _Role { get; set; }
    }
}
