using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    internal class Calculator
    {
        public string Beräkna(string input)
        {
            try
            {
                string svar = Split(input);
                return svar.ToString();
            }
            catch
            {
                MessageBox.Show("Beräkna ett tal i taget!");
                return "";
            }
        }
        public string ParantesFörst(string parantes)
        {
            string värdeIParantes = "";
            for (int i = 0; i < parantes.Length; i++)
            {
                if (parantes[i].ToString() == "*")
                {
                    var multisplit = parantes.Split('*');
                    return värdeIParantes = Multiplikation(multisplit);
                }
                if (parantes[i].ToString() == "-")
                {
                    var subsplit = parantes.Split('-');
                    return värdeIParantes = Subtraktion(subsplit);
                }
                if (parantes[i].ToString() == "+")
                {
                    var addsplit = parantes.Split('+');
                    return värdeIParantes = Addition(addsplit);
                }
                if (parantes[i].ToString() == "/")
                {
                    var divsplit = parantes.Split('/');
                    return värdeIParantes = Division(divsplit);
                }
                if (parantes[i].ToString() == "%")
                {
                    var prosplit = parantes.Split('%');
                    return värdeIParantes = Procent(prosplit);
                }
                if (parantes[i].ToString() == "√")
                {
                   
                    var rotsplit = parantes.Split('√');
                    return värdeIParantes = Rotenur(rotsplit[1]);
                }
            }

            return värdeIParantes;
        }
        public string Split(string input)
        {
            string[] beräkna = new string[input.Length];
            if (input.Contains("("))
            {
                var split1 = input.Split('(', ')');
                string a = split1[1]; //detta tar bort paranteser och innehåller endast uträkningen i parantesen
                string b = split1[2]; //innehåller andra delen
                string färdig = ParantesFörst(a);
                färdig += b;

                input = färdig;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "*")
                {
                    beräkna = input.Split('*');
                    return Multiplikation(beräkna);
                }
                if (input[i].ToString() == "+")
                {
                    beräkna = input.Split('+');
                    return Addition(beräkna);
                }
                if (input[i].ToString() == "-")
                {
                    beräkna = input.Split('-');
                    return Subtraktion(beräkna);
                }
                if (input[i].ToString() == "/")
                {
                    beräkna = input.Split('/');
                    return Division(beräkna);
                }
                if (input[i].ToString() == "%")
                {
                    beräkna = input.Split('%');
                    return Procent(beräkna);
                }
                if (input[i].ToString() == "√")
                {
                    beräkna = input.Split('√');
                    return Rotenur(beräkna[1]);
                }
            }
            return "";
        }
        public string Multiplikation(string[] numbers)
        {
            double nr1 = Convert.ToDouble(numbers[0]);
            double nr2 = Convert.ToDouble(numbers[1]);
            var sum = nr1 * nr2;

            return sum.ToString();
        }
        public string Addition(string[] numbers)
        {
            double nr1 = Convert.ToDouble(numbers[0]);
            double nr2 = Convert.ToDouble(numbers[1]);
            double beräkna = nr1 + nr2;
            return beräkna.ToString();
        }
        public string Subtraktion(string[] numbers)
        {
            double nr1 = Convert.ToDouble(numbers[0]);
            double nr2 = Convert.ToDouble(numbers[1]);
            double beräkna = nr1 - nr2;
            return beräkna.ToString();
        }
        public string Division(string[] numbers)
        {
            double nr1 = Convert.ToDouble(numbers[0]);
            double nr2 = Convert.ToDouble(numbers[1]);
            double beräkna = nr1 / nr2;
            return beräkna.ToString();
        }
        public string Procent(string[] numbers)
        {
            double nr1 = Convert.ToDouble(numbers[0]);
            double nr2 = Convert.ToDouble(numbers[1]);
            double beräkna = nr1 * (0.1f) * nr2 * (0.1f);
            return beräkna.ToString();
        }
        public string Rotenur(string number)
        {
            double rotenur = Convert.ToDouble(number);
            string rot = Math.Sqrt(rotenur).ToString();
            return rot.ToString();
        }
    }
}
