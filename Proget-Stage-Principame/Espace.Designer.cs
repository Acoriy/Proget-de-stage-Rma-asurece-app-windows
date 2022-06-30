
namespace Proget_Stage_Principame
{
    partial class Espace
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRechercheEsp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNevou = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridEspace = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demarcheure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demarcheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prospectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1Report = new Proget_Stage_Principame.DataSet1Report();
            this.prospectTableAdapter = new Proget_Stage_Principame.DataSet1ReportTableAdapters.ProspectTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Report)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.textRechercheEsp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 80);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textRechercheEsp
            // 
            this.textRechercheEsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRechercheEsp.Location = new System.Drawing.Point(205, 32);
            this.textRechercheEsp.Name = "textRechercheEsp";
            this.textRechercheEsp.Size = new System.Drawing.Size(332, 32);
            this.textRechercheEsp.TabIndex = 1;
            this.textRechercheEsp.TextChanged += new System.EventHandler(this.textRechercheEsp_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_rechercher_plus_40;
            this.pictureBox1.Location = new System.Drawing.Point(79, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnNevou);
            this.panel2.Controls.Add(this.btnAnnuler);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 74);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnNevou
            // 
            this.btnNevou.BackColor = System.Drawing.Color.Purple;
            this.btnNevou.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNevou.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNevou.ForeColor = System.Drawing.Color.White;
            this.btnNevou.Location = new System.Drawing.Point(493, 11);
            this.btnNevou.Name = "btnNevou";
            this.btnNevou.Size = new System.Drawing.Size(179, 51);
            this.btnNevou.TabIndex = 14;
            this.btnNevou.Text = "Nouveau";
            this.btnNevou.UseVisualStyleBackColor = false;
            this.btnNevou.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Purple;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.White;
            this.btnAnnuler.Location = new System.Drawing.Point(212, 11);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(179, 51);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridEspace);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1061, 507);
            this.panel3.TabIndex = 3;
            // 
            // dataGridEspace
            // 
            this.dataGridEspace.AutoGenerateColumns = false;
            this.dataGridEspace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEspace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEspace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nom,
            this.Telephone,
            this.Demarcheure,
            this.codeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.demarcheureDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
            this.dataGridEspace.DataSource = this.prospectBindingSource;
            this.dataGridEspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEspace.Location = new System.Drawing.Point(0, 0);
            this.dataGridEspace.Name = "dataGridEspace";
            this.dataGridEspace.RowHeadersWidth = 62;
            this.dataGridEspace.RowTemplate.Height = 28;
            this.dataGridEspace.Size = new System.Drawing.Size(1061, 507);
            this.dataGridEspace.TabIndex = 0;
            this.dataGridEspace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspace_CellClick);
            this.dataGridEspace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspace_CellContentClick);
            this.dataGridEspace.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEspace_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "code";
            this.Column1.HeaderText = "codeProspect";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "SonTelephone";
            this.Telephone.MinimumWidth = 8;
            this.Telephone.Name = "Telephone";
            // 
            // Demarcheure
            // 
            this.Demarcheure.DataPropertyName = "Demarcheure";
            this.Demarcheure.HeaderText = "Demarcheure";
            this.Demarcheure.MinimumWidth = 8;
            this.Demarcheure.Name = "Demarcheure";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // demarcheureDataGridViewTextBoxColumn
            // 
            this.demarcheureDataGridViewTextBoxColumn.DataPropertyName = "Demarcheure";
            this.demarcheureDataGridViewTextBoxColumn.HeaderText = "Demarcheure";
            this.demarcheureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.demarcheureDataGridViewTextBoxColumn.Name = "demarcheureDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // prospectBindingSource
            // 
            this.prospectBindingSource.DataMember = "Prospect";
            this.prospectBindingSource.DataSource = this.dataSet1Report;
            // 
            // dataSet1Report
            // 
            this.dataSet1Report.DataSetName = "DataSet1Report";
            this.dataSet1Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prospectTableAdapter
            // 
            this.prospectTableAdapter.ClearBeforeFill = true;
            // 
            // Espace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 661);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Espace";
            this.Text = "Espace";
            this.Load += new System.EventHandler(this.Espace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEspace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prospectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1Report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textRechercheEsp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridEspace;
        private DataSet1Report dataSet1Report;
        private System.Windows.Forms.BindingSource prospectBindingSource;
        private DataSet1ReportTableAdapters.ProspectTableAdapter prospectTableAdapter;
        private System.Windows.Forms.Button btnNevou;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demarcheure;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demarcheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
    }
}