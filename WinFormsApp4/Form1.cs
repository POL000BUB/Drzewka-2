using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        String[] gminy = [
            "Brzozowo",
            "Brzózki Małe",
            "Brzózki Wielkie",
            "Brzózki Średnie",
            "Mała Wioska",
            "Wielka Wioska",
            "Zakrętowice",
            "Stawówka",
            "Dolne Bagienko",
            "Górne Bagienko",
            "Krzaczewo",
            "Patykowo"
        ];

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Brzozy = (int)numericUpDown1.Value;
            int Sosny = (int)numericUpDown2.Value;
            int Swierki = (int)numericUpDown3.Value;
            int Deby = (int)numericUpDown4.Value;
            int Lipy = (int)numericUpDown5.Value;
            int Leszczyny = (int)numericUpDown6.Value;
            int Topole = (int)numericUpDown7.Value;
            int Inne = (int)numericUpDown8.Value;

            RadioButton[] radioButtons = [
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4,
                radioButton5,
                radioButton6,
                radioButton7,
                radioButton8,
                radioButton9,
                radioButton10,
                radioButton11,
                radioButton12
                ];

            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (radioButtons[i].Checked)
                {
                    string gmina = gminy[i];
                    string message = string.Format("Gmina {0} złożyła dane: \n\n Brzozy: {1}\n Sosny: {2}\n Swierki: {3}\n Deby: {4}\n Lipy: {5}\n Leszczyny: {6}\n Topole: {7} \n Inne: {8} \n", gmina, Brzozy, Sosny, Swierki, Deby, Lipy, Leszczyny, Topole, Inne);

                    MessageBox.Show(message);
                }
            }

            if (radioButton1.Checked)
            {
                MessageBox.Show("Gmina Brzozowo z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Gmina Brz�zki Ma�e z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Gmina Brz�zki Wielkie z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Gmina Brz�zki �rednie z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton5.Checked)
            {
                MessageBox.Show("Gmina Ma�a Wioska z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton6.Checked)
            {
                MessageBox.Show("Gmina Wielka Wioska z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton7.Checked)
            {
                MessageBox.Show("Gmina Zakr�towice z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton8.Checked)
            {
                MessageBox.Show("Gmina Staw�wek z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton9.Checked)
            {
                MessageBox.Show("Gmina Dolne Bagienko z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton10.Checked)
            {
                MessageBox.Show("Gmina G�rne Bagienko z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton11.Checked)
            {
                MessageBox.Show("Gmina Krzaczewo z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton12.Checked)
            {
                MessageBox.Show("Gmina Patykowo z�o�y�a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "�wierki: " + Swierki + "\n" +
                    "D�b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Brzozy = (int)numericUpDown1.Value;
            int Sosny = (int)numericUpDown2.Value;
            int Swierki = (int)numericUpDown3.Value;
            int Deby = (int)numericUpDown4.Value;
            int Lipy = (int)numericUpDown5.Value;
            int Leszczyny = (int)numericUpDown6.Value;
            int Topole = (int)numericUpDown7.Value;
            int Inne = (int)numericUpDown8.Value;
            int sumadrzew = Brzozy + Sosny + Swierki + Deby + Lipy + Leszczyny + Topole + Inne;
            double procentbrzoz = (double)Brzozy / sumadrzew * 100;

            if (procentbrzoz > 80)
            {
                int brakujacedrzewa = (int)Math.Ceiling((Brzozy / 0.8) - sumadrzew);
                int drzewadodatkowe = brakujacedrzewa * 4;

                MessageBox.Show("Liczba brz�z przekracza 80% drzewostanu gminy.\n" +
                                "Nale�y dosadzi� " + drzewadodatkowe + " drzew innych gatunk�w, aby brzozy stanowi�y mniej ni� 80% drzewostanu gminy.");
            }
            else
            {
                MessageBox.Show("Liczba brz�z nie przekracza 80% drzewostanu gminy.");
            }
        }
    }
}
