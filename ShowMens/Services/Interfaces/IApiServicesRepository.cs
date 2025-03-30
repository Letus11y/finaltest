using System;
using ShowMens.Models;

namespace ShowMens.Services.Interfaces;

public interface IApiServicesRepository
{
    Task<IEnumerable<UserModel>> GetMaleUsersAsync();
    void GetMens ();
}
