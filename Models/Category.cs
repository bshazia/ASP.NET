using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooks.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
        public string Name { get; set; }
		[DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
		public DateTime CreatedDateTime { get; set; } = DateTime.Now;

	}
	//public class CategoryDBContext : DbContext
	//{
	//	public DbSet<Category> Categories { get; set; }
	//}
}

