using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string role { get; set; } // "ADMIN" hoặc "STAFF"
        public string fullName { get; set; }
        public string sex { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dateOfRegistration { get; set; }

        public Account() { }

        public Account(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public Account(int id, string username, string password, string role, string fullName, string sex, DateTime dateOfBirth, string address, string phoneNumber, DateTime dateOfRegistration)
        {
            this.id = id;
            Username = username;
            Password = password;
            this.role = role;
            this.fullName = fullName;
            this.sex = sex;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateOfRegistration = dateOfRegistration;
        }
    }
}