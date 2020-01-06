using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions; // -> Librería para las expresiones regulares
using System.Windows.Forms; // -> Para poder trabajar con eventos a nivel de una clase
namespace NutriFat_V_1._0._1
{
    public class Class_VerifyData
    {
        public string nameUser;
        //Aceptacion para solo letras y espacios 
        public Boolean Verifica_Nombre_Apellido(string nameLast)
        {
            string expre_nom = "^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$";
            return Regex.IsMatch(nameLast, expre_nom);
        }

        //Verifica los datos del correo
        public Boolean Verifica_Correo(string correo_compara)
        {
            string expre = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo_compara, expre))
            {
                if (Regex.Replace(correo_compara, expre, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
      


        //Verifica datos de la contraseña
        public Boolean Verifica_Contraseña_Segura(string correo_compara)
        {
            string expre_pass = "^(?=.*?[A - Z])(?=.*?[a - z])(?=.*?[0 - 9])(?=.*?[#?!@$%^&*-]).{8,}$";
            if (Regex.IsMatch(correo_compara, expre_pass))
            {
                if (Regex.Replace(correo_compara, expre_pass, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /*El siguiente método se encarga de bloquear o no bloquear la introduccion
         * de datos ingresados por el usuario, esto va permitir evitar datos no deseados
         * en el registro.*/
        public void Solo_Numeros(KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar)) //Captura la tecla selecionada del usuario 
            {
                e.Handled = false; //Si es un número se permite seguir introduciendo mas números
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; //Si es la tecla de borra(tecla de control) se permite poder vorra el dato ingresado 
            }
            else
            {
                e.Handled = true; /*Si nada de lo anterior de cumple, ya sea porque se introdujeron letras o caracteres especiales,
                                    no se podran introducir mas datos(retorna true para que no se permita introducir datos y false 
                                                                                            para que estos si se puedan introducir)*/
            }
        }

    }
}
