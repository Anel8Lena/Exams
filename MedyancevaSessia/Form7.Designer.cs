
namespace MedyancevaSessia
{
    partial class Form7
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.flowers01DataSet = new MedyancevaSessia.Flowers01DataSet();
            this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovarTableAdapter = new MedyancevaSessia.Flowers01DataSetTableAdapters.TovarTableAdapter();
            this.arcticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edIzmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deyvSkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvoNaSkladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tovarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(588, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tovarBindingSource1, "Opis_", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1061, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 368);
            this.textBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 31);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.arcticleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.edIzmDataGridViewTextBoxColumn,
            this.summDataGridViewTextBoxColumn,
            this.maxSkidDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.categoryTovDataGridViewTextBoxColumn,
            this.deyvSkidDataGridViewTextBoxColumn,
            this.colvoNaSkladeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tovarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1043, 368);
            this.dataGridView1.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(1137, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // flowers01DataSet
            // 
            this.flowers01DataSet.DataSetName = "Flowers01DataSet";
            this.flowers01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tovarBindingSource
            // 
            this.tovarBindingSource.DataMember = "Tovar";
            this.tovarBindingSource.DataSource = this.flowers01DataSet;
            // 
            // tovarTableAdapter
            // 
            this.tovarTableAdapter.ClearBeforeFill = true;
            // 
            // arcticleDataGridViewTextBoxColumn
            // 
            this.arcticleDataGridViewTextBoxColumn.DataPropertyName = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.HeaderText = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.Name = "arcticleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // edIzmDataGridViewTextBoxColumn
            // 
            this.edIzmDataGridViewTextBoxColumn.DataPropertyName = "Ed_ izm_";
            this.edIzmDataGridViewTextBoxColumn.HeaderText = "Ed_ izm_";
            this.edIzmDataGridViewTextBoxColumn.Name = "edIzmDataGridViewTextBoxColumn";
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "Summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Summ";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            // 
            // maxSkidDataGridViewTextBoxColumn
            // 
            this.maxSkidDataGridViewTextBoxColumn.DataPropertyName = "Max skid_";
            this.maxSkidDataGridViewTextBoxColumn.HeaderText = "Max skid_";
            this.maxSkidDataGridViewTextBoxColumn.Name = "maxSkidDataGridViewTextBoxColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            // 
            // categoryTovDataGridViewTextBoxColumn
            // 
            this.categoryTovDataGridViewTextBoxColumn.DataPropertyName = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.HeaderText = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.Name = "categoryTovDataGridViewTextBoxColumn";
            // 
            // deyvSkidDataGridViewTextBoxColumn
            // 
            this.deyvSkidDataGridViewTextBoxColumn.DataPropertyName = "Deyv_ skid_";
            this.deyvSkidDataGridViewTextBoxColumn.HeaderText = "Deyv_ skid_";
            this.deyvSkidDataGridViewTextBoxColumn.Name = "deyvSkidDataGridViewTextBoxColumn";
            // 
            // colvoNaSkladeDataGridViewTextBoxColumn
            // 
            this.colvoNaSkladeDataGridViewTextBoxColumn.DataPropertyName = "Col-vo na sklade";
            this.colvoNaSkladeDataGridViewTextBoxColumn.HeaderText = "Col-vo na sklade";
            this.colvoNaSkladeDataGridViewTextBoxColumn.Name = "colvoNaSkladeDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis_";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis_";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            // 
            // tovarBindingSource1
            // 
            this.tovarBindingSource1.DataMember = "Tovar";
            this.tovarBindingSource1.DataSource = this.flowers01DataSet;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1278, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары и поставщики";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Flowers01DataSet flowers01DataSet;
        private System.Windows.Forms.BindingSource tovarBindingSource;
        private Flowers01DataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edIzmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deyvSkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvoNaSkladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tovarBindingSource1;
    }
}