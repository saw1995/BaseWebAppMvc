using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoDigital.Client
{
    public class ConfigEndpoint
    {
        public string urlVedic { get;set;}
        public ConfigEndpoint(string param)
        {
            urlVedic = param;
        }
    }
}
