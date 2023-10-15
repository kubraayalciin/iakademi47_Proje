using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace iakademi47_Proje.Models
{
	public class Message
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int MessageID { get; set; }
		public int UserID { get; set; }
		public int ProdductID { get; set; }

		[StringLength(150)]
		public string? Content { get; set; }


	}
}
