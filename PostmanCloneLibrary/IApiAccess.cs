using PostmanCloneLibrary.enums;

namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string requestUri, bool formatJson = true, HttpAction action = HttpAction.GET);
        bool IsValidUrl(string url);
    }
}