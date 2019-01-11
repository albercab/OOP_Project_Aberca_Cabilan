using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoatRental
{
    class User
    {
        public string Id, FirstName, LastName, MiddleName, Address, Username, Password, Gender;
        public byte Age;
        public User(String id, String firstname, String lastname, String middlename, String address, byte age, String username, String password, String gender)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.MiddleName = middlename;
            this.Address = address;
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.Id = id;
            this.Gender = gender;

        }
        public String toString()
        {
            return "User{" +
                  ", Id='" + Id + '\'' +
                    "FirstName='" + FirstName + '\'' +
                    ", LastName='" + LastName + '\'' +
                    ", MiddleName='" + MiddleName + '\'' +
                    ", Address='" + Address + '\'' +
                    ", Username='" + Username + '\'' +
                    ", Password='" + Password + '\'' +
                     ", Gender='" + Gender + '\'' +
                    ", Age=" + Age +
                    '}';
        }
        public User(String id, String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

    }
}
