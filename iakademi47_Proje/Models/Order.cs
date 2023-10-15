using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi47_Proje.Models
{
	public class Order
	{

		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int OrderID { get; set; }

		[Required]
		public DateTime OrderDate { get; set; }

		[Required]
		[StringLength(30)]

		public string? OrderGroupGUID { get; set; }

		public int UserID { get; set; }

		public int ProductID { get; set; }

		[DisplayName("Adet")]
        public int Quantity { get; set; }
    }
}
