using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Text;

namespace rfidBD
{
    public partial class Form2 : KryptonForm
    {
        string[] arregloPuertos;
        SerialPort puerto;
        
       // Timer temporizador;
        public Form2()
        {
            InitializeComponent();

            puerto = new SerialPort();
            puerto.BaudRate = 9600;
            puerto.DataBits = 8;
            puerto.StopBits = StopBits.One;
            puerto.Parity = Parity.None;

        }
       /* private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)//Metodo generado parea recibir datos
        {
            this.Invoke(new Action(ProcessingData));
        }
        private void ProcessingData() //obtencion de datos del puerto
        {
            string datosRecibidos = puerto.ReadLine();
            string datosFormateados = System.Text.Encoding.ASCII.GetString(System.Text.Encoding.ASCII.GetBytes(datosRecibidos));
            this.Invoke((MethodInvoker)delegate
            {
                txt_uid1.Text += datosFormateados;
            });
        }*/
        class Conexion
        {
            public static MySqlConnection conexion()
            {
                string servidor = "192.168.1.92";
                string bd = "rfidbd";
                string usuario = "usuario";
                string password = "Nas12345";

                string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";

                try
                {
                    MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                    return conexionBD;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return null;
                }
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {


        }

        private void buttonverificar_Click(object sender, EventArgs e)
        {
            try
            {

                tabla_form2.Rows.Clear();

                string sql = ("select uid,nombre,fechaderegistro,niveldeacceso,telefono,foto  from datos WHERE uid= '" + txt_uid1.Text + "'"); //selecciona el dato de la tarjeta para buscar los datos 
                MySqlConnection conexionBD = Conexion.conexion(); //abre el puerto para obtener los datos 
                conexionBD.Open();
                MySqlCommand comando1 = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexionBD); //crea el sistema de conexion
                MySqlDataReader reader = comando1.ExecuteReader();
                DataTable dt = new DataTable(); //hace el arreglo en la base de datos
            
                if (reader.HasRows)
                {

                    reader.Read();
                    MemoryStream ms = new MemoryStream((byte[])reader["foto"]); // crea la instancia para obtenor los bytes de la foto



                    Bitmap bm = new Bitmap(ms); // obtiene la foto a .peg
                    pictureBox3.Image = bm; //la muestra 
                    
                    

                }
                else
                {
                   MessageBox.Show("No se encontraron registros");
                }
                conexionBD.Close();
                adaptador.Fill(dt);

                // MessageBox.Show(string.Format("uid = {0} nombre: {1} fechaderegistro: {2} niveldeacceso: {3} telefono: {4}", dt.Rows[0].ItemArray[0].ToString(), dt.Rows[0].ItemArray[1].ToString(), dt.Rows[0].ItemArray[2].ToString(), dt.Rows[0].ItemArray[3].ToString(), dt.Rows[0].ItemArray[4].ToString()));

                string UID = dt.Rows[0].ItemArray[0].ToString();
                string Nombre = dt.Rows[0].ItemArray[1].ToString();
                string fecha = dt.Rows[0].ItemArray[2].ToString();
                string acceso = dt.Rows[0].ItemArray[3].ToString();
                string telefono = dt.Rows[0].ItemArray[4].ToString();






                /*lbNombre.Text   ="Nombre del usuario    "+Nombre;
                lbFecha.Text    ="Fecha de su registro  "+fecha;
                lbAcceso.Text   ="Nivel de acceso       "+acceso;
                lbTelefono.Text ="Numero de telefono    "+telefono;*/

                /* columna_acces.HeaderText = acceso;
                 columna_nombre.ToolTipText = fecha;
                 Columna_uid.ToolTipText = UID;
                 columna_telefono.ToolTipText = telefono;
                 Columna_Fecha.ToolTipText = fecha;*/

                /*tabla.Rows.Clear();

                tabla.Rows.Add(UID,Nombre,fecha,acceso,telefono);*/

                tabla_form2.Rows.Add(UID, Nombre, fecha, acceso, telefono);




            }

            catch (Exception ex)
            {
               // MessageBox.Show("Error " + ex.Message );
            }
        }

      /* private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();

                /*serialPort1.Close();
                txt_uid1.Text = entrada;
                //txt_uid1.Text = serialPort1.ReadLine();
            }catch(Exception ex)
            {
                MessageBox.Show("puerto cerrado "); 
            }
        }*/

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            puerto.Close();
            this.Hide();
            Form1 mostrar = new Form1();
            mostrar.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "DELETE FROM datos where uid = '" + txt_uid1.Text + "'" ; 
                MySqlConnection conexionBD = Conexion.conexion(); //abre el puerto para obtener los datos 
                conexionBD.Open();

                MySqlCommand comando1 = new MySqlCommand(sql, conexionBD);
                comando1.ExecuteNonQuery();
                MessageBox.Show("eliminado");
                conexionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message + ex.StackTrace);
            }
            
        }

        //movimiento del formulario
        int m, mx, my;
       

        private void Form2_MouseDown_1(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txt_uid1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cb_Puertos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort puertoSalida = new SerialPort();
        }

        private void cb_Puertos_DropDown(object sender, EventArgs e)
        {
            cb_Puertos.Items.Clear();
            arregloPuertos = SerialPort.GetPortNames(); // Metodo que regtresa un array con los puertos seriales en string
            foreach (string element_nombrePort in arregloPuertos)
            {
                cb_Puertos.Items.Add(element_nombrePort);
            }
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {


                if (puerto.IsOpen)
                {
                    puerto.Close();
                    btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
                    MessageBox.Show("Puerto cerrado");
                }
                else
                {
                    try
                    {
                        puerto.PortName = cb_Puertos.SelectedItem.ToString();
                        puerto.Open();
                        puerto.DtrEnable = true;

                        // ProcessingData();
                        btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__8_;
                        MessageBox.Show("Puerto abierto");

                    }
                    catch (Exception ex) { MessageBox.Show("Error " + ex.Message); }
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            String confirmacion = "";
            MessageBox.Show("Coloca la tarjeta");
            try
            {
                puerto.Write("2\r\n");
                confirmacion = puerto.ReadTo("']");
                int uidIndex = confirmacion.IndexOf("UID      : ");
                string uid = confirmacion.Substring(uidIndex + 11, 8);
                txt_uid1.Text = uid;

            }
            catch (Exception ex) { MessageBox.Show("Puerto cerrado" + ex.Message); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_MouseUp_1(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Form2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

    }
}
