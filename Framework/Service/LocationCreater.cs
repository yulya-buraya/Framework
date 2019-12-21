using Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Service
{
	class LocationCreater
	{
		public static Location WithTwoPoint()
		{
			return new Location(TestDataReader.GetData("RentalPointSelect"), 
				                TestDataReader.GetData("ReturnPointSelect"));
		}

		public static Location WithOnePoint()
		{
			return new Location(TestDataReader.GetData("RentalPointSelect"));
		}
	}
}
