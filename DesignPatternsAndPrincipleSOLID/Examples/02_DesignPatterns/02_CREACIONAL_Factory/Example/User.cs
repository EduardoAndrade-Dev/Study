using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Examples._02_DesignPatterns._02_CREACIONAL_Factory.Example
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        private User(string name, string email, string country)
        {
            Name = name;
            Email = email;
            Country = country;
        }

        public static class Factory
        {
            public static User CreateWithDefaultCountry(string name, string email)
            {
                return new User(name, email, "chile");
            }

            public static User CreateWithDefaultEmail(string name, string country)
            {
                return new User(name, "teste@gmail.com", country);
            }

        }
    }
}
