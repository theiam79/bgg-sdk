
namespace Bgg.Sdk.Extensions
{
    [Serializable]
    internal class BggApiException : Exception
    {
        private string[] _apiErrors = [];

        public List<string> ApiErrors => [.. _apiErrors.AsReadOnly()];

        public BggApiException()
        {
        }

        public BggApiException(string? message) : base(message)
        {
        }

        public BggApiException(string? message, string[] apiErrors) : base(message)
        {
            _apiErrors = apiErrors;
        }
    }
}