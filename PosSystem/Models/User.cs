using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem.Models
{
    public class User
    {
        public User(int iD, string firstName, string lastName, string nameKH, string email, string password, string gender, string role)
        {
            _ID = iD;
            _FirstName = firstName;
            _LastName = lastName;
            _NameKH = nameKH;
            _Email = email;
            _Password = password;
            _Gender = gender;
            _Role = role;
        }

        private int _ID { get; set; }
        private string _FirstName { get; set; }
        private string _LastName { get; set; }
        private string _NameKH { get; set; }
        private string _Email { get; set; }
        private string _Password { get; set; }
        private string _Gender { get; set; }
        private string _Role { get; set; }
    }
}
