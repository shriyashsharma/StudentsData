using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsData.Models
{
    public class Students
    {
		public int Id { get; set; }
		public string  Name { get; set; }
		public string Class { get; set; }
		public List<FatherDetail> Father { get; set; }
	}
}
