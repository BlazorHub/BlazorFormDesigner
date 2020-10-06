using BlazorFormDesigner.Web.Models;
using BlazorFormDesigner.Web.Requests;
using BlazorFormDesigner.Web.Responses;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlazorFormDesigner.Web.Services
{
    public class LoginService
    {
        public event Func<Task> LoginEvent;

        private readonly HttpClient Client;

        public User User { get; private set; }

        public LoginService()
        {
            Client = new HttpClient { BaseAddress = new Uri("https://localhost:5001/") };
        }

        public async Task<ErrorResponse> Login(LoginRequest request)
        {
            try
            {
                var response = await Client.PutAsJsonAsync("user/login", request);

                if (response.IsSuccessStatusCode)
                {
                    var loginResponse = await response.Content.ReadAsAsync<LoginResponse>();
                    User = loginResponse.ToUser();
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", User.Token);
                    Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", User.Token);
                    await LoginEvent?.Invoke();
                    return null;
                }

                return await response.Content.ReadAsAsync<ErrorResponse>();
            }
            catch (Exception)
            {
                return new ErrorResponse { Content = "Unable to connect to server." };
            }
        }

        public async Task Logout()
        {
            User = null;
            await LoginEvent?.Invoke();
        }
    }
}
