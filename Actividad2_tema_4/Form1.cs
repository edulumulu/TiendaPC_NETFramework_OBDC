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
    public partial class Form1 : Form
    {
        DataTable componentes;
        DataTable productos_carrito = new DataTable();

        //Metodo que carga los datos de la BBDD en el ListView
        private void cargar_datos()
        {
            componentes = this.dataSet21.catalogo;
            lv_lista.Items.Clear();
            foreach (DataRow componente in componentes.Rows)
            {
                ListViewItem item = lv_lista.Items.Add(componente["id"].ToString());
                item.SubItems.Add(componente["componente"].ToString());
                item.SubItems.Add(componente["precio"].ToString());
                item.SubItems.Add(componente["marca"].ToString());
                item.SubItems.Add(componente["categoría"].ToString());

            }
        }

        //Cargo el combobox del filtro por precios
        private void cargarPrecio()
        {
            cb_precio.Items.Clear();
            cb_precio.Items.Add("Selecciona un rango de precio");
            cb_precio.Items.Add("Menos de 100");
            cb_precio.Items.Add("Menos de 200");
            cb_precio.Items.Add("Menos de 500");
            cb_precio.SelectedIndex = 0;
        }


        public Form1()
        {
            InitializeComponent();

            // Creo el DataTable para el carrito
            productos_carrito.Columns.Add("id", typeof(int));
            productos_carrito.Columns.Add("nombre", typeof(string));
            productos_carrito.Columns.Add("precio", typeof(decimal));
            productos_carrito.Columns.Add("marca", typeof(string));
            productos_carrito.Columns.Add("categoria", typeof(string));

            // Enlazo todos los ComboBox y el textbox a un mismo evento
            cb_categoria.SelectedIndexChanged += ComboBox_TextChanged;
            cb_marca.TextChanged += ComboBox_TextChanged;
            cb_precio.SelectedIndexChanged += ComboBox_TextChanged;
            tb_nombre.TextChanged += ComboBox_TextChanged;

            cb_categoria.TextChanged += cb_marca_TextChanged;
            // cb_marca.TextChanged += ComboBox_TextChanged;
            // cb_precio.TextChanged += ComboBox_TextChanged;
        }

        //Cargo el formulario
        private void Form1_Load(object sender, EventArgs e)
        {

            this.dataTable1TableAdapter.Fill(this.dataSet21.DataTable1);
            this.categoriasTableAdapter.Fill(this.dataSet21.categorias);
            this.catalogoTableAdapter.Fill(this.dataSet21.catalogo);
            this.componentesTableAdapter.Fill(this.dataSet21.componentes);
            //lv_lista.DrawSubItem += lv_lista_DrawSubItem;

            cargar_datos();

            //Los combobox hago que aparezcan sin selección
            cb_categoria.SelectedIndex = -1;
            cb_marca.SelectedIndex = -1;

            cargarPrecio();

            // Crear un control ToolTip para mostrar informacon cuando se pasa el puntero por encima de ListView
            ToolTip toolTip = new ToolTip();

            // Controlo la duracion del mensaje y el tiempo de espera
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1500;
            toolTip.ReshowDelay = 2000;

            // lo asigno al ListView
            toolTip.SetToolTip(lv_lista, "haz doble click para añadir un producto al carrito");

        }


        //Evento cada vez que se escribe sobre cualquier combobox
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        //Evento cuando se selecciona un item del combo box
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrar();
        }


        //METODOS RELACCIONADOS CON LOS FILTROS DE BÚSQUEDA

        //método que filtra los resultados teniendo en cuenta los cuatro filtros
        private void filtrar()
        {
            componentes = this.dataSet21.catalogo;
            lv_lista.Items.Clear();

            foreach (DataRow componente in componentes.Rows)
            {
                // Si pasa todos los filtros de nombre, categoría, marca y precio, lo agrego al ListView
                if (!mostrar_componente_por_nombre(componente)) continue;
                if (!mostrar_componente_por_categoria2(componente)) continue;
                if (!mostrar_componente_por_marca2(componente)) continue;
                if (!mostrar_componente_por_precio2(componente)) continue;

                ListViewItem item = lv_lista.Items.Add(componente["id"].ToString());
                item.SubItems.Add(componente["componente"].ToString());
                item.SubItems.Add(componente["precio"].ToString());
                item.SubItems.Add(componente["marca"].ToString());
                item.SubItems.Add(componente["categoría"].ToString());
            }
        }

        //los sigueintestres metodos que devuelve tru o false si hay coincidencia a la hora de escribir con los filtros que se aplican      
        private bool mostrar_componente_por_nombre(DataRow componente)
        {
            // Si el TextBox de nombre está vacío o no hay texto
            if (string.IsNullOrEmpty(tb_nombre.Text)) return true;

            // Obtengo el valor
            string nombre = componente["componente"] != DBNull.Value ? componente["componente"].ToString() : string.Empty;

            return nombre.IndexOf(tb_nombre.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        private bool mostrar_componente_por_categoria2(DataRow componente)
        {
            if (string.IsNullOrEmpty(cb_categoria.Text)) return true;

            string categoria = componente["categoría"] != DBNull.Value ? componente["categoría"].ToString() : string.Empty;

            return categoria.IndexOf(cb_categoria.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        private bool mostrar_componente_por_marca2(DataRow componente)
        {
            if (string.IsNullOrEmpty(cb_marca.Text) || cb_marca.SelectedIndex == -1) return true; // No filtra si no hay texto o selección en el ComboBox

            string marca = componente["marca"] != DBNull.Value ? componente["marca"].ToString() : string.Empty;

            return marca.IndexOf(cb_marca.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        private bool mostrar_componente_por_precio2(DataRow componente)
        {
            bool precioCoincide = true;  // Si no hay filtro de precio, no lo filtro
            if (cb_precio.SelectedIndex > 0)
            {
                decimal precioMaximo = decimal.Parse(cb_precio.SelectedItem.ToString().Replace("Menos de ", "").Replace(" $", ""));
                precioCoincide = decimal.Parse(componente["precio"].ToString()) < precioMaximo;
            }

            return precioCoincide;
        }


        //los tres siguientes métodos restablecen los Combo box de búsqueda 
        private void bt_precio_Click(object sender, EventArgs e)
        {
            cb_precio.SelectedItem = null;
        }
        private void bt_marca_Click(object sender, EventArgs e)
        {
            cb_marca.SelectedIndex = -1;
        }
        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            cb_categoria.SelectedIndex = -1;

        }



        //MÉTODOS RELACCIONADOS CON LOS ELEMENTOS DEL CARRITO

        //Para recuperar el carrito del Form2
        public DataTable Carrito { get; set; }

        // Botones y clicks relacionados con el carrito
        private void bt_anadir_Click(object sender, EventArgs e)
        {
            añadir_productos_carrito();
        }
        private void bt_carrito_Click(object sender, EventArgs e)
        {
            abrir_carrito();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vaciar_carrito();
        }
        private void doubleclik_selectedItem_lista(object sender, EventArgs e)
        {
            if (lv_lista.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_lista.SelectedItems[0];

                DataRow nuevaFila = productos_carrito.NewRow();
                nuevaFila["id"] = selectedItem.SubItems[0].Text;
                nuevaFila["nombre"] = selectedItem.SubItems[1].Text;
                nuevaFila["precio"] = Convert.ToDecimal(selectedItem.SubItems[2].Text);
                nuevaFila["marca"] = selectedItem.SubItems[3].Text;
                nuevaFila["categoria"] = selectedItem.SubItems[4].Text;

                productos_carrito.Rows.Add(nuevaFila);
                carrito.Agregar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto.");
            }
        }


        //Método que pregunta al usuario si quiere aceptar la inclusion de productros al carrito y que guarda los productos en un Datatable
        private void añadir_productos_carrito()
        {
            if (lv_lista.SelectedItems.Count > 0) //Si hay almenos uno seleccionado muestra diálogo
            {
                DialogResult result = MessageBox.Show("¿Seguro que deseas añadir estos productos al carrito?",
                                                      "Confirmar Añadir", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Itero sobre cada item seleccionado
                    foreach (ListViewItem selectedItem in lv_lista.SelectedItems)
                    {
                        // Creo una nueva fila para el carrito 
                        DataRow nuevaFila = productos_carrito.NewRow();
                        nuevaFila["id"] = selectedItem.SubItems[0].Text;
                        nuevaFila["nombre"] = selectedItem.SubItems[1].Text;
                        nuevaFila["precio"] = Convert.ToDecimal(selectedItem.SubItems[2].Text);
                        nuevaFila["marca"] = selectedItem.SubItems[3].Text;
                        nuevaFila["categoria"] = selectedItem.SubItems[4].Text;

                        productos_carrito.Rows.Add(nuevaFila);
                        carrito.Agregar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un producto para añadir al carrito.");
            }
        }

        //Método que pasa los datos del carrito del Form1 al Form2 o al a inversa
        private void abrir_carrito()
        {
            if (productos_carrito != null && productos_carrito.Rows.Count > 0)
            {
                Form2 f2 = new Form2(productos_carrito);
                f2.ShowDialog();

                // Después de cerrar el form2, verifico si el carrito en Form2 tiene datos
                if (f2.Carrito != null && f2.Carrito.Rows.Count > 0)
                {
                    this.Carrito = f2.Carrito;
                    actualizarVistaCarrito();
                }
                else
                {
                    vaciar_carrito();
                    
                }
            }
            else
            {

                MessageBox.Show("Antes de abrir el carrito debes seleccionar algún producto ", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Método para actualizar el carrito se se módfifico en el Form2
        private void actualizarVistaCarrito()
        {
            int cantidadFilas = this.Carrito.Rows.Count;// Obtengo la cantidad de filas del DataTable
            carrito.Eliminar(carrito.Notificaciones); //Resto las notificaiones si hay menos
            carrito.Agregar(cantidadFilas);  // Aquí se paso la cantidad de filas al método Agregar

        }

        //Vacío el carrito
        private void vaciar_carrito()
        {
            productos_carrito.Clear();
            carrito.Eliminar(carrito.Notificaciones);
        }


        //MÉTODOS RELACCIONADOS CON LOS MENUS YY SUBMENUS
        //Clicks
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrar_ventana();
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_archivo();
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar_txt();
        }
        private void filtrarPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_precio.DroppedDown = !cb_precio.DroppedDown;
        }
        private void filtrarPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_marca.DroppedDown = !cb_marca.DroppedDown;
        }
        private void filtrarPorCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_categoria.DroppedDown = !cb_categoria.DroppedDown;
        }
        private void vaciarCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vaciar_carrito();
        }
        private void verCarritoToolStripMenuItem_Click_1(object sender, EventArgs e) { abrir_carrito(); }
        private void finalizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total de la compra: " + obtenerSumaPrecios().ToString() + "\nMuchas Gracias por su compra");
            vaciar_carrito();
        }
        private void añadirProductosSeleccionadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            añadir_productos_carrito();
        }
        private void bt_anadir2_Click(object sender, EventArgs e)
        {
            añadir_productos_carrito();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            cerrar_ventana();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            abrir_archivo();
        }
        private void toolbt_guardar_Click(object sender, EventArgs e)
        {
            guardar_txt();
        }
        private void toolbt_vaciar_carrito_Click(object sender, EventArgs e)
        {
            vaciar_carrito();
        }
        private void toolbt_ir_a_carrito_Click(object sender, EventArgs e)
        {
            abrir_carrito();
        }
        private void carrito_click(object sender, EventArgs e)
        {
            abrir_carrito();
        }
        private void bt_reset_carrito_Click(object sender, EventArgs e)
        {
            cargar_datos();
            cb_precio.SelectedItem = null;
            cb_marca.SelectedIndex = -1;
            cb_categoria.SelectedIndex = -1;
            tb_nombre.Text = string.Empty;

        }

        //Métodos relaccionados con las acciones de los menus
        //Pregunta al usuario si quiere salir del formulario y sale o no
        private void cerrar_ventana()
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que deseas salir?", "Confirmar salida",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Método ficticio de abrir un archivo
        private void abrir_archivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establezco el filtro para mostrar ciertos tipos de archivos
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Selecciona un archivo para abrir";

            DialogResult resultado = openFileDialog.ShowDialog();  // Mostro el cuadro de diálogo de apertura de archivo

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Aquí se abriría el archivo: " + openFileDialog.FileName);
            }

            openFileDialog.Dispose();
        }

        //Método que guarda en un txt el carrito con su balor (Me ayudó chat gpt)
        private void guardar_txt()
        {
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
                    for (int i = 0; i < productos_carrito.Columns.Count; i++)
                    {
                        writer.Write(productos_carrito.Columns[i].ColumnName);
                        if (i < productos_carrito.Columns.Count - 1)
                        {
                            writer.Write("\t"); // Usamos tabuladores para separar los campos
                        }
                    }
                    writer.WriteLine(); // Salto de línea después de los encabezados

                    // Escribimos los datos del DataTable (contenido de las filas)
                    foreach (DataRow row in productos_carrito.Rows)
                    {
                        for (int i = 0; i < productos_carrito.Columns.Count; i++)
                        {
                            writer.Write(row[i].ToString());
                            if (i < productos_carrito.Columns.Count - 1)
                            {
                                writer.Write("\t"); // Usamos tabuladores para separar los campos
                            }
                        }
                        writer.WriteLine(); // Salto de línea después de cada fila
                    }
                }

                // Mostrar mensaje confirmando que el archivo se guardó correctamente
                MessageBox.Show("El archivo se ha guardado correctamente en: " + archivoSeleccionado);
            }
        }

        //Método que obtiene el total para incorporarlo en el mensaje de finalización de carrito
        private decimal obtenerSumaPrecios()
        {
            if (productos_carrito != null && productos_carrito.Rows.Count > 0)
            {
                decimal sumaPrecios = 0;
                foreach (DataRow row in productos_carrito.Rows)
                {
                    sumaPrecios += Convert.ToDecimal(row["precio"]);
                }

                return sumaPrecios;
            }
            else
            {
                return 0;
            }
        }


        //Activdad tema 5 Informes
        private void generar_informe()
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void abrirInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generar_informe();
        }

        private void toolStripBt_informe_Click(object sender, EventArgs e)
        {
            generar_informe();
        }

        private void generar_graficos()
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            generar_graficos();
        }

        private void abrirGráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generar_graficos();
        }




        //Métodos que fui probando pero que al final no usé
        private void verCarritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrir_carrito();
        }
        private void cb_marca_TextChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            if (string.IsNullOrEmpty(comboBox.Text))
            {
                comboBox.SelectedIndex = -1;
            }
            filtrar();
        }

        private void filtrar_categoría()
        {
            componentes = this.dataSet21.catalogo;
            lv_lista.Items.Clear();
            foreach (DataRow componente in componentes.Rows)
            {
                if (!mostrar_componente_por_categoriae(componente)) continue;
                ListViewItem item = lv_lista.Items.Add(componente["id"].ToString());
                item.SubItems.Add(componente["componente"].ToString());
                item.SubItems.Add(componente["precio"].ToString());
                item.SubItems.Add(componente["marca"].ToString());
                item.SubItems.Add(componente["categoría"].ToString());
            }

        }

        private bool mostrar_componente_por_categoriae(DataRow componente)
        {

            if (cb_categoria.Text != componente["categoría"].ToString()) return false;
            return true;

        }

        private void filtrar_marca()
        {
            componentes = this.dataSet21.catalogo;
            lv_lista.Items.Clear();
            foreach (DataRow componente in componentes.Rows)
            {
                if (!mostrar_componente_por_marca(componente)) continue;
                ListViewItem item = lv_lista.Items.Add(componente["id"].ToString());
                item.SubItems.Add(componente["componente"].ToString());
                item.SubItems.Add(componente["precio"].ToString());
                item.SubItems.Add(componente["marca"].ToString());
                item.SubItems.Add(componente["categoría"].ToString());
            }

        }

        private bool mostrar_componente_por_marca(DataRow componente)
        {

            if (cb_marca.Text != componente["marca"].ToString()) return false;
            return true;

        }

        private void filtrar_precio()
        {
            componentes = this.dataSet21.catalogo;
            lv_lista.Items.Clear();
            foreach (DataRow componente in componentes.Rows)
            {
                if (!mostrar_componente_por_precio(componente)) continue;
                ListViewItem item = lv_lista.Items.Add(componente["id"].ToString());
                item.SubItems.Add(componente["componente"].ToString());
                item.SubItems.Add(componente["precio"].ToString());
                item.SubItems.Add(componente["marca"].ToString());
                item.SubItems.Add(componente["categoría"].ToString());
            }

        }

        private bool mostrar_componente_por_precio(DataRow componente)
        {
            bool precioCoincide = true;  // Si no hay filtro de precio, no lo filtramos
            if (cb_precio.SelectedIndex > 0)  // Asegúrate de que el ComboBox de precios tenga opciones válidas (por ejemplo, "Menos de 100")
            {
                decimal precioMaximo = decimal.Parse(cb_precio.SelectedItem.ToString().Replace("Menos de ", "").Replace(" $", ""));
                precioCoincide = decimal.Parse(componente["precio"].ToString()) < precioMaximo;
            }

            return precioCoincide;

        }

       
    }

}
