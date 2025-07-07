namespace Hidrobo_T1S6.Views.Administración
{
    partial class FRM_Inicio
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
            lbl_Inventario = new Label();
            lbl_NombreP = new Label();
            lbl_Lote = new Label();
            lbl_Ingreso = new Label();
            lbl_FechaCaducidad = new Label();
            lbl_Proveedor = new Label();
            lbl_Stock = new Label();
            lbl_PrecioUnitario = new Label();
            txt_NombreProducto = new TextBox();
            txt_Lote = new TextBox();
            txt_Proveedor = new TextBox();
            txt_Stock = new TextBox();
            txt_PrecioUnitario = new TextBox();
            lst_Datos = new ListBox();
            btn_Guardar = new Button();
            time_Ingreso = new DateTimePicker();
            time_Caducidad = new DateTimePicker();
            btn_Editor = new Button();
            btn_Cancelar = new Button();
            btn_Eliminar = new Button();
            btn_Salir = new Button();
            SuspendLayout();
            // 
            // lbl_Inventario
            // 
            lbl_Inventario.AutoSize = true;
            lbl_Inventario.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Inventario.Location = new Point(297, 9);
            lbl_Inventario.Name = "lbl_Inventario";
            lbl_Inventario.Size = new Size(218, 24);
            lbl_Inventario.TabIndex = 0;
            lbl_Inventario.Text = "Inventario Tienda Pet's";
            // 
            // lbl_NombreP
            // 
            lbl_NombreP.AutoSize = true;
            lbl_NombreP.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_NombreP.Location = new Point(30, 71);
            lbl_NombreP.Name = "lbl_NombreP";
            lbl_NombreP.Size = new Size(127, 19);
            lbl_NombreP.TabIndex = 1;
            lbl_NombreP.Text = "Nombre Producto";
            // 
            // lbl_Lote
            // 
            lbl_Lote.AutoSize = true;
            lbl_Lote.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Lote.Location = new Point(30, 119);
            lbl_Lote.Name = "lbl_Lote";
            lbl_Lote.Size = new Size(39, 19);
            lbl_Lote.TabIndex = 2;
            lbl_Lote.Text = "Lote";
            // 
            // lbl_Ingreso
            // 
            lbl_Ingreso.AutoSize = true;
            lbl_Ingreso.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Ingreso.Location = new Point(30, 182);
            lbl_Ingreso.Name = "lbl_Ingreso";
            lbl_Ingreso.Size = new Size(59, 19);
            lbl_Ingreso.TabIndex = 3;
            lbl_Ingreso.Text = "Ingreso";
            // 
            // lbl_FechaCaducidad
            // 
            lbl_FechaCaducidad.AutoSize = true;
            lbl_FechaCaducidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_FechaCaducidad.Location = new Point(30, 241);
            lbl_FechaCaducidad.Name = "lbl_FechaCaducidad";
            lbl_FechaCaducidad.Size = new Size(127, 19);
            lbl_FechaCaducidad.TabIndex = 4;
            lbl_FechaCaducidad.Text = "Fecha Caducidad";
            // 
            // lbl_Proveedor
            // 
            lbl_Proveedor.AutoSize = true;
            lbl_Proveedor.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Proveedor.Location = new Point(30, 302);
            lbl_Proveedor.Name = "lbl_Proveedor";
            lbl_Proveedor.Size = new Size(133, 19);
            lbl_Proveedor.TabIndex = 5;
            lbl_Proveedor.Text = "Nombre Proveedor";
            // 
            // lbl_Stock
            // 
            lbl_Stock.AutoSize = true;
            lbl_Stock.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_Stock.Location = new Point(30, 364);
            lbl_Stock.Name = "lbl_Stock";
            lbl_Stock.Size = new Size(131, 19);
            lbl_Stock.TabIndex = 6;
            lbl_Stock.Text = "Producto en Stock";
            // 
            // lbl_PrecioUnitario
            // 
            lbl_PrecioUnitario.AutoSize = true;
            lbl_PrecioUnitario.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic);
            lbl_PrecioUnitario.Location = new Point(29, 422);
            lbl_PrecioUnitario.Name = "lbl_PrecioUnitario";
            lbl_PrecioUnitario.Size = new Size(132, 19);
            lbl_PrecioUnitario.TabIndex = 7;
            lbl_PrecioUnitario.Text = "Precio por Unidad";
            // 
            // txt_NombreProducto
            // 
            txt_NombreProducto.Font = new Font("Times New Roman", 12F);
            txt_NombreProducto.Location = new Point(30, 93);
            txt_NombreProducto.Name = "txt_NombreProducto";
            txt_NombreProducto.Size = new Size(174, 26);
            txt_NombreProducto.TabIndex = 8;
            // 
            // txt_Lote
            // 
            txt_Lote.Font = new Font("Times New Roman", 12F);
            txt_Lote.Location = new Point(30, 146);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new Size(174, 26);
            txt_Lote.TabIndex = 9;
            // 
            // txt_Proveedor
            // 
            txt_Proveedor.Font = new Font("Times New Roman", 12F);
            txt_Proveedor.Location = new Point(30, 324);
            txt_Proveedor.Name = "txt_Proveedor";
            txt_Proveedor.Size = new Size(174, 26);
            txt_Proveedor.TabIndex = 12;
            // 
            // txt_Stock
            // 
            txt_Stock.Font = new Font("Times New Roman", 12F);
            txt_Stock.Location = new Point(30, 386);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(174, 26);
            txt_Stock.TabIndex = 13;
            // 
            // txt_PrecioUnitario
            // 
            txt_PrecioUnitario.Font = new Font("Times New Roman", 12F);
            txt_PrecioUnitario.Location = new Point(30, 444);
            txt_PrecioUnitario.Name = "txt_PrecioUnitario";
            txt_PrecioUnitario.Size = new Size(174, 26);
            txt_PrecioUnitario.TabIndex = 14;
            // 
            // lst_Datos
            // 
            lst_Datos.FormattingEnabled = true;
            lst_Datos.ItemHeight = 15;
            lst_Datos.Location = new Point(237, 71);
            lst_Datos.Name = "lst_Datos";
            lst_Datos.Size = new Size(415, 394);
            lst_Datos.TabIndex = 15;
            lst_Datos.SelectedIndexChanged += lst_Datos_SelectedIndexChanged;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = Color.FromArgb(255, 128, 255);
            btn_Guardar.FlatStyle = FlatStyle.Flat;
            btn_Guardar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Guardar.Location = new Point(682, 84);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(99, 35);
            btn_Guardar.TabIndex = 16;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // time_Ingreso
            // 
            time_Ingreso.Location = new Point(30, 204);
            time_Ingreso.Name = "time_Ingreso";
            time_Ingreso.Size = new Size(174, 23);
            time_Ingreso.TabIndex = 17;
            // 
            // time_Caducidad
            // 
            time_Caducidad.Location = new Point(30, 263);
            time_Caducidad.Name = "time_Caducidad";
            time_Caducidad.Size = new Size(174, 23);
            time_Caducidad.TabIndex = 18;
            // 
            // btn_Editor
            // 
            btn_Editor.BackColor = Color.FromArgb(255, 128, 255);
            btn_Editor.FlatStyle = FlatStyle.Flat;
            btn_Editor.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Editor.Location = new Point(682, 179);
            btn_Editor.Name = "btn_Editor";
            btn_Editor.Size = new Size(99, 35);
            btn_Editor.TabIndex = 19;
            btn_Editor.Text = "Editar";
            btn_Editor.UseVisualStyleBackColor = false;
            btn_Editor.Click += btn_Editor_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(255, 128, 255);
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Cancelar.Location = new Point(682, 286);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(99, 35);
            btn_Cancelar.TabIndex = 20;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(255, 128, 255);
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Eliminar.Location = new Point(333, 491);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(170, 46);
            btn_Eliminar.TabIndex = 21;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.FromArgb(255, 128, 255);
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btn_Salir.Location = new Point(682, 406);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(99, 35);
            btn_Salir.TabIndex = 22;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // FRM_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(806, 549);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Eliminar);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Editor);
            Controls.Add(time_Caducidad);
            Controls.Add(time_Ingreso);
            Controls.Add(btn_Guardar);
            Controls.Add(lst_Datos);
            Controls.Add(txt_PrecioUnitario);
            Controls.Add(txt_Stock);
            Controls.Add(txt_Proveedor);
            Controls.Add(txt_Lote);
            Controls.Add(txt_NombreProducto);
            Controls.Add(lbl_PrecioUnitario);
            Controls.Add(lbl_Stock);
            Controls.Add(lbl_Proveedor);
            Controls.Add(lbl_FechaCaducidad);
            Controls.Add(lbl_Ingreso);
            Controls.Add(lbl_Lote);
            Controls.Add(lbl_NombreP);
            Controls.Add(lbl_Inventario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FRM_Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_Inicio";
            Load += FRM_Inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Inventario;
        private Label lbl_NombreP;
        private Label lbl_Lote;
        private Label lbl_Ingreso;
        private Label lbl_FechaCaducidad;
        private Label lbl_Proveedor;
        private Label lbl_Stock;
        private Label lbl_PrecioUnitario;
        private TextBox txt_NombreProducto;
        private TextBox txt_Lote;
        private TextBox txt_Proveedor;
        private TextBox txt_Stock;
        private TextBox txt_PrecioUnitario;
        private ListBox lst_Datos;
        private Button btn_Guardar;
        private DateTimePicker time_Ingreso;
        private DateTimePicker time_Caducidad;
        private Button btn_Editor;
        private Button btn_Cancelar;
        private Button btn_Eliminar;
        private Button btn_Salir;
    }
}