using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace iakademi47_Proje.Models
{
	public class Category
	{
		[DisplayName("ID")]
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int CategoryID { get; set; }

		[DisplayName("Üst Kategori Adı")]

		public int ParentID { get; set; }

		[DisplayName("Kategori Adı")]
		[Required(ErrorMessage ="Kategori Adı Girmek Zorunlu")]
		[StringLength(50,ErrorMessage ="En fazla 50 karakter")]
        public string? CategoryName { get; set; }


		[DisplayName("Aktif")]
		public bool Active { get; set; }


	}
}
