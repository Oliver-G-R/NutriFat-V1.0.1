using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriFat_V_1._0._1
{
    public class Class_WeightCalculation
    {

        public double peso, altura;

        public Class_WeightCalculation()
        {
            peso = 0;
            altura = 0;
        }
        public int Calcular_IMC()
        {
            double est, est2, imc;
            est = altura / 100;
            est2 = Math.Pow(est, 2);
            imc = peso / est2;
            //
            int enImc = Convert.ToInt32(imc);
            return enImc;

        }

        public string Calcular_TipoPeso(string genero, int imc)
        {
            if (genero == "M")
            {
                if (imc <= 19)
                {
                    return "Bajo";
                }
                else if (imc >= 20 && imc <= 24)
                {
                    return "Normal";
                } else if (imc >= 24 && imc <= 29)
                {
                    return "Sobrepeso";
                } else if (imc > 29)
                {
                    return "Obecidad";
                }
            } else if (genero == "H")
            {
                if (imc <= 20)
                {
                    return "Bajo";
                }
                else if (imc >= 20 && imc <= 25)
                {
                    return "Normal";
                }
                else if (imc >= 25 && imc <= 30)
                {
                    return "Sobrepeso";
                }
                else if (imc > 30)
                {
                    return "Obecidad";
                }
            }
            return "";
        }

        public int Peso_Ideal(double est, string gen, string max_min)
        {
            //Mujeres
            if (gen == "M" && max_min == "min")   //BUG DE MAXIMOS VALORES PARA EL CONTROLADOR 
            {
                double est100 = est / 100;
                double est2 = Math.Pow(est100, 2);
                double pMin = 19 * est2;
                int intpMin = Convert.ToInt32(pMin);
                return intpMin;

            }else if(gen == "M" && max_min == "max")
            {
                double est100 = est / 100;
                double est2 = Math.Pow(est100, 2);
                double pMin = 24 * est2;
                int intpMin = Convert.ToInt32(pMin);
                return intpMin;
            }
            //Hombres
            if(gen == "H" && max_min == "min")
            {
                double est100 = est / 100;
                double est2 = Math.Pow(est100, 2);
                double pMin = 20 * est2;
                int intpMin = Convert.ToInt32(pMin);
                return intpMin;
            }
            else if(gen == "H" && max_min == "max")
            {
                double est100 = est / 100;
                double est2 = Math.Pow(est100, 2);
                double pMin = 25 * est2;
                int intpMin = Convert.ToInt32(pMin);
                return intpMin;
            }

            return 0;
        }
        
      


    }

}
