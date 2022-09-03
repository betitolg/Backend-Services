﻿using static LaLena.Web.SD;

namespace LaLena.Web.Models
{
    public class ApiRequest
    {

        public ApiType apiType { get; set; } = ApiType.GET;

        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }

    }
}
