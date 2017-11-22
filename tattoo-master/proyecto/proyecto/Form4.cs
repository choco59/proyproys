using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
        conexion conexion_bd = new conexion(); 
        private void bunifuImageButton4_Click(object sender, EventArgs e)
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

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (label.Text != ""  && nombreus.Text != "" && apellidous.Text != "" && telefonous.Text != "" && direccionus.Text != "" && telefonous.Text != "" && nickus.Text != "" && passus.Text != "" && pass2us.Text != "")
            {
                if (passus.Text == pass2us.Text)
                {
                    string cadenaencriptada = encriptar.GetMD5(pass2us.Text);
                    pass2us.Text = cadenaencriptada.Trim();
                    string consulta_agregar = "INSERT INTO usuario (id_usuario,password,nombreusu,apellidousu,direccionusu,telefonousu,nickname) VALUES ( "+ Convert.ToInt32(cius.Text) + ",'" + pass2us.Text + "','" + nombreus.Text + "','" + apellidous.Text + "','" + direccionus.Text + "'," + Convert.ToInt32(telefonous.Text) + ",'" + nickus.Text + "')";
                    if (conexion_bd.InsertarDatos(consulta_agregar))
                    {
                        MessageBox.Show("DATOS INSERTADOS");
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("LO SENTIMOS PERO OCURRIO UN ERROR AL INSERTAR LOS DATOS POR FAVOR INTENTE NUEVAMENTE");

                    }
                }
                else
                {
                    MessageBox.Show("LAS CONTRASEÑAS NO COINCIDEN");


                }
            }
            else
            {

                MessageBox.Show("Todos los campos deben ser llenados","PRECAUCION",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Hide();
                
            }
            
        }

        private void pass2us_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nombreus_TextChanged(object sender, EventArgs e)
        {
        }

        private void nombreus_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);

        }

        private void apellidous_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
            
        }

        private void telefonous_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonous_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void nickus_TextChanged(object sender, EventArgs e)
        {

        }

        private void nickus_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
    }
}
