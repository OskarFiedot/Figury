using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Oskar Fiedot     179914      Tele gr. dziek. 1.      grupa projektowa: 4
 * gra o tytule "Figury"
 */

// Klasa Form1, definiująca działanie gry i jej interfejs

namespace Figury
{
    public partial class Form1 : Form 
    {
        List<Panel> panele = new List<Panel>();         // listy elementów znajdujących się w oknie gry, ułatwiające wykonywanie powtarzalnych zadań
        List<Figura> figury = new List<Figura>();
        List<Label> liczby = new List<Label>();
        Hashtable hashtable = new Hashtable();     // tablica hashowalna, przechowująca jako klucze obiekty figur na ekranie, a jako wartości obiekty labelów nad tymi figurami, które są do nich przypisane
        Gra game = new Gra();       // instancja klasy Gra

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.IO.Directory.SetCurrentDirectory("../../..");
            poziom_label.Text = $"Poziom: {game.Level}";
            next_lvl_label.Text = "";

            figury.Add(kwadrat1);
            figury.Add(okrag1);
            figury.Add(trojkat1);

            foreach (var figura in figury)  // każda figura ma generowaną liczbę oraz ustawiana jest jej domyślna lokalizacja
            {
                figura.BringToFront();
                figura.SetOryginalLocation(figura.Location);
                figura.DrawNumber(game.Level);
            }

            panele.Add(panel_prawy);
            panele.Add(panel_lewy);

            liczby.Add(label1);
            liczby.Add(label2);
            liczby.Add(label3);

            ShowNumbers();     // wyświetlanie liczb figur na dole ekranu w losowej kolejności
            game.StartGame();   // włączenie stoperów

            hashtable.Add(kwadrat1, kwadrat_label);
            hashtable.Add(okrag1, okrag_label);
            hashtable.Add(trojkat1, trojkat_label);
        }

