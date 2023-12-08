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
    public partial class Form2 : Form
    {
        dbTarefasEntities1 ctx = new dbTarefasEntities1();


        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuarioBuscado = ctx.Usuario.FirstOrDefault(x => x.Email == textBox2.Text);

            if(usuarioBuscado != null)
            {
                MessageBox.Show("Esse email ja existe!!!");
                return;
            }

            Usuario user = new Usuario();
            user.Nome = textBox1.Text;
            user.Email = textBox2.Text; 
            user.Telefone = textBox3.Text;
            user.Usuario1 = textBox4.Text;

            ctx.Usuario.Add(user);
            ctx.SaveChanges();

            MessageBox.Show("Usuario cadastrado com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nomeAleatorio = textBox1.Text + "." + textBox1.Text;
            textBox4.Text = nomeAleatorio;
        }
    }
}
