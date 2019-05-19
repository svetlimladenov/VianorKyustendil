using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace VianorKyustendil.Web.Services.HomeServices
{
    public class VianorServices : IVianorServices
    {
        private readonly IConfiguration configuration;

        public VianorServices(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public bool AreWeHiring
        {
            get
            {
                var areWeHiring = Convert.ToBoolean(this.configuration["AreWeHiring"]);
                return areWeHiring;
            }
        }
    }
}