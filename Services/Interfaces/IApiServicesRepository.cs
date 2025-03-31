using System;
using ShowMens.Models;

namespace ShowMens.Services.Interfaces;

public interface IApiServicesRepository
{
    Task<List<UserModel>> GetMaleUsersAsync();
}

