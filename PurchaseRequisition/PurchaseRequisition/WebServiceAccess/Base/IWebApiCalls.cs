using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseRequisition.Models;
using PurchaseRequisition.ViewModels;

namespace PurchaseRequisition.WebServiceAccess.Base
{
    public interface IWebApiCalls
    {
        Task<User> GetUserAsync(string userId);
        Task<string> CreateUserAsync(string password, User user);
        Task<string> UpdateUserAsync(string userId, User user);
        Task DeleteUserAsync(string userId);
        Task<string> ChangePasswordAsync(string userId, User user, string currPassword, string newPassword);
        Task<IList<User>> GetUserAsync(int skip = 0, int take = 10);
    }
}
