using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOEntity
{
	public class ProductDTO
	{
		public int ID { get; set; }
		public string Image { get; set; }
		public string Star { get; set; }
		public string Name { get; set; }
		public string Price { get; set; }

		//Foreign Key

		//ID int Category_Id
		public int CategoryID { get; set; }

		//references Category(ID);
		public CategoryDTO CategoryDTO { get; set; }
	}
}
