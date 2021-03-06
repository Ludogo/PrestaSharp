using Bukimedia.PrestaSharp.Entities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bukimedia.PrestaSharp.Factories
{
    public class WarehouseFactory : GenericFactory<warehouse>
    {
        protected override string singularEntityName { get { return "warehouse"; } }
        protected override string pluralEntityName { get { return "warehouses"; } }

        public WarehouseFactory(string BaseUrl, string Account, string SecretKey, int? shopId)
                : base(BaseUrl, Account, SecretKey, shopId)
        {
        }
    }
}
