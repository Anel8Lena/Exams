
namespace MedyancevaSessia
{
    partial class Form5
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arcticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edIzmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxSkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deyvSkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colvoNaSkladeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowers01DataSet = new MedyancevaSessia.Flowers01DataSet();
            this.flowersTableAdapter = new MedyancevaSessia.Flowers01DataSetTableAdapters.FlowersTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(1049, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.categoryTovDataGridViewTextBoxColumn,
            this.deyvSkidDataGridViewTextBoxColumn,
            this.colvoNaSkladeDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.pictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flowersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 368);
            this.dataGridView1.TabIndex = 14;
            // 
            // arcticleDataGridViewTextBoxColumn
            // 
            this.arcticleDataGridViewTextBoxColumn.DataPropertyName = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.HeaderText = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.Name = "arcticleDataGridViewTextBoxColumn";
            this.arcticleDataGridViewTextBoxColumn.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 80;
            // 
            // edIzmDataGridViewTextBoxColumn
            // 
            this.edIzmDataGridViewTextBoxColumn.DataPropertyName = "Ed_ izm_";
            this.edIzmDataGridViewTextBoxColumn.HeaderText = "Ed_ izm_";
            this.edIzmDataGridViewTextBoxColumn.Name = "edIzmDataGridViewTextBoxColumn";
            this.edIzmDataGridViewTextBoxColumn.Width = 80;
            // 
            // summDataGridViewTextBoxColumn
            // 
            this.summDataGridViewTextBoxColumn.DataPropertyName = "Summ";
            this.summDataGridViewTextBoxColumn.HeaderText = "Summ";
            this.summDataGridViewTextBoxColumn.Name = "summDataGridViewTextBoxColumn";
            this.summDataGridViewTextBoxColumn.Width = 80;
            // 
            // maxSkidDataGridViewTextBoxColumn
            // 
            this.maxSkidDataGridViewTextBoxColumn.DataPropertyName = "Max skid_";
            this.maxSkidDataGridViewTextBoxColumn.HeaderText = "Max skid_";
            this.maxSkidDataGridViewTextBoxColumn.Name = "maxSkidDataGridViewTextBoxColumn";
            this.maxSkidDataGridViewTextBoxColumn.Width = 80;
            // 
            // categoryTovDataGridViewTextBoxColumn
            // 
            this.categoryTovDataGridViewTextBoxColumn.DataPropertyName = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.HeaderText = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.Name = "categoryTovDataGridViewTextBoxColumn";
            this.categoryTovDataGridViewTextBoxColumn.Width = 81;
            // 
            // deyvSkidDataGridViewTextBoxColumn
            // 
            this.deyvSkidDataGridViewTextBoxColumn.DataPropertyName = "Deyv_ skid_";
            this.deyvSkidDataGridViewTextBoxColumn.HeaderText = "Deyv_ skid_";
            this.deyvSkidDataGridViewTextBoxColumn.Name = "deyvSkidDataGridViewTextBoxColumn";
            this.deyvSkidDataGridViewTextBoxColumn.Width = 80;
            // 
            // colvoNaSkladeDataGridViewTextBoxColumn
            // 
            this.colvoNaSkladeDataGridViewTextBoxColumn.DataPropertyName = "Col-vo na sklade";
            this.colvoNaSkladeDataGridViewTextBoxColumn.HeaderText = "Col-vo na sklade";
            this.colvoNaSkladeDataGridViewTextBoxColumn.Name = "colvoNaSkladeDataGridViewTextBoxColumn";
            this.colvoNaSkladeDataGridViewTextBoxColumn.Width = 80;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis_";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis_";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 80;
            // 
            // pictureDataGridViewTextBoxColumn
            // 
            this.pictureDataGridViewTextBoxColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewTextBoxColumn.HeaderText = "Picture";
            this.pictureDataGridViewTextBoxColumn.Name = "pictureDataGridViewTextBoxColumn";
            this.pictureDataGridViewTextBoxColumn.Width = 80;
            // 
            // flowersBindingSource
            // 
            this.flowersBindingSource.DataMember = "Flowers";
            this.flowersBindingSource.DataSource = this.flowers01DataSet;
            // 
            // flowers01DataSet
            // 
            this.flowers01DataSet.DataSetName = "Flowers01DataSet";
            this.flowers01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowersTableAdapter
            // 
            this.flowersTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(459, 31);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Поиск";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.flowersBindingSource, "Opis_", true));
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(862, 70);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 368);
            this.textBox2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(588, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1179, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цветы";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Flowers01DataSet flowers01DataSet;
        private System.Windows.Forms.BindingSource flowersBindingSource;
        private Flowers01DataSetTableAdapters.FlowersTableAdapter flowersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edIzmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxSkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deyvSkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colvoNaSkladeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}