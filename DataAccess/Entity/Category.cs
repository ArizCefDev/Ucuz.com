﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
	public class Category
	{
		public int ID { get; set; }
		public string Name { get; set; }

		//icaze verildi
		public List<Product> Products { get; set; }
	}
}
