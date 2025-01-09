using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
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
                radioButton2, radioButton3, radioButton4,
                radioButton5, radioButton6,
                radioButton7, radioButton8,
                radioButton9, radioButton10, radioButton11,
                radioButton12
                ];

            if (radioButton1.Checked)
            {
                MessageBox.Show("Gmina Brzozowo z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Gmina Brzózki Ma³e z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton3.Checked)
            {
                MessageBox.Show("Gmina Brzózki Wielkie z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton4.Checked)
            {
                MessageBox.Show("Gmina Brzózki Œrednie z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton5.Checked)
            {
                MessageBox.Show("Gmina Ma³a Wioska z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton6.Checked)
            {
                MessageBox.Show("Gmina Wielka Wioska z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton7.Checked)
            {
                MessageBox.Show("Gmina Zakrêtowice z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton8.Checked)
            {
                MessageBox.Show("Gmina Stawówek z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton9.Checked)
            {
                MessageBox.Show("Gmina Dolne Bagienko z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton10.Checked)
            {
                MessageBox.Show("Gmina Górne Bagienko z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton11.Checked)
            {
                MessageBox.Show("Gmina Krzaczewo z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
                    "Lipa: " + Lipy + "\n" +
                    "Leszczyna: " + Leszczyny + "\n" +
                    "Topola: " + Topole + "\n" +
                    "Inne: " + Inne + "\n");
            }
            else if (radioButton12.Checked)
            {
                MessageBox.Show("Gmina Patykowo z³o¿y³a dane. \n\n" +
                    "Brzoza: " + Brzozy + "\n" +
                    "Sosna: " + Sosny + "\n" +
                    "Œwierki: " + Swierki + "\n" +
                    "D¹b: " + Deby + "\n" +
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

                MessageBox.Show("Liczba brzóz przekracza 80% drzewostanu gminy.\n" +
                                "Nale¿y dosadziæ " + drzewadodatkowe + " drzew innych gatunków, aby brzozy stanowi³y mniej ni¿ 80% drzewostanu gminy.");
            }
            else
            {
                MessageBox.Show("Liczba brzóz nie przekracza 80% drzewostanu gminy.");
            }
        }
    }
}
