using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace iakademi47_Proje.Models

{
	public class Supplier
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int SupplierID { get; set; }

		[Required]
		[DisplayName("Marka Adı")]
		public string? BrandName { get; set; }


		[DisplayName("Resim")]
		public string? PhotoPath { get; set; }


		[DisplayName("Aktif")]
		public bool Active { get; set; }



	}
}
