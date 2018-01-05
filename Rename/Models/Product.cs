using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gummi.Models
{
	[Table("Products")]
	public class Product
	{
		[Key]
		public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
		public string Description { get; set; }
	}
}
