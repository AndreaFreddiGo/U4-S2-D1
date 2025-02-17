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

            do
            {
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

                switch (input)
                {
                    case "1":
                        conto += 2.50;
                        break;
                    case "2":
                        conto += 5.20;
                        break;
                    case "3":
                        conto += 10.00;
                        break;
                    case "4":
                        conto += 12.50;
                        break;
                    case "5":
                        conto += 3.50;
                        break;
                    case "6":
                        conto += 8.00;
                        break;
                    case "7":
                        conto += 5.00;
                        break;
                    case "8":
                        conto += 5.00;
                        break;
                    case "9":
                        conto += 6.00;
                        break;
                    case "10":
                        conto += 7.90;
                        break;
                    case "11":
                        Console.WriteLine($"\r\nIl conto totale (più servizio al tavolo di €3.00) è di €{(conto + 3):F2}");
                        break;
                    default:
                        Console.WriteLine("\r\nScelta non valida! Riprova.\r\n");
                        break;
                }
            } while (input != "11");
        }
    }
}
