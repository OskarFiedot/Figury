using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// klasa Figury, po której dziedziczą klasy Kwadrat, Okrag oraz Trojkat, implementujące dodatkowo jedynie swój wygląd

namespace Figury
{
    public abstract partial class Figura : PictureBox
    {
        protected Point OriginalLocation { get; set; }  //zmienna przechowująca oryginalną lokalizację figury
        public bool Compared { get; set; }  //zmienna używana w celu zaznaczenia, że dana figura znajduje się w porównywarce
        public double Number { get; protected set; }    //zmienna przechowująca liczbe, przypisaną do danej figury
        public string StrNumber { get; protected set; } //zmienna przechowująca sposób zapisu liczby, przypisanej do danej figury
        public static List<double> ListOfNumbers { get; protected set; }    //lista wygenerowanych liczb, dla wszystkich figur

        public Figura()
        {
            InitializeComponent();
            ControlExtension.Draggable(this, true); // Funkcja, pochodząca z NuGeta "Control.Draggable" autorstwa użytkownika intruder, umożliwiająca przeciąganie myszką obiektów
            ListOfNumbers = new List<double>();
            this.BackColor = Color.Transparent; 
            this.Compared = false;
        }

        public void MoveToOriginalLocation()   // funkcja przenosi figurę do oryginalnej pozycji
        {
            Compared = false;
            this.Location = OriginalLocation;
        }

        public void SetOryginalLocation(Point p)    //Ustawienie oryginalnej pozycji figury
        {
            OriginalLocation = p;
        }

        public static void ClearListOfNumbers() //Czyszczenie listy wygenerowanych liczb
        {
            ListOfNumbers.Clear();
        }

        public void DrawNumber(int poziom)  // Funkcja generująca liczbe i jej sposób zapisu dla figury, na podstawie aktualnego poziomy rozgrywki
        {
            Random r = new Random();

            do
            {
                switch (poziom)
                {
                    case 1:
                        int n1 = r.Next(0, 1000);
                        Number = n1;
                        StrNumber = Number.ToString();
                        break;

                    case 2:
                        n1 = r.Next(1, 10);
                        int n2 = 10;
                        Number = (double)n1 / (double)n2;
                        if (r.Next(0, 1000) < 500)
                        {
                            StrNumber = $"{n1}/{n2}";
                        }
                        else
                        {
                            StrNumber = Math.Round(Number, 3).ToString();
                        }
                        break;

                    case 3:
                        do
                        {
                            n1 = r.Next(1, 100);
                            n2 = r.Next(1, 100);
                        } while (n1 >= n2);
                        Number = (double)n1 / (double)n2;
                        if (r.Next(0, 1000) < 500)
                        {
                            StrNumber = $"{n1}/{n2}";
                        }
                        else
                        {
                            StrNumber = Math.Round(Number, 3).ToString();
                        }
                        break;

                    case 4:
                        n1 = r.Next(1, 10);
                        n2 = r.Next(0, 5);
                        Number = Math.Pow(n1, n2);
                        if (r.Next(0, 1000) < 500 || n2 <= 1)
                        {
                            StrNumber = $"{n1}^{n2}";
                        }
                        else
                        {
                            StrNumber = $"{n1}";
                            for (int i = 0; i < n2 - 1; i++)
                            {
                                StrNumber += $"*{n1}";
                            }
                        }
                        break;

                    case 5:
                        n1 = r.Next(1, 10);
                        n2 = r.Next(2, 7);
                        int los = r.Next(0, 1000);
                        if (los < 300)
                        {
                            Number = Math.Pow(n1, n2);
                            StrNumber = $"{n1}^{n2}";
                        }
                        else if (los < 400)
                        {
                            Number = Math.Pow(n1, n2);
                            StrNumber = $"{n1}";
                            for (int i = 0; i < n2 - 1; i++)
                            {
                                StrNumber += $"*{n1}";
                            }
                        }
                        else
                        {
                            Number = 1;
                            for (int i = 2; i <= n2; i++)
                            {
                                Number *= i;
                            }
                            StrNumber = $"{n2}!";
                        }
                        break;

                    case 6:
                        n1 = r.Next(1, 10);
                        do
                        {
                            n2 = r.Next(-9, 9);
                        } while (n2 == 0 || n2 == 1);
                        Number = n1 * Math.Pow(10, n2);
                        StrNumber = $"{n1} * 10^{n2}";
                        break;

                    case 7:
                        n1 = r.Next(2, 15);
                        n2 = r.Next(2, 15);
                        Number = n1 * n2;
                        StrNumber = $"{n1} * {n2}";
                        break;

                    case 8:
                        n1 = r.Next(2, 10);
                        n2 = r.Next(2, 5);
                        Number = n2;
                        StrNumber = $"log{n1}({Math.Pow(n1, n2)})";
                        break;

                    case 9:
                        n1 = r.Next(3, 10);
                        n2 = r.Next(3, 10);
                        int n3 = r.Next(2, 5);
                        los = r.Next(1, 1000);
                        if (los < 333)
                        {
                            Number = n1 * Math.Pow(n2, n3);
                            StrNumber = $"{n1}*{n2}^{n3}";
                        }
                        else if (los < 666)
                        {
                            Number = Math.Pow(n1+n2, n3);
                            StrNumber = $"({n1}+{n2})^{n3}";
                        }
                        else
                        {
                            Number = Math.Pow((double)n1/(double)n2, n3);
                            StrNumber = $"({n1}/{n2})^{n3}";
                        }
                        break;

                    case 10:
                        n1 = r.Next(3, 10);
                        n2 = r.Next(3, 8);
                        n3 = r.Next(2, 5);
                        los = r.Next(1, 1000);
                        if (los < 333)
                        {
                            Number = n1 * Math.Pow(n2, n3);
                            StrNumber = $"{n1}*{n2}^{n3}";
                        }
                        else if (los < 666)
                        {
                            int silnia = 1;
                            for (int i = 2; i <= n2; i++)
                            {
                                silnia *= i;
                            }
                            Number = (double)silnia / (double)(n1 * n3);
                            StrNumber = $"{n2}!/({n1}*{n3})";
                        }
                        else 
                        {
                            Number = Math.Pow(n2, n3);
                            StrNumber = $"log{n1}({Math.Pow(n1, n2)}^{n3})";
                        }
                        break;

                    default:
                        break;
                }
            } while (ListOfNumbers.Contains(Number)); //generowanie liczb odbywa się tak długo, dopóki wygeneruje się unikatowa liczba dla danej figury
            ListOfNumbers.Add(Number);
        }
    }
}
