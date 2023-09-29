using CreditoDigital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditoDigital.Client
{
    public interface ICoreVedic
    {
        Task<PruebaModel> Prueba(PruebaModel param);
    }
}
