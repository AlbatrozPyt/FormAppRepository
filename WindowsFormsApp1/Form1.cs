using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        dbTarefasEntities1 ctx = new dbTarefasEntities1 ();


        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           new Form2().Show();
           Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(IsKeyLocked(Keys.CapsLock))
            {
                LabelCapsLock.Visible = true;
            }
            else
            {
                LabelCapsLock.Visible = false;  
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var BuscarUsuario = ctx.Usuario.FirstOrDefault(x => x.Usuario1 == login.Text || x.Email == login.Text);

            if (BuscarUsuario != null )
            {
                MessageBox.Show("Login realizado com sucesso!!!");
                return;
            }

            MessageBox.Show("Usuario ou email incorretos");
        }
    }
}
