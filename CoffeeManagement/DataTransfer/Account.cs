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
        public string role { get; set; }

        public string fullName { get; set; }
        public string sex { get; set; }
        public string dateOfBirth { get; set; } 
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string dateOfRegistration { get; set; }
        public Account(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public Account() {}
        //public Account(int id, string username, string password, string fullName, string sex, string dateOfBirth, string address, string phoneNumber, string dateOfRegistration)
        //{
        //    this.id = id;
        //    Username = username;
        //    Password = password;
        //    this.fullName = fullName;
        //    this.sex = sex;
        //    this.dateOfBirth = dateOfBirth;
        //    this.address = address;
        //    this.phoneNumber = phoneNumber;
        //    this.dateOfRegistration = dateOfRegistration;
        //}
    }
}
