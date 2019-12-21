using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
	public class Auto
	{
		public string Model { get; set; }
		public string Transmission { get; set; }
		public string Fuel { get; set; }

		public Auto(string model)
		{
			this.Model = model;
		}

		public Auto(string model, string transmission, string fuel)
		{
			this.Model = model;
			this.Transmission = transmission;
			this.Fuel = fuel;
		}
	}
}
