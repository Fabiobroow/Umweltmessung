using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitsauftrag_Umweltmessung
{
    class Umweltmessung
    {
        static int[,,] messungen = new int[365,1,1];

        static void Main(string[] args)
        {

            umweltmessungMenu();
            Console.ReadLine();

        }

        static void umweltmessungMenu()
        {
            Umweltmessung um = new Umweltmessung();
            

            Console.WriteLine("Willkommen bei dem Umweltmesser");
            Console.WriteLine("Bitte Wählen sie zwischen folgenden Punkten");
            Console.WriteLine(" _______________________________________________");
            Console.WriteLine("|(1) Messwerte eingeben                         |");
            Console.WriteLine("|(2) Mittelwert Abfragen                        |");
            Console.WriteLine("|(3) Messwerte eines Tages verändern            |");
            Console.WriteLine("|(4) Exportieren der daten                      |");
            Console.WriteLine("|_______________________________________________|");
            int eingabe = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            switch (eingabe)
            {
                case 1:
                    um.messwertEingebe();
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    break;
            }
        }
        public void messwertEingebe()
        {
            Console.WriteLine("Messwerte eingeben");
            int arrayLenght = messungen.Length;
            Console.WriteLine(arrayLenght);

        }
    }
}
