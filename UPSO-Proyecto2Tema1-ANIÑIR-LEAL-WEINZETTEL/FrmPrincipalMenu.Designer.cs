namespace UPSO_Proyecto2Tema1_ANIÑIR_LEAL_WEINZETTEL
{
    partial class FrmPrincipalMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEscaneo = new System.Windows.Forms.Button();
            this.btnMostrarTodosAutos = new System.Windows.Forms.Button();
            this.btnCargaBateria = new System.Windows.Forms.Button();
            this.btnMostarTeslaMasAntiguo = new System.Windows.Forms.Button();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnAltasAuto = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEscaneoNave = new System.Windows.Forms.Button();
            this.btnMostarTodasNaves = new System.Windows.Forms.Button();
            this.BtnCargaCombustibleNave = new System.Windows.Forms.Button();
            this.btnMostarnaveMasNueva = new System.Windows.Forms.Button();
            this.btnEliminarNave = new System.Windows.Forms.Button();
            this.btnAltaNave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1146, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1098, 236);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEscaneo);
            this.groupBox1.Controls.Add(this.btnMostrarTodosAutos);
            this.groupBox1.Controls.Add(this.btnCargaBateria);
            this.groupBox1.Controls.Add(this.btnMostarTeslaMasAntiguo);
            this.groupBox1.Controls.Add(this.btnEliminarAuto);
            this.groupBox1.Controls.Add(this.btnAltasAuto);
            this.groupBox1.Location = new System.Drawing.Point(40, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1042, 94);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnEscaneo
            // 
            this.btnEscaneo.Location = new System.Drawing.Point(716, 20);
            this.btnEscaneo.Name = "btnEscaneo";
            this.btnEscaneo.Size = new System.Drawing.Size(139, 59);
            this.btnEscaneo.TabIndex = 5;
            this.btnEscaneo.Text = "Escaneo Vehicular";
            this.btnEscaneo.UseVisualStyleBackColor = true;
            this.btnEscaneo.Click += new System.EventHandler(this.btnEscaneo_Click);
            // 
            // btnMostrarTodosAutos
            // 
            this.btnMostrarTodosAutos.Location = new System.Drawing.Point(877, 20);
            this.btnMostrarTodosAutos.Name = "btnMostrarTodosAutos";
            this.btnMostrarTodosAutos.Size = new System.Drawing.Size(139, 59);
            this.btnMostrarTodosAutos.TabIndex = 4;
            this.btnMostrarTodosAutos.Text = "Mostar Todos los Autos";
            this.btnMostrarTodosAutos.UseVisualStyleBackColor = true;
            this.btnMostrarTodosAutos.Click += new System.EventHandler(this.btnMostrarTodosAutos_Click);
            // 
            // btnCargaBateria
            // 
            this.btnCargaBateria.Location = new System.Drawing.Point(546, 20);
            this.btnCargaBateria.Name = "btnCargaBateria";
            this.btnCargaBateria.Size = new System.Drawing.Size(139, 59);
            this.btnCargaBateria.TabIndex = 3;
            this.btnCargaBateria.Text = "Carga de Bateria";
            this.btnCargaBateria.UseVisualStyleBackColor = true;
            this.btnCargaBateria.Click += new System.EventHandler(this.btnCargaBateria_Click);
            // 
            // btnMostarTeslaMasAntiguo
            // 
            this.btnMostarTeslaMasAntiguo.Location = new System.Drawing.Point(378, 20);
            this.btnMostarTeslaMasAntiguo.Name = "btnMostarTeslaMasAntiguo";
            this.btnMostarTeslaMasAntiguo.Size = new System.Drawing.Size(139, 59);
            this.btnMostarTeslaMasAntiguo.TabIndex = 2;
            this.btnMostarTeslaMasAntiguo.Text = "Mostar Mas Antiguo";
            this.btnMostarTeslaMasAntiguo.UseVisualStyleBackColor = true;
            this.btnMostarTeslaMasAntiguo.Click += new System.EventHandler(this.btnMostarCarga_Click);
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Location = new System.Drawing.Point(212, 20);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(139, 59);
            this.btnEliminarAuto.TabIndex = 1;
            this.btnEliminarAuto.Text = "Eliminar Auto";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            this.btnEliminarAuto.Click += new System.EventHandler(this.btnEliminarAuto_Click);
            // 
            // btnAltasAuto
            // 
            this.btnAltasAuto.Location = new System.Drawing.Point(41, 20);
            this.btnAltasAuto.Name = "btnAltasAuto";
            this.btnAltasAuto.Size = new System.Drawing.Size(139, 59);
            this.btnAltasAuto.TabIndex = 0;
            this.btnAltasAuto.Text = "Alta Nuevo Auto";
            this.btnAltasAuto.UseVisualStyleBackColor = true;
            this.btnAltasAuto.Click += new System.EventHandler(this.btnAltasAuto_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEscaneoNave);
            this.groupBox2.Controls.Add(this.btnMostarTodasNaves);
            this.groupBox2.Controls.Add(this.BtnCargaCombustibleNave);
            this.groupBox2.Controls.Add(this.btnMostarnaveMasNueva);
            this.groupBox2.Controls.Add(this.btnEliminarNave);
            this.groupBox2.Controls.Add(this.btnAltaNave);
            this.groupBox2.Location = new System.Drawing.Point(40, 721);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 94);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnEscaneoNave
            // 
            this.btnEscaneoNave.Location = new System.Drawing.Point(716, 20);
            this.btnEscaneoNave.Name = "btnEscaneoNave";
            this.btnEscaneoNave.Size = new System.Drawing.Size(139, 59);
            this.btnEscaneoNave.TabIndex = 6;
            this.btnEscaneoNave.Text = "Escaneo Nave";
            this.btnEscaneoNave.UseVisualStyleBackColor = true;
            this.btnEscaneoNave.Click += new System.EventHandler(this.btnEscaneoNave_Click);
            // 
            // btnMostarTodasNaves
            // 
            this.btnMostarTodasNaves.Location = new System.Drawing.Point(877, 20);
            this.btnMostarTodasNaves.Name = "btnMostarTodasNaves";
            this.btnMostarTodasNaves.Size = new System.Drawing.Size(139, 59);
            this.btnMostarTodasNaves.TabIndex = 5;
            this.btnMostarTodasNaves.Text = "Mostar Todas las Naves";
            this.btnMostarTodasNaves.UseVisualStyleBackColor = true;
            this.btnMostarTodasNaves.Click += new System.EventHandler(this.btnMostarTodasNaves_Click);
            // 
            // BtnCargaCombustibleNave
            // 
            this.BtnCargaCombustibleNave.Location = new System.Drawing.Point(546, 20);
            this.BtnCargaCombustibleNave.Name = "BtnCargaCombustibleNave";
            this.BtnCargaCombustibleNave.Size = new System.Drawing.Size(139, 59);
            this.BtnCargaCombustibleNave.TabIndex = 3;
            this.BtnCargaCombustibleNave.TabStop = false;
            this.BtnCargaCombustibleNave.Text = "Carga de Combustible";
            this.BtnCargaCombustibleNave.UseVisualStyleBackColor = true;
            this.BtnCargaCombustibleNave.Click += new System.EventHandler(this.BtnCargaCombustibleNave_Click);
            // 
            // btnMostarnaveMasNueva
            // 
            this.btnMostarnaveMasNueva.Location = new System.Drawing.Point(378, 20);
            this.btnMostarnaveMasNueva.Name = "btnMostarnaveMasNueva";
            this.btnMostarnaveMasNueva.Size = new System.Drawing.Size(139, 59);
            this.btnMostarnaveMasNueva.TabIndex = 2;
            this.btnMostarnaveMasNueva.Text = "Mostar Nave Mas Nueva";
            this.btnMostarnaveMasNueva.UseVisualStyleBackColor = true;
            this.btnMostarnaveMasNueva.Click += new System.EventHandler(this.btnMostarnaveMasNueva_Click);
            // 
            // btnEliminarNave
            // 
            this.btnEliminarNave.Location = new System.Drawing.Point(212, 20);
            this.btnEliminarNave.Name = "btnEliminarNave";
            this.btnEliminarNave.Size = new System.Drawing.Size(139, 59);
            this.btnEliminarNave.TabIndex = 1;
            this.btnEliminarNave.Text = "Eliminar Nave";
            this.btnEliminarNave.UseVisualStyleBackColor = true;
            this.btnEliminarNave.Click += new System.EventHandler(this.btnEliminarNave_Click);
            // 
            // btnAltaNave
            // 
            this.btnAltaNave.Location = new System.Drawing.Point(41, 20);
            this.btnAltaNave.Name = "btnAltaNave";
            this.btnAltaNave.Size = new System.Drawing.Size(139, 59);
            this.btnAltaNave.TabIndex = 0;
            this.btnAltaNave.Text = "Alta Nuevo Nave";
            this.btnAltaNave.UseVisualStyleBackColor = true;
            this.btnAltaNave.Click += new System.EventHandler(this.btnAltaNave_Click);
            // 
            // FrmPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 835);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipalMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Button btnCargaBateria;
        private Button btnMostarTeslaMasAntiguo;
        private Button btnEliminarAuto;
        private Button btnAltasAuto;
        private GroupBox groupBox2;
        private Button BtnCargaCombustibleNave;
        private Button btnMostarnaveMasNueva;
        private Button btnEliminarNave;
        private Button btnAltaNave;
        private Button btnMostrarTodosAutos;
        private Button btnMostarTodasNaves;
        private Button btnEscaneo;
        private Button btnEscaneoNave;
    }
}