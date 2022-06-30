
namespace Proget_Stage_Principame
{
    partial class Listeaction
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModifierAc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSuprimerAc = new System.Windows.Forms.Button();
            this.btnNvAction = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridAction = new System.Windows.Forms.DataGridView();
            this.codeacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProspectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sontelephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectDeProspectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEchanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perssoninflientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lActionProspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proget_stageDataSet = new Proget_Stage_Principame.Proget_stageDataSet();
            this.lActionProspectionTableAdapter = new Proget_Stage_Principame.Proget_stageDataSetTableAdapters.LActionProspectionTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lActionProspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proget_stageDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.btnModifierAc);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSuprimerAc);
            this.groupBox1.Controls.Add(this.btnNvAction);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 616);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1330, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnModifierAc
            // 
            this.btnModifierAc.BackColor = System.Drawing.Color.Chocolate;
            this.btnModifierAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierAc.ForeColor = System.Drawing.Color.White;
            this.btnModifierAc.Location = new System.Drawing.Point(363, 25);
            this.btnModifierAc.Name = "btnModifierAc";
            this.btnModifierAc.Size = new System.Drawing.Size(274, 73);
            this.btnModifierAc.TabIndex = 3;
            this.btnModifierAc.Text = "Modifier action";
            this.btnModifierAc.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1032, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "Suivi de la prspection";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSuprimerAc
            // 
            this.btnSuprimerAc.BackColor = System.Drawing.Color.Chocolate;
            this.btnSuprimerAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimerAc.ForeColor = System.Drawing.Color.White;
            this.btnSuprimerAc.Location = new System.Drawing.Point(697, 25);
            this.btnSuprimerAc.Name = "btnSuprimerAc";
            this.btnSuprimerAc.Size = new System.Drawing.Size(274, 73);
            this.btnSuprimerAc.TabIndex = 1;
            this.btnSuprimerAc.Text = "Suprimer Action";
            this.btnSuprimerAc.UseVisualStyleBackColor = false;
            // 
            // btnNvAction
            // 
            this.btnNvAction.BackColor = System.Drawing.Color.Chocolate;
            this.btnNvAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNvAction.ForeColor = System.Drawing.Color.White;
            this.btnNvAction.Location = new System.Drawing.Point(32, 25);
            this.btnNvAction.Name = "btnNvAction";
            this.btnNvAction.Size = new System.Drawing.Size(274, 73);
            this.btnNvAction.TabIndex = 0;
            this.btnNvAction.Text = "Nouvelle action";
            this.btnNvAction.UseVisualStyleBackColor = false;
            this.btnNvAction.Click += new System.EventHandler(this.btnNvAction_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Navy;
            this.groupBox2.Controls.Add(this.dataGridAction);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1330, 616);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridAction
            // 
            this.dataGridAction.AutoGenerateColumns = false;
            this.dataGridAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeacDataGridViewTextBoxColumn,
            this.dateProspectionDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.sontelephoneDataGridViewTextBoxColumn,
            this.objectDeProspectionDataGridViewTextBoxColumn,
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn,
            this.resultatDataGridViewTextBoxColumn,
            this.dateEchanceDataGridViewTextBoxColumn,
            this.perssoninflientDataGridViewTextBoxColumn,
            this.observationDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.dataGridAction.DataSource = this.lActionProspectionBindingSource;
            this.dataGridAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAction.Location = new System.Drawing.Point(3, 22);
            this.dataGridAction.Name = "dataGridAction";
            this.dataGridAction.RowHeadersWidth = 62;
            this.dataGridAction.RowTemplate.Height = 28;
            this.dataGridAction.Size = new System.Drawing.Size(1324, 591);
            this.dataGridAction.TabIndex = 0;
            // 
            // codeacDataGridViewTextBoxColumn
            // 
            this.codeacDataGridViewTextBoxColumn.DataPropertyName = "codeac";
            this.codeacDataGridViewTextBoxColumn.HeaderText = "codeac";
            this.codeacDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeacDataGridViewTextBoxColumn.Name = "codeacDataGridViewTextBoxColumn";
            this.codeacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateProspectionDataGridViewTextBoxColumn
            // 
            this.dateProspectionDataGridViewTextBoxColumn.DataPropertyName = "dateProspection";
            this.dateProspectionDataGridViewTextBoxColumn.HeaderText = "dateProspection";
            this.dateProspectionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateProspectionDataGridViewTextBoxColumn.Name = "dateProspectionDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // sontelephoneDataGridViewTextBoxColumn
            // 
            this.sontelephoneDataGridViewTextBoxColumn.DataPropertyName = "sontelephone";
            this.sontelephoneDataGridViewTextBoxColumn.HeaderText = "sontelephone";
            this.sontelephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.sontelephoneDataGridViewTextBoxColumn.Name = "sontelephoneDataGridViewTextBoxColumn";
            // 
            // objectDeProspectionDataGridViewTextBoxColumn
            // 
            this.objectDeProspectionDataGridViewTextBoxColumn.DataPropertyName = "objectDeProspection";
            this.objectDeProspectionDataGridViewTextBoxColumn.HeaderText = "objectDeProspection";
            this.objectDeProspectionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.objectDeProspectionDataGridViewTextBoxColumn.Name = "objectDeProspectionDataGridViewTextBoxColumn";
            // 
            // moiyenDeContactPreferéDataGridViewTextBoxColumn
            // 
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn.DataPropertyName = "moiyenDeContactPreferé";
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn.HeaderText = "moiyenDeContactPreferé";
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moiyenDeContactPreferéDataGridViewTextBoxColumn.Name = "moiyenDeContactPreferéDataGridViewTextBoxColumn";
            // 
            // resultatDataGridViewTextBoxColumn
            // 
            this.resultatDataGridViewTextBoxColumn.DataPropertyName = "resultat";
            this.resultatDataGridViewTextBoxColumn.HeaderText = "resultat";
            this.resultatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.resultatDataGridViewTextBoxColumn.Name = "resultatDataGridViewTextBoxColumn";
            // 
            // dateEchanceDataGridViewTextBoxColumn
            // 
            this.dateEchanceDataGridViewTextBoxColumn.DataPropertyName = "dateEchance";
            this.dateEchanceDataGridViewTextBoxColumn.HeaderText = "dateEchance";
            this.dateEchanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateEchanceDataGridViewTextBoxColumn.Name = "dateEchanceDataGridViewTextBoxColumn";
            // 
            // perssoninflientDataGridViewTextBoxColumn
            // 
            this.perssoninflientDataGridViewTextBoxColumn.DataPropertyName = "Persson_inflient";
            this.perssoninflientDataGridViewTextBoxColumn.HeaderText = "Persson_inflient";
            this.perssoninflientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.perssoninflientDataGridViewTextBoxColumn.Name = "perssoninflientDataGridViewTextBoxColumn";
            // 
            // observationDataGridViewTextBoxColumn
            // 
            this.observationDataGridViewTextBoxColumn.DataPropertyName = "observation";
            this.observationDataGridViewTextBoxColumn.HeaderText = "observation";
            this.observationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.observationDataGridViewTextBoxColumn.Name = "observationDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // lActionProspectionBindingSource
            // 
            this.lActionProspectionBindingSource.DataMember = "LActionProspection";
            this.lActionProspectionBindingSource.DataSource = this.proget_stageDataSet;
            // 
            // proget_stageDataSet
            // 
            this.proget_stageDataSet.DataSetName = "Proget_stageDataSet";
            this.proget_stageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lActionProspectionTableAdapter
            // 
            this.lActionProspectionTableAdapter.ClearBeforeFill = true;
            // 
            // Listeaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 720);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listeaction";
            this.Text = "Actions";
            this.Load += new System.EventHandler(this.Actions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lActionProspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proget_stageDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModifierAc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSuprimerAc;
        private System.Windows.Forms.Button btnNvAction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridAction;
        private Proget_stageDataSet proget_stageDataSet;
        private System.Windows.Forms.BindingSource lActionProspectionBindingSource;
        private Proget_stageDataSetTableAdapters.LActionProspectionTableAdapter lActionProspectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProspectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sontelephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDeProspectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moiyenDeContactPreferéDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEchanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perssoninflientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
    }
}