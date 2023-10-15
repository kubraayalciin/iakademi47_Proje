using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace iakademi47_Proje.Models
{
	public class Comment
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int CommentID { get; set; }
        public int UserID { get; set; }
        public int ProdductID { get; set; }

		[StringLength(150)]
		public string? Review { get; set; }


    }
}
