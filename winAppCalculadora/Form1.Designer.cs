namespace winAppCalculadora
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculadora4DataSet = new winAppCalculadora.calculadora4DataSet();
            this.resultadoOperacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultadoOperacionTableAdapter = new winAppCalculadora.calculadora4DataSetTableAdapters.resultadoOperacionTableAdapter();
            this.idoperacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dato2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadora4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoOperacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nueva operación";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Actualizar datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Modificar operación";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 320);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Abrir página";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idoperacionDataGridViewTextBoxColumn,
            this.dato1DataGridViewTextBoxColumn,
            this.dato2DataGridViewTextBoxColumn,
            this.operacionDataGridViewTextBoxColumn,
            this.resultadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultadoOperacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(240, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 276);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // calculadora4DataSet
            // 
            this.calculadora4DataSet.DataSetName = "calculadora4DataSet";
            this.calculadora4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultadoOperacionBindingSource
            // 
            this.resultadoOperacionBindingSource.DataMember = "resultadoOperacion";
            this.resultadoOperacionBindingSource.DataSource = this.calculadora4DataSet;
            // 
            // resultadoOperacionTableAdapter
            // 
            this.resultadoOperacionTableAdapter.ClearBeforeFill = true;
            // 
            // idoperacionDataGridViewTextBoxColumn
            // 
            this.idoperacionDataGridViewTextBoxColumn.DataPropertyName = "id_operacion";
            this.idoperacionDataGridViewTextBoxColumn.HeaderText = "id";
            this.idoperacionDataGridViewTextBoxColumn.Name = "idoperacionDataGridViewTextBoxColumn";
            this.idoperacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dato1DataGridViewTextBoxColumn
            // 
            this.dato1DataGridViewTextBoxColumn.DataPropertyName = "dato1";
            this.dato1DataGridViewTextBoxColumn.HeaderText = "dato 1";
            this.dato1DataGridViewTextBoxColumn.Name = "dato1DataGridViewTextBoxColumn";
            // 
            // dato2DataGridViewTextBoxColumn
            // 
            this.dato2DataGridViewTextBoxColumn.DataPropertyName = "dato2";
            this.dato2DataGridViewTextBoxColumn.HeaderText = "dato 2";
            this.dato2DataGridViewTextBoxColumn.Name = "dato2DataGridViewTextBoxColumn";
            // 
            // operacionDataGridViewTextBoxColumn
            // 
            this.operacionDataGridViewTextBoxColumn.DataPropertyName = "operacion";
            this.operacionDataGridViewTextBoxColumn.HeaderText = "operación";
            this.operacionDataGridViewTextBoxColumn.Name = "operacionDataGridViewTextBoxColumn";
            // 
            // resultadoDataGridViewTextBoxColumn
            // 
            this.resultadoDataGridViewTextBoxColumn.DataPropertyName = "resultado";
            this.resultadoDataGridViewTextBoxColumn.HeaderText = "resultado";
            this.resultadoDataGridViewTextBoxColumn.Name = "resultadoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculadora4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoOperacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private calculadora4DataSet calculadora4DataSet;
        private System.Windows.Forms.BindingSource resultadoOperacionBindingSource;
        private calculadora4DataSetTableAdapters.resultadoOperacionTableAdapter resultadoOperacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idoperacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dato2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultadoDataGridViewTextBoxColumn;
    }
}

