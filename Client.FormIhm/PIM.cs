using MyAirport.Pim.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormIhm
{
    public partial class PIM : Form
    {

        public event PimStateEventHandler PimStateChanged;
        public delegate void PimStateEventHandler(object sender, PimState state);

        private void OnPimStateChanged(PimState newState)
        {
            if (newState != this.state)
            {
                this.state = newState;
                if (this.PimStateChanged != null)
                {
                    PimStateChanged(this, this.state);
                }
            }
        }


        private PimState state = PimState.Deconnecter;
        private PimState State
        {
            get { return this.state; }
            set { OnPimStateChanged(value); }
        }

        public PIM()
        {
            InitializeComponent();
            this.PimStateChanged += PIM_PimStateChanged;
        }

        void PIM_PimStateChanged(object sender, PimState state)
        {
            MessageBox.Show("StateChanged");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<BagageDefinition> bagages = MyAirport.Pim.Models.Factory.Model.GetBagage("023232546100");
            Console.WriteLine(bagages[0].CodeIata.ToString());
            this.textBox_codeIata.Text = bagages[0].CodeIata.ToString();
            this.textBox_codeIata.Enabled = false;
            Console.WriteLine(bagages[0].Compagnie.ToString());
            this.textBox_compagnie.Text = bagages[0].Compagnie.ToString();
            this.textBox_compagnie.Enabled = false;
            Console.WriteLine(bagages[0].DateVol.ToString());
            this.textBox_date.Text = bagages[0].DateVol.ToString();
            this.textBox_date.Enabled = false;
            Console.WriteLine(bagages[0].EnContinuation.ToString());
            this.checkBox_continuation.Checked = bagages[0].EnContinuation;
            this.checkBox_continuation.Enabled = false;
            Console.WriteLine(bagages[0].IdBagage.ToString());
            Console.WriteLine(bagages[0].Itineraire.ToString());
            this.textBox_itineraire.Text = bagages[0].Itineraire.ToString();
            this.textBox_itineraire.Enabled = false;
            Console.WriteLine(bagages[0].Ligne.ToString());
            this.textBox_ligne.Text = bagages[0].Ligne.ToString();
            this.textBox_ligne.Enabled = false;
            Console.WriteLine(bagages[0].Prioritaire.ToString());
            this.checkBox_prioritaire.Checked = bagages[0].Prioritaire;
            this.checkBox_prioritaire.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PIM_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     
    }
}
