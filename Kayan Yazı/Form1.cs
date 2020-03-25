using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kayan_Yazı
{
    public partial class Form1 : Form
    {

        #region Değişkenler

        string kelime; // textbox tan gelen değeri tutacak.

        string parça; // gelen kelime üzerinden alacağımız parçayı tutacakç.

        #endregion


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kelime = textBox1.Text.ToUpper(); // yazı textboxa nasıl yazılırsa yazılsın tüm harflerini büyük yaptık daha estetik görüntü için.

            label3.Text = kelime.ToString(); 

            timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            parça = kelime.Substring(0, 1); // substirng metodu ile kelimemizden istediğimiz parçayı aldık. bu kulllanımında kaçıncı elemandan itibaren kaç karakter alacağını söyledik.

            kelime=kelime.Remove(0,1); // kelimemizden karakter sildik. kaçıncı karakterden itibaren kaç karakter sileceğimizi belirttik.

            kelime = kelime + parça; // yeni kelimemize aldığımız parçayı ekledik.

            label3.Text = kelime.ToString(); // label a yazdırdık.
        }
    }
}
