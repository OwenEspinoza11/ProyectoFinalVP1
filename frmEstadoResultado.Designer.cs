namespace ProyectoFinalVP1
{
    partial class frmEstadoResultado
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Utilidad bruta");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Utilidad de operacion");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Utilidad a/impuesto");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Utilidad neta");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Calcular", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoResultado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.dtpF1 = new System.Windows.Forms.DateTimePicker();
            this.dtpF2 = new System.Windows.Forms.DateTimePicker();
            this.mtxtVentasTotales = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCostoDeVentas = new System.Windows.Forms.MaskedTextBox();
            this.txtUtilidadBruta = new System.Windows.Forms.TextBox();
            this.mtxtGastosDeOperacion = new System.Windows.Forms.MaskedTextBox();
            this.txtUtilidadDeOperacion = new System.Windows.Forms.TextBox();
            this.mtxtGastosVenta = new System.Windows.Forms.MaskedTextBox();
            this.txtUtilidadAntesImpuesto = new System.Windows.Forms.TextBox();
            this.txtUtilidadNeta = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas totales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo de ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Utilidad bruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gastos de operacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Utilidad de la operacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gastos de venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Utilidad antes de impuesto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Impuesto a la renta (IR)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Utilidad neta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(316, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Estado de resultado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(255, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Empresa";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(217, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(219, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Estado de resultado del";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(528, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 25);
            this.label13.TabIndex = 12;
            this.label13.Text = "al";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(348, 46);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(237, 23);
            this.txtNombreEmpresa.TabIndex = 13;
            // 
            // dtpF1
            // 
            this.dtpF1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpF1.Location = new System.Drawing.Point(442, 87);
            this.dtpF1.Name = "dtpF1";
            this.dtpF1.Size = new System.Drawing.Size(80, 23);
            this.dtpF1.TabIndex = 14;
            // 
            // dtpF2
            // 
            this.dtpF2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpF2.Location = new System.Drawing.Point(561, 87);
            this.dtpF2.Name = "dtpF2";
            this.dtpF2.Size = new System.Drawing.Size(80, 23);
            this.dtpF2.TabIndex = 15;
            // 
            // mtxtVentasTotales
            // 
            this.mtxtVentasTotales.Location = new System.Drawing.Point(187, 155);
            this.mtxtVentasTotales.Mask = "000000000000";
            this.mtxtVentasTotales.Name = "mtxtVentasTotales";
            this.mtxtVentasTotales.Size = new System.Drawing.Size(100, 23);
            this.mtxtVentasTotales.TabIndex = 16;
            // 
            // mtxtCostoDeVentas
            // 
            this.mtxtCostoDeVentas.Location = new System.Drawing.Point(187, 184);
            this.mtxtCostoDeVentas.Mask = "000000000000";
            this.mtxtCostoDeVentas.Name = "mtxtCostoDeVentas";
            this.mtxtCostoDeVentas.Size = new System.Drawing.Size(100, 23);
            this.mtxtCostoDeVentas.TabIndex = 17;
            // 
            // txtUtilidadBruta
            // 
            this.txtUtilidadBruta.Location = new System.Drawing.Point(187, 213);
            this.txtUtilidadBruta.Name = "txtUtilidadBruta";
            this.txtUtilidadBruta.Size = new System.Drawing.Size(100, 23);
            this.txtUtilidadBruta.TabIndex = 18;
            // 
            // mtxtGastosDeOperacion
            // 
            this.mtxtGastosDeOperacion.Location = new System.Drawing.Point(187, 242);
            this.mtxtGastosDeOperacion.Mask = "000000000000";
            this.mtxtGastosDeOperacion.Name = "mtxtGastosDeOperacion";
            this.mtxtGastosDeOperacion.Size = new System.Drawing.Size(100, 23);
            this.mtxtGastosDeOperacion.TabIndex = 19;
            // 
            // txtUtilidadDeOperacion
            // 
            this.txtUtilidadDeOperacion.Location = new System.Drawing.Point(187, 271);
            this.txtUtilidadDeOperacion.Name = "txtUtilidadDeOperacion";
            this.txtUtilidadDeOperacion.Size = new System.Drawing.Size(100, 23);
            this.txtUtilidadDeOperacion.TabIndex = 20;
            // 
            // mtxtGastosVenta
            // 
            this.mtxtGastosVenta.Location = new System.Drawing.Point(187, 300);
            this.mtxtGastosVenta.Mask = "000000000000";
            this.mtxtGastosVenta.Name = "mtxtGastosVenta";
            this.mtxtGastosVenta.Size = new System.Drawing.Size(100, 23);
            this.mtxtGastosVenta.TabIndex = 21;
            // 
            // txtUtilidadAntesImpuesto
            // 
            this.txtUtilidadAntesImpuesto.Location = new System.Drawing.Point(187, 329);
            this.txtUtilidadAntesImpuesto.Name = "txtUtilidadAntesImpuesto";
            this.txtUtilidadAntesImpuesto.Size = new System.Drawing.Size(100, 23);
            this.txtUtilidadAntesImpuesto.TabIndex = 22;
            // 
            // txtUtilidadNeta
            // 
            this.txtUtilidadNeta.Location = new System.Drawing.Point(187, 387);
            this.txtUtilidadNeta.Name = "txtUtilidadNeta";
            this.txtUtilidadNeta.Size = new System.Drawing.Size(100, 23);
            this.txtUtilidadNeta.TabIndex = 24;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(36, 441);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 25;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(117, 441);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 26;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(198, 441);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridView1.Location = new System.Drawing.Point(316, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(472, 306);
            this.dataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empresa";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha inicial";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha final";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ventas totales";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Costo de ventas";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Utilidad bruta";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Gastos de operacion";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Utilidad de la operacion";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Gastos de venta";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Utilidad a/im";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "IR";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Utilidad neta";
            this.Column12.Name = "Column12";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Utilidad bruta";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Utilidad de operacion";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Utilidad a/impuesto";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Utilidad neta";
            treeNode5.Name = "Calcular";
            treeNode5.Text = "Calcular";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(173, 128);
            this.treeView1.TabIndex = 29;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(187, 358);
            this.txtIR.Name = "txtIR";
            this.txtIR.Size = new System.Drawing.Size(100, 23);
            this.txtIR.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtUtilidadNeta);
            this.Controls.Add(this.txtUtilidadAntesImpuesto);
            this.Controls.Add(this.mtxtGastosVenta);
            this.Controls.Add(this.txtUtilidadDeOperacion);
            this.Controls.Add(this.mtxtGastosDeOperacion);
            this.Controls.Add(this.txtUtilidadBruta);
            this.Controls.Add(this.mtxtCostoDeVentas);
            this.Controls.Add(this.mtxtVentasTotales);
            this.Controls.Add(this.dtpF2);
            this.Controls.Add(this.dtpF1);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEstadoResultado";
            this.Text = "Estado de resultado";
            this.Load += new System.EventHandler(this.frmEstadoResultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtNombreEmpresa;
        private DateTimePicker dtpF1;
        private DateTimePicker dtpF2;
        private MaskedTextBox mtxtVentasTotales;
        private MaskedTextBox mtxtCostoDeVentas;
        private TextBox txtUtilidadBruta;
        private MaskedTextBox mtxtGastosDeOperacion;
        private TextBox txtUtilidadDeOperacion;
        private MaskedTextBox mtxtGastosVenta;
        private TextBox txtUtilidadAntesImpuesto;
        private TextBox txtUtilidadNeta;
        private Button btnCalcular;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridView dataGridView1;
        private TreeView treeView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private TextBox txtIR;
        private PictureBox pictureBox1;
    }
}