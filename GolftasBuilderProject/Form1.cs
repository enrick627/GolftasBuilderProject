using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolftasBuilderProject
{
    public partial class Form_GolftasBuilder : Form
    {
        public Form_GolftasBuilder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form_GolftasBuilder_Load(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_ToonGolftas_Click(object sender, EventArgs e)
        {
            string Driver, DrieWood, VijfWood, Ijzers, Wedges, Putters;
            Driver = textBox_driver.ToString();
            DrieWood = textBox_3wood.ToString();
            VijfWood = textBox_5wood.ToString();
            Ijzers = textBox_ijzers.ToString();
            Wedges = textBox1_wedges.ToString();
            Putters = textBox_putters.ToString();
            this.Textbox_TotaleGolftas.Text = ($"driver:{Driver} 3 wood:{DrieWood} 5 wood: {VijfWood} ijzers: {Ijzers} wedges: {Wedges} putters: {Putters}");
            
        }

        private void Textbox_TotaleGolftas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
