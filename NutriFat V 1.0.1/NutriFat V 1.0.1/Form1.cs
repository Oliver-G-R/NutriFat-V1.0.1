using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Agrega movimiento 
namespace NutriFat_V_1._0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            textBox_mail.MaxLength = 35;
                                           /*Su valor máximo de caracteres sera de 15, esto quiere decir
                                            * que ya no se podran introducir más caracteres*/
            textBox_pass.MaxLength = 20;
       
        }
        #region import motion modules for windows 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);
        #endregion <----------------------

        #region Interactivity for windows
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            
        }
       
        private void panel_check_In_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region function buttons
        // Button Exit 
        private void btn_getOut_MouseEnter(object sender, EventArgs e)
        {
            btn_getOut.BackColor = Color.IndianRed;
        }
        private void btn_getOut_MouseLeave(object sender, EventArgs e)
        {
            btn_getOut.BackColor = Color.WhiteSmoke;
        }
        private void btn_getOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button Minimize
        private void btn_Minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimize.BackColor = Color.LightGray;
        }

        private void btn_Minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimize.BackColor = Color.WhiteSmoke;
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Create Account
        private void Btn_Create_Account(object sender, EventArgs e)
        {
            this.panel_check_In.Visible = false;
            
            Open_Child_Form(new UserRegister());
            this.panel_check_In.Visible = true;

        }
        #endregion

        #region textbox function 
        //---------------------------------------------------------------------textBox mail

        /* --> Ambos eventos se estaran alternando dependiendo si la condicion 
         * se llega a cumplir(si esto no se cumple el txt seguira visible)*/
        private void textBox_mail_Enter(object sender, EventArgs e)
        {
            if (textBox_mail.Text == "Correo")
            {
                textBox_mail.Text = ""; /*En este caso si el textBox_mail_Enter es seleccionado y es igual a "Correo"
                                                                           textBox_mail_Enter sera igual a una cadean vacía*/
                textBox_mail.ForeColor = Color.Black;  

            }
        }
                                                                         
        private void textBox_mail_Leave(object sender, EventArgs e)
        {
            if (textBox_mail.Text == "")
            {
                textBox_mail.Text = "Correo"; /*Si textBox_mail_Leave es seleccionado, y el textBox_mail igual a una cadean vacía,
                                                         su valor de txt sera igual a la cadena "Correo"(cdena de txt por defecto)*/
                textBox_mail.ForeColor = Color.DimGray; 

            }
        }
        //-------------------------------------------------------------------textBox Password

        /*En esta parte de aquí se utilizara el mismo método anterior, la diferencia es que ahora 
         * como el dato que se va introducir es una contraseña, se debe hacer uso de la propiedad 
         * UseSystemPasswordChar, para cubrir ese dato, y que solo sea visible cuando el usuario así lo quiera*/
        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "Contraseña")
            {
                textBox_pass.Text = "";
                textBox_pass.ForeColor = Color.Black;
                textBox_pass.UseSystemPasswordChar = true;  
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "")
            {
                textBox_pass.Text = "Contraseña";
                textBox_pass.ForeColor = Color.DimGray;
                textBox_pass.UseSystemPasswordChar = false;
            }
        }

        private void btn_visible_pass_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_pass.UseSystemPasswordChar = false;
        } 
                                                                                     /*--------------------------------------BUG--------------------------------------
                                                                                      * En esta parte se oriigino un bug de txt, el cual cubriía el texto por defecto 
                                                                                      * "Contraseña" ya que aunque el método  textBox_pass_Leave se cumpliera y pusiera
                                                                                      * la propiedad UseSystemPasswordChar como falso, esta no se podía seguir cumpliendo 
                                                                                      * ya que el método btn_visible_pass_MouseUp al ser ejecutado, cambiaba esa misma 
                                                                                      * propiedad a verdadero, lo cual originaba el bug que cubria el texto de "Contraseña"
                                                                                      * por defecto*/
                                                                                      
        private void btn_visible_pass_MouseUp(object sender, MouseEventArgs e)
        {
            if(textBox_pass.Text == "Contraseña")
            {
                textBox_pass.UseSystemPasswordChar = false;
            }else
            {                                                                       /*--------------------------------------SOLUCIÓN--------------------------------------
                                                                                     * Esto se pudo solucionar creando un condicional el cual dijera que si el 
                                                                                     * textBox_pass.Text es igual a "Contraseña", su valor para si mismo sería
                                                                                     * su valor contenido por defecto, en todo caso de que no fuera así, entonces
                                                                                     * la propiedad UseSystemPasswordChar sería verdadera, cubriendo la contraseña
                                                                                     * ingresada*/
                textBox_pass.UseSystemPasswordChar = true;
            }
    
           
        }




        #endregion

        #region Open new form

        //Abrir Formulario hijo
        private Form Form_Active = null;
        private void Open_Child_Form(Form childForm)
        {

            if (Form_Active != null)
            {
                Form_Active.Close();
            }
            Form_Active = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_check_In.Controls.Add(childForm);
            panel_check_In.Tag = childForm;
            //
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion

        //Recibe los datos prueba
        string pass, mail;
        public void Receive_Data(string mailUser, string password)
        {
            this.pass = password;
            this.mail = mailUser;
        }
       

        #region btn_start
        private void button_start_Click(object sender, EventArgs e)
        {

            if (textBox_mail.Text == mail && textBox_pass.Text == pass)
            {
                this.Hide();
                t WigCal = new t();
                WigCal.Show();
            }// -> Dar color a las lineas para advertir que la contraseña y correo no son validos
            else if (textBox_mail.Text != mail)
            {
                lineShape_Correo.BorderColor = Color.Red;
            } else
            {
                lineShape_Correo.BorderColor = Color.Gray;
            }
            //
            if(textBox_pass.Text != pass)
            {
                lineShape_Contraseña.BorderColor = Color.Red;
            }
            else
            {
                lineShape_Correo.BorderColor = Color.Gray;
            }
        }


        #endregion

     
    }
}
