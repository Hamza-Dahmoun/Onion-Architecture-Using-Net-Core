using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyName.AppName.Web.Infrastructure
{
    public class ApiServicesUrls
    {
        //Mentor:
        //Api Urls are generated using this helper class.
        //you will inject this class in constructors or views to generate api urls based on model
        //classes.In this manner you will never hard code urls in views or controllers.

        private static AppSettings _appSettings;

        public Uri CreateRequestUri(string baseUri, string relativePath = "")
        {
            Uri uri = new Uri(baseUri);
            Uri endPoint = new Uri(uri, relativePath);
            UriBuilder uriBuilder = new UriBuilder(endPoint);
            return uriBuilder.Uri;
        }
        public ApiServicesUrls(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public string GetBaseUrl<T>()
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}").ToString();
        }

        public string GetAllUrl<T>()
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}/all").ToString();
        }

        public string GetAllPagedUrl<T>()
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}/paged").ToString();
        }

        public string GetDatabableUrl<T>()
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}/datatable").ToString();
        }

        public string GetByIdUrl<T>()
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}/").ToString();
        }
        public string GetByIdUrl<T, TKey>(TKey id)
        {
            return CreateRequestUri(ApiBaseUrl, $"{typeof(T).Name}/{id}").ToString();
        }


        public string ApiBaseUrl { get => _appSettings.ApiBaseUrl; }
    }
}
