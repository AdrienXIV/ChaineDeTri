namespace Chaine_De_Tri
{
    partial class Chaine_De_Tri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chaine_De_Tri));
            this.buttonOnVerin1 = new System.Windows.Forms.Button();
            this.buttonOnVerin2 = new System.Windows.Forms.Button();
            this.buttonOnVerin3 = new System.Windows.Forms.Button();
            this.buttonOffVerin1 = new System.Windows.Forms.Button();
            this.buttonOffVerin2 = new System.Windows.Forms.Button();
            this.buttonOffVerin3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEtatCapteur = new System.Windows.Forms.TextBox();
            this.buttonMarche = new System.Windows.Forms.Button();
            this.buttonArret = new System.Windows.Forms.Button();
            this.textBoxEtatChaineDeTri = new System.Windows.Forms.TextBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.timerEtat = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.timerMessage = new System.Windows.Forms.Timer(this.components);
            this.textBoxDetection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonRecuperer = new System.Windows.Forms.Button();
            this.buttonTapisLancer = new System.Windows.Forms.Button();
            this.buttonTapisArret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOnVerin1
            // 
            this.buttonOnVerin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOnVerin1.Location = new System.Drawing.Point(456, 213);
            this.buttonOnVerin1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnVerin1.Name = "buttonOnVerin1";
            this.buttonOnVerin1.Size = new System.Drawing.Size(100, 42);
            this.buttonOnVerin1.TabIndex = 0;
            this.buttonOnVerin1.Text = "ON";
            this.buttonOnVerin1.UseVisualStyleBackColor = true;
            this.buttonOnVerin1.Click += new System.EventHandler(this.buttonOnVerin1_Click);
            // 
            // buttonOnVerin2
            // 
            this.buttonOnVerin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOnVerin2.Location = new System.Drawing.Point(564, 213);
            this.buttonOnVerin2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnVerin2.Name = "buttonOnVerin2";
            this.buttonOnVerin2.Size = new System.Drawing.Size(100, 42);
            this.buttonOnVerin2.TabIndex = 1;
            this.buttonOnVerin2.Text = "ON";
            this.buttonOnVerin2.UseVisualStyleBackColor = true;
            this.buttonOnVerin2.Click += new System.EventHandler(this.buttonOnVerin2_Click);
            // 
            // buttonOnVerin3
            // 
            this.buttonOnVerin3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOnVerin3.Location = new System.Drawing.Point(672, 213);
            this.buttonOnVerin3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnVerin3.Name = "buttonOnVerin3";
            this.buttonOnVerin3.Size = new System.Drawing.Size(100, 42);
            this.buttonOnVerin3.TabIndex = 2;
            this.buttonOnVerin3.Text = "ON";
            this.buttonOnVerin3.UseVisualStyleBackColor = true;
            this.buttonOnVerin3.Click += new System.EventHandler(this.buttonOnVerin3_Click);
            // 
            // buttonOffVerin1
            // 
            this.buttonOffVerin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOffVerin1.Location = new System.Drawing.Point(456, 262);
            this.buttonOffVerin1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOffVerin1.Name = "buttonOffVerin1";
            this.buttonOffVerin1.Size = new System.Drawing.Size(100, 42);
            this.buttonOffVerin1.TabIndex = 3;
            this.buttonOffVerin1.Text = "OFF";
            this.buttonOffVerin1.UseVisualStyleBackColor = true;
            this.buttonOffVerin1.Click += new System.EventHandler(this.buttonOffVerin1_Click);
            // 
            // buttonOffVerin2
            // 
            this.buttonOffVerin2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOffVerin2.Location = new System.Drawing.Point(564, 262);
            this.buttonOffVerin2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOffVerin2.Name = "buttonOffVerin2";
            this.buttonOffVerin2.Size = new System.Drawing.Size(100, 42);
            this.buttonOffVerin2.TabIndex = 4;
            this.buttonOffVerin2.Text = "OFF";
            this.buttonOffVerin2.UseVisualStyleBackColor = true;
            this.buttonOffVerin2.Click += new System.EventHandler(this.buttonOffVerin2_Click);
            // 
            // buttonOffVerin3
            // 
            this.buttonOffVerin3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOffVerin3.Location = new System.Drawing.Point(672, 262);
            this.buttonOffVerin3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOffVerin3.Name = "buttonOffVerin3";
            this.buttonOffVerin3.Size = new System.Drawing.Size(100, 42);
            this.buttonOffVerin3.TabIndex = 5;
            this.buttonOffVerin3.Text = "OFF";
            this.buttonOffVerin3.UseVisualStyleBackColor = true;
            this.buttonOffVerin3.Click += new System.EventHandler(this.buttonOffVerin3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vérin 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vérin 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vérin 3";
            // 
            // textBoxEtatCapteur
            // 
            this.textBoxEtatCapteur.Location = new System.Drawing.Point(456, 90);
            this.textBoxEtatCapteur.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEtatCapteur.Multiline = true;
            this.textBoxEtatCapteur.Name = "textBoxEtatCapteur";
            this.textBoxEtatCapteur.ReadOnly = true;
            this.textBoxEtatCapteur.Size = new System.Drawing.Size(315, 88);
            this.textBoxEtatCapteur.TabIndex = 11;
            this.textBoxEtatCapteur.TextChanged += new System.EventHandler(this.textBoxEtatCapteur_TextChanged);
            // 
            // buttonMarche
            // 
            this.buttonMarche.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarche.Location = new System.Drawing.Point(16, 102);
            this.buttonMarche.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMarche.Name = "buttonMarche";
            this.buttonMarche.Size = new System.Drawing.Size(175, 57);
            this.buttonMarche.TabIndex = 12;
            this.buttonMarche.Text = "Lancer";
            this.buttonMarche.UseVisualStyleBackColor = true;
            this.buttonMarche.Click += new System.EventHandler(this.buttonMarche_Click);
            // 
            // buttonArret
            // 
            this.buttonArret.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonArret.Location = new System.Drawing.Point(221, 102);
            this.buttonArret.Margin = new System.Windows.Forms.Padding(4);
            this.buttonArret.Name = "buttonArret";
            this.buttonArret.Size = new System.Drawing.Size(175, 57);
            this.buttonArret.TabIndex = 13;
            this.buttonArret.Text = "Arrêter";
            this.buttonArret.UseVisualStyleBackColor = true;
            this.buttonArret.Click += new System.EventHandler(this.buttonArret_Click);
            // 
            // textBoxEtatChaineDeTri
            // 
            this.textBoxEtatChaineDeTri.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxEtatChaineDeTri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEtatChaineDeTri.Location = new System.Drawing.Point(16, 166);
            this.textBoxEtatChaineDeTri.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEtatChaineDeTri.Multiline = true;
            this.textBoxEtatChaineDeTri.Name = "textBoxEtatChaineDeTri";
            this.textBoxEtatChaineDeTri.ReadOnly = true;
            this.textBoxEtatChaineDeTri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEtatChaineDeTri.Size = new System.Drawing.Size(379, 235);
            this.textBoxEtatChaineDeTri.TabIndex = 14;
            this.textBoxEtatChaineDeTri.TextChanged += new System.EventHandler(this.textBoxEtatChaineDeTri_TextChanged);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonConnexion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConnexion.Location = new System.Drawing.Point(16, 22);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(380, 41);
            this.buttonConnexion.TabIndex = 15;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonQuitter.Location = new System.Drawing.Point(588, 502);
            this.buttonQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(184, 52);
            this.buttonQuitter.TabIndex = 16;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // timerEtat
            // 
            this.timerEtat.Interval = 200;
            this.timerEtat.Tick += new System.EventHandler(this.timerEtat_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Etats Capteurs :";
            // 
            // timerMessage
            // 
            this.timerMessage.Interval = 103;
            this.timerMessage.Tick += new System.EventHandler(this.timerMessage_Tick);
            // 
            // textBoxDetection
            // 
            this.textBoxDetection.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxDetection.Location = new System.Drawing.Point(16, 449);
            this.textBoxDetection.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDetection.Multiline = true;
            this.textBoxDetection.Name = "textBoxDetection";
            this.textBoxDetection.ReadOnly = true;
            this.textBoxDetection.Size = new System.Drawing.Size(184, 104);
            this.textBoxDetection.TabIndex = 22;
            this.textBoxDetection.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Détection : ";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.BackColor = System.Drawing.SystemColors.Control;
            this.labelHeure.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelHeure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeure.Location = new System.Drawing.Point(707, 11);
            this.labelHeure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(109, 20);
            this.labelHeure.TabIndex = 24;
            this.labelHeure.Text = "                    ";
            this.labelHeure.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHeure.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(691, 31);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(139, 20);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "                          ";
            // 
            // buttonRecuperer
            // 
            this.buttonRecuperer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecuperer.Location = new System.Drawing.Point(209, 449);
            this.buttonRecuperer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecuperer.Name = "buttonRecuperer";
            this.buttonRecuperer.Size = new System.Drawing.Size(187, 105);
            this.buttonRecuperer.TabIndex = 26;
            this.buttonRecuperer.Text = "Récuperer l\'historique";
            this.buttonRecuperer.UseVisualStyleBackColor = true;
            this.buttonRecuperer.Click += new System.EventHandler(this.buttonRecuperer_Click);
            // 
            // buttonTapisLancer
            // 
            this.buttonTapisLancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTapisLancer.Location = new System.Drawing.Point(456, 311);
            this.buttonTapisLancer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTapisLancer.Name = "buttonTapisLancer";
            this.buttonTapisLancer.Size = new System.Drawing.Size(316, 42);
            this.buttonTapisLancer.TabIndex = 27;
            this.buttonTapisLancer.Text = "Tapis Marche";
            this.buttonTapisLancer.UseVisualStyleBackColor = true;
            this.buttonTapisLancer.Click += new System.EventHandler(this.buttonTapisLancer_Click);
            // 
            // buttonTapisArret
            // 
            this.buttonTapisArret.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTapisArret.Location = new System.Drawing.Point(456, 361);
            this.buttonTapisArret.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTapisArret.Name = "buttonTapisArret";
            this.buttonTapisArret.Size = new System.Drawing.Size(316, 42);
            this.buttonTapisArret.TabIndex = 28;
            this.buttonTapisArret.Text = "Tapis Arrêt";
            this.buttonTapisArret.UseVisualStyleBackColor = true;
            this.buttonTapisArret.Click += new System.EventHandler(this.buttonTapisArret_Click);
            // 
            // Chaine_De_Tri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 569);
            this.Controls.Add(this.buttonTapisArret);
            this.Controls.Add(this.buttonTapisLancer);
            this.Controls.Add(this.buttonRecuperer);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelHeure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDetection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxEtatChaineDeTri);
            this.Controls.Add(this.buttonArret);
            this.Controls.Add(this.buttonMarche);
            this.Controls.Add(this.textBoxEtatCapteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOffVerin3);
            this.Controls.Add(this.buttonOffVerin2);
            this.Controls.Add(this.buttonOffVerin1);
            this.Controls.Add(this.buttonOnVerin3);
            this.Controls.Add(this.buttonOnVerin2);
            this.Controls.Add(this.buttonOnVerin1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chaine_De_Tri";
            this.Text = "Chaîne de Tri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOnVerin1;
        private System.Windows.Forms.Button buttonOnVerin2;
        private System.Windows.Forms.Button buttonOnVerin3;
        private System.Windows.Forms.Button buttonOffVerin1;
        private System.Windows.Forms.Button buttonOffVerin2;
        private System.Windows.Forms.Button buttonOffVerin3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEtatCapteur;
        private System.Windows.Forms.Button buttonMarche;
        private System.Windows.Forms.Button buttonArret;
        private System.Windows.Forms.TextBox textBoxEtatChaineDeTri;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Timer timerEtat;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerMessage;
        private System.Windows.Forms.TextBox textBoxDetection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonRecuperer;
        private System.Windows.Forms.Button buttonTapisLancer;
        private System.Windows.Forms.Button buttonTapisArret;
    }
}

