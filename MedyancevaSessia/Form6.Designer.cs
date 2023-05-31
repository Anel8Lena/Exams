
namespace MedyancevaSessia
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.arcticleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowers01DataSet = new MedyancevaSessia.Flowers01DataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.postavTableAdapter = new MedyancevaSessia.Flowers01DataSetTableAdapters.PostavTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(588, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 17);
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
            this.proizvDataGridViewTextBoxColumn,
            this.postavDataGridViewTextBoxColumn,
            this.categoryTovDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.postavBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 368);
            this.dataGridView1.TabIndex = 20;
            // 
            // arcticleDataGridViewTextBoxColumn
            // 
            this.arcticleDataGridViewTextBoxColumn.DataPropertyName = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.HeaderText = "Arcticle";
            this.arcticleDataGridViewTextBoxColumn.Name = "arcticleDataGridViewTextBoxColumn";
            // 
            // proizvDataGridViewTextBoxColumn
            // 
            this.proizvDataGridViewTextBoxColumn.DataPropertyName = "Proizv_";
            this.proizvDataGridViewTextBoxColumn.HeaderText = "Proizv_";
            this.proizvDataGridViewTextBoxColumn.Name = "proizvDataGridViewTextBoxColumn";
            // 
            // postavDataGridViewTextBoxColumn
            // 
            this.postavDataGridViewTextBoxColumn.DataPropertyName = "Postav_";
            this.postavDataGridViewTextBoxColumn.HeaderText = "Postav_";
            this.postavDataGridViewTextBoxColumn.Name = "postavDataGridViewTextBoxColumn";
            // 
            // categoryTovDataGridViewTextBoxColumn
            // 
            this.categoryTovDataGridViewTextBoxColumn.DataPropertyName = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.HeaderText = "Category tov_";
            this.categoryTovDataGridViewTextBoxColumn.Name = "categoryTovDataGridViewTextBoxColumn";
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis_";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis_";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            // 
            // postavBindingSource
            // 
            this.postavBindingSource.DataMember = "Postav";
            this.postavBindingSource.DataSource = this.flowers01DataSet;
            // 
            // flowers01DataSet
            // 
            this.flowers01DataSet.DataSetName = "Flowers01DataSet";
            this.flowers01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(588, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // postavTableAdapter
            // 
            this.postavTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(712, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postavBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowers01DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private Flowers01DataSet flowers01DataSet;
        private System.Windows.Forms.BindingSource postavBindingSource;
        private Flowers01DataSetTableAdapters.PostavTableAdapter postavTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn arcticleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
    }
}