using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calendar.NET;
using MySql.Data.MySqlClient;
using WindowsFormsControlLibrary1;
namespace proyecto
{
    public partial class Form3 : Form
    {
        int pw;
        bool hide;
        int pwx;
       
   
        public Form3()
        {
            
            InitializeComponent();
            
            pw = panel1.Width;
            pwx = panel1.Width - 250;
            hide = false;
            explorador.Dock = DockStyle.Fill;
            explorador.Visible = true;
            WindowState = FormWindowState.Maximized;
            timer2.Enabled = true;
            calendar1.CalendarDate = DateTime.Now;
            calendar1.CalendarView = CalendarViews.Month;
          
            timer1.Start();
            pictureBox1.Visible = false;
            DateTime hoy = DateTime.Now;
            {
                anoscita.Text = hoy.ToString(" dd-MM-yyyy");
                horacita.Text = hoy.ToString("HH:mm");
               
            }           
            MostrarCombo();
            MostrarDatos();
            MostrarDatos1();
            MostrarDatos2();
            
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void MostrarDatos()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT id_almacen as numero,descripcion_producto as Descripcion,tipo_producto as Tipo,cantidad,costo_unidad as Precio FROM almacen", "almacen");
            dataGridView1.DataSource = conexion_bd.ds.Tables["almacen"];
            dataGridView1.Columns["Descripcion"].Visible = false;
            
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectofinDataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.proyectofinDataSet1.usuario);
           
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            explorador.Visible = true;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;
            citas.Visible = false;
            explorador.Dock = DockStyle.Fill;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
           
            inventario.Visible = true;
            explorador.Visible = false;
            inventario.Dock = DockStyle.Fill;
            horarios.Visible = false;
            contactos.Visible = false;
            citas.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Visible = false;

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            horarios.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Dock = DockStyle.Fill;
            contactos.Visible = false;
            citas.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            contactos.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            contactos.Dock = DockStyle.Fill;
            citas.Visible = false;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = false;
            //label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                panel1.Width = panel1.Width + 125;

