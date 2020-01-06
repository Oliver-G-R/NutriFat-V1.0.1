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
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }

        Class_VerifyData cls_veryDt = new Class_VerifyData(); //Clase utilizada de manera global
        private void Weightcalculation_Load(object sender, EventArgs e)
        {
            
        }
        #region import motion modules for windows 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);
        #endregion <----------------------

        private void Weightcalculation_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Functions Textbox
        //Txt Altura
        private void Textbox_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_veryDt.Solo_Numeros(e);
        }
        private void Textbox_Altura_Enter(object sender, EventArgs e)
        {
            if(Textbox_Altura.Text == "0")
            {
                Textbox_Altura.Text = "";
            }
        }
        private void Textbox_Altura_Leave(object sender, EventArgs e)
        {
            if (Textbox_Altura.Text == "")
            {
                Textbox_Altura.Text = "0";
            }
        }

        //Txt Peso
        private void Textbox_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            cls_veryDt.Solo_Numeros(e);
        }
        private void Textbox_Peso_Enter(object sender, EventArgs e)
        {
            if(Textbox_Peso.Text == "0")
            {
                Textbox_Peso.Text = "";
            }
        }
        private void Textbox_Peso_Leave(object sender, EventArgs e)
        {
            if (Textbox_Peso.Text == "")
            {
                Textbox_Peso.Text = "0";
            }
        }


        #endregion

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            int Altura;
            int Peso;
            if (Textbox_Altura.Text == "" || Textbox_Peso.Text == "")
            {
                Altura = 0;
                Peso = 0;
            }
            else
            {
                Altura = Convert.ToInt32(Textbox_Altura.Text);
                Peso = Convert.ToInt32(Textbox_Peso.Text);
            }
            
            if (Altura >= 100 && Altura <= 300 && Peso >=50 && Peso <= 200)
            {
                DataOutput DtO = new DataOutput();

                Class_WeightCalculation cls_weigCal = new Class_WeightCalculation();
                cls_weigCal.altura = Altura;
                cls_weigCal.peso = Peso;

                //-----------
                string genero;
                if (radioButton_hombre.Checked == true)
                {
                    genero = "H";
                }
                else if (radioButton_mujer.Checked == true)
                {
                    genero = "M";
                }
                else
                {
                    genero = "";
                }
                //--------
                DtO.Receive_Data(cls_weigCal.Calcular_IMC(), genero, Altura); // -> Mandando los datos al método del form DataOutput
                DtO.ShowDialog();
            }
            
           
         
           
        }
        //Radio btns

       
    }
}
