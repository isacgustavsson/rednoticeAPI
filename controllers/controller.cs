using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/v1")]
public class SampleController(HttpClient httpClient) : ControllerBase
{
    private readonly HttpClient _httpClient = httpClient;

    [HttpGet("games")]
    public async Task<IActionResult> GetGames()
    {
        string url = "https://api.server.nbaapi.com/api/games";

        var response = await _httpClient.GetFromJsonAsync<Root>(url);

        if (response is null)
        {
            return NotFound("no data");
        }

        return Ok(response);
    }
}
