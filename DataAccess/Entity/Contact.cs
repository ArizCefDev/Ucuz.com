using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
	public class Contact
	{
        public int ID { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
		public string Gmail { get; set; }
		public string Map { get; set; }
    }
}
