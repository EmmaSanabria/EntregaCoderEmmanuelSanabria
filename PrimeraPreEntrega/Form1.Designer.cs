namespace PrimeraPreEntrega
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgUsuarios = new DataGridView();
            dgProductosVendidos = new DataGridView();
            dgVenta = new DataGridView();
            dgProductos = new DataGridView();
            AgregarProducto = new Button();
            ModificarProducto = new Button();
            BorrarProducto = new Button();
            ObtenerProducto = new Button();
            Obtener = new Button();
            BorrarVenta = new Button();
            ModificarVenta = new Button();
            AgregarVenta = new Button();
            ObtenerUsuario = new Button();
            BorrarUsuario = new Button();
            ModificarUsuario = new Button();
            AgregarUsuario = new Button();
            ObtenerProductosVendidos = new Button();
            BorrarProductosVendidos = new Button();
            ModificarProductosVendidos = new Button();
            AgregarProductosVendidos = new Button();
            txtDescripcion = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtIdUsuario = new TextBox();
            txtIdUsuarioVenta = new TextBox();
            txtComentarioVenta = new TextBox();
            txtMailUsuario = new TextBox();
            txtContraseñaUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellidoUsuario = new TextBox();
            txtNombre = new TextBox();
            txtIdVentaProductoVenta = new TextBox();
            txtStockProductoVendido = new TextBox();
            txtIdProductoVenta = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // dgUsuarios
            // 
            dgUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuarios.Location = new Point(67, 492);
            dgUsuarios.Name = "dgUsuarios";
            dgUsuarios.Size = new Size(505, 199);
            dgUsuarios.TabIndex = 0;
            dgUsuarios.CellContentClick += dgUsuario_CellContentClick;
            // 
            // dgProductosVendidos
            // 
            dgProductosVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductosVendidos.Location = new Point(675, 493);
            dgProductosVendidos.Name = "dgProductosVendidos";
            dgProductosVendidos.Size = new Size(505, 198);
            dgProductosVendidos.TabIndex = 1;
            dgProductosVendidos.CellContentClick += dgProductosVendidos_CellContentClick;
            // 
            // dgVenta
            // 
            dgVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVenta.Location = new Point(675, 133);
            dgVenta.Name = "dgVenta";
            dgVenta.Size = new Size(505, 198);
            dgVenta.TabIndex = 2;
            dgVenta.CellContentClick += dgVenta_CellContentClick;
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(67, 132);
            dgProductos.Name = "dgProductos";
            dgProductos.Size = new Size(495, 199);
            dgProductos.TabIndex = 3;
            dgProductos.CellContentClick += dgProducto_CellContentClick;
            // 
            // AgregarProducto
            // 
            AgregarProducto.Location = new Point(67, 103);
            AgregarProducto.Name = "AgregarProducto";
            AgregarProducto.Size = new Size(75, 23);
            AgregarProducto.TabIndex = 4;
            AgregarProducto.Text = "Agregar";
            AgregarProducto.UseVisualStyleBackColor = true;
            AgregarProducto.Click += AgregarProducto_Click_1;
            // 
            // ModificarProducto
            // 
            ModificarProducto.Location = new Point(148, 103);
            ModificarProducto.Name = "ModificarProducto";
            ModificarProducto.Size = new Size(75, 23);
            ModificarProducto.TabIndex = 5;
            ModificarProducto.Text = "Modificar";
            ModificarProducto.UseVisualStyleBackColor = true;
            ModificarProducto.Click += ModificarProducto_Click;
            // 
            // BorrarProducto
            // 
            BorrarProducto.Location = new Point(229, 103);
            BorrarProducto.Name = "BorrarProducto";
            BorrarProducto.Size = new Size(75, 23);
            BorrarProducto.TabIndex = 6;
            BorrarProducto.Text = "Borrar";
            BorrarProducto.UseVisualStyleBackColor = true;
            BorrarProducto.Click += BorrarProducto_Click_1;
            // 
            // ObtenerProducto
            // 
            ObtenerProducto.Location = new Point(310, 103);
            ObtenerProducto.Name = "ObtenerProducto";
            ObtenerProducto.Size = new Size(75, 23);
            ObtenerProducto.TabIndex = 7;
            ObtenerProducto.Text = "Obtener";
            ObtenerProducto.UseVisualStyleBackColor = true;
            ObtenerProducto.Click += ObtenerProducto_Click_1;
            // 
            // Obtener
            // 
            Obtener.Location = new Point(918, 103);
            Obtener.Name = "Obtener";
            Obtener.Size = new Size(75, 23);
            Obtener.TabIndex = 11;
            Obtener.Text = "Obtener";
            Obtener.UseVisualStyleBackColor = true;
            Obtener.Click += ObtenerVenta_Click;
            // 
            // BorrarVenta
            // 
            BorrarVenta.Location = new Point(837, 103);
            BorrarVenta.Name = "BorrarVenta";
            BorrarVenta.Size = new Size(75, 23);
            BorrarVenta.TabIndex = 10;
            BorrarVenta.Text = "Borrar";
            BorrarVenta.UseVisualStyleBackColor = true;
            BorrarVenta.Click += BorrarVenta_Click;
            // 
            // ModificarVenta
            // 
            ModificarVenta.Location = new Point(756, 103);
            ModificarVenta.Name = "ModificarVenta";
            ModificarVenta.Size = new Size(75, 23);
            ModificarVenta.TabIndex = 9;
            ModificarVenta.Text = "Modificar";
            ModificarVenta.UseVisualStyleBackColor = true;
            ModificarVenta.Click += ModificarVenta_Click;
            // 
            // AgregarVenta
            // 
            AgregarVenta.Location = new Point(675, 103);
            AgregarVenta.Name = "AgregarVenta";
            AgregarVenta.Size = new Size(75, 23);
            AgregarVenta.TabIndex = 8;
            AgregarVenta.Text = "Agregar";
            AgregarVenta.UseVisualStyleBackColor = true;
            AgregarVenta.Click += AgregarVenta_Click_1;
            // 
            // ObtenerUsuario
            // 
            ObtenerUsuario.Location = new Point(310, 449);
            ObtenerUsuario.Name = "ObtenerUsuario";
            ObtenerUsuario.Size = new Size(75, 23);
            ObtenerUsuario.TabIndex = 15;
            ObtenerUsuario.Text = "Obtener";
            ObtenerUsuario.UseVisualStyleBackColor = true;
            ObtenerUsuario.Click += ObtenerUsuario_Click;
            // 
            // BorrarUsuario
            // 
            BorrarUsuario.Location = new Point(229, 449);
            BorrarUsuario.Name = "BorrarUsuario";
            BorrarUsuario.Size = new Size(75, 23);
            BorrarUsuario.TabIndex = 14;
            BorrarUsuario.Text = "Borrar";
            BorrarUsuario.UseVisualStyleBackColor = true;
            BorrarUsuario.Click += BorrarUsuario_Click;
            // 
            // ModificarUsuario
            // 
            ModificarUsuario.Location = new Point(148, 449);
            ModificarUsuario.Name = "ModificarUsuario";
            ModificarUsuario.Size = new Size(75, 23);
            ModificarUsuario.TabIndex = 13;
            ModificarUsuario.Text = "Modificar";
            ModificarUsuario.UseVisualStyleBackColor = true;
            ModificarUsuario.Click += ModificarUsuario_Click;
            // 
            // AgregarUsuario
            // 
            AgregarUsuario.Location = new Point(67, 449);
            AgregarUsuario.Name = "AgregarUsuario";
            AgregarUsuario.Size = new Size(75, 23);
            AgregarUsuario.TabIndex = 12;
            AgregarUsuario.Text = "Agregar";
            AgregarUsuario.UseVisualStyleBackColor = true;
            AgregarUsuario.Click += AgregarUsuario_Click;
            // 
            // ObtenerProductosVendidos
            // 
            ObtenerProductosVendidos.Location = new Point(921, 449);
            ObtenerProductosVendidos.Name = "ObtenerProductosVendidos";
            ObtenerProductosVendidos.Size = new Size(75, 23);
            ObtenerProductosVendidos.TabIndex = 19;
            ObtenerProductosVendidos.Text = "Obtener";
            ObtenerProductosVendidos.UseVisualStyleBackColor = true;
            ObtenerProductosVendidos.Click += ObtenerProductosVendidos_Click;
            // 
            // BorrarProductosVendidos
            // 
            BorrarProductosVendidos.Location = new Point(840, 449);
            BorrarProductosVendidos.Name = "BorrarProductosVendidos";
            BorrarProductosVendidos.Size = new Size(75, 23);
            BorrarProductosVendidos.TabIndex = 18;
            BorrarProductosVendidos.Text = "Borrar";
            BorrarProductosVendidos.UseVisualStyleBackColor = true;
            BorrarProductosVendidos.Click += BorrarProductosVendidos_Click;
            // 
            // ModificarProductosVendidos
            // 
            ModificarProductosVendidos.Location = new Point(759, 449);
            ModificarProductosVendidos.Name = "ModificarProductosVendidos";
            ModificarProductosVendidos.Size = new Size(75, 23);
            ModificarProductosVendidos.TabIndex = 17;
            ModificarProductosVendidos.Text = "Modificar";
            ModificarProductosVendidos.UseVisualStyleBackColor = true;
            ModificarProductosVendidos.Click += ModificarProductosVendidos_Click;
            // 
            // AgregarProductosVendidos
            // 
            AgregarProductosVendidos.Location = new Point(678, 449);
            AgregarProductosVendidos.Name = "AgregarProductosVendidos";
            AgregarProductosVendidos.Size = new Size(75, 23);
            AgregarProductosVendidos.TabIndex = 16;
            AgregarProductosVendidos.Text = "Agregar";
            AgregarProductosVendidos.UseVisualStyleBackColor = true;
            AgregarProductosVendidos.Click += AgregarProductosVendidos_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(64, 62);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 20;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(170, 62);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 21;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(277, 62);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 22;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(383, 62);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 23;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(489, 62);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(100, 23);
            txtIdUsuario.TabIndex = 24;
            // 
            // txtIdUsuarioVenta
            // 
            txtIdUsuarioVenta.Location = new Point(781, 62);
            txtIdUsuarioVenta.Name = "txtIdUsuarioVenta";
            txtIdUsuarioVenta.Size = new Size(100, 23);
            txtIdUsuarioVenta.TabIndex = 26;
            // 
            // txtComentarioVenta
            // 
            txtComentarioVenta.Location = new Point(675, 62);
            txtComentarioVenta.Name = "txtComentarioVenta";
            txtComentarioVenta.Size = new Size(100, 23);
            txtComentarioVenta.TabIndex = 25;
            // 
            // txtMailUsuario
            // 
            txtMailUsuario.Location = new Point(489, 411);
            txtMailUsuario.Name = "txtMailUsuario";
            txtMailUsuario.Size = new Size(100, 23);
            txtMailUsuario.TabIndex = 31;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Location = new Point(383, 411);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.Size = new Size(100, 23);
            txtContraseñaUsuario.TabIndex = 30;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(277, 411);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(100, 23);
            txtNombreUsuario.TabIndex = 29;
            // 
            // txtApellidoUsuario
            // 
            txtApellidoUsuario.Location = new Point(170, 411);
            txtApellidoUsuario.Name = "txtApellidoUsuario";
            txtApellidoUsuario.Size = new Size(100, 23);
            txtApellidoUsuario.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(64, 411);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 27;
            // 
            // txtIdVentaProductoVenta
            // 
            txtIdVentaProductoVenta.Location = new Point(888, 411);
            txtIdVentaProductoVenta.Name = "txtIdVentaProductoVenta";
            txtIdVentaProductoVenta.Size = new Size(100, 23);
            txtIdVentaProductoVenta.TabIndex = 34;
            // 
            // txtStockProductoVendido
            // 
            txtStockProductoVendido.Location = new Point(781, 411);
            txtStockProductoVendido.Name = "txtStockProductoVendido";
            txtStockProductoVendido.Size = new Size(100, 23);
            txtStockProductoVendido.TabIndex = 33;
            // 
            // txtIdProductoVenta
            // 
            txtIdProductoVenta.Location = new Point(675, 411);
            txtIdProductoVenta.Name = "txtIdProductoVenta";
            txtIdProductoVenta.Size = new Size(100, 23);
            txtIdProductoVenta.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 816);
            Controls.Add(txtIdVentaProductoVenta);
            Controls.Add(txtStockProductoVendido);
            Controls.Add(txtIdProductoVenta);
            Controls.Add(txtMailUsuario);
            Controls.Add(txtContraseñaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellidoUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtIdUsuarioVenta);
            Controls.Add(txtComentarioVenta);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(ObtenerProductosVendidos);
            Controls.Add(BorrarProductosVendidos);
            Controls.Add(ModificarProductosVendidos);
            Controls.Add(AgregarProductosVendidos);
            Controls.Add(ObtenerUsuario);
            Controls.Add(BorrarUsuario);
            Controls.Add(ModificarUsuario);
            Controls.Add(AgregarUsuario);
            Controls.Add(Obtener);
            Controls.Add(BorrarVenta);
            Controls.Add(ModificarVenta);
            Controls.Add(AgregarVenta);
            Controls.Add(ObtenerProducto);
            Controls.Add(BorrarProducto);
            Controls.Add(ModificarProducto);
            Controls.Add(AgregarProducto);
            Controls.Add(dgProductos);
            Controls.Add(dgVenta);
            Controls.Add(dgProductosVendidos);
            Controls.Add(dgUsuarios);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductosVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsuarios;
        private DataGridView dgProductosVendidos;
        private DataGridView dgVenta;
        private DataGridView dgProductos;
        private Button AgregarProducto;
        private Button ModificarProducto;
        private Button BorrarProducto;
        private Button ObtenerProducto;
        private Button Obtener;
        private Button BorrarVenta;
        private Button ModificarVenta;
        private Button AgregarVenta;
        private Button ObtenerUsuario;
        private Button BorrarUsuario;
        private Button ModificarUsuario;
        private Button AgregarUsuario;
        private Button ObtenerProductosVendidos;
        private Button BorrarProductosVendidos;
        private Button ModificarProductosVendidos;
        private Button AgregarProductosVendidos;
        private TextBox txtDescripcion;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtIdUsuario;
        private TextBox txtIdUsuarioVenta;
        private TextBox txtComentarioVenta;
        private TextBox txtMailUsuario;
        private TextBox txtContraseñaUsuario;
        private TextBox txtNombreUsuario;
        private TextBox txtApellidoUsuario;
        private TextBox txtNombre;
        private TextBox txtIdVentaProductoVenta;
        private TextBox txtStockProductoVendido;
        private TextBox txtIdProductoVenta;
    }
}
