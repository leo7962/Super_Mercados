using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Super_Mercado.Models;

namespace Super_Mercado.Services
{
    interface ISuper_MercadoService
    {
        Task<Producto> Create(Producto producto);

        Task<IEnumerable<Producto>> GetAll();

        Task<Producto> GetById(long? Id);

        Task<Producto> Update(Producto producto);

        Task<Producto> Delete(Producto producto);
    }
}
