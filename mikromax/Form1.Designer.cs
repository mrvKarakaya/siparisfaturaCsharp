
namespace mikromax
{
    partial class Form1
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
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new mikromax.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mikromaxDataSet3 = new mikromax.mikromaxDataSet3();
            this.viewSiparisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewSiparisTableAdapter = new mikromax.mikromaxDataSet3TableAdapters.ViewSiparisTableAdapter();
            this.mikromaxDataSet4 = new mikromax.mikromaxDataSet4();
            this.viewSiparisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewSiparisTableAdapter1 = new mikromax.mikromaxDataSet4TableAdapters.ViewSiparisTableAdapter();
            this.txtevrakno = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mikromaxDataSet = new mikromax.mikromaxDataSet();
            this.mikromaxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mikromaxDataSet2 = new mikromax.mikromaxDataSet2();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterilerTableAdapter = new mikromax.mikromaxDataSet2TableAdapters.musterilerTableAdapter();
            this.cmbmusteriad = new System.Windows.Forms.ComboBox();
            this.cmburunler = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiparisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiparisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 281);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 73);
            this.button4.TabIndex = 9;
            this.button4.Text = "Evrağı Gör";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "yeni kayıt ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // mikromaxDataSet3
            // 
            this.mikromaxDataSet3.DataSetName = "mikromaxDataSet3";
            this.mikromaxDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSiparisBindingSource
            // 
            this.viewSiparisBindingSource.DataMember = "ViewSiparis";
            this.viewSiparisBindingSource.DataSource = this.mikromaxDataSet3;
            // 
            // viewSiparisTableAdapter
            // 
            this.viewSiparisTableAdapter.ClearBeforeFill = true;
            // 
            // mikromaxDataSet4
            // 
            this.mikromaxDataSet4.DataSetName = "mikromaxDataSet4";
            this.mikromaxDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewSiparisBindingSource1
            // 
            this.viewSiparisBindingSource1.DataMember = "ViewSiparis";
            this.viewSiparisBindingSource1.DataSource = this.mikromaxDataSet4;
            // 
            // viewSiparisTableAdapter1
            // 
            this.viewSiparisTableAdapter1.ClearBeforeFill = true;
            // 
            // txtevrakno
            // 
            this.txtevrakno.Location = new System.Drawing.Point(506, 167);
            this.txtevrakno.Name = "txtevrakno";
            this.txtevrakno.Size = new System.Drawing.Size(121, 20);
            this.txtevrakno.TabIndex = 13;
            this.txtevrakno.TextChanged += new System.EventHandler(this.txtevrakno_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 233);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // mikromaxDataSet
            // 
            this.mikromaxDataSet.DataSetName = "mikromaxDataSet";
            this.mikromaxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mikromaxDataSetBindingSource
            // 
            this.mikromaxDataSetBindingSource.DataSource = this.mikromaxDataSet;
            this.mikromaxDataSetBindingSource.Position = 0;
            // 
            // mikromaxDataSet2
            // 
            this.mikromaxDataSet2.DataSetName = "mikromaxDataSet2";
            this.mikromaxDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.mikromaxDataSet2;
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // cmbmusteriad
            // 
            this.cmbmusteriad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmusteriad.FormattingEnabled = true;
            this.cmbmusteriad.Location = new System.Drawing.Point(506, 71);
            this.cmbmusteriad.Name = "cmbmusteriad";
            this.cmbmusteriad.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteriad.TabIndex = 22;
            // 
            // cmburunler
            // 
            this.cmburunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmburunler.FormattingEnabled = true;
            this.cmburunler.Location = new System.Drawing.Point(506, 120);
            this.cmburunler.Name = "cmburunler";
            this.cmburunler.Size = new System.Drawing.Size(121, 21);
            this.cmburunler.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(506, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmburunler);
            this.Controls.Add(this.cmbmusteriad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtevrakno);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiparisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewSiparisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mikromaxDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private System.Windows.Forms.BindingSource mikromaxDataSetBindingSource;
        private mikromaxDataSet mikromaxDataSet;
        private mikromaxDataSet2 mikromaxDataSet2;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private mikromaxDataSet2TableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private mikromaxDataSet3 mikromaxDataSet3;
        private System.Windows.Forms.BindingSource viewSiparisBindingSource;
        private mikromaxDataSet3TableAdapters.ViewSiparisTableAdapter viewSiparisTableAdapter;
        private mikromaxDataSet4 mikromaxDataSet4;
        private System.Windows.Forms.BindingSource viewSiparisBindingSource1;
        private mikromaxDataSet4TableAdapters.ViewSiparisTableAdapter viewSiparisTableAdapter1;
        private System.Windows.Forms.TextBox txtevrakno;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbmusteriad;
        private System.Windows.Forms.ComboBox cmburunler;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}