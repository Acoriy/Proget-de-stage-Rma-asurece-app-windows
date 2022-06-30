
namespace Proget_Stage_Principame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainepanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.btnEcheancier = new System.Windows.Forms.Button();
            this.PetiMenu = new System.Windows.Forms.Button();
            this.btnListeAction = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlisteProcpect = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainepanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainepanel
            // 
            this.mainepanel.Controls.Add(this.pictureBox2);
            this.mainepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainepanel.Location = new System.Drawing.Point(346, 110);
            this.mainepanel.Name = "mainepanel";
            this.mainepanel.Size = new System.Drawing.Size(1037, 550);
            this.mainepanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(346, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1037, 110);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 55);
            this.panel3.TabIndex = 0;
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFermer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_fermer_30;
            this.btnFermer.Location = new System.Drawing.Point(960, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(74, 52);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.btnEcheancier);
            this.panel1.Controls.Add(this.PetiMenu);
            this.panel1.Controls.Add(this.btnListeAction);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnlisteProcpect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 660);
            this.panel1.TabIndex = 3;
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.White;
            this.pnlBut.Location = new System.Drawing.Point(3, 292);
            this.pnlBut.Name = "pnlBut";
            this.pnlBut.Size = new System.Drawing.Size(34, 117);
            this.pnlBut.TabIndex = 8;
            // 
            // btnEcheancier
            // 
            this.btnEcheancier.BackColor = System.Drawing.Color.Navy;
            this.btnEcheancier.FlatAppearance.BorderSize = 0;
            this.btnEcheancier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnEcheancier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEcheancier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEcheancier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEcheancier.ForeColor = System.Drawing.Color.White;
            this.btnEcheancier.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_pin_100;
            this.btnEcheancier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEcheancier.Location = new System.Drawing.Point(38, 609);
            this.btnEcheancier.Name = "btnEcheancier";
            this.btnEcheancier.Size = new System.Drawing.Size(302, 166);
            this.btnEcheancier.TabIndex = 7;
            this.btnEcheancier.Text = "Echeancier des prospections";
            this.btnEcheancier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEcheancier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEcheancier.UseVisualStyleBackColor = false;
            this.btnEcheancier.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PetiMenu
            // 
            this.PetiMenu.FlatAppearance.BorderSize = 0;
            this.PetiMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.PetiMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PetiMenu.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_menu_arrondi_48;
            this.PetiMenu.Location = new System.Drawing.Point(12, 188);
            this.PetiMenu.Name = "PetiMenu";
            this.PetiMenu.Size = new System.Drawing.Size(79, 64);
            this.PetiMenu.TabIndex = 6;
            this.PetiMenu.UseVisualStyleBackColor = true;
            this.PetiMenu.Click += new System.EventHandler(this.PetiMenu_Click);
            // 
            // btnListeAction
            // 
            this.btnListeAction.BackColor = System.Drawing.Color.Navy;
            this.btnListeAction.FlatAppearance.BorderSize = 0;
            this.btnListeAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnListeAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnListeAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeAction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeAction.ForeColor = System.Drawing.Color.White;
            this.btnListeAction.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_travail_100__1_;
            this.btnListeAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeAction.Location = new System.Drawing.Point(38, 434);
            this.btnListeAction.Name = "btnListeAction";
            this.btnListeAction.Size = new System.Drawing.Size(302, 161);
            this.btnListeAction.TabIndex = 5;
            this.btnListeAction.Text = "        Liste des actions des  procpects ";
            this.btnListeAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListeAction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeAction.UseVisualStyleBackColor = false;
            this.btnListeAction.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proget_Stage_Principame.Properties.Resources.logine1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnlisteProcpect
            // 
            this.btnlisteProcpect.BackColor = System.Drawing.Color.Navy;
            this.btnlisteProcpect.FlatAppearance.BorderSize = 0;
            this.btnlisteProcpect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnlisteProcpect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnlisteProcpect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlisteProcpect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlisteProcpect.ForeColor = System.Drawing.Color.White;
            this.btnlisteProcpect.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_contrat_de_travail_100;
            this.btnlisteProcpect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlisteProcpect.Location = new System.Drawing.Point(38, 272);
            this.btnlisteProcpect.Name = "btnlisteProcpect";
            this.btnlisteProcpect.Size = new System.Drawing.Size(305, 148);
            this.btnlisteProcpect.TabIndex = 2;
            this.btnlisteProcpect.Text = "Liste des procpects ";
            this.btnlisteProcpect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlisteProcpect.UseVisualStyleBackColor = false;
            this.btnlisteProcpect.Click += new System.EventHandler(this.btnlisteProcpect_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Proget_Stage_Principame.Properties.Resources.RMA_Emploi_Recrutement_Dreamjob_ma_1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1037, 550);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 660);
            this.Controls.Add(this.mainepanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainepanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainepanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListeAction;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlisteProcpect;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button PetiMenu;
        private System.Windows.Forms.Button btnEcheancier;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

