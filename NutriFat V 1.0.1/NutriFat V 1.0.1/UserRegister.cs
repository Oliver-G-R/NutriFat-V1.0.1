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
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            textBox_mail_rg.MaxLength = 35;
            textBox_pass_rg.MaxLength = 20;
            textBox_veri_rg_pass.MaxLength = 20;

            //
            label_veri_name.Text = "";
            label_veri_last_name.Text = "";
            label_mail.Text = "";
            label_veri_pass.Text = "";
            label_veri_p2.Text = "";
            
        }
        #region import motion modules for windows 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);


        #endregion <----------------------

        #region Events for textbox
        /*Crear los eventos para los textbox, los cuales permitiran quitar o poner el nombre por defecto de cada
         textbox, esto dependiendo de donde se encuentre el puntero*/
        private void textBox_name_Enter(object sender, EventArgs e)
        {
            if (textBox_name.Text == "Nombre")
            {
                textBox_name.Text = "";
                textBox_name.ForeColor = Color.Black;

            }
        }
        private void textBox_name_Leave(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                textBox_name.Text = "Nombre";
                textBox_name.ForeColor = Color.DimGray;

            }
        }
        private void textBox_last_name_Enter(object sender, EventArgs e)
        {
            if (textBox_last_name.Text == "Apellido")
            {
                textBox_last_name.Text = "";
                textBox_last_name.ForeColor = Color.Black;
            }
        }

        private void textBox_last_name_Leave(object sender, EventArgs e)
        {
            if (textBox_last_name.Text == "")
            {
                textBox_last_name.Text = "Apellido";
                textBox_last_name.ForeColor = Color.DimGray;
            }
        }

        private void textBox_mail_rg_Enter(object sender, EventArgs e)
        {
            if(textBox_mail_rg.Text == "Correo")
            {
                textBox_mail_rg.Text = "";
                textBox_mail_rg.ForeColor = Color.Black;
            }
        }

        private void textBox_mail_rg_Leave(object sender, EventArgs e)
        {
            if (textBox_mail_rg.Text == "")
            {
                textBox_mail_rg.Text = "Correo";
                textBox_mail_rg.ForeColor = Color.DimGray;
            }
        }

        //_-----------------------------

        private void textBox_pass_rg_Enter(object sender, EventArgs e)
        {
            if(textBox_pass_rg.Text == "Contraseña")
            {
                textBox_pass_rg.Text = "";
                textBox_pass_rg.ForeColor = Color.Black;
                textBox_pass_rg.UseSystemPasswordChar = true;
            }
        }

        private void textBox_pass_rg_Leave(object sender, EventArgs e)
        {
            if (textBox_pass_rg.Text == "")
            {
                textBox_pass_rg.Text = "Contraseña";
                textBox_pass_rg.ForeColor = Color.DimGray;
                textBox_pass_rg.UseSystemPasswordChar = false;
            }
        }

        private void textBox_veri_rg_pass_Enter(object sender, EventArgs e)
        {
            if(textBox_veri_rg_pass.Text == "Verificar Contraseña")
            {
                textBox_veri_rg_pass.Text = "";
                textBox_veri_rg_pass.ForeColor = Color.Black;
                textBox_veri_rg_pass.UseSystemPasswordChar = true;
            }
        }
        private void textBox_veri_rg_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_veri_rg_pass.Text == "")
            {
                textBox_veri_rg_pass.Text = "Verificar Contraseña";
                textBox_veri_rg_pass.ForeColor = Color.DimGray;
                textBox_veri_rg_pass.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region Function buttons
        private void btn_previous_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        //See passwords

        private void btn_visible_pass_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_pass_rg.UseSystemPasswordChar = false;
            textBox_veri_rg_pass.UseSystemPasswordChar = false;
        }

        private void btn_visible_pass_MouseUp(object sender, MouseEventArgs e)
        {
            if(textBox_pass_rg.Text == "Contraseña" )
            {
                textBox_pass_rg.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pass_rg.UseSystemPasswordChar = true;
            }
            //
            if(textBox_veri_rg_pass.Text == "Verificar Contraseña")
            {
                textBox_veri_rg_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_veri_rg_pass.UseSystemPasswordChar = true;
            }
        }
        //Delete data
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox_name.Text = "\0";
            textBox_last_name.Text = "\0";
            textBox_mail_rg.Text = "\0";
            textBox_pass_rg.Text = "\0";
            textBox_veri_rg_pass.Text = "\0";
            //
            textBox_name.Text = "Nombre";
            textBox_name.ForeColor = Color.DimGray;
            textBox_last_name.Text = "Apellido";
            textBox_mail_rg.Text = "Correo";
            textBox_pass_rg.Text = "Contraseña";
            textBox_pass_rg.UseSystemPasswordChar = false;
            textBox_veri_rg_pass.Text = "Verificar Contraseña";
            textBox_veri_rg_pass.UseSystemPasswordChar = false;
            //
            label_veri_name.Text = "";
            label_veri_last_name.Text = "";
            label_mail.Text = "";
            label_veri_pass.Text = "";
            label_veri_p2.Text = "";

        }
        #endregion

        private void Btn_Create_Ac_Click(object sender, EventArgs e)
        {

            //------------------------------------------
            //------------Clases de utilidad------------
            //------------------------------------------
            Class_VerifyData Cls_VeriData = new Class_VerifyData();  //-> Clase para verificar datos correctos
            //-----------------------------------------------------
            int trueRg, rg_n = 0, rg_lstnme = 0, rg_mail_ = 0, rg_ps = 0, rg_veryPs = 0;

            #region UserName
            if (textBox_name.Text == "Nombre")
            {
                label_veri_name.ForeColor = Color.Red;
                label_veri_name.Text = "Introduce un nombre";
            }else if(textBox_name.Text.Length <=3)
            {
                label_veri_name.ForeColor = Color.Red;
                label_veri_name.Text = "Nombre muy corto";
            }
            else if(Cls_VeriData.Verifica_Nombre_Apellido(textBox_name.Text) == false)
            {
                label_veri_name.ForeColor = Color.Red;
                label_veri_name.Text = "No se permiten #%*! - 123";
            }
            else
            {
                label_veri_name.Text = "";
                rg_n = 1;
            }
            #endregion

            #region LastName
            if(textBox_last_name.Text == "Apellido")
            {
                label_veri_last_name.ForeColor = Color.Red;
                label_veri_last_name.Text = "Introduce un apellido";
            }else if(textBox_last_name.Text.Length <= 3)
            {
                label_veri_last_name.ForeColor = Color.Red;
                label_veri_last_name.Text = "Apellido muy corto";
            }else if(Cls_VeriData.Verifica_Nombre_Apellido(textBox_last_name.Text) == false)
            {
                label_veri_last_name.ForeColor = Color.Red;
                label_veri_last_name.Text = "No se permiten #%*! - 123";
            }
            else
            {
                label_veri_last_name.Text = "";
                rg_lstnme = 1;
            }
            #endregion

            #region Mail
            if(textBox_mail_rg.Text == "Correo")
            {
                label_mail.ForeColor = Color.Red;
                label_mail.Text = "Introduce un correo";
            }else if(Cls_VeriData.Verifica_Correo(textBox_mail_rg.Text) == false)
            {
                label_mail.ForeColor = Color.Red;
                label_mail.Text = "Correo no valido";
            }else
            {
                label_mail.Text = "";
                rg_mail_ = 1;
            }
            #endregion

            #region Password
            if(textBox_pass_rg.Text == "Contraseña")
            {
                label_veri_pass.ForeColor = Color.Red;
                label_veri_pass.Text = "Introduce una contraseña";
            }else if(textBox_pass_rg.Text.Length <= 10)
            {
                label_veri_pass.ForeColor = Color.Red;
                label_veri_pass.Text = "La contraseña debe ser mayor a 10 caracteres";
            }
            else
            {
                label_veri_pass.Text = "";
                rg_ps = 1;
            }
            #endregion

            #region Verify password
            if(textBox_veri_rg_pass.Text == "Verificar Contraseña")
            {
                label_veri_p2.ForeColor = Color.Red;
                label_veri_p2.Text = "!¡";
            }else if(textBox_pass_rg.Text != textBox_veri_rg_pass.Text)
            {
                label_veri_p2.ForeColor = Color.Red;
                label_veri_p2.Text = "Las contraseñas no coinciden";
            }else
            {
                label_veri_p2.Text = "";
                rg_veryPs = 1;
            }
            #endregion

            /*Se muestra la ventana si todo sumo 5 puntos, es decir, si todos los datos han llenado
              correctamente, se mostrara la siguiente ventana*/

            trueRg = rg_n + rg_lstnme + rg_mail_ + rg_ps + rg_veryPs;
            if(trueRg == 5)
            {
                Form1 f1 = new Form1();
              f1.Receive_Data(textBox_mail_rg.Text, textBox_pass_rg.Text);
              f1.ShowDialog();
              this.Hide();
            }




        }

        
    }
}
