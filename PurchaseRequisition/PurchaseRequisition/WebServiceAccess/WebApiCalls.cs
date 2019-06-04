using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using PurchaseRequisition.Models;
using PurchaseRequisition.ViewModels;
using PurchaseRequisition.Configuration;
using PurchaseRequisition.WebServiceAccess.Base;

namespace PurchaseRequisition.WebServiceAccess
{
    public class WebApiCalls : WebApiCallsBase, IWebApiCalls
    {
        public WebApiCalls(IWebServiceLocator settings) : base(settings)
        {

        }

        public Task<string> ChangePasswordAsync(string userId, User user, string currPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public async Task<string> CreateUserAsync(string password, User user)
        {
            var json = JsonConvert.SerializeObject(user);
            return await SubmitPostRequestAsync(UserCreateUri + password, json);
        }

        public async Task DeleteUserAsync(string userId)
        {
            await SubmitDeleteRequestAsync(UserDeleteUri + userId);
            return;
        }

        public async Task<User> GetUserAsync(string userId)
        {
            return await GetItemAsync<User>($"{UserGetUri}{userId}");
        }

        public async Task<IList<User>> GetUserAsync(int skip = 0, int take = 10)
        {
            return await GetItemListAsync<User>($"{UserGetUri}?skip={skip}&take={take}");
        }

        public async Task<string> UpdateUserAsync(string userId, User user)
        {
            var json = JsonConvert.SerializeObject(user);
            return await SubmitPutRequestAsync($"{UserUpdateUri}{userId}", json);
        }
    }
}
