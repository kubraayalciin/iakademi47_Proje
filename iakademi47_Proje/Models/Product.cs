
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iakademi47_Proje.Models
{
	public class Product
	{
		[Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		
        public int ProductID { get; set; }

		[Required]
		[StringLength(100)]
		[DisplayName("Ürün Adı")]
        public string? ProductName { get; set; }

		[Required]
		[DisplayName("Fiyat")]
        public decimal UnitPrice { get; set; }


		
		[DisplayName("Kategori")]
		public int CategoryID { get; set; }

		[DisplayName("Marka")]
		public int SupplierID { get; set; }

		[DisplayName("Stok")] 
		public int Stock { get; set;}

		[DisplayName("İndirim")]
		public int Discount { get; set;}

		[DisplayName("Statü")]
		public int StatusID { get; set; }

        public DateTime AddDate { get; set; }

		[DisplayName("Anahtar Kelimeler")]
		public string? Keywords { get; set;}

		//encapsulation = kapsülleme
		private int _KDV { get; set; }
        public int KDV 
		
		{ get
			{ return _KDV; }
			
		set
			{ _KDV = Math.Abs(value);}		
		
		}

        public int Highlighted { get; set; } // öne çıkanlar

        public int TopSeller { get; set; } //çok satanlar

		[DisplayName("Bu Ürüne Bakanlar")]
        public int Related { get; set; } //buna bakanlar buna da baktı

		[DisplayName("Notlar")]
		public string? Notes { get; set; }

		[DisplayName("Resim")]
        public string? PhotoPath { get; set; }

		[DisplayName("Aktif")]
		public bool Active { get; set; }
	}
}
