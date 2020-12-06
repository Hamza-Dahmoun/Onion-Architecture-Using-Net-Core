using CompanyName.AppName.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CompanyName.AppName.Web.Services
{
    public class ActivityService
    {
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

    }
}
