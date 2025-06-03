using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2_tema_4
{
    public partial class Form2 : Form
    {
        private DataTable lista_productos;
        //private DataTable carrito_recalculado=new DataTable();

       // private bool cantidadModificada = false; // Bandera de control

        public Form2(DataTable lista_productos)
        {
            InitializeComponent();
            this.lista_productos = lista_productos;
            
            // Creo un control para mostrar un mensaje cuando paso el raton por el LV
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;  
            toolTip.InitialDelay = 1500;  
            toolTip.ReshowDelay = 2000;    
            toolTip.SetToolTip(lv_lista, "haz doble click sobre el producto para modificar las unidades");
        }

        //Método que carga el listview con los productos del carrito agrupandolo si tienen el mismo nombre
        private void cargar_carrito(DataTable carrito)
        {
            
            lv_lista.Items.Clear(); // Limpio los elementos anteriores del ListView
            decimal precio_carrito = 0;

            // Creo un diccionario para agrupar productos por nombre
            var productosAgrupados = carrito.AsEnumerable()
                                            .GroupBy(row => row["nombre"].ToString())
                                            .ToList();

            // Itero sobre los productos agrupados para ver si se eligueron varios productos con el mismo nombre y calculo eltotal
            foreach (var grupo in productosAgrupados)
            {
                string nombreProducto = grupo.Key;  // Nombre del producto
                int cantidad = grupo.Count();  // Contar cuántos productos con el mismo nombre
                decimal precioUnidad = Convert.ToDecimal(grupo.First()["precio"]);  // Precio de una unidad del producto

                decimal precioTotal = precioUnidad * cantidad; // Calculo el precio total (precio * cantidad)

                ListViewItem item = new ListViewItem((lv_lista.Items.Count + 1).ToString()); // Número de orden

                item.SubItems.Add(cantidad.ToString()); // Cantidad de productos
                item.SubItems.Add(nombreProducto);   // Nombre del producto
                item.SubItems.Add(precioTotal.ToString()); // Precio total

                lv_lista.Items.Add(item);
                precio_carrito += precioTotal;
            }

            lb_total.Text = precio_carrito.ToString("C2");

        }

        //Carga el formulario
        private void Form2_Load(object sender, EventArgs e)
        {
            cargar_carrito(lista_productos);
            carrito_carrito.Agregar(lista_productos.Rows.Count);

        }


        // Método que muestra un cuadro de diálogo con un ComboBox para seleccionar la nueva cantidad
        //He tenido que pedir ayuda a chat gpt porque se me empezo a liar mucho la cosa
        private void lv_lista_ItemActivate(object sender, EventArgs e)
        {
            if (lv_lista.SelectedItems.Count > 0) // Verifico si se ha seleccionado un ítem
            {
                ListViewItem selectedItem = lv_lista.SelectedItems[0];

                string nombreProducto = selectedItem.SubItems[2].Text;

                // Obtener la cantidad actual desde el ListView
                int cantidadActual = int.Parse(selectedItem.SubItems[1].Text);
                decimal precioActual = decimal.Parse(selectedItem.SubItems[3].Text);

                // Obtener la nueva cantidad
                int nuevaCantidad = ObtenerCantidadModificada(cantidadActual);

                if (nuevaCantidad >= 0)
                {
                    var filasProducto = lista_productos.AsEnumerable()
                                                     .Where(row => row["nombre"].ToString().Trim() == nombreProducto)
                                                     .ToList();

                    if (filasProducto.Any())
                    {
                        if (nuevaCantidad == 0)
                        {
                            foreach (var fila in filasProducto)
                            {
                                lista_productos.Rows.Remove(fila);
                            }

                            // Eliminar del ListView
                            foreach (ListViewItem item in lv_lista.Items)
                            {
                                if (item.SubItems[2].Text == nombreProducto)
                                {
                                    lv_lista.Items.Remove(item);
                                    break;
                                }
                            }

                            // Actualizo el ListView
                            cargar_carrito(lista_productos);
                            MessageBox.Show("El producto ha sido eliminado del carrito.");

                            //Actualizo carrito
                            carrito_carrito.Eliminar(carrito_carrito.Notificaciones);  
                            carrito_carrito.Agregar(lista_productos.Rows.Count);  
                        }
                        else
                        {
                            int cantidadActualEnDataTable = filasProducto.Count;
                            if (nuevaCantidad > cantidadActualEnDataTable)
                            {
                                // Agrego filas adicionales
                                int filasAAgregar = nuevaCantidad - cantidadActualEnDataTable;
                                for (int i = 0; i < filasAAgregar; i++)
                                {
                                    DataRow nuevaFila = lista_productos.NewRow();
                                    DataRow filaOriginal = filasProducto.First();

                                    nuevaFila["id"] = filaOriginal["id"];
                                    nuevaFila["nombre"] = filaOriginal["nombre"];
                                    nuevaFila["precio"] = filaOriginal["precio"];
                                    nuevaFila["marca"] = filaOriginal["marca"];
                                    nuevaFila["categoria"] = filaOriginal["categoria"];

                                    lista_productos.Rows.Add(nuevaFila);
                                }
                            }
                            else if (nuevaCantidad < cantidadActualEnDataTable)
                            {
                                // Elimino filas adicionales
                                int filasAEliminar = cantidadActualEnDataTable - nuevaCantidad;

                                for (int i = 0; i < filasAEliminar; i++)
                                {
                                    var filaEliminar = filasProducto[filasProducto.Count - 1 - i];
                                    lista_productos.Rows.Remove(filaEliminar);
                                }
                            }

                            cargar_carrito(lista_productos);
                            carrito_carrito.Eliminar(carrito_carrito.Notificaciones);
                            carrito_carrito.Agregar(lista_productos.Rows.Count);
                            MessageBox.Show("Cantidad actualizada.");
                        }

                        //Actrualizo el total del precoio
                        decimal total = 0;

                        foreach (DataRow row in lista_productos.Rows)
                        {
                            decimal precio = (decimal)row["precio"]; // Suponiendo que la columna de precio se llama "precio"
                            total += precio;
                        }

                        lb_total.Text = total.ToString("C2"); // Usamos formato de moneda

                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto en el carrito.");
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad seleccionada no es válida.");
                }
            }
        }

        //Método que obtine la cantidad de unidades que el usuario quiere de un determinado prpoducto
        private int ObtenerCantidadModificada(int cantidadActual)
        {
            // Creo un cuadro de entrada con TextBox
            Form inputForm = new Form();
            inputForm.Text = "Modificar cantidad";
            inputForm.StartPosition = FormStartPosition.CenterParent;
            inputForm.Width = 250;

            // Creo el Label informativo
            Label label = new Label() { Left = 20, Top = 20, Text = "Nueva cantidad:" };
            inputForm.Controls.Add(label);

            // Creo el TextBox para ingresar la cantidad
            TextBox textBoxCantidad = new TextBox()
            {
                Left = 80,
                Top = 50,
                Width = 50,
                TextAlign = HorizontalAlignment.Center,
                Text = cantidadActual.ToString(), // Establecer la cantidad actual
                MaxLength = 3 // Limitar la longitud de los números
            };
            inputForm.Controls.Add(textBoxCantidad);

            // Creo los botones (-) y (+)
            Button btnDecrementar = new Button() { Text = "-", Left = 30, Top = 50, Width = 40 };
            Button btnIncrementar = new Button() { Text = "+", Left = 135, Top = 50, Width = 40 };

            
            btnDecrementar.Click += (sender, e) =>
            {
                //si esta vacio interpreto que es 0
                int cantidad = 0;
                if (!string.IsNullOrEmpty(textBoxCantidad.Text) && int.TryParse(textBoxCantidad.Text, out cantidad))
                {
                    if (cantidad > 0)
                    {
                        textBoxCantidad.Text = (cantidad - 1).ToString(); 
                    }
                }
                else
                {
                    textBoxCantidad.Text = "0";
                }
            };

            btnIncrementar.Click += (sender, e) =>
            {
                //si esta vacio interpreto que es 0
                int cantidad = 0;
                if (!string.IsNullOrEmpty(textBoxCantidad.Text) && int.TryParse(textBoxCantidad.Text, out cantidad))
                {
                    if (cantidad < 50) 
                    {
                        textBoxCantidad.Text = (cantidad + 1).ToString(); // Sumar 1 si no se supera el máximo
                    }
                }
                else
                {
                    // Si el TextBox está vacío o no es un número válido, tratamos la cantidad como 0
                    textBoxCantidad.Text = "1"; // Iniciamos en 1 si está vacío para evitar 0 como valor inicial
                }
            };

            // Agrego los botones al formulario
            inputForm.Controls.Add(btnDecrementar);
            inputForm.Controls.Add(btnIncrementar);

            // Creo los botones Aceptar, Cancelar y Eliminar Producto
            Button btnAceptar = new Button() { Text = "Aceptar", Left = 120, Top = 80, Width = 80 };
            Button btnCancelar = new Button() { Text = "Cancelar", Left = 20, Top = 80, Width = 80 };
            Button btnEliminar = new Button() { Text = "Eliminar Producto", Left = 20, Top = 110, Width = 180 };

            inputForm.Controls.Add(btnAceptar);
            inputForm.Controls.Add(btnCancelar);
            inputForm.Controls.Add(btnEliminar);

            // Variable para almacenar el valor seleccionado
            int cantidadSeleccionada = -1;

            // Eventos de botonses
            btnAceptar.Click += (sender, e) =>
            {
                if (int.TryParse(textBoxCantidad.Text, out cantidadSeleccionada) && cantidadSeleccionada >= 0)
                {
                    inputForm.DialogResult = DialogResult.OK; 
                    inputForm.Close(); 
                }
                else
                {
                    MessageBox.Show("Por favor ingrese una cantidad válida.");
                }
            };

            btnCancelar.Click += (sender, e) =>
            {
                inputForm.DialogResult = DialogResult.Cancel; 
                inputForm.Close(); 
            };

            btnEliminar.Click += (sender, e) =>
            {
                cantidadSeleccionada = 0; 
                inputForm.DialogResult = DialogResult.Yes; 
                inputForm.Close(); 
            };

            // Mostro el formulario 
            DialogResult result = inputForm.ShowDialog();

            
            if (result == DialogResult.OK && cantidadSeleccionada >= 0)
            {
                return cantidadSeleccionada; 
            }
            else if (result == DialogResult.Yes)  
            {
                return 0; 
            }
            else
            {
                return -1;
            }
        }

        //pARA TRASPASAR LOS DATOS AL FORMULARIO 1
        public DataTable Carrito { get; set; }

        //bOTONTES Y ACCIONES DE MENUS
        private void button1_Click(object sender, EventArgs e)
        {
            finalizar_compra();
        }
        private void bt_atras_Click(object sender, EventArgs e)
        {
            salir_del_formulario();
        }
        private void finalizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            finalizar_compra();
        }
        private void importarCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loguear_empleado();
        }
        private void tb_salir_Click(object sender, EventArgs e)
        {
            salir_del_formulario();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            loguear_empleado();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        private void volverAtrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salir_del_formulario();
        }


        //mÉTODOS DEL FORMULARIO
        private void finalizar_compra()
        {
            lista_productos.Clear();

            salir_del_formulario();

            decimal totalCompra = decimal.Parse(lb_total.Text, System.Globalization.NumberStyles.Currency);

            MessageBox.Show("Total de la compra: " + totalCompra.ToString("C2") + "\nMuchas Gracias por su compra");
        }


        private void salir_del_formulario()
        {
            DataTable carritoData = lista_productos;  

            this.Carrito = carritoData;

            this.Close();
        }

        //mETODO QUE simula el logging y que exporta un doc txt (Me ayudó chat gpt)
        private void loguear_empleado()
        {
            MessageBox.Show("Aquí debería loguearse el Administrativo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Crear el SaveFileDialog para permitir al usuario elegir la ubicación y nombre del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo de productos del carrito";

            // Mostrar el cuadro de diálogo
            DialogResult resultado = saveFileDialog.ShowDialog();

            // Si el usuario elige un archivo, guardamos los datos en ese archivo
            if (resultado == DialogResult.OK)
            {
                string archivoSeleccionado = saveFileDialog.FileName;

                // Usamos StreamWriter para escribir en el archivo de texto
                using (StreamWriter writer = new StreamWriter(archivoSeleccionado))
                {
                    // Escribimos los encabezados (nombres de columnas del DataTable)
                    for (int i = 0; i < lista_productos.Columns.Count; i++)
                    {
                        writer.Write(lista_productos.Columns[i].ColumnName);
                        if (i < lista_productos.Columns.Count - 1)
                        {
                            writer.Write("\t"); // Usamos tabuladores para separar los campos
                        }
                    }
                    writer.WriteLine(); // Salto de línea después de los encabezados

                    // Escribimos los datos del DataTable (contenido de las filas)
                    foreach (DataRow row in lista_productos.Rows)
                    {
                        for (int i = 0; i < lista_productos.Columns.Count; i++)
                        {
                            writer.Write(row[i].ToString());
                            if (i < lista_productos.Columns.Count - 1)
                            {
                                writer.Write("\t"); // Usamos tabuladores para separar los campos
                            }
                        }
                        writer.WriteLine(); // Salto de línea después de cada fila
                    }
                    writer.WriteLine();
                    writer.WriteLine("Total de la compra: " + decimal.Parse(lb_total.Text)); // Asegúrate de que lb_total.Text tenga un valor numérico válido

                }

                // Mostrar mensaje confirmando que el archivo se guardó correctamente
                MessageBox.Show("El archivo se ha guardado correctamente en: " + archivoSeleccionado);
            }
        }
        
       



        // Métodos que al final no utilicé
        private void slectedItem_lista(object sender, EventArgs e)
        {

        }

    }




}






