using System.Xml.Serialization;

namespace Bgg.Sdk.Models
{
    [XmlRoot("errors")]
    public class ErrorResponse
    {
        [XmlElement("error")]
        public List<ErrorDetails> Errors { get; init; } = [];
        public class ErrorDetails
        {
            [XmlElement("message")]
            public string Message { get; init; } = "";

        }
    }
}
