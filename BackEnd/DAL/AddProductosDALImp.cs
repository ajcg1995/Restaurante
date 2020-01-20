using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;

namespace BackEnd.DAL
{
    public class AddProductosDALImp : IAddProductosDAL
    {
        private RestauranteEntities context;

        public bool AgregarProducto(Productos producto)
        {
          
            using (context = new RestauranteEntities()) {

                context.Productos.Add(producto);
            }
            return true;
        }

        public void buscarPorId(int idProducto)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Productos producto)
        {
            throw new NotImplementedException();
        }

        public void ModificarProducto(Productos producto)
        {
            throw new NotImplementedException();
        }
    }
}
