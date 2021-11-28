using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Models.Collection
{

    public class Status
    {
		[XmlAttribute("own")]
		public string Own { get; set; }

		[XmlAttribute("prevowned")]
		public string PreviouslyOwned { get; set; }

		[XmlAttribute("fortrade")]
		public string ForTrade { get; set; }

		[XmlAttribute("want")]
		public string Want { get; set; }

		[XmlAttribute("wanttoplay")]
		public string WantToPlay { get; set; }

		[XmlAttribute("wanttobuy")]
		public string WantToBuy { get; set; }

		[XmlAttribute("wishlist")]
		public string Wishlist { get; set; }

		[XmlAttribute("wishlistpriority")]
		public int WishlistPriority { get; set; } = 0;

		[XmlAttribute("preordered")]
		public string Preordered { get; set; }

		[XmlAttribute("lastmodified")]
		public string LastModified { get; set; }
	}

}
