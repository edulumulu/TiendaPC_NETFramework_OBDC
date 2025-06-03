namespace Actividad2_tema_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet21 = new Actividad2_tema_4.DataSet2();
            this.lv_lista = new System.Windows.Forms.ListView();
            this.columnHeader_id_comp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.componentesTableAdapter = new Actividad2_tema_4.DataSet2TableAdapters.componentesTableAdapter();
            this.catalogoTableAdapter = new Actividad2_tema_4.DataSet2TableAdapters.catalogoTableAdapter();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new Actividad2_tema_4.DataSet2TableAdapters.categoriasTableAdapter();
            this.cb_precio = new System.Windows.Forms.ComboBox();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTable1TableAdapter = new Actividad2_tema_4.DataSet2TableAdapters.DataTable1TableAdapter();
            this.bt_categoría = new System.Windows.Forms.Button();
            this.bt_precio = new System.Windows.Forms.Button();
            this.bt_marca = new System.Windows.Forms.Button();
            this.bt_anadir = new System.Windows.Forms.Button();
            this.carrito = new correo.correo();
            this.bt_carrito = new System.Windows.Forms.Button();
            this.bt_vaciar_carrito = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrarPorCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirProductosSeleccionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaciarCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirInformeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirGráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_anadir2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolbt_guardar = new System.Windows.Forms.ToolStripButton();
            this.toolbt_abrir = new System.Windows.Forms.ToolStripButton();
            this.toolbt_vaciar_carrito = new System.Windows.Forms.ToolStripButton();
            this.toolbt_ir_a_carrito = new System.Windows.Forms.ToolStripButton();
            this.toolStripBt_informe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_reset_carrito = new System.Windows.Forms.Button();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet2";
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lv_lista
            // 
            this.lv_lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_id_comp,
            this.columnHeader_nombre,
            this.columnHeader_precio,
            this.columnHeader_marca,
            this.columnHeader_categoria});
            this.lv_lista.FullRowSelect = true;
            this.lv_lista.HideSelection = false;
            this.lv_lista.Location = new System.Drawing.Point(33, 248);
            this.lv_lista.Name = "lv_lista";
            this.lv_lista.Size = new System.Drawing.Size(639, 275);
            this.lv_lista.TabIndex = 0;
            this.lv_lista.UseCompatibleStateImageBehavior = false;
            this.lv_lista.View = System.Windows.Forms.View.Details;
            this.lv_lista.DoubleClick += new System.EventHandler(this.doubleclik_selectedItem_lista);
            // 
            // columnHeader_id_comp
            // 
            this.columnHeader_id_comp.Text = "id_componente";
            this.columnHeader_id_comp.Width = 40;
            // 
            // columnHeader_nombre
            // 
            this.columnHeader_nombre.Text = "nombre";
            this.columnHeader_nombre.Width = 250;
            // 
            // columnHeader_precio
            // 
            this.columnHeader_precio.Text = "precio";
            this.columnHeader_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader_marca
            // 
            this.columnHeader_marca.Text = "marca";
            this.columnHeader_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_marca.Width = 120;
            // 
            // columnHeader_categoria
            // 
            this.columnHeader_categoria.Text = "categoría";
            this.columnHeader_categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader_categoria.Width = 140;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "catalogo";
            this.bindingSource1.DataSource = this.dataSet21;
            // 
            // componentesTableAdapter
            // 
            this.componentesTableAdapter.ClearBeforeFill = true;
            // 
            // catalogoTableAdapter
            // 
            this.catalogoTableAdapter.ClearBeforeFill = true;
            // 
            // cb_categoria
            // 
            this.cb_categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_categoria.DataSource = this.categoriasBindingSource;
            this.cb_categoria.DisplayMember = "nombre";
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(392, 139);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(121, 21);
            this.cb_categoria.TabIndex = 1;
            this.cb_categoria.ValueMember = "id";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "categorias";
            this.categoriasBindingSource.DataSource = this.dataSet21;
            // 
            // componentesBindingSource
            // 
            this.componentesBindingSource.DataMember = "componentes";
            this.componentesBindingSource.DataSource = this.dataSet21;
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataMember = "catalogo";
            this.catalogoBindingSource.DataSource = this.dataSet21;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // cb_precio
            // 
            this.cb_precio.FormattingEnabled = true;
            this.cb_precio.Location = new System.Drawing.Point(73, 139);
            this.cb_precio.Name = "cb_precio";
            this.cb_precio.Size = new System.Drawing.Size(121, 21);
            this.cb_precio.TabIndex = 2;
            // 
            // cb_marca
            // 
            this.cb_marca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_marca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_marca.DataSource = this.dataTable1BindingSource;
            this.cb_marca.DisplayMember = "marca";
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(392, 101);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(121, 21);
            this.cb_marca.TabIndex = 3;
            this.cb_marca.ValueMember = "marca";
            this.cb_marca.TextChanged += new System.EventHandler(this.cb_marca_TextChanged);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Utiliza los filtros de uno en uno para buscar el producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca:";
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // bt_categoría
            // 
            this.bt_categoría.Location = new System.Drawing.Point(519, 137);
            this.bt_categoría.Name = "bt_categoría";
            this.bt_categoría.Size = new System.Drawing.Size(96, 23);
            this.bt_categoría.TabIndex = 8;
            this.bt_categoría.Text = "Filtrar categoría";
            this.bt_categoría.UseVisualStyleBackColor = true;
            this.bt_categoría.Click += new System.EventHandler(this.bt_filtrar_Click);
            // 
            // bt_precio
            // 
            this.bt_precio.Location = new System.Drawing.Point(200, 137);
            this.bt_precio.Name = "bt_precio";
            this.bt_precio.Size = new System.Drawing.Size(96, 23);
            this.bt_precio.TabIndex = 9;
            this.bt_precio.Text = "Resetear filtro";
            this.bt_precio.UseVisualStyleBackColor = true;
            this.bt_precio.Click += new System.EventHandler(this.bt_precio_Click);
            // 
            // bt_marca
            // 
            this.bt_marca.Location = new System.Drawing.Point(519, 101);
            this.bt_marca.Name = "bt_marca";
            this.bt_marca.Size = new System.Drawing.Size(96, 23);
            this.bt_marca.TabIndex = 10;
            this.bt_marca.Text = "Filtrar por marca";
            this.bt_marca.UseVisualStyleBackColor = true;
            this.bt_marca.Click += new System.EventHandler(this.bt_marca_Click);
            // 
            // bt_anadir
            // 
            this.bt_anadir.BackColor = System.Drawing.Color.Yellow;
            this.bt_anadir.Location = new System.Drawing.Point(556, 529);
            this.bt_anadir.Name = "bt_anadir";
            this.bt_anadir.Size = new System.Drawing.Size(116, 40);
            this.bt_anadir.TabIndex = 11;
            this.bt_anadir.Text = "Añadir productos";
            this.bt_anadir.UseVisualStyleBackColor = false;
            this.bt_anadir.Click += new System.EventHandler(this.bt_anadir_Click);
            // 
            // carrito
            // 
            this.carrito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.carrito.ColorCirculo = System.Drawing.Color.OrangeRed;
            this.carrito.ColorDeFondo = System.Drawing.Color.Transparent;
            this.carrito.ColorTexto = System.Drawing.Color.White;
            this.carrito.Imagen = global::Actividad2_tema_4.Properties.Resources.carrito3;
            this.carrito.Location = new System.Drawing.Point(700, 65);
            this.carrito.Name = "carrito";
            this.carrito.Notificaciones = 0;
            this.carrito.Size = new System.Drawing.Size(119, 119);
            this.carrito.TabIndex = 12;
            this.carrito.Click += new System.EventHandler(this.carrito_click);
            // 
            // bt_carrito
            // 
            this.bt_carrito.Location = new System.Drawing.Point(700, 190);
            this.bt_carrito.Name = "bt_carrito";
            this.bt_carrito.Size = new System.Drawing.Size(119, 23);
            this.bt_carrito.TabIndex = 13;
            this.bt_carrito.Text = "Ir al carrito";
            this.bt_carrito.UseVisualStyleBackColor = true;
            this.bt_carrito.Click += new System.EventHandler(this.bt_carrito_Click);
            // 
            // bt_vaciar_carrito
            // 
            this.bt_vaciar_carrito.Location = new System.Drawing.Point(700, 219);
            this.bt_vaciar_carrito.Name = "bt_vaciar_carrito";
            this.bt_vaciar_carrito.Size = new System.Drawing.Size(119, 23);
            this.bt_vaciar_carrito.TabIndex = 14;
            this.bt_vaciar_carrito.Text = "Vaciar carrito";
            this.bt_vaciar_carrito.UseVisualStyleBackColor = true;
            this.bt_vaciar_carrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.carritoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtrarPorPrecioToolStripMenuItem,
            this.filtrarPorMarcaToolStripMenuItem,
            this.filtrarPorCategoríaToolStripMenuItem,
            this.añadirProductosSeleccionadosToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // filtrarPorPrecioToolStripMenuItem
            // 
            this.filtrarPorPrecioToolStripMenuItem.Name = "filtrarPorPrecioToolStripMenuItem";
            this.filtrarPorPrecioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.filtrarPorPrecioToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.filtrarPorPrecioToolStripMenuItem.Text = "Filtrar por Precio";
            this.filtrarPorPrecioToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorPrecioToolStripMenuItem_Click);
            // 
            // filtrarPorMarcaToolStripMenuItem
            // 
            this.filtrarPorMarcaToolStripMenuItem.Name = "filtrarPorMarcaToolStripMenuItem";
            this.filtrarPorMarcaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.filtrarPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.filtrarPorMarcaToolStripMenuItem.Text = "Filtrar por marca";
            this.filtrarPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorMarcaToolStripMenuItem_Click);
            // 
            // filtrarPorCategoríaToolStripMenuItem
            // 
            this.filtrarPorCategoríaToolStripMenuItem.Name = "filtrarPorCategoríaToolStripMenuItem";
            this.filtrarPorCategoríaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.filtrarPorCategoríaToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.filtrarPorCategoríaToolStripMenuItem.Text = "Filtrar por categoría";
            this.filtrarPorCategoríaToolStripMenuItem.Click += new System.EventHandler(this.filtrarPorCategoríaToolStripMenuItem_Click);
            // 
            // añadirProductosSeleccionadosToolStripMenuItem
            // 
            this.añadirProductosSeleccionadosToolStripMenuItem.Name = "añadirProductosSeleccionadosToolStripMenuItem";
            this.añadirProductosSeleccionadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.añadirProductosSeleccionadosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.añadirProductosSeleccionadosToolStripMenuItem.Text = "Añadir productos seleccionados";
            this.añadirProductosSeleccionadosToolStripMenuItem.Click += new System.EventHandler(this.añadirProductosSeleccionadosToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCarritoToolStripMenuItem,
            this.vaciarCarritoToolStripMenuItem,
            this.finalizarCompraToolStripMenuItem});
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.carritoToolStripMenuItem.Text = "Carrito";
            // 
            // verCarritoToolStripMenuItem
            // 
            this.verCarritoToolStripMenuItem.Name = "verCarritoToolStripMenuItem";
            this.verCarritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.verCarritoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.verCarritoToolStripMenuItem.Text = "Ver carrito";
            this.verCarritoToolStripMenuItem.Click += new System.EventHandler(this.verCarritoToolStripMenuItem_Click_1);
            // 
            // vaciarCarritoToolStripMenuItem
            // 
            this.vaciarCarritoToolStripMenuItem.Name = "vaciarCarritoToolStripMenuItem";
            this.vaciarCarritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.vaciarCarritoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.vaciarCarritoToolStripMenuItem.Text = "Vaciar carrito";
            this.vaciarCarritoToolStripMenuItem.Click += new System.EventHandler(this.vaciarCarritoToolStripMenuItem_Click);
            // 
            // finalizarCompraToolStripMenuItem
            // 
            this.finalizarCompraToolStripMenuItem.Name = "finalizarCompraToolStripMenuItem";
            this.finalizarCompraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.finalizarCompraToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.finalizarCompraToolStripMenuItem.Text = "Finalizar Compra";
            this.finalizarCompraToolStripMenuItem.Click += new System.EventHandler(this.finalizarCompraToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirInformeToolStripMenuItem,
            this.abrirGráficosToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // abrirInformeToolStripMenuItem
            // 
            this.abrirInformeToolStripMenuItem.Name = "abrirInformeToolStripMenuItem";
            this.abrirInformeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.abrirInformeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirInformeToolStripMenuItem.Text = "Abrir informe";
            this.abrirInformeToolStripMenuItem.Click += new System.EventHandler(this.abrirInformeToolStripMenuItem_Click);
            // 
            // abrirGráficosToolStripMenuItem
            // 
            this.abrirGráficosToolStripMenuItem.Name = "abrirGráficosToolStripMenuItem";
            this.abrirGráficosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.abrirGráficosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirGráficosToolStripMenuItem.Text = "Abrir gráficos";
            this.abrirGráficosToolStripMenuItem.Click += new System.EventHandler(this.abrirGráficosToolStripMenuItem_Click);
            // 
            // bt_anadir2
            // 
            this.bt_anadir2.BackColor = System.Drawing.Color.Yellow;
            this.bt_anadir2.Location = new System.Drawing.Point(556, 202);
            this.bt_anadir2.Name = "bt_anadir2";
            this.bt_anadir2.Size = new System.Drawing.Size(116, 40);
            this.bt_anadir2.TabIndex = 16;
            this.bt_anadir2.Text = "Añadir productos";
            this.bt_anadir2.UseVisualStyleBackColor = false;
            this.bt_anadir2.Click += new System.EventHandler(this.bt_anadir2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbt_guardar,
            this.toolbt_abrir,
            this.toolbt_vaciar_carrito,
            this.toolbt_ir_a_carrito,
            this.toolStripBt_informe,
            this.toolStripButton1,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolbt_guardar
            // 
            this.toolbt_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbt_guardar.Image = global::Actividad2_tema_4.Properties.Resources.guardar;
            this.toolbt_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbt_guardar.Name = "toolbt_guardar";
            this.toolbt_guardar.Size = new System.Drawing.Size(23, 22);
            this.toolbt_guardar.Text = "toolStripButton1";
            this.toolbt_guardar.Click += new System.EventHandler(this.toolbt_guardar_Click);
            // 
            // toolbt_abrir
            // 
            this.toolbt_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbt_abrir.Image = global::Actividad2_tema_4.Properties.Resources.abrir;
            this.toolbt_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbt_abrir.Name = "toolbt_abrir";
            this.toolbt_abrir.Size = new System.Drawing.Size(23, 22);
            this.toolbt_abrir.Text = "toolStripButton2";
            this.toolbt_abrir.ToolTipText = "Abrir documento";
            this.toolbt_abrir.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolbt_vaciar_carrito
            // 
            this.toolbt_vaciar_carrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbt_vaciar_carrito.Image = global::Actividad2_tema_4.Properties.Resources.carrito_2;
            this.toolbt_vaciar_carrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbt_vaciar_carrito.Name = "toolbt_vaciar_carrito";
            this.toolbt_vaciar_carrito.Size = new System.Drawing.Size(23, 22);
            this.toolbt_vaciar_carrito.Text = "toolStripButton3";
            this.toolbt_vaciar_carrito.Click += new System.EventHandler(this.toolbt_vaciar_carrito_Click);
            // 
            // toolbt_ir_a_carrito
            // 
            this.toolbt_ir_a_carrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbt_ir_a_carrito.Image = global::Actividad2_tema_4.Properties.Resources.carrito3;
            this.toolbt_ir_a_carrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbt_ir_a_carrito.Name = "toolbt_ir_a_carrito";
            this.toolbt_ir_a_carrito.Size = new System.Drawing.Size(23, 22);
            this.toolbt_ir_a_carrito.Text = "toolStripButton4";
            this.toolbt_ir_a_carrito.Click += new System.EventHandler(this.toolbt_ir_a_carrito_Click);
            // 
            // toolStripBt_informe
            // 
            this.toolStripBt_informe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBt_informe.Image = global::Actividad2_tema_4.Properties.Resources.informe;
            this.toolStripBt_informe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBt_informe.Name = "toolStripBt_informe";
            this.toolStripBt_informe.Size = new System.Drawing.Size(23, 22);
            this.toolStripBt_informe.Text = "Generar informe";
            this.toolStripBt_informe.Click += new System.EventHandler(this.toolStripBt_informe_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Actividad2_tema_4.Properties.Resources.circulo1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Mostrar gráficos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::Actividad2_tema_4.Properties.Resources.salir;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.ToolTipText = "cerrar ventana";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(518, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Selecciona uno o varios productos y añadelo con el botón o haciendo doble click";
            // 
            // bt_reset_carrito
            // 
            this.bt_reset_carrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_reset_carrito.Location = new System.Drawing.Point(470, 52);
            this.bt_reset_carrito.Name = "bt_reset_carrito";
            this.bt_reset_carrito.Size = new System.Drawing.Size(145, 40);
            this.bt_reset_carrito.TabIndex = 20;
            this.bt_reset_carrito.Text = "Mostrar catálogo completo";
            this.bt_reset_carrito.UseVisualStyleBackColor = false;
            this.bt_reset_carrito.Click += new System.EventHandler(this.bt_reset_carrito_Click);
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(87, 101);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(209, 20);
            this.tb_nombre.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.bt_reset_carrito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bt_anadir2);
            this.Controls.Add(this.bt_vaciar_carrito);
            this.Controls.Add(this.bt_carrito);
            this.Controls.Add(this.carrito);
            this.Controls.Add(this.bt_anadir);
            this.Controls.Add(this.bt_marca);
            this.Controls.Add(this.bt_precio);
            this.Controls.Add(this.bt_categoría);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.cb_precio);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.lv_lista);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Componentes Informáticos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet21;
        private System.Windows.Forms.ListView lv_lista;
        private System.Windows.Forms.ColumnHeader columnHeader_id_comp;
        private System.Windows.Forms.ColumnHeader columnHeader_nombre;
        private System.Windows.Forms.ColumnHeader columnHeader_precio;
        private System.Windows.Forms.ColumnHeader columnHeader_marca;
        private System.Windows.Forms.ColumnHeader columnHeader_categoria;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet2TableAdapters.componentesTableAdapter componentesTableAdapter;
        private DataSet2TableAdapters.catalogoTableAdapter catalogoTableAdapter;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private System.Windows.Forms.BindingSource componentesBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DataSet2TableAdapters.categoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.ComboBox cb_precio;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet2TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.Button bt_categoría;
        private System.Windows.Forms.Button bt_precio;
        private System.Windows.Forms.Button bt_marca;
        private System.Windows.Forms.Button bt_anadir;
        private correo.correo carrito;
        private System.Windows.Forms.Button bt_carrito;
        private System.Windows.Forms.Button bt_vaciar_carrito;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrarPorCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaciarCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirProductosSeleccionadosToolStripMenuItem;
        private System.Windows.Forms.Button bt_anadir2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolbt_guardar;
        private System.Windows.Forms.ToolStripButton toolbt_abrir;
        private System.Windows.Forms.ToolStripButton toolbt_vaciar_carrito;
        private System.Windows.Forms.ToolStripButton toolbt_ir_a_carrito;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_reset_carrito;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirInformeToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripBt_informe;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem abrirGráficosToolStripMenuItem;
    }
}

