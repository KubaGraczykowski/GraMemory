using GraMemory.Klasy;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GraMemory
{
    public partial class FormMemory : Form
    {
        GameSettings settings;

        MemoryCard first = null;
        MemoryCard second = null;

        public FormMemory()
        {
            InitializeComponent();

            settings = new GameSettings();

            SetBoard();

            SetCards();

            timerShowTime.Start();
        }

        void SetBoard()
        {
            panelKart.Height = settings.Size * settings.Columns;
            panelKart.Width = settings.Size * settings.Rows;

            Height = panelKart.Height + 100;
            Width = panelKart.Width + 30;

            labelStart.Text = "Gra rozpocznie sie za " + settings.ShowTime;
            labelCzas.Text = settings.GameTime.ToString();
            labelPunkty.Text = settings.Score.ToString();
        }

        void SetCards()
        {
            // pobieramy do tablicy ścieżki do plików z obrazkami
            string[] cardsFiles = Directory.GetFiles(settings.FrontPicFolder);

            // tworzymy listę na karty
            List<MemoryCard> cards = new List<MemoryCard>();

            foreach (var file in cardsFiles)
            {
                // tutaj id generowane jest nie przez konstruktor, a przez metodę statyczną klasy Guid o nazwie NewGuid
                Guid id = Guid.NewGuid();

                MemoryCard card1 = new MemoryCard(id, settings.BackPic, file);
                cards.Add(card1);

                MemoryCard card2 = new MemoryCard(id, settings.BackPic, file);
                cards.Add(card2);
            }
            // generator liczb losowych
            Random generator = new Random();

            for (int rows = 0; rows < settings.Rows; rows++)
            {
                for (int columns = 0; columns < settings.Columns; columns++)
                {
                    int index = generator.Next(0, cards.Count);

                    var card = cards[index];

                    int margin = 2;

                    card.Location = new Point(rows * settings.Size + rows * margin, columns * settings.Size + columns * margin);

                    card.Width = settings.Size;
                    card.Height = settings.Size;

                    card.Click += BtnClicked;

                    // odkrywamy kartę
                    card.ShowCard();
                    // i dodajemy do panelu
                    panelKart.Controls.Add(card);

                    cards.Remove(card);
                }
            }
        }

        private void timerShowTime_Tick(object sender, EventArgs e)
        {
            settings.ShowTime--;

            labelStart.Text = $"Gra rozpocznie sie za {settings.ShowTime}";

            if(settings.ShowTime <= 0)
            {
                labelStart.Visible = false;

                foreach (var item in panelKart.Controls)
                {
                    var card = (MemoryCard)item;
                    card.HideCard();
                }

                timerShowTime.Stop();

                timerGameTime.Start();
            }
        }

        void BtnClicked(object sender, EventArgs e)
        {
            MemoryCard card = (MemoryCard)sender;

            if(first == null)
            {
                first = card;
                first.ShowCard();
            }
            else
            {
                second = card;
                second.ShowCard();
                panelKart.Enabled = false;

                if(first.ID == second.ID)
                {
                    settings.Score++;

                    labelPunkty.Text = settings.Score.ToString();

                    first = null;
                    second = null;

                    panelKart.Enabled = true;
                }
                else
                {
                    timerHiding.Start();
                }    
            }
        }

        private void timerHiding_Tick(object sender, EventArgs e)
        {
            first.HideCard();
            second.HideCard();

            first = null;
            second = null;

            panelKart.Enabled = true;

            timerHiding.Stop();
        }

        private void timerGameTime_Tick(object sender, EventArgs e)
        {
            settings.GameTime--;

            labelCzas.Text = settings.GameTime.ToString();

            if(settings.GameTime <= 0 || settings.Score == settings.MaxScore)
            {
                timerGameTime.Stop();
                timerHiding.Stop();

                var odp = MessageBox.Show("Zdobyte punkty: " + settings.Score + "\nGrasz ponownie?", "Koniec gry", MessageBoxButtons.YesNo);

                if(odp == DialogResult.Yes)
                {
                    settings.StartSettings();
                    SetBoard();
                    SetCards();

                    timerShowTime.Start();
                }
                else
                {
                    Application.Exit();
                }    
            }
        }
    }
}

