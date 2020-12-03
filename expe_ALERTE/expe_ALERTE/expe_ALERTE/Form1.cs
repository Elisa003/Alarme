using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace expe_ALERTE
{
    public partial class Form1 : Form
    {
        int cpt = 5;
        DateTime start;
        DateTime stop;
        TimeSpan tpsEcoule;
        int tempsReaction1;
        int tailleVue1;
        int tempsReaction2;
        int tailleVue2;
        bool expe1 = true;

        public Form1()
        {
            InitializeComponent();
            btnDemarrer2.Enabled = false;
        }

        private void buttonDemarrer_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            this.alerte.ForeColor = System.Drawing.Color.Red;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick); // timer_Tick est appelé à chaque déclenchement
            timer.Interval = 5000;                      // Le déclenchement a lieu toutes les 5 secondes
            timer.Enabled = true;
            if (!expe1)
                timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            cpt++;
            this.alerte.Font = new System.Drawing.Font("Arial", cpt);
        }


        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && expe1)
            {
                stop = DateTime.Now;
                tpsEcoule = stop - start;
                tempsReaction1 = (tpsEcoule.Seconds) / (cpt-4);
                tailleVue1 = cpt;

                MessageBox.Show("Expérience 1 terminée");
                btnDemarrer.BackColor = Color.DarkSeaGreen;
                btnDemarrer.Enabled = false;
                btnDemarrer2.BackColor = Color.LimeGreen;
                btnDemarrer2.Enabled = true;
                alerte.ForeColor = Color.Black;
                alerte.Font = new System.Drawing.Font("Arial", tailleVue1);
            }
            if (e.KeyCode == Keys.Escape && !expe1)
            {
                stop = DateTime.Now;
                tpsEcoule = stop - start;
                tempsReaction2 = (tpsEcoule.Seconds) / (cpt - 4);
                tailleVue2 = cpt;

                MessageBox.Show("Expérience 2 terminée");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Expérience 1\nle temps de réaction est : " + tempsReaction1 + " à la taille de police : " + tailleVue1 + "\nExpérience 2\nle temps de réaction est : " + tempsReaction2 + " à la taille de police : " + tailleVue2);
        }

        private void btnDemarrer2_Click(object sender, EventArgs e)
        {
            expe1 = false;
            start = DateTime.Now;
            cpt = tailleVue1;
            alerte.ForeColor = Color.Red;

            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer2.Tick += new EventHandler(timer_Tick); // timer_Tick est appelé à chaque déclenchement
            timer2.Interval = 5000;                      // Le déclenchement a lieu toutes les 5 secondes
            timer2.Enabled = true;
        }
    }
}


