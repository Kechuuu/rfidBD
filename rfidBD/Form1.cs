using AForge.Video;
using AForge.Video.DirectShow;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace rfidBD
{
    public partial class Form1 : KryptonForm

    {
        string[] arregloPuertos; //Arreglo para los puertos
        SerialPort puerto;
        string datosPuerto;
        string sendDatos;
        Timer temporizador;
        public Form1()
        {
            InitializeComponent();

            puerto = new SerialPort(); //Constructor Puerto Serial
            // Enumeracion 
            puerto.DataReceived += Puerto_DataReceived;
            temporizador = new Timer();
            temporizador.Interval = 500;
            temporizador.Enabled = true;
            temporizador.Start();

            /*Form1 obtencionForm1 = new Form1();
            AddOwnedForm(obtencionForm1);
            obtencionForm1.pu*/

        }
        
        

        private void ProcessingData() //obtencion de datos del puerto
        {
           
            datosPuerto = puerto.ReadLine();
            //txt_uid.Text = datosPuerto.ToString();
            
        }
        private void SendData()
        {
            sendDatos = txt_nombre.Text;
            puerto.Write(sendDatos);
            
        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)//Metodo generado parea recibir datos
        {
            this.Invoke(new Action(ProcessingData));
        }

        class Conexion //crea la conexion con la base de datos
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

        private void button1_Click(object sender, EventArgs e) //agregar usuario        
            {
            String confirmacion = "";
            if (txt_nombre.Text != string.Empty && txt_tel.Text != string.Empty && txt_uid.Text != string.Empty && combobox.Text != string.Empty)
            {
                
                string marcaInicio = "@";
                string marcaFinal = "&";
                string marcaDeAcceso = "#";

                try
                {
                   // MessageBox.Show("coloca la tarjeta sobre el scanner"); arduino

                    if (combobox.Text == "ALTO")
                    {
                        NivelUsuario = "1";
                    }
                    if (combobox.Text == "MEDIO")
                    {
                        NivelUsuario = "2";
                    }
                    if (combobox.Text == "BAJO")
                    {
                        NivelUsuario = "3";
                    }
                    MessageBox.Show("Coloca la tarjeta en el lector");

                    string nombreClave = txt_nombre.Text.Substring(0, 12);

                    CodigoUsuario = string.Concat(marcaInicio, NivelUsuario, nombreClave, marcaFinal, marcaDeAcceso);

                   // MessageBox.Show(CodigoUsuario);

                    puerto.Write("1\r\n");
                    puerto.Write(CodigoUsuario+"\r\n");
                    puerto.Write("2\r\n");
                    confirmacion = puerto.ReadTo("']");
                   // MessageBox.Show(confirmacion);


                    //codigo arduino
                    /* puerto.Write("1");
                    //txt_nombre.Text = puerto.ReadTo("#");
                    puerto.Write(CodigoUsuario);

                    MessageBox.Show("retire la tarjeta y vuelvela a colocar para la lecura comparacion del codigo");

                    puerto.Write("3");
                    status = puerto.ReadTo("&");
                   // MessageBox.Show("Su codigo clave de la tarjeta es: "+ status.Trim());*/

                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Puerto cerrado"+ex.Message);
 
                        //     String CodigoVerificacion = CodigoUsuario.Substring(0, 15); // variable que compara el codigo escrito con el codigo recibido

                    }

                    //***************************************************************************************************************************************
                    //formato de coonversion para la imagen de .peg a byte

                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] aByte = ms.ToArray();
                    MySqlConnection conexionBD = Conexion.conexion(); //abre puerto de conexion
                    conexionBD.Open();


                

               // string CodigoReal = String.Concat(CodigoUsuario.Substring(0,14).Where(c => !Char.IsWhiteSpace(c))); // quita todo los espacios en blanco dejando una sola cadena 


                if (confirmacion.Contains(CodigoUsuario))
                    {

                        //sube los datos del usuario a la base de datos  
                        try
                        {
                            MySqlCommand comando = new MySqlCommand("INSERT INTO datos (uid,nombre,fechaderegistro,niveldeacceso,telefono,Foto) VALUES ('" + txt_uid.Text + "','" + txt_nombre.Text + "','" + DateTime.Now.ToString("d") + "','" + combobox.SelectedItem.ToString() + "','" + txt_tel.Text + "',@Foto)", conexionBD);
                            comando.Parameters.AddWithValue("Foto", aByte);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("USUARIO REGISTRADO");
                            pictureBox2.Image = null;
                            pictureBox1.Image = null;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error " + ex.Message);
                        }


                    }
                    else { MessageBox.Show("No se grabaron los datos"); }
                }
                else
                {
                    MessageBox.Show("Datos insuficientes, rellene todos los espacios");
                }
            }
            




        private void button2_Click_1(object sender, EventArgs e) //busca los datos del usuario en la base de datos y los muestra 
        {

            //puerto.Close();
            this.Close();
            Form2 registro = new Form2();
            registro.Show();
        }

        

        private VideoCaptureDevice cam = new VideoCaptureDevice();
        private FilterInfoCollection miDispositivo = null;
        private VideoCaptureDevice miWebcam;


        private void cerrar(object sender, EventArgs e)
        {
            cerrarWebcam();
        }

        private void cargaDispositivo() //ingresa a la camara
        {
            cerrarWebcam();
           
            miDispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (miDispositivo.Count > 0)
            {
                
                for (int i = 0; i < miDispositivo.Count; i++)
                {
                    cb1.Items.Add(miDispositivo[i].Name.ToString());
                    cb1.Text = miDispositivo[0].ToString();


                }
            }
        }
        private void capturarFoto() //clase de captura de la foto
        {
            try
            {
                int i = cb1.SelectedIndex;
                string nombreDispositivo = miDispositivo[i].MonikerString;
                miWebcam = new VideoCaptureDevice(nombreDispositivo);
                miWebcam.NewFrame += new NewFrameEventHandler(capturando);
                miWebcam.Start();
            }
            catch { MessageBox.Show("Camara incorrecta"); }
        }

        private void capturando(object sender, NewFrameEventArgs e) //conversion de datos de la imagen a imagen visual
        {
            Bitmap f = (Bitmap)(e.Frame.Clone());
            pictureBox1.Image = f;
        }

        private void cerrarWebcam() //cierra la camara
        {
            if (miWebcam != null && miWebcam.IsRunning)
            {
                miWebcam.SignalToStop();
                miWebcam = null;
            }
        }

        private void tomarFoto() //toma la imagen de la camara y la captura
        {
            if (miWebcam != null && miWebcam.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
            }
        }

        private void btnCamara_Click(object sender, EventArgs e) //el metodo click de la boton de la screen
        {
            capturarFoto();

        }

        private void btnCaptura_Click(object sender, EventArgs e)//el metodo click de la boton de la camara
        {
            tomarFoto();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(cerrar);
            cargaDispositivo();
        }

        private void kryptonPalette1_PalettePaint(object sender, ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nombre_Enter(object sender, EventArgs e) //limpia el text box de user
        {
            txt_nombre.Text = string.Empty;
        }

        private void txt_uid_Enter(object sender, EventArgs e) //limpia text box de UID
        {
            txt_uid.Text = string.Empty;
        }

        private void txt_tel_Enter(object sender, EventArgs e)//limpia text box de telefono
        {
            txt_tel.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)//cierra el Formulario
        {
            Application.Exit();

        }

        private void cb_puerto_SelectedIndexChanged(object sender, EventArgs e) //seleccion de puertos
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
       /* private void btn_conectar_DoubleClick(object sender, EventArgs e)
        {
            btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__7_;
            puerto.Close();
        }*/

        private void btn_conectar_Click(object sender, EventArgs e) //conexion a los puertos
        {
            try
            {
                
                              
               // btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__8_;
               
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

                    }catch(Exception ex) { MessageBox.Show("Error " + ex.Message); }
                }

                /*else
                 {
                     if (cb_Puertos.SelectedItem != null)
                     {
                         puerto.PortName = cb_Puertos.SelectedItem.ToString();
                         puerto.Open();
                         ProcessingData();
                         btn_conectar.Image = global::rfidBD.Properties.Resources.Diseño_sin_título__8_;
                     }

                 }*/
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        int m, mx, my;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        String CodigoUsuario = "";
        String NivelUsuario = "";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string marcaInicio = "@";
                string marcaFinal = "&";
                string marcaDeAcceso = "#";

                if (combobox.Text == "ALTO")
                {
                    NivelUsuario = "1";
                }
                if (combobox.Text == "MEDIO")
                {
                    NivelUsuario = "2";
                }
                if (combobox.Text == "BAJO")
                {
                    NivelUsuario = "3";
                }

                string nombreClave = txt_nombre.Text.Substring(0, 12);

                CodigoUsuario = string.Concat(marcaInicio, NivelUsuario, nombreClave, marcaFinal, marcaDeAcceso);

                MessageBox.Show(CodigoUsuario);

                puerto.Write("1");
                //txt_nombre.Text = puerto.ReadTo("#");
                puerto.Write(CodigoUsuario);
            } catch(Exception ex)
            {
                MessageBox.Show("Puerto cerrado"+ex.Message);
            }

        }

       

        public void pictureBox5_Click(object sender, EventArgs e)
        {

            String confirmacion = "";
            MessageBox.Show("Coloca la tarjeta");
            try
            {
                puerto.Write("2\r\n");
                confirmacion = puerto.ReadTo("']");
                int uidIndex = confirmacion.IndexOf("UID      : ");
                string uid = confirmacion.Substring(uidIndex + 11, 8);
                txt_uid.Text = uid; 

            }
            catch (Exception ex) { 
                MessageBox.Show("Puerto cerrado"+ex.Message); }
        }

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}



