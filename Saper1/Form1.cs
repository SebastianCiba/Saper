using System;
using System.Collections.Generic;
//using System.ComponentModel; //optymalizacja importów
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper1
{
    public partial class Form1 : Form
    {
        int[,] pola;
        int wysokość = 10;
        int szerokość = 10;
        int liczbaBomb = 10;
        int oznaczone = 0;
        int[] bomby;
        int odkryte = 0;
        Button[,] przyciski = new Button[16, 16];

        public void losowaie()
        {
            bomby = new int[liczbaBomb];
            Random losowa = new Random();
            int liczbaPól = wysokość * szerokość;
            for (int j = 0; j < liczbaBomb; j++)
            {
                bomby[j] = losowa.Next(liczbaPól);
                if (pola[bomby[j] / szerokość, bomby[j] % wysokość] != 9)
                    pola[bomby[j] / szerokość, bomby[j] % wysokość] = 9;
                else j--;
            }
        }

        public void oblicz()
        {
            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    ///-11 -10  -9
                    /// -1   0  +1
                    /// +9 +10 +11
                    ///-i-j -i -i+j
                    ///  -j  0   +j
                    ///+i-j +i +i+j
                    if (pola[i, j] == 9)
                    {
                        if (i - 1 >= 0 && j - 1 >= 0 && pola[i - 1, j - 1] != 9)
                            pola[i - 1, j - 1]++;

                        if (i - 1 >= 0 && pola[i - 1, j] != 9)
                            pola[i - 1, j]++;

                        if (i - 1 >= 0 && j + 1 <= wysokość - 1 && pola[i - 1, j + 1] != 9)
                            pola[i - 1, j + 1]++;

                        if (j - 1 >= 0 && pola[i, j - 1] != 9)
                            pola[i, j - 1]++;

                        if (j + 1 <= wysokość - 1 && pola[i, j + 1] != 9)
                            pola[i, j + 1]++;

                        if (i + 1 <= szerokość - 1 && j - 1 >= 0 && pola[i + 1, j - 1] != 9)
                            pola[i + 1, j - 1]++;

                        if (i + 1 <= szerokość - 1 && pola[i + 1, j] != 9)
                            pola[i + 1, j]++;

                        if (i + 1 <= szerokość - 1 && j + 1 <= wysokość - 1 && pola[i + 1, j + 1] != 9)
                            pola[i + 1, j + 1]++;
                    }
                }
            }
        }

        private void czyść()
        {
            for (int y = 0; y < szerokość; y++)
            {
                for (int x = 0; x < wysokość; x++)
                {
                    this.Controls.Remove(przyciski[y,x]);
                }
            }
            oznaczone = 0;
        }

        private void generuj()
        {
            pola = new int[szerokość, wysokość];

            for (int i = 0; i < szerokość; i++)
            {
                for (int j = 0; j < wysokość; j++)
                {
                    pola[i, j] = 0;
                }
            }

            losowaie();
            oblicz();
            for (int y = 0; y < szerokość; y++)
            {
                for (int x = 0; x < wysokość; x++)
                {
                    przyciski[y, x] = new Button();
                    przyciski[y, x].Tag = "" + x + y + pola[x, y] + "E";
                    przyciski[y, x].Size = new Size(20, 20);
                    przyciski[y, x].Top = 58 + 20 * x;
                    przyciski[y, x].Left = 3 + 20 * y;
                    przyciski[y, x].Click += pokarz;
                    przyciski[y, x].MouseUp += rightClick;
                    przyciski[y, x].BackgroundImageLayout = ImageLayout.Stretch;
                    //przyciski[y, x].Text = pola[przyciski[y, x].Top / 20 - 1, przyciski[y, x].Left / 20].ToString();
                    //przyciski[y, x].Text = pola[przyciski[y, x].Top / 20 - 2, przyciski[y, x].Left / 20].ToString();
                    this.Controls.Add(przyciski[ y, x]);
                    
                }
            }

            licznikBomb();
        }

        public Form1()
        {
            InitializeComponent();
            generuj();
        }

        private Image getImage(string name)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + name;
            Image obrazek = Image.FromFile(@path);

            return obrazek;
        }

        private void pokarz(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            MouseEventArgs me = (MouseEventArgs)e;
            //przycisk.Text = przycisk.Top.ToString() + przycisk.Left.ToString();

            //int wartość = przycisk.Tag.ToString()[2] - '0';
            //przycisk.Text = pola[przycisk.Top / 20 - 2, przycisk.Left / 20].ToString();
            int wartość = pola[przycisk.Top / 20 - 2, przycisk.Left / 20];
            if (wartość == 9)
            {
                timer1.Stop();
                string path1 = AppDomain.CurrentDomain.BaseDirectory + "przegrana.png";
                Image przegrana = Image.FromFile(@path1);
                button1.BackgroundImage = przegrana;

                string path = AppDomain.CurrentDomain.BaseDirectory + "bomba.png";
                Image bomba = Image.FromFile(@path);
                przycisk.BackgroundImage = bomba;
                przycisk.BackgroundImageLayout = ImageLayout.Stretch;

                for (int y = 0; y < szerokość; y++)
                {
                    for (int x = 0; x < wysokość; x++)
                    {
                        if (pola[y, x] == 9)
                        {
                            przyciski[y, x].BackgroundImage = bomba; ;
                            przyciski[y, x].BackgroundImageLayout = ImageLayout.Stretch;
                        }

                    }
                }

                string message = "Boom!" + Environment.NewLine + "Czas: " + czas;
                string caption = "Przegrana";

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    czyść();
                    nowaGra();
                }
            }
            else
                pokazWartosc(przycisk, wartość);
        }

        private void pokazWartosc(Button przycisk, int wartość)
        {

            if (wartość == 0)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                //przycisk.Text = wartość.ToString();
                przycisk.BackgroundImage = getImage("zero.png");
                //int x = przycisk.Tag.ToString()[0] - '0';
                //int y = przycisk.Tag.ToString()[1] - '0';
                int y = przycisk.Left / 20;
                int x = przycisk.Top / 20 - 2;
                pokarzSąsiadów(y, x);
            }
            else if (wartość == 1)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "jeden.png";
                Image jeden = Image.FromFile(@path);
                przycisk.BackgroundImage = jeden;
            }
            else if (wartość == 2)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "dwa.png";
                Image dwa = Image.FromFile(@path);
                przycisk.BackgroundImage = dwa;
            }
            else if (wartość == 3)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "trzy.png";
                Image trzy = Image.FromFile(@path);
                przycisk.BackgroundImage = trzy;
            }
            else if (wartość == 4)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "cztery.png";
                Image cztery = Image.FromFile(@path);
                przycisk.BackgroundImage = cztery;
            }
            else if (wartość == 5)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "pięć.png";
                Image pięć = Image.FromFile(@path);
                przycisk.BackgroundImage = pięć;
            }
            else if (wartość == 6)
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                string path = AppDomain.CurrentDomain.BaseDirectory + "sześć.png";
                Image sześć = Image.FromFile(@path);
                przycisk.BackgroundImage = sześć;
            }
            else
            {
                if (przycisk.Enabled != false)
                    odkryte++;
                przycisk.Enabled = false;
                przycisk.Text = wartość.ToString();

            }
            wygrana();
        }

        List<Button> przyciskiSprawdzone = new List<Button>();

        private void pokarzSąsiadów(int y, int x)
        {
            for (int przesunięcieY = -1; przesunięcieY <= 1; przesunięcieY++)
            {
                for (int przesunięcieX = -1; przesunięcieX <= 1; przesunięcieX++)
                {
                    int nowyX = x + przesunięcieX;
                    int nowyY = y + przesunięcieY;

                    if (nowyX < 0)
                    {
                        nowyX = 0;
                    }

                    if (nowyX > wysokość - 1)
                    {
                        nowyX = wysokość - 1;
                    }

                    if (nowyY < 0)
                    {
                        nowyY = 0;
                    }

                    if (nowyY > szerokość - 1)
                    {
                        nowyY = szerokość - 1;
                    }

                    Button przycisk = przyciski[nowyY, nowyX];
                    //int wartość = przycisk.Tag.ToString()[2] - '0';
                    int wartość = pola[nowyY, nowyX];
                    if (!przyciskiSprawdzone.Contains(przycisk))
                    {
                        if (wartość == 0)
                        {
                            if (przycisk.Enabled != false)
                                odkryte++;
                            przycisk.Enabled = false;
                            string path = AppDomain.CurrentDomain.BaseDirectory + "zero.png";
                            Image zero = Image.FromFile(@path);

                            przycisk.BackgroundImage = zero;
                            przyciskiSprawdzone.Add(przycisk);
                            pokarzSąsiadów(nowyY, nowyX);

                        }
                        else if (wartość != 9)
                        {
                            pokazWartosc(przycisk, wartość);
                        }
                    }
                }
            }
        }

        private void rightClick(object sender, MouseEventArgs e)
        {
            Button przycisk = (Button)sender;

            if (e.Button == MouseButtons.Right)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "bombaOznaczona.png";
                Image bombaOznaczona = Image.FromFile(@path);

                if (przycisk.Tag.ToString()[3] == 'O')
                {
                    oznaczone--;
                    przycisk.BackgroundImage = null;
                    przycisk.Tag = przycisk.Tag.ToString().Replace("O", "E");
                }
                else
                {
                    oznaczone++;
                    przycisk.BackgroundImage = bombaOznaczona;
                    przycisk.Tag = przycisk.Tag.ToString().Replace("E", "O");
                }
            }

            licznikBomb();
        }

        private void licznikBomb()
        {
            int pozostałobomb = liczbaBomb - oznaczone;
            switch (pozostałobomb % 10)
            {
                case 0:
                    pictureBox2.Image = getImage("cyfra0.png"); break;
                case 1:
                    pictureBox2.Image = getImage("cyfra1.png"); break;
                case 2:
                    pictureBox2.Image = getImage("cyfra2.png"); break;
                case 3:
                    pictureBox2.Image = getImage("cyfra3.png"); break;
                case 4:
                    pictureBox2.Image = getImage("cyfra4.png"); break;
                case 5:
                    pictureBox2.Image = getImage("cyfra5.png"); break;
                case 6:
                    pictureBox2.Image = getImage("cyfra6.png"); break;
                case 7:
                    pictureBox2.Image = getImage("cyfra7.png"); break;
                case 8:
                    pictureBox2.Image = getImage("cyfra8.png"); break;
                case 9:
                    pictureBox2.Image = getImage("cyfra9.png"); break;
            }
            switch (pozostałobomb / 10)
            {
                case 0:
                    pictureBox3.Image = getImage("cyfra0.png"); break;
                case 1:
                    pictureBox3.Image = getImage("cyfra1.png"); break;
                case 2:
                    pictureBox3.Image = getImage("cyfra2.png"); break;
                case 3:
                    pictureBox3.Image = getImage("cyfra3.png"); break;
                case 4:
                    pictureBox3.Image = getImage("cyfra4.png"); break;
                case 5:
                    pictureBox3.Image = getImage("cyfra5.png"); break;
                case 6:
                    pictureBox3.Image = getImage("cyfra6.png"); break;
                case 7:
                    pictureBox3.Image = getImage("cyfra7.png"); break;
                case 8:
                    pictureBox3.Image = getImage("cyfra8.png"); break;
                case 9:
                    pictureBox3.Image = getImage("cyfra9.png"); break;
            }
        }

        private void nowaGra()
        {
            Width = szerokość * 20 + 22;
            Height = wysokość * 20 + 100;
            generuj();
            timer1.Start();
            sekundy = 0;
            minuty = 0;
            odkryte = 0;
            czas = "0:00";
            zegar.Text = czas;
            string path = AppDomain.CurrentDomain.BaseDirectory + "uśmiech.png";
            Image uśmiech = Image.FromFile(@path);
            button1.BackgroundImage = uśmiech;
        }

        private void wygrana()
        {
            if (odkryte == szerokość*wysokość - liczbaBomb)
            {
                timer1.Stop();
                string path = AppDomain.CurrentDomain.BaseDirectory + "wygrana.png";
                Image wygrana = Image.FromFile(@path);
                button1.BackgroundImage = wygrana;

                string message = "Gratulacje, wygrana!" + Environment.NewLine + "Czas: " + czas;
                string caption = "Wygrana";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    czyść();
                    nowaGra();
                }
                    
            }
        }

        int sekundy = 0;
        int minuty = 0;
        String czas;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekundy++;
            if (sekundy > 59)
            {
                minuty++;
                sekundy = 0;
            }
            if (sekundy < 10)
                czas = minuty + ":0" + sekundy;
            else
                czas = minuty + ":" + sekundy;
            zegar.Text = czas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            czyść();
            nowaGra();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "restart.png";
            Image restart = Image.FromFile(@path);
            button1.BackgroundImage = restart;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "uśmiech.png";
            Image uśmiech = Image.FromFile(@path);
            button1.BackgroundImage = uśmiech;
        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyść();
            nowaGra();
        }

        private void początkującyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyść();
            wysokość = 10;
            szerokość = 10;
            liczbaBomb = 10;
            button1.Left = 88;
            zegar.Left = 138;
            nowaGra();
        }

        private void średniozaawansowanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czyść();
            wysokość = 16;
            szerokość = 16;
            liczbaBomb = 40;
            button1.Left = 148;
            zegar.Left = 258;
            nowaGra();
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void obryPoczątekToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Saper C#" + Environment.NewLine + "Sebastian Ciba";
            string caption = "Informacje";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

    }
}