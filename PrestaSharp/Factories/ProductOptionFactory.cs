﻿using Bukimedia.PrestaSharp.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Factories
{
    public class ProductOptionFactory : GenericFactory<product_option>
    {
        protected override string singularEntityName { get { return "product_option"; } }
        protected override string pluralEntityName { get { return "product_options"; } }

        public ProductOptionFactory(string BaseUrl, string Account, string SecretKey, int? shopId)
                : base(BaseUrl, Account, SecretKey, shopId)
        {
        }
    }
}