using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace iakademi47_Proje.Models
{
	public class Setting
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int SettingID { get; set; }
        public string? Telephone { get; set; }
		public string? Adress { get; set; }
		public string? Email { get; set; }
        public int MainPageCount { get; set; }
        public int SubPageCount { get; set; }

    }
}
