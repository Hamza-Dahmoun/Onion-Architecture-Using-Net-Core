using CompanyName.AppName.Domain.Entities;
using CompanyName.AppName.Web.Infrastructure;
using Newtonsoft.Json;
using Reusable.Business.Core.BusinessResult;
using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CompanyName.AppName.Web.Services
{
    public class ActivityService
    {
        //The methods of this class use services from API project controllers


        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        private readonly ApiServicesUrls _apiServicesUrls;
        private readonly string _baseUrl;

        public ActivityService(HttpClient httpClient, AppSettings appSettings, ApiServicesUrls apiServicesUrls, string baseUrl)
        {
            _httpClient = httpClient;
            _appSettings = appSettings;
            _apiServicesUrls = apiServicesUrls;
            _baseUrl = baseUrl;
        }

        public async Task<List<Activity>> GetAllAsync()
        {
            string requestUrl = _apiServicesUrls.GetAllUrl<Activity>();

            string responseString = await _httpClient.GetStringAsync(requestUrl);

            var list = JsonConvert.DeserializeObject<List<Activity>>(responseString);

            return list;
        }

        public async Task<PagedResult<Activity>> GetAllPagedAsync(string term, string orderby, int page = 1, int pageSize=10)
        {
            string requestUrl = _apiServicesUrls.GetAllPagedUrl<Activity>() + $"?term={term}&orderby={orderby}&page={page}&pageSize={pageSize}";
            
            string responseString = await _httpClient.GetStringAsync(requestUrl);
            
            var list = JsonConvert.DeserializeObject<PagedResult<Activity>>(responseString);

            return list;
        }

        public async Task<Activity> GetByIdAsync(Guid id)
        {
            string requestUrl = _apiServicesUrls.GetByIdUrl<Activity, Guid>(id);

            string responseString = await _httpClient.GetStringAsync(requestUrl);

            var entity = JsonConvert.DeserializeObject<Activity>(responseString);

            return entity;
        }

        public async Task<BusinessResult> PostAsync(Activity entity)
        {
            BusinessResult businessResult = BusinessResult.Success;

            string requestUrl = _apiServicesUrls.GetBaseUrl<Activity>();

            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(requestUrl, entity);

            response.EnsureSuccessStatusCode();

            businessResult = JsonConvert.DeserializeObject<BusinessResult>(await response.Content.ReadAsStringAsync());

            return businessResult;
        }

        public async Task<BusinessResult> PutAsync(Guid id, Activity entity)
        {
            BusinessResult businessResult = BusinessResult.Success;

            string requestUrl = _apiServicesUrls.GetByIdUrl<Activity, Guid>(id);

            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(requestUrl, entity);

            response.EnsureSuccessStatusCode();

            businessResult = JsonConvert.DeserializeObject<BusinessResult>(await response.Content.ReadAsStringAsync());

            return businessResult;
        }

        public async Task<BusinessResult> DeleteAsync(Guid id, Activity entity)
        {
            BusinessResult businessResult = BusinessResult.Success;

            string requestUrl = _apiServicesUrls.GetByIdUrl<Activity, Guid>(id);

            HttpResponseMessage response = await _httpClient.DeleteAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            businessResult = JsonConvert.DeserializeObject<BusinessResult>(await response.Content.ReadAsStringAsync());

            return businessResult;
        }
    }
}
