using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ShowMens.Models;
using ShowMens.Services.Interfaces;

public class ApiService : IApiServicesRepository
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<UserModel>> GetMaleUsersAsync()
    {
        var json = await _httpClient.GetStringAsync("https://randomuser.me/api/?results=50&gender=female");
        
        // Deserializar la respuesta en un objeto
        var response = JsonSerializer.Deserialize<Response>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        return response?.Results.Select(u => new UserModel
        {
            Name = u.Name,
            Email = u.Email,
            Gender = u.Gender,
            Picture = u.Picture
        }).ToList() ?? new List<UserModel>();
    }
}
