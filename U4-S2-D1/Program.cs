using System.Runtime.CompilerServices;

namespace U4_S2_D1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Menù();
        }

        static void Menù()
        {
            double conto = 0;
            string input;

            var menuItems = new Dictionary<string, double>
                {
                    { "1", 2.50 },
                    { "2", 5.20 },
                    { "3", 10.00 },
                    { "4", 12.50 },
                    { "5", 3.50 },
                    { "6", 8.00 },
                    { "7", 5.00 },
                    { "8", 5.00 },
                    { "9", 6.00 },
                    { "10", 7.90 }
                };

        Start:
            Console.WriteLine("==============MENU==============" +
            "\r\n\r\n1:  Coca Cola 150 ml (€ 2.50)" +
            "\r\n\r\n2:  Insalata di pollo (€ 5.20)" +
            "\r\n\r\n3:  Pizza Margherita (€ 10.00)" +
            "\r\n\r\n4:  Pizza 4 Formaggi (€ 12.50)" +
            "\r\n\r\n5:  Pz patatine fritte (€ 3.50)" +
            "\r\n\r\n6:  Insalata di riso (€ 8.00)" +
            "\r\n\r\n7:  Frutta di stagione (€ 5.00)" +
            "\r\n\r\n8:  Pizza fritta (€ 5.00)" +
            "\r\n\r\n9:  Piadina vegetariana (€ 6.00)" +
            "\r\n\r\n10: Panino Hamburger (€ 7.90)" +
            "\r\n\r\n11: Stampa conto finale e conferma" +
            "\r\n\r\n==============MENU==============");

            Console.WriteLine("\r\nSelezionare il prodotto dal menù o digitare 11 per la stampa del conto:\r\n");
            input = Console.ReadLine();

            if (menuItems.ContainsKey(input))
            {
                conto += menuItems[input];
                goto Start;
            }
            else if (input == "11")
            {
                Console.WriteLine($"\r\nIl conto totale (più servizio al tavolo di €3.00) è di €{(conto + 3):F2}");
            }
            else
            {
                Console.WriteLine("\r\nScelta non valida! Riprova.\r\n");
                goto Start;
            }
        }
    }
}
