
namespace Proget_Stage_Principame
{
    partial class choiGraph
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
            this.GraphClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GraphEmploiyés = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphClient
            // 
            this.GraphClient.BackColor = System.Drawing.Color.Blue;
            this.GraphClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GraphClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GraphClient.FlatAppearance.BorderSize = 5;
            this.GraphClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GraphClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphClient.ForeColor = System.Drawing.Color.White;
            this.GraphClient.Location = new System.Drawing.Point(727, 54);
            this.GraphClient.Name = "GraphClient";
            this.GraphClient.Size = new System.Drawing.Size(299, 155);
            this.GraphClient.TabIndex = 0;
            this.GraphClient.Text = "Imprimer Graph Client";
            this.GraphClient.UseVisualStyleBackColor = false;
            this.GraphClient.Click += new System.EventHandler(this.GraphClient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 145);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(724, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dernières Statistiques";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GraphEmploiyés);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 371);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 241);
            this.panel2.TabIndex = 3;
            // 
            // GraphEmploiyés
            // 
            this.GraphEmploiyés.BackColor = System.Drawing.Color.Blue;
            this.GraphEmploiyés.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GraphEmploiyés.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GraphEmploiyés.FlatAppearance.BorderSize = 5;
            this.GraphEmploiyés.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GraphEmploiyés.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphEmploiyés.ForeColor = System.Drawing.Color.White;
            this.GraphEmploiyés.Location = new System.Drawing.Point(727, 33);
            this.GraphEmploiyés.Name = "GraphEmploiyés";
            this.GraphEmploiyés.Size = new System.Drawing.Size(299, 155);
            this.GraphEmploiyés.TabIndex = 2;
            this.GraphEmploiyés.Text = "Imprimer Graph Emploiyés";
            this.GraphEmploiyés.UseVisualStyleBackColor = false;
            this.GraphEmploiyés.Click += new System.EventHandler(this.GraphEmploiyés_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.GraphClient);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1272, 226);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnSubtract);
            this.panel4.Controls.Add(this.btnFermer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1272, 51);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proget_Stage_Principame.Properties.Resources.course_1015601_640;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proget_Stage_Principame.Properties.Resources.course_1015596_640;
            this.pictureBox2.Location = new System.Drawing.Point(12, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(484, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubtract.FlatAppearance.BorderSize = 0;
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtract.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_moins_48;
            this.btnSubtract.Location = new System.Drawing.Point(1128, 0);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(64, 51);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Image = global::Proget_Stage_Principame.Properties.Resources.icons8_fermer_30;
            this.btnFermer.Location = new System.Drawing.Point(1198, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(74, 51);
            this.btnFermer.TabIndex = 0;
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // choiGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1272, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choiGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choiGraph";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GraphClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button GraphEmploiyés;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSubtract;
    }
}