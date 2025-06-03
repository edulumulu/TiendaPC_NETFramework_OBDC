namespace Actividad2_tema_4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lv_lista = new System.Windows.Forms.ListView();
            this.Nº = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.bt_atras = new System.Windows.Forms.Button();
            this.bt_finalizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soloParaAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tb_salir = new System.Windows.Forms.ToolStripButton();
            this.carrito_carrito = new correo.correo();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_lista
            // 
            this.lv_lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nº,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv_lista.FullRowSelect = true;
            this.lv_lista.HideSelection = false;
            this.lv_lista.Location = new System.Drawing.Point(29, 169);
            this.lv_lista.Name = "lv_lista";
            this.lv_lista.Size = new System.Drawing.Size(605, 210);
            this.lv_lista.TabIndex = 0;
            this.lv_lista.UseCompatibleStateImageBehavior = false;
            this.lv_lista.View = System.Windows.Forms.View.Details;
            this.lv_lista.ItemActivate += new System.EventHandler(this.lv_lista_ItemActivate);
            this.lv_lista.SelectedIndexChanged += new System.EventHandler(this.slectedItem_lista);
            // 
            // Nº
            // 
            this.Nº.Text = "Nº";
            this.Nº.Width = 35;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Cantidad";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "nombre";
            this.columnHeader2.Width = 384;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "precio";
            this.columnHeader3.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.Location = new System.Drawing.Point(437, 393);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(89, 31);
            this.lb_total.TabIndex = 2;
            this.lb_total.Text = "10000";
            this.lb_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt_atras
            // 
            this.bt_atras.Location = new System.Drawing.Point(532, 503);
            this.bt_atras.Name = "bt_atras";
            this.bt_atras.Size = new System.Drawing.Size(102, 29);
            this.bt_atras.TabIndex = 5;
            this.bt_atras.Text = "Volver atras";
            this.bt_atras.UseVisualStyleBackColor = true;
            this.bt_atras.Click += new System.EventHandler(this.bt_atras_Click);
            // 
            // bt_finalizar
            // 
            this.bt_finalizar.Location = new System.Drawing.Point(532, 440);
            this.bt_finalizar.Name = "bt_finalizar";
            this.bt_finalizar.Size = new System.Drawing.Size(102, 45);
            this.bt_finalizar.TabIndex = 6;
            this.bt_finalizar.Text = "Finalizar compra";
            this.bt_finalizar.UseVisualStyleBackColor = true;
            this.bt_finalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Para modificar la cantidad, haz doble click sobre el producto";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soloParaAdministradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalizarCompraToolStripMenuItem,
            this.volverAtrásToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // finalizarCompraToolStripMenuItem
            // 
            this.finalizarCompraToolStripMenuItem.Name = "finalizarCompraToolStripMenuItem";
            this.finalizarCompraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.finalizarCompraToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.finalizarCompraToolStripMenuItem.Text = "Finalizar compra";
            this.finalizarCompraToolStripMenuItem.Click += new System.EventHandler(this.finalizarCompraToolStripMenuItem_Click);
            // 
            // volverAtrásToolStripMenuItem
            // 
            this.volverAtrásToolStripMenuItem.Name = "volverAtrásToolStripMenuItem";
            this.volverAtrásToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.volverAtrásToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.volverAtrásToolStripMenuItem.Text = "Volver atrás";
            this.volverAtrásToolStripMenuItem.Click += new System.EventHandler(this.volverAtrásToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // soloParaAdministradorToolStripMenuItem
            // 
            this.soloParaAdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarCarritoToolStripMenuItem});
            this.soloParaAdministradorToolStripMenuItem.Name = "soloParaAdministradorToolStripMenuItem";
            this.soloParaAdministradorToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.soloParaAdministradorToolStripMenuItem.Text = "Solo para administrador";
            // 
            // importarCarritoToolStripMenuItem
            // 
            this.importarCarritoToolStripMenuItem.Name = "importarCarritoToolStripMenuItem";
            this.importarCarritoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.importarCarritoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.importarCarritoToolStripMenuItem.Text = "Exportar carrito";
            this.importarCarritoToolStripMenuItem.Click += new System.EventHandler(this.importarCarritoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.tb_salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(665, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Actividad2_tema_4.Properties.Resources.pagar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Finalizar compra";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Actividad2_tema_4.Properties.Resources.privado;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Logear un administrativo";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tb_salir
            // 
            this.tb_salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_salir.Image = global::Actividad2_tema_4.Properties.Resources.salir;
            this.tb_salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_salir.Name = "tb_salir";
            this.tb_salir.Size = new System.Drawing.Size(23, 22);
            this.tb_salir.Text = "toolStripButton3";
            this.tb_salir.ToolTipText = "Cerrar ventana";
            this.tb_salir.Click += new System.EventHandler(this.tb_salir_Click);
            // 
            // carrito_carrito
            // 
            this.carrito_carrito.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.carrito_carrito.ColorCirculo = System.Drawing.Color.OrangeRed;
            this.carrito_carrito.ColorDeFondo = System.Drawing.Color.Transparent;
            this.carrito_carrito.ColorTexto = System.Drawing.Color.White;
            this.carrito_carrito.Imagen = global::Actividad2_tema_4.Properties.Resources.carrito3;
            this.carrito_carrito.Location = new System.Drawing.Point(526, 52);
            this.carrito_carrito.Name = "carrito_carrito";
            this.carrito_carrito.Notificaciones = 0;
            this.carrito_carrito.Size = new System.Drawing.Size(108, 108);
            this.carrito_carrito.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 544);
            this.Controls.Add(this.carrito_carrito);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_finalizar);
            this.Controls.Add(this.bt_atras);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_lista);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Carrito de la compra";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_lista;
        private System.Windows.Forms.ColumnHeader Nº;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button bt_atras;
        private System.Windows.Forms.Button bt_finalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soloParaAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tb_salir;
        private correo.correo carrito_carrito;
        private System.Windows.Forms.ToolStripMenuItem volverAtrásToolStripMenuItem;
    }
}