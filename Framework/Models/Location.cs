using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Models
{
	class Location
	{
		public string RentalPointSelect { get; set; }
		public string ReturnPointSelect { get; set; }


		public Location(string rentalPointSelect, string returnPointSelect)
		{
			this.RentalPointSelect = rentalPointSelect;
			this.ReturnPointSelect = returnPointSelect;
		}

		public Location(string rentalPointSelect)
		{
			this.RentalPointSelect = rentalPointSelect;
		}
	}
}
