using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Framework.Models
{
    public class User
    {
        public string Name { get; set; }
        public string SurName{ get; set; }
		public string Country { get; set; }
		public string PhoneNumber{ get; set; }
		public string Age { get; set; }
		public string Email{ get; set; }

		public User(string name, string surName, string country, string phoneNumber, string email)
        {
            this.Name = name;
			this.SurName = surName;
			this.Country = country;
			this.PhoneNumber = phoneNumber;
			this.Email =email;
		}
		public User (string age)
		{
			this.Age = age;
		}

		
	}
}
