﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PurchaseRequisition.Configuration
{
    public class WebServiceLocator : IWebServiceLocator
    {
        public WebServiceLocator(IConfiguration config)
        {
            var customSection = config.GetSection(nameof(WebServiceLocator));
            ServiceAddress = customSection?.GetSection(nameof(ServiceAddress))?.Value;
        }

        public string ServiceAddress { get; }
    }
}
