namespace expe_ALERTE
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
            this.components = new System.ComponentModel.Container();
            this.alerte = new System.Windows.Forms.Label();
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnDemarrer2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alerte
            // 
            this.alerte.AutoSize = true;
            this.alerte.BackColor = System.Drawing.SystemColors.ControlText;
            this.alerte.Dock = System.Windows.Forms.DockStyle.Right;
            this.alerte.Font = new System.Drawing.Font("Arial", 5F);
            this.alerte.Location = new System.Drawing.Point(1085, 0);
            this.alerte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alerte.Name = "alerte";
            this.alerte.Size = new System.Drawing.Size(33, 7);
            this.alerte.TabIndex = 0;
            this.alerte.Text = "ALERTE";
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.AutoSize = true;
            this.btnDemarrer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDemarrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemarrer.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrer.ForeColor = System.Drawing.Color.Black;
            this.btnDemarrer.Location = new System.Drawing.Point(361, 24);
            this.btnDemarrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(179, 35);
            this.btnDemarrer.TabIndex = 1;
            this.btnDemarrer.Text = "DEMARRER Expérience 1";
            this.btnDemarrer.UseVisualStyleBackColor = false;
            this.btnDemarrer.Click += new System.EventHandler(this.buttonDemarrer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnDemarrer2);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.alerte);
            this.panel1.Controls.Add(this.btnDemarrer);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 100);
            this.panel1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 95);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1118, 585);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://jeu.cc/marios-adventure-2?c=D", System.UriKind.Absolute);
            this.webBrowser1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webBrowser1_PreviewKeyDown);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(11, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(85, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnDemarrer2
            // 
            this.btnDemarrer2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDemarrer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemarrer2.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrer2.Location = new System.Drawing.Point(603, 24);
            this.btnDemarrer2.Name = "btnDemarrer2";
            this.btnDemarrer2.Size = new System.Drawing.Size(179, 35);
            this.btnDemarrer2.TabIndex = 3;
            this.btnDemarrer2.Text = "DEMARRER Expérience 2";
            this.btnDemarrer2.UseVisualStyleBackColor = false;
            this.btnDemarrer2.Click += new System.EventHandler(this.btnDemarrer2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 681);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label alerte;
        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnDemarrer2;
        private System.Windows.Forms.Timer timer2;
    }
}

