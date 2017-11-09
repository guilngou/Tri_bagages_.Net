namespace Client.FormIhm
{
    partial class PIM
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_codeIata = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ligne = new System.Windows.Forms.TextBox();
            this.textBox_compagnie = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox_prioritaire = new System.Windows.Forms.CheckBox();
            this.checkBox_continuation = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_itineraire = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_codeIata);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CodeIata :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_codeIata
            // 
            this.textBox_codeIata.Location = new System.Drawing.Point(68, 23);
            this.textBox_codeIata.Name = "textBox_codeIata";
            this.textBox_codeIata.Size = new System.Drawing.Size(100, 20);
            this.textBox_codeIata.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_date);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_ligne);
            this.groupBox2.Controls.Add(this.textBox_compagnie);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations Vol";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jour d\'exploitation :";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(120, 99);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(158, 20);
            this.textBox_date.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ligne";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compagnie :";
            // 
            // textBox_ligne
            // 
            this.textBox_ligne.Location = new System.Drawing.Point(120, 60);
            this.textBox_ligne.Name = "textBox_ligne";
            this.textBox_ligne.Size = new System.Drawing.Size(158, 20);
            this.textBox_ligne.TabIndex = 2;
            // 
            // textBox_compagnie
            // 
            this.textBox_compagnie.Location = new System.Drawing.Point(120, 19);
            this.textBox_compagnie.Name = "textBox_compagnie";
            this.textBox_compagnie.Size = new System.Drawing.Size(158, 20);
            this.textBox_compagnie.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox_prioritaire);
            this.groupBox3.Controls.Add(this.checkBox_continuation);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox_itineraire);
            this.groupBox3.Location = new System.Drawing.Point(502, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informations Passager";
            // 
            // checkBox_prioritaire
            // 
            this.checkBox_prioritaire.AutoSize = true;
            this.checkBox_prioritaire.Location = new System.Drawing.Point(115, 121);
            this.checkBox_prioritaire.Name = "checkBox_prioritaire";
            this.checkBox_prioritaire.Size = new System.Drawing.Size(51, 17);
            this.checkBox_prioritaire.TabIndex = 7;
            this.checkBox_prioritaire.Text = "Rush";
            this.checkBox_prioritaire.UseVisualStyleBackColor = true;
            // 
            // checkBox_continuation
            // 
            this.checkBox_continuation.AutoSize = true;
            this.checkBox_continuation.Location = new System.Drawing.Point(115, 98);
            this.checkBox_continuation.Name = "checkBox_continuation";
            this.checkBox_continuation.Size = new System.Drawing.Size(88, 17);
            this.checkBox_continuation.TabIndex = 6;
            this.checkBox_continuation.Text = "Continuation ";
            this.checkBox_continuation.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Classe bagage :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(95, 60);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Itinéraire :";
            // 
            // textBox_itineraire
            // 
            this.textBox_itineraire.Location = new System.Drawing.Point(95, 25);
            this.textBox_itineraire.Name = "textBox_itineraire";
            this.textBox_itineraire.Size = new System.Drawing.Size(100, 20);
            this.textBox_itineraire.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(925, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(300, 17);
            this.toolStripStatusLabel1.Text = "Messages";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel2.Text = "Etat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réinitialiserToolStripMenuItem});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // réinitialiserToolStripMenuItem
            // 
            this.réinitialiserToolStripMenuItem.Name = "réinitialiserToolStripMenuItem";
            this.réinitialiserToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.réinitialiserToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.réinitialiserToolStripMenuItem.Text = "Réinitialiser";
            this.réinitialiserToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserToolStripMenuItem_Click);
            // 
            // PIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PIM";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PIM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_codeIata;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_compagnie;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ligne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_itineraire;
        private System.Windows.Forms.CheckBox checkBox_prioritaire;
        private System.Windows.Forms.CheckBox checkBox_continuation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserToolStripMenuItem;
    }
}

