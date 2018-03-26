using System;
using System.Collections.Generic;

namespace StudentsData.Models
{
	public class FatherDetail
	{
		public int Id { get; set; }
		public Students Student { get; set; }
		public string FatherName { get; set; }
		public string Class { get; set; }
		public int Age { get; set; }

		
	}
}