using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuynhThaoNguyen_2033210471
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool check(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNhapSo.Clear();
            txtIn.Clear();
            txtTinhTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            // Tinh tong cac so
            string input = txtIn.Text;
            string[] DaySo = input.Split(' ');
            int[] MangSoNguyen = Array.ConvertAll(DaySo, int.Parse);
            txtTinhTong.Text = MangSoNguyen.Sum().ToString();
            int TongChan=0;
            int TongLe = 0;
            for(int i=0;i<MangSoNguyen.Count();i++)
            {
                //Tong chan
                if (check(MangSoNguyen[i]))
                {
                    TongChan=TongChan + MangSoNguyen[i];
                    txtTongChan.Text = TongChan.ToString();
                }
                else
                {
                    //Tong le
                    TongLe = TongLe + MangSoNguyen[i];
                    txtTongLe.Text = TongLe.ToString();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string input = txtNhapSo.Text;
            string[] DaySo = input.Split(' ');
            int[] MangSoNguyen = Array.ConvertAll(DaySo, int.Parse);
            txtIn.Text = string.Join(" ", MangSoNguyen);
        }
    }
}
    

