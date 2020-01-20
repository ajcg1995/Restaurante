using BackEnd.BLL;
using BackEnd.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class FrmAdministrarProductos : Form
    {
        IAddProductos metodosBLL = new AddProductosBLLImp();
        public FrmAdministrarProductos()
        {
            InitializeComponent();
            
        }

        private void AdministrarProductos_Load(object sender, EventArgs e)
        {
            // cargar datos del Combobox
            cmbTipoProducto.Items.Add("Platillos");
            cmbTipoProducto.Items.Add("Refrescos");
            cmbTipoProducto.Items.Add("Bebidas");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos objetoProductos = new Productos();
            objetoProductos.Nombre = txtNombre.Text;
            objetoProductos.Descripcion = txtDescripcion.Text;
            objetoProductos.Imagen = txtImagen.Text;

            //Validacion del ComboBox
                int producto = 0;
                if (cmbTipoProducto.SelectedItem.ToString() == "Platillos")
                {
                    producto = 1;
                }
                else if (cmbTipoProducto.SelectedItem.ToString() == "Refrescos")
                {
                    producto = 2;
                }
                else {
                    producto = 3;
                }
            objetoProductos.Tipo_Producto = producto;

            objetoProductos.Cantidad = Int32.Parse(txtCantidad.Text);

            Boolean validacionExistencia = metodosBLL.AgregarProducto(objetoProductos);           
        }
    }
}
