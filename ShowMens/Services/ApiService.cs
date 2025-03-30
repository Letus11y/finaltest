using System;
using ShowMens.Models;
using System.Text.Json;



namespace ShowMens.Services;

public class ApiService
{
    private readonly HttpClient _httpClient = new();

        public async Task<List<UserModel>> GetMaleUsersAsync()
        {
            string url = "https://randomuser.me/api/?results=50&gender=male";
            var response = await _httpClient.GetStringAsync(url);

            var json = JsonDocument.Parse(response);
            var users = new List<UserModel>();

            foreach (var user in json.RootElement.GetProperty("results").EnumerateArray())
            {
                users.Add(new UserModel
                {
                    FullName = $"{user.GetProperty("name").GetProperty("first").GetString()} {user.GetProperty("name").GetProperty("last").GetString()}",
                    Age = user.GetProperty("dob").GetProperty("age").GetInt32(),
                    Email = user.GetProperty("email").GetString(),
                    Gender = user.GetProperty("gender").GetString()
                });
            }

            return users;
        }
}