                if (panel1.Width == pw)
                {
                   
                   
                    pictureBox1.Visible = true;
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                   
                }
            }
            else
            {
                panel1.Width = panel1.Width - 125;
                

                if (panel1.Width == pwx)
                {

                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        private void menusup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuinf_Paint(object sender, PaintEventArgs e)
        {

        }

        private void explorador_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(textBox1.Text);
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            webBrowser2.GoBack();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            webBrowser2.GoForward();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            webBrowser2.GoHome();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if

            ( MessageBox.Show("Seguro que desea cerrar la sesión?", "CERRAR SESIÓN", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
             Form1 f1 = new Form1();
             f1.Show();
             this.Hide();
             
            }
             
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            if
            (MessageBox.Show("Seguro que desea eliminar", "ELIMINAR PRODUCTO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
            
            
            }
        
            
            }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("dato a guardar");
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            
            agregar_cita f5 = new agregar_cita();
            f5.Show();
            
        }

        private void calendar2_Load(object sender, EventArgs e)
        {
            
        }
        
        private void calendar1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void calendar1_Load_2(object sender, EventArgs e)
        {
            
           
            
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            contactos.Visible = true;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            citas.Dock = DockStyle.Fill;
            ctatuajes.Dock = DockStyle.Fill;
            citas.Visible = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctatuajes.Dock = DockStyle.Fill;
           
            ctatuajes.Visible = true;
            ctatuajes.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            contactos.Visible = false;
            explorador.Visible = false;
            inventario.Visible = false;
            horarios.Visible = false;
            ctatuajes.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if

           (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                contactos.Visible = false;
                explorador.Visible = false;
                inventario.Visible = false;
                horarios.Visible = false;
                ctatuajes.Visible = false;

            }
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string consulta_id = "SELECT MAX(id_tatuaje) AS id FROM tatuaje";

            string consulta_agregarcita = "INSERT INTO cita (id_cita,id_usuario,id_cliente,fecha,hora,id_tatuaje) VALUES ( '{1}','" + cicliente.Text + "','" + tatuadorcita.Text + "','" + anoscita.Text + "','" + horacita.Text + ":" + 00 + "',(SELECT MAX(id_tatuaje) FROM tatuaje))";
            //  MessageBox.Show("1");
            //conexion_bd.InsertarDatos(consulta_agregarcita);
          
            string consulta_agregartatuaje = "INSERT INTO tatuaje (id_tatuaje,precio,adelanto,tamano,descripcion_tatuaje,tipo,ubicacion) VALUES ('{1}' ,'" + precio.Text + "','" + adelanto.Text + "','" + tamano.Text + "','" +descripcion.Text + "','" + tipo.Text + "','" + ubicacion.Text + "')";
            //conexion_bd.InsertarDatos(consulta_agregartatuaje);
            //MessageBox.Show("2");

            string consulta_agregarcliente = "INSERT INTO cliente (id_cliente,nombre,apellido,edad,observaciones_clinic) VALUES ( '"+cicliente.Text+"','" + nombrecita.Text + "','" + apellidocita.Text + "','" + edad.Text + "','" +obeservacionescita.Text  + "')";
            //conexion_bd.InsertarDatos(consulta_agregarcliente);
            //MessageBox.Show("3");


            if (conexion_bd.InsertarDatos(consulta_agregarcliente) )
          {
             MessageBox.Show("DATOS INSERTADOS");
               this.Hide();
             if(conexion_bd.InsertarDatos(consulta_agregartatuaje))
             {
                 MessageBox.Show("DATOS INSERTADOS");
                 if (conexion_bd.InsertarDatos(consulta_agregarcita))
                 {
                     MessageBox.Show("DATOS INSERTADOS");
                 }
             }


         }
         else
        {
              MessageBox.Show("LO SENTIMOS PERO OCURRIO UN ERROR AL INSERTAR LOS DATOS POR FAVOR INTENTE NUEVAMENTE");

        }
           
            
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctatuajes.Visible = false;
            ctatuajes.Visible = true;
            ctatuajes.Dock = DockStyle.Fill;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if

         (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                explorador.Visible = true;
                inventario.Visible = false;
                horarios.Visible = false;
                contactos.Visible = false;
                citas.Visible = false;
                explorador.Dock = DockStyle.Fill;  
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calendar1.CalendarView = CalendarViews.Day;
            button10.Visible = false;
            button11.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            calendar1.CalendarView = CalendarViews.Month;
            button11.Visible = false;
            button10.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            agreg_inventario.Visible = false;
            inventario.Visible = true;
            string consulta_agregar = "INSERT INTO almacen VALUES ('{0}','" + descripcion_almacen.Text + "','" + tipo_almacen.Text + "','" + cantidad_almacen.Text + "','" + precio_almacen.Text + "')";
            if (conexion_bd.InsertarDatos(consulta_agregar))
            {
                MessageBox.Show("Datos insertados");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Datos no insertados");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            inventario.Visible = false;
            agreg_inventario.Visible = true;
            agreg_inventario.Dock = DockStyle.Fill;
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if

        (MessageBox.Show("Seguro que desea cancelar?", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                agreg_inventario.Visible = false;
                inventario.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if

       (MessageBox.Show("Seguro que desea eliminar?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {


                if (conexion_bd.EliminarDatos("almacen", "id_almacen = " + id_pro.Text))
                {
                    MessageBox.Show("Datos eliminados");
                    MostrarDatos();
                }
                else
                {
                    MessageBox.Show("Datos no eliminado");
                }
            }
        }
        public void MostrarCombo()
        {
            //metodo para obtener los datos de ciudad en el combo
            conexion_bd.consulta("SELECT * FROM usuario", "usuario");
            tatuadorcita.DataSource = conexion_bd.ds.Tables["usuario"];
            tatuadorcita.DisplayMember = "nickname";
            tatuadorcita.ValueMember = "id_usuario";
        }
        

        private void calendar1_Load_3(object sender, EventArgs e)
        {
            var ce2 = new CustomEvent
            {
                IgnoreTimeComponent = false,
                EventText = "Tatuaje",
                Date = new DateTime(2017, 11, 14, 18, 0, 0),
                EventLengthInHours = 2f,
                RecurringFrequency = RecurringFrequencies.None,
                EventFont = new Font("Verdana", 12, FontStyle.Regular),
                Enabled = true,
                EventColor = Color.FromArgb(120, 255, 120),
                EventTextColor = Color.Black,
                ThisDayForwardOnly = false
            };
            calendar1.AddEvent(ce2);


            var ce3 = new CustomEvent
            {
                IgnoreTimeComponent = false,
                EventText = "Piercing",
                Date = new DateTime(2017, 11, 15, 19, 0, 0),
                EventLengthInHours = 2f,
                RecurringFrequency = RecurringFrequencies.None,
                EventFont = new Font("Verdana", 12, FontStyle.Regular),
                Enabled = false,
                EventColor = Color.FromArgb(120, 255, 120),
                EventTextColor = Color.Black,
                ThisDayForwardOnly = false
            };
            calendar1.AddEvent(ce3); 
            

        }

        private void anocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void mescita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void diacita_TextChanged(object sender, EventArgs e)
        {

        }

        private void diacita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void horacita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void minutocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void cicliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void nombrecita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void apellidocita_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView1.Rows[e.RowIndex];
            descripcion_producto.Text = registro.Cells["descripcion_producto"].Value.ToString();
            precio_unidad.Text = registro.Cells["costo_unidad"].Value.ToString();
            cantidad_producto.Text = registro.Cells["cantidad"].Value.ToString();
            id_pro.Text = registro.Cells["id_almacen"].Value.ToString();
            
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boton para actualizar datos
            string actualizar = "descripcion_producto='" + descripcion_producto.Text + "', costo_unidad= '" + precio_unidad.Text + "',cantidad='" + cantidad_producto.Text + "'";
            if (conexion_bd.ActualizarDatos("almacen", actualizar, "id_almacen=" + id_pro.Text.Trim()))
            {
                MessageBox.Show("Datos actualizados");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("Datos no actualizados");

            }
        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //boton para actualizar datos
                string actualizar = "nombreusu='" +nom.Text + "', apellidousu= '" + app.Text + "',direccionusu='" + dirc.Text + "', telefonousu= '" + telef.Text + "'";
                if (conexion_bd.ActualizarDatos("usuario", actualizar, "id_usuario=" + idd.Text))
                {
                    MessageBox.Show("Datos actualizados");
                 
                    MostrarDatos1();
                }
                else
                {
                    MessageBox.Show("Datos no actualizados");

                }
            }
        }
        public void MostrarDatos1()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT id_usuario,password,nombreusu as Nombre,apellidousu as Apellido,direccionusu as Direccion,telefonousu as Telefono,nickname FROM usuario", "usuario");
            dataGridView4.DataSource = conexion_bd.ds.Tables["usuario"];
            dataGridView4.Columns["id_usuario"].Visible = false;
            dataGridView4.Columns["password"].Visible = false;
            dataGridView4.Columns["nickname"].Visible = false;

        }
        public void MostrarDatos2()
        {
            //metodo para mostrar datos
            conexion_bd.consulta("SELECT id_cliente,nombre as Nombre,apellido as Apellido,edad,observaciones_clinic FROM cliente", "cliente");
            dataGridView5.DataSource = conexion_bd.ds.Tables["cliente"];
            dataGridView5.Columns["id_cliente"].Visible = false;
            dataGridView5.Columns["edad"].Visible = false;
            dataGridView5.Columns["observaciones_clinic"].Visible = false;

        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView4.Rows[e.RowIndex];
            nom.Text = registro.Cells["Nombre"].Value.ToString();
            app.Text = registro.Cells["Apellido"].Value.ToString();
            dirc.Text = registro.Cells["Direccion"].Value.ToString();
            telef.Text = registro.Cells["Telefono"].Value.ToString();
            idd.Text = registro.Cells["id_usuario"].Value.ToString();
            label8.Visible = true;
            dirc.Visible = true;
            tel.Visible = true;
            telef.Visible = true;
            edd.Visible = false;
            eddt.Visible = false;
            b1.Visible = true;
            b2.Visible = false;
            
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //forma para obtener los registros en los campos al dar click sobre un registro
            DataGridViewRow registro = dataGridView5.Rows[e.RowIndex];
            nom.Text = registro.Cells["Nombre"].Value.ToString();
            app.Text = registro.Cells["Apellido"].Value.ToString();
            idd.Text = registro.Cells["id_cliente"].Value.ToString();
            eddt.Text = registro.Cells["edad"].Value.ToString();
            dirc.Visible=false;
            label8.Visible = false;
            tel.Visible = false;
            telef.Visible = false;
            edd.Visible = true;
            eddt.Visible = true;
            b1.Visible = false;
            b2.Visible = true;

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea guardar los cambios?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //boton para actualizar datos
                string actualizar = "nombre='" + nom.Text + "', apellido= '" + app.Text + "'";
                if (conexion_bd.ActualizarDatos("cliente", actualizar, "id_cliente=" + idd.Text))
                {
                    MessageBox.Show("Datos actualizados");

                    MostrarDatos2();
                }
                else
                {
                    MessageBox.Show("Datos no actualizados");

                }
            }
        }

        private void nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void app_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void telef_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void eddt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void tamano_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloLetras(e);
        }

        private void adelanto_TextChanged(object sender, EventArgs e)
        {

        }

        private void adelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }
       
    }
}
