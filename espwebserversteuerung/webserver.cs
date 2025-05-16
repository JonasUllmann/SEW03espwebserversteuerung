using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class WebServerController
{
    private readonly HttpClient _httpClient = new();

    // GET-Anfrage
    public async Task<string> SendGetAsync(string url)
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            return $"Fehler: {ex.Message}";
        }
    }

    // POST-Anfrage mit JSON-Daten

}