        private void Figura_MouseUp(object sender, MouseEventArgs e)    //Funkcja, która przy odciśnięciu przycisku myszki, której kursor znajduje się nad dowolną figurą,
        {                                                               //sprawdza czy figura została przeniesiona do porównywarki i jeśli tak było, sprawdza czy po drugiej stronie porównywarki znajduje się inna figura
            var figura = sender as Figura;                              // i porównuje je, jeśli faktycznie się tam znajduje
            komunikat_label.Visible = false;
            next_lvl_label.Text = "";

            foreach (var panel in panele)
            {
                if (figura.Location.X > panel.Location.X && (figura.Location.X + figura.Width) < (panel.Location.X + panel.Width) && figura.Location.Y > panel.Location.Y && (figura.Location.Y + figura.Height) < (panel.Location.Y + panel.Height))
                {
                    figura.Compared = true; // właściwość Compared przyjmuje wartość True, gdy figura jest w porównywarce
                    textBox1.Text = $"{panel.Name} {figura.Compared} {figura.StrNumber} {figura.Number}"; //textBox, który jest tu jedynie w celach pomocniczych, przy programowaniu
                    break;
                }
                else
                {
                    if (panel == panele.Last())     // Jeśli figura nie została upuszczona w panelu do porównywania, to wraca na swoją oryginalną pozycję
                    {
                        figura.MoveToOriginalLocation();
                        textBox1.Text = $"{figura.Compared}";
                        comparison_site.Image = null;
                    }
                }
            }

            if (figura.Compared)    // Jeśli figura została upuszczona w porównywarce, to sprawdzane jest, czy znajduje się już w niej inna figura
            {
                int licznik = 0;
                Figura figura2 = null;

                foreach (var f in figury)
                {
                    if (f.Compared && f != figura)
                    {
                        licznik++;
                        figura2 = f;
                    }
                }

                if (licznik == 1)   // Jeśli w porównywarce, poza przeniesioną figurą, znajduje się już jedna inna figura, to ich liczby są porównywane
                {
                    if (figura.Location.X < this.Width/2 && figura2.Location.X > this.Width/2)
                    {
                        if (figura.Number > figura2.Number)
                        {
                            comparison_site.Image = Image.FromFile("znak_wiekszosci.png");
                        }
                        else if (figura.Number < figura2.Number)
                        {
                            comparison_site.Image = Image.FromFile("znak_mniejszosci.png");
                        }
                    }
                    else if(figura.Location.X > this.Width/2 && figura2.Location.X < this.Width/2)
                    {
                        if (figura.Number > figura2.Number)
                        {
                            comparison_site.Image = Image.FromFile("znak_mniejszosci.png");
                        }
                        else if (figura.Number < figura2.Number)
                        {
                            comparison_site.Image = Image.FromFile("znak_wiekszosci.png");
                        }
                    }
                    else
                    {
                        foreach (var f in figury)       //Zabezpieczenie, na wypadek, gdyby użytkownik umieścił figury w tym samym polu porównywarki
                        {
                            f.MoveToOriginalLocation();
                        }

                        komunikat_label.Visible = true;
                        comparison_site.Image = null;
                    }
                }
                else if(licznik == 2)       // Jeśli w porównywarce znajduje się więcej figur, niż 2, to wszystkie wracają na swoją oryginalną pozycję
                {
                    foreach (var f in figury)
                    {
                        f.MoveToOriginalLocation();
                    }

                    komunikat_label.Visible = true;
                    comparison_site.Image = null;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)    // Funkcja aktualizująca czas na wyświetlanym na ekranie stoperze
        {
            TimeSpan ts = game.LevelStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            stoper_label.Text = elapsedTime;
        }

        private void button_end_game_Click(object sender, EventArgs e)  // Zdarzenie po naciśnięciu przycisku zakończenia gry 
        {
            label_end_game.Text = "Zakończyłeś grę. Oto Twoje dotychczasowe statystyki:";
            EndGamePanel();
            game.EndGame();
        }

        public void EndGamePanel()  // funkcja, wyświetlająca panel końca gry, przechowującego statystyki rozgrywki
        {
            panel_end_game.Visible = true;
            panel_end_game.BringToFront();
            TimeSpan ts = game.GameStopwatch.Elapsed;
            label_czas_koncowy.Text += string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);
            label_liczba_bledow.Text += $"{game.NumberOfMistakes}";
            label_pokonane_poziomy.Text += $"{game.LevelTimeSpans.Count()}";
            label_pozostale_poziomy.Text += $"{game.MaxLevel - game.LevelTimeSpans.Count()}";
        }

        private void ShowNumbers()  // Funkcja, która losuje w jakiej kolejności na dole ekranu mają wyświetlić się liczby, które należy przypisać do figur
        {
            Random r = new Random();
            List<int> wylosowaneIndeksy= new List<int>();
            int i;

            foreach (var label in liczby)
            {
                do
                {
                    i = r.Next(figury.Count);
                } while (wylosowaneIndeksy.Contains(i));
                wylosowaneIndeksy.Add(i);

                label.Text = figury[i].StrNumber;
            }
        }

        private void number_MouseDown(object sender, MouseEventArgs e) 
        {
            komunikat_label.Visible = false;

            Label label = sender as Label;

            label.DoDragDrop(label.Text, DragDropEffects.Copy);
        }

        private void button_next_lvl_Click(object sender, EventArgs e) // Zdarzenie po naciśnięciu przycisku z napisem "Sprawdź"
        {
            game.Pause();   // stopery gry na chwilę się zatrzymują
            var licznik = 0;

            foreach (var figura in figury)      // pętla sprawdza, czy wszystkie liczby zostały prawidłowo przypisane do figur
            {
                Label label = hashtable[figura] as Label;

                if (figura.StrNumber == label.Text)
                {
                    licznik++;
                }
            }

            if (licznik == 3 && TimeSpan.Compare(game.LevelStopwatch.Elapsed, game.MaxTimesForLevel[game.Level-1]) == -1) // Jeśli użytkownik przypisał wszystkie liczby prawidłowo i zmieścił się w czasie
            {                                                                                                             // to przechodzi na wyższy poziom
                if (game.Level == game.MaxLevel) // Jeśli użytkownił był na ostatnim poziomie, gra się kończy
                {
                    game.EndGame();
                    EndGamePanel();
                    return;
                }

                game.LevelUp();     // w innym przypadku, gracz przechodzi do następnego poziomu
                poziom_label.Text = $"Poziom: {game.Level}";
                next_lvl_label.Text = "Gratulacje! Przechodzisz do następnego poziomu.";
            }
            else if (licznik == 3 && TimeSpan.Compare(game.LevelStopwatch.Elapsed, game.MaxTimesForLevel[game.Level - 1]) == 1) //Jeśli gracz nie zmieścił sie w czasie, musi rozpocząć poziom od nowa, z nowymi liczbami
            {
                game.RestartLevel();
                next_lvl_label.Text = "Liczby zostały poprawnie przypisane, ale niestety nie udało się zmieścić w przedziale czasowym :(";
            }
            else // Jeśli użytkownik źle przypisał liczby, pojawia się stosowny komunikat
            {
                game.AddMistake(3 - licznik); // aktualizowana jest również liczba błędów gracza
                game.Resume();                // oraz wznawiane stopery
                next_lvl_label.Text = "Niestety, dopasowanie liczb jest nieprawidłowe.";
                foreach (Label label in hashtable.Values)
                {
                    label.Text = "";
                }
                return;
            }

            Figura.ClearListOfNumbers(); // Lista liczb figura jest czyszczona za każdym razem przed ponownym generowaniem liczb
            foreach (var figura in figury)
            {
                figura.MoveToOriginalLocation();
                figura.DrawNumber(game.Level);
                Label label = hashtable[figura] as Label;
                label.Text = "";
            }

            comparison_site.Image = null;
            ShowNumbers();
        }

        private void label_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void label_DragDrop(object sender, DragEventArgs e)
        {
            Label label = sender as Label;

            label.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void button_reset_Click(object sender, EventArgs e) // zdarzenie po naciśnięciu przycisku resetu, figury wracają na swoje miejsca
        {
            foreach (var figura in figury)
            {
                figura.MoveToOriginalLocation();
                Label label = hashtable[figura] as Label;
                label.Text = "";
            }

            comparison_site.Image = null;
            komunikat_label.Visible = false;
        }

        private void restart_button_Click(object sender, EventArgs e) // Jeśli w panelu końca gry, użytkownik naciśnie przycisk restartu, gra rozpoczyna się na nowo od pierwszego poziomu i z wyzerowanymi statystykami
        {
            panel_end_game.Visible = false;
            label_end_game.Text = "Gratulacje!\nUdało Ci się przejść wszystkie poziomy!\nOto garść Twoich statystyk:";
            label_czas_koncowy.Text = "Czas całej gry: ";
            label_liczba_bledow.Text = "Liczba błędów: ";
            label_pokonane_poziomy.Text = "Liczba pokonanych poziomów: ";
            label_pozostale_poziomy.Text = "Liczba pozostałych poziomów: ";
            game.StartGame();
            poziom_label.Text = $"Poziom: {game.Level}";
            next_lvl_label.Text = "";
            komunikat_label.Visible = false;
            comparison_site.Image = null;
            Figura.ClearListOfNumbers();
            foreach (var figura in figury)
            {
                Label label = hashtable[figura] as Label;
                label.Text = "";
                figura.MoveToOriginalLocation();
                figura.DrawNumber(game.Level);
            }
            ShowNumbers();
        }
    }
}
