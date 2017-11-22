using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexion conexion_bd = new conexion(); 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            Form3 f7 = new Form3();
            f7.Show();
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=proyectofin; Uid=root; pwd=;");
            conectar.Open();

            string contrase2 = encriptar.GetMD5(password.Text.Trim());
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectados = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = ("SELECT * FROM usuario WHERE nickname ='" + usuario.Text + "' and password = '" + contrase2 + "'");
            MySqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {

                MessageBox.Show(" BIENVENIDO "+usuario.Text);
                Form3 f8 = new Form3();
                f7.Show();

            }
            else
            {
                MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS");
            }

            
            
             
            //string cadenaEncriptada = encriptar.GetMD5(password.Text.Trim());
           // conexion_bd.Autentificar();
            
           
            /*   
            Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
                WindowState = FormWindowState.Maximized;
           
           */
         }  
             
                

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;

            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            
              // button1.Visible = false;
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                conexion_bd.Conectar();
           
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f7 = new Form5();
            f7.Show();
           
        }
    }
}
