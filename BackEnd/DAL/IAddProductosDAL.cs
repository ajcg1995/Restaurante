using BackEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public interface IAddProductosDAL
    {
        Boolean AgregarProducto(Productos producto);
        void ModificarProducto(Productos producto);
        void Eliminar(Productos producto);
        void buscarPorId(int idProducto);
    }
}
