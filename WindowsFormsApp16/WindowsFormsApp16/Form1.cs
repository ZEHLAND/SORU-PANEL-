using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        int soru = 0, Dogru = 0, Yanlıs = 0;

    private void A_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            sonraki.Enabled = true;
            label2.Text = A.Text;
            if (label1.Text == label2.Text)
            {
                Dogru++;
                label5.Text = Dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                Yanlıs++;
                label6.Text = Yanlıs.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            sonraki.Enabled = true;
            {
                label2.Text = B.Text;
                if (label1.Text == label2.Text)
                {
                    Dogru++;
                    label5.Text = Dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    Yanlıs++;
                    label6.Text = Yanlıs.ToString();
                    pictureBox2.Visible = true;
                }
            }

        }

        private void C_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            sonraki.Enabled = true;
            {
                label2.Text = C.Text;
                if (label1.Text == label2.Text)
                {
                    Dogru++;
                    label5.Text = Dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    Yanlıs++;
                    label6.Text = Yanlıs.ToString();
                    pictureBox2.Visible = true;
                }
            }

        }

        private void D_Click(object sender, EventArgs e)
        {
            A.Enabled = false;
            B.Enabled = false;
            C.Enabled = false;
            D.Enabled = false;
            sonraki.Enabled = true;
            {
                label2.Text =D.Text;
                if (label1.Text == label2.Text)
                {
                    Dogru++;
                    label5.Text = Dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    Yanlıs++;
                    label6.Text = Yanlıs.ToString();
                    pictureBox2.Visible = true;
                }
            }

        }

        private void dogru_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sonraki_Click(object sender, EventArgs e)
        {
            sonraki.Text = "SONRAKİ";
            sonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            A.Enabled = true;
            B.Enabled = true;
            C.Enabled = true;
            D.Enabled = true;
            soru++;
            label4.Text = soru.ToString();
            if (soru == 1)
            {
                richTextBox1.Text = "Erkekler ne ister ? ";
                A.Text = "Allahtan belasını";
                B.Text = "Annelerini";
                C.Text = "İlgi(yer verirsin küçümser)";
                D.Text = "Erkekler sapıktır(İnsanın piskolojisi bozuluyor).";
                label1.Text = "Allahtan belasını";
            }
            if (soru == 2)
            {
                richTextBox1.Text = "İnsanlar neden kapalıları dışlar?";
                A.Text = "Atatürkün annesini sevmediklerinden";
                B.Text = "Nene Hatunu sevmediklerinden";
                C.Text = "Hz.Hatice annemizi sevmediklerinden ";
                D.Text = "Beyinlerinde elektronun içinde ki boşluk yüzdesinden fazla boşluk vardır.";
                label1.Text = "Beyinlerinde elektronun içinde ki boşluk yüzdesinden fazla boşluk vardır.";
            }
            if (soru == 3)
            {
                A.Enabled = false;
                B.Enabled = false;
                C.Enabled = false;
                D.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                sonraki.Text = "BİTTİ.";
                MessageBox.Show("Doğru: " + Dogru + " / "+ "Yanlış: " + Yanlıs);

            }
              
        }
    }
}
