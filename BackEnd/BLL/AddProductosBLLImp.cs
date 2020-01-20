using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Model;

namespace BackEnd.BLL
{
    public class AddProductosBLLImp : IAddProductos
    {
        IAddProductos metodosDAL = new AddProductosBLLImp();
        public bool AgregarProducto(Productos producto)
        {
            Boolean validacionExistencia = metodosDAL.AgregarProducto(producto);
            return validacionExistencia;
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
