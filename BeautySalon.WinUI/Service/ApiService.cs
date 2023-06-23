using BeautySalon.Model;
using BeautySalon.Model.ViewModels;
using BeautySalon.WinUI.Properties;
using Flurl.Http;
using System.Text;

namespace BeautySalon.WinUI.Service
{
    public class ApiService
    {
        private readonly string? _resource = null;
        public string _endpoint = Resources.ApiURL;

        public static string? username;
        public static string? password;
        public static UserVM? authenticatedUser;

        public ApiService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> GetAll<T>(object? searchObject = null)
        {
            var query = "";
            if (searchObject != null) 
            {
                query = await searchObject.ToQueryString();
            }

            return await $"{_endpoint}{_resource}?{query}".WithBasicAuth(username, password).GetJsonAsync<T>();
        }

        public async Task<T> GetById<T>(object id)
        {
            return await $"{_endpoint}{_resource}/{id}".WithBasicAuth(username, password).GetJsonAsync<T>();
        }

        public async Task<bool> Delete<T>(object id)
        {
            return await $"{_endpoint}{_resource}/{id}".WithBasicAuth(username, password).DeleteAsync().ReceiveJson<bool>();
        }

        public async Task<T> Insert<T>(object request)
        {
            try
            {
                return await $"{_endpoint}{_resource}".WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}: {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                return await $"{_endpoint}{_resource}/{id}".WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}: {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }

        }
    }
}
