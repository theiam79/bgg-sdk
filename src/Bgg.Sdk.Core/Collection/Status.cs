using System.Xml.Serialization;

namespace Bgg.Sdk.Core.Collection
{

    public class Status
    {
		[XmlAttribute("own")]
		public bool Own { get; set; }

		[XmlAttribute("prevowned")]
		public bool PreviouslyOwned { get; set; }

		[XmlAttribute("fortrade")]
		public bool ForTrade { get; set; }

		[XmlAttribute("want")]
		public bool Want { get; set; }

		[XmlAttribute("wanttoplay")]
		public bool WantToPlay { get; set; }

		[XmlAttribute("wanttobuy")]
		public bool WantToBuy { get; set; }

		[XmlAttribute("wishlist")]
		public bool Wishlist { get; set; }

		[XmlAttribute("wishlistpriority")]
		public int WishlistPriority { get; set; } = 0;

		[XmlAttribute("preordered")]
		public bool Preordered { get; set; }

		[XmlAttribute("lastmodified")]
		public string LastModifiedString { get; set; } = "";

		[XmlIgnore]
		public DateTime? LastModified => DateTime.TryParse(LastModifiedString, out var date) ? date : null;
	}

}
