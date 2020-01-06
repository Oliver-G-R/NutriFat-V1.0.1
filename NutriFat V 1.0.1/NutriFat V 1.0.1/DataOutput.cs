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
    public partial class DataOutput : Form
    {
        public DataOutput()
        {
            InitializeComponent();
        }

        // Variables globales y clases
        Class_WeightCalculation cls_weightC = new Class_WeightCalculation();
        int imc, estatura;
        string genero;
        public void Receive_Data(int RecDta, string gen, int est)
        {
            this.imc = RecDta; /* -> Toma a la variable imc (global) y le asigna el valor que se a recivido de la la forma
                                      WeightCalculation*/
                                                              /*El método se va encargar de recibir los datos que hayan 
                                                               * sido enviados por la forma WeightCalculation*/
            this.genero = gen;
            this.estatura = est;
        }
        private void DataOutput_Load(object sender, EventArgs e)
        {
            Progressbar_IMC.Value = imc;
           
            label_peso_can.Text = cls_weightC.Calcular_TipoPeso(genero, imc);   /* -> Se busca el nombre del tipo de peso, 
                                                                                  deacuerdo al genero y al imc y a su ves
                                                                                  se le asigna ese valor de tipo texto*/
            ProgresBar_Max.Value = cls_weightC.Peso_Ideal(estatura,genero, "max");
            ProgresBar_Min.Value = cls_weightC.Peso_Ideal(estatura,genero, "min");
        }
        #region import motion modules for windows 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);
        #endregion <----------------------

        #region Intractivity for Windows
        private void DataOutput_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Button evets
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
            this.Close();
        }

        //btn minimize
      

        private void btn_Minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_Minimize.BackColor = Color.IndianRed;
        }
        private void btn_Minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_Minimize.BackColor = Color.WhiteSmoke;
        }
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }





        #endregion
    }
}
