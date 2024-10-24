using PostmanCloneLibrary.enums;
using System.Text.Json;

namespace PostmanCloneLibrary;

public class ApiAccess : IApiAccess
{

    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string requestUri,
                                           bool formatJson = true,
                                           HttpAction action = HttpAction.GET)
    {
        if (string.IsNullOrEmpty(requestUri)) return "Input url must not be empty !";
        HttpResponseMessage response = await client.GetAsync(requestUri);

        if (response.IsSuccessStatusCode)
        {
            string jsonContent = await response.Content.ReadAsStringAsync();


            if (formatJson)
            {
                // Format the JSON content for pretty printing
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonContent);
                jsonContent = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });
            }

            return jsonContent;
        }
        else
        {
            return "Error: " + response.StatusCode;
        }
    }

    public bool IsValidUrl(string url)
    {
        if (string.IsNullOrEmpty(url)) return false;

        bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput)
            && (uriOutput.Scheme == Uri.UriSchemeHttps);

        return output;
    }

}
