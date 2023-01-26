using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Resultado.Text = "Nome: "+ Men1.Text + "\n\r" + "Endereço: " + Men2.Text + "\n\r" + "Celular :"+ Men3.Text + "\n\r"+ "Data Nascimento: "+ Men4.Text + "\n\r"+"CEP: "+ Men5.Text; 
            Tex1.Visible= false;
            Tex2.Visible = false;
            Tex3.Visible = false;
            Tex4.Visible = false;
            Tex5.Visible = false;
            Men1.Visible=false;
            Men2.Visible=false;
            Men3.Visible=false;
            Men4.Visible=false; 
            Men5.Visible=false;
            B1.Visible=false;
           
        }

        private void Men1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
