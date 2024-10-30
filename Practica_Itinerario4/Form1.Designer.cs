namespace Practica_Itinerario4
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
         this.lblDNI = new System.Windows.Forms.Label();
         this.txtDNI = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.lblProducto = new System.Windows.Forms.Label();
         this.txtCantidad = new System.Windows.Forms.TextBox();
         this.BoxProducto = new System.Windows.Forms.ComboBox();
         this.lblCantidad = new System.Windows.Forms.Label();
         this.btnAgregarItem = new System.Windows.Forms.Button();
         this.btnAltaPedido = new System.Windows.Forms.Button();
         this.dgvDetallesPedidos = new System.Windows.Forms.DataGridView();
         this.lblDescripcionProducto = new System.Windows.Forms.Label();
         this.txtDescripcionProd = new System.Windows.Forms.TextBox();
         this.lblPrecio = new System.Windows.Forms.Label();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.btnAgregarProd = new System.Windows.Forms.Button();
         this.lblSelectProd = new System.Windows.Forms.Label();
         this.BoxSelectProd = new System.Windows.Forms.ComboBox();
         this.lblNuevoPrecio = new System.Windows.Forms.Label();
         this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
         this.btnModificarPrecio = new System.Windows.Forms.Button();
         this.btnMostrarPedidos = new System.Windows.Forms.Button();
         this.dgvMostrarPedidos = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPedidos)).BeginInit();
         this.SuspendLayout();
         // 
         // lblDNI
         // 
         this.lblDNI.AutoSize = true;
         this.lblDNI.Location = new System.Drawing.Point(60, 27);
         this.lblDNI.Name = "lblDNI";
         this.lblDNI.Size = new System.Drawing.Size(30, 16);
         this.lblDNI.TabIndex = 0;
         this.lblDNI.Text = "DNI";
         // 
         // txtDNI
         // 
         this.txtDNI.Location = new System.Drawing.Point(106, 21);
         this.txtDNI.Name = "txtDNI";
         this.txtDNI.Size = new System.Drawing.Size(120, 22);
         this.txtDNI.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(100, 123);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(0, 16);
         this.label1.TabIndex = 2;
         // 
         // lblProducto
         // 
         this.lblProducto.AutoSize = true;
         this.lblProducto.Location = new System.Drawing.Point(16, 61);
         this.lblProducto.Name = "lblProducto";
         this.lblProducto.Size = new System.Drawing.Size(84, 16);
         this.lblProducto.TabIndex = 3;
         this.lblProducto.Text = "PRODUCTO";
         // 
         // txtCantidad
         // 
         this.txtCantidad.Location = new System.Drawing.Point(106, 91);
         this.txtCantidad.Name = "txtCantidad";
         this.txtCantidad.Size = new System.Drawing.Size(120, 22);
         this.txtCantidad.TabIndex = 4;
         // 
         // BoxProducto
         // 
         this.BoxProducto.FormattingEnabled = true;
         this.BoxProducto.Location = new System.Drawing.Point(106, 58);
         this.BoxProducto.Name = "BoxProducto";
         this.BoxProducto.Size = new System.Drawing.Size(120, 24);
         this.BoxProducto.TabIndex = 5;
         // 
         // lblCantidad
         // 
         this.lblCantidad.AutoSize = true;
         this.lblCantidad.Location = new System.Drawing.Point(24, 94);
         this.lblCantidad.Name = "lblCantidad";
         this.lblCantidad.Size = new System.Drawing.Size(76, 16);
         this.lblCantidad.TabIndex = 6;
         this.lblCantidad.Text = "CANTIDAD";
         // 
         // btnAgregarItem
         // 
         this.btnAgregarItem.Location = new System.Drawing.Point(279, 83);
         this.btnAgregarItem.Name = "btnAgregarItem";
         this.btnAgregarItem.Size = new System.Drawing.Size(105, 59);
         this.btnAgregarItem.TabIndex = 7;
         this.btnAgregarItem.Text = "AGREGAR ITEM";
         this.btnAgregarItem.UseVisualStyleBackColor = true;
         this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
         // 
         // btnAltaPedido
         // 
         this.btnAltaPedido.Location = new System.Drawing.Point(279, 18);
         this.btnAltaPedido.Name = "btnAltaPedido";
         this.btnAltaPedido.Size = new System.Drawing.Size(105, 59);
         this.btnAltaPedido.TabIndex = 8;
         this.btnAltaPedido.Text = "ALTA PEDIDO";
         this.btnAltaPedido.UseVisualStyleBackColor = true;
         this.btnAltaPedido.Click += new System.EventHandler(this.btnAltaPedido_Click);
         // 
         // dgvDetallesPedidos
         // 
         this.dgvDetallesPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvDetallesPedidos.Location = new System.Drawing.Point(410, 27);
         this.dgvDetallesPedidos.Name = "dgvDetallesPedidos";
         this.dgvDetallesPedidos.RowHeadersWidth = 51;
         this.dgvDetallesPedidos.RowTemplate.Height = 24;
         this.dgvDetallesPedidos.Size = new System.Drawing.Size(378, 303);
         this.dgvDetallesPedidos.TabIndex = 9;
         // 
         // lblDescripcionProducto
         // 
         this.lblDescripcionProducto.AutoSize = true;
         this.lblDescripcionProducto.Location = new System.Drawing.Point(9, 157);
         this.lblDescripcionProducto.Name = "lblDescripcionProducto";
         this.lblDescripcionProducto.Size = new System.Drawing.Size(136, 16);
         this.lblDescripcionProducto.TabIndex = 10;
         this.lblDescripcionProducto.Text = "Descripción Producto";
         // 
         // txtDescripcionProd
         // 
         this.txtDescripcionProd.Location = new System.Drawing.Point(151, 151);
         this.txtDescripcionProd.Name = "txtDescripcionProd";
         this.txtDescripcionProd.Size = new System.Drawing.Size(120, 22);
         this.txtDescripcionProd.TabIndex = 11;
         // 
         // lblPrecio
         // 
         this.lblPrecio.AutoSize = true;
         this.lblPrecio.Location = new System.Drawing.Point(89, 192);
         this.lblPrecio.Name = "lblPrecio";
         this.lblPrecio.Size = new System.Drawing.Size(46, 16);
         this.lblPrecio.TabIndex = 12;
         this.lblPrecio.Text = "Precio";
         // 
         // txtPrecio
         // 
         this.txtPrecio.Location = new System.Drawing.Point(151, 186);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.Size = new System.Drawing.Size(120, 22);
         this.txtPrecio.TabIndex = 13;
         // 
         // btnAgregarProd
         // 
         this.btnAgregarProd.Location = new System.Drawing.Point(279, 157);
         this.btnAgregarProd.Name = "btnAgregarProd";
         this.btnAgregarProd.Size = new System.Drawing.Size(105, 59);
         this.btnAgregarProd.TabIndex = 14;
         this.btnAgregarProd.Text = "AGREGAR PRODUCTO";
         this.btnAgregarProd.UseVisualStyleBackColor = true;
         this.btnAgregarProd.Click += new System.EventHandler(this.btnAgregarProd_Click);
         // 
         // lblSelectProd
         // 
         this.lblSelectProd.AutoSize = true;
         this.lblSelectProd.Location = new System.Drawing.Point(9, 274);
         this.lblSelectProd.Name = "lblSelectProd";
         this.lblSelectProd.Size = new System.Drawing.Size(136, 16);
         this.lblSelectProd.TabIndex = 15;
         this.lblSelectProd.Text = "Seleccionar Producto";
         // 
         // BoxSelectProd
         // 
         this.BoxSelectProd.FormattingEnabled = true;
         this.BoxSelectProd.Location = new System.Drawing.Point(151, 266);
         this.BoxSelectProd.Name = "BoxSelectProd";
         this.BoxSelectProd.Size = new System.Drawing.Size(120, 24);
         this.BoxSelectProd.TabIndex = 16;
         // 
         // lblNuevoPrecio
         // 
         this.lblNuevoPrecio.AutoSize = true;
         this.lblNuevoPrecio.Location = new System.Drawing.Point(60, 314);
         this.lblNuevoPrecio.Name = "lblNuevoPrecio";
         this.lblNuevoPrecio.Size = new System.Drawing.Size(89, 16);
         this.lblNuevoPrecio.TabIndex = 17;
         this.lblNuevoPrecio.Text = "Nuevo Precio";
         // 
         // txtNuevoPrecio
         // 
         this.txtNuevoPrecio.Location = new System.Drawing.Point(151, 308);
         this.txtNuevoPrecio.Name = "txtNuevoPrecio";
         this.txtNuevoPrecio.Size = new System.Drawing.Size(120, 22);
         this.txtNuevoPrecio.TabIndex = 18;
         // 
         // btnModificarPrecio
         // 
         this.btnModificarPrecio.Location = new System.Drawing.Point(279, 271);
         this.btnModificarPrecio.Name = "btnModificarPrecio";
         this.btnModificarPrecio.Size = new System.Drawing.Size(105, 59);
         this.btnModificarPrecio.TabIndex = 19;
         this.btnModificarPrecio.Text = "MODIFICAR PRECIO";
         this.btnModificarPrecio.UseVisualStyleBackColor = true;
         this.btnModificarPrecio.Click += new System.EventHandler(this.btnModificarPrecio_Click);
         // 
         // btnMostrarPedidos
         // 
         this.btnMostrarPedidos.Location = new System.Drawing.Point(666, 379);
         this.btnMostrarPedidos.Name = "btnMostrarPedidos";
         this.btnMostrarPedidos.Size = new System.Drawing.Size(105, 59);
         this.btnMostrarPedidos.TabIndex = 20;
         this.btnMostrarPedidos.Text = "MOSTRAR PEDIDOS";
         this.btnMostrarPedidos.UseVisualStyleBackColor = true;
         this.btnMostrarPedidos.Click += new System.EventHandler(this.btnMostrarPedidos_Click);
         // 
         // dgvMostrarPedidos
         // 
         this.dgvMostrarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvMostrarPedidos.Location = new System.Drawing.Point(12, 358);
         this.dgvMostrarPedidos.Name = "dgvMostrarPedidos";
         this.dgvMostrarPedidos.RowHeadersWidth = 51;
         this.dgvMostrarPedidos.RowTemplate.Height = 24;
         this.dgvMostrarPedidos.Size = new System.Drawing.Size(636, 80);
         this.dgvMostrarPedidos.TabIndex = 21;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.dgvMostrarPedidos);
         this.Controls.Add(this.btnMostrarPedidos);
         this.Controls.Add(this.btnModificarPrecio);
         this.Controls.Add(this.txtNuevoPrecio);
         this.Controls.Add(this.lblNuevoPrecio);
         this.Controls.Add(this.BoxSelectProd);
         this.Controls.Add(this.lblSelectProd);
         this.Controls.Add(this.btnAgregarProd);
         this.Controls.Add(this.txtPrecio);
         this.Controls.Add(this.lblPrecio);
         this.Controls.Add(this.txtDescripcionProd);
         this.Controls.Add(this.lblDescripcionProducto);
         this.Controls.Add(this.dgvDetallesPedidos);
         this.Controls.Add(this.btnAltaPedido);
         this.Controls.Add(this.btnAgregarItem);
         this.Controls.Add(this.lblCantidad);
         this.Controls.Add(this.BoxProducto);
         this.Controls.Add(this.txtCantidad);
         this.Controls.Add(this.lblProducto);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtDNI);
         this.Controls.Add(this.lblDNI);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesPedidos)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPedidos)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblDNI;
      private System.Windows.Forms.TextBox txtDNI;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblProducto;
      private System.Windows.Forms.TextBox txtCantidad;
      private System.Windows.Forms.ComboBox BoxProducto;
      private System.Windows.Forms.Label lblCantidad;
      private System.Windows.Forms.Button btnAgregarItem;
      private System.Windows.Forms.Button btnAltaPedido;
      private System.Windows.Forms.DataGridView dgvDetallesPedidos;
      private System.Windows.Forms.Label lblDescripcionProducto;
      private System.Windows.Forms.TextBox txtDescripcionProd;
      private System.Windows.Forms.Label lblPrecio;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.Button btnAgregarProd;
      private System.Windows.Forms.Label lblSelectProd;
      private System.Windows.Forms.ComboBox BoxSelectProd;
      private System.Windows.Forms.Label lblNuevoPrecio;
      private System.Windows.Forms.TextBox txtNuevoPrecio;
      private System.Windows.Forms.Button btnModificarPrecio;
      private System.Windows.Forms.Button btnMostrarPedidos;
      private System.Windows.Forms.DataGridView dgvMostrarPedidos;
   }
}

