using System;
using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rfidBD
{
    public partial class Form3 : KryptonForm
    {
        public Form3()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //movimiento del formulario
        int m, mx, my;

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int errorUsuario = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_user.Text == "Nas" && txt_password.Text == "Nas12345")
                {
                    
                    this.Hide();
                    Form1 open = new Form1();
                    open.Show();
                }
                else
                {
                    if (txt_user.Text != "Nas")
                    {

                        errorUsuario = 1;
                    }
                    else
                    {
                        errorUsuario = 2;
                    }

                    switch (errorUsuario)
                    {
                        case 1:
                            MessageBox.Show("Usuario incorrecto");
                            break;
                        case 2:
                            MessageBox.Show("Contraseña incorrecta");
                            break;
                        default:
                            break;
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            
        }
        int mp = 0;

        private void btn_verPassword_Click(object sender, EventArgs e)
        {
            

            if (mp == 1)
            {
                txt_password.PasswordChar = '*';
                btn_verPassword.Image = rfidBD.Properties.Resources._1;
                mp = 0;
            }
            else
            {
                txt_password.PasswordChar = '\0';
                btn_verPassword.Image = rfidBD.Properties.Resources._2;
                mp = 1;
            }
            
            
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }


    }
}
