using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KantinOtomasyon
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<cUsers> UserItem;
        public MainWindow(List<cUsers> LoginControlItem)
        {
            InitializeComponent();
            UserItem = LoginControlItem;
        }
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürünler urunler = new Ürünler(UserItem);
            urunler.Show();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünEkle urunEkle = new ÜrünEkle(UserItem);
            urunEkle.Show();
        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokGirişi stokGirisi = new StokGirişi(UserItem);
            stokGirisi.Show();
        }

        private void ÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokListesi stoklistesi = new StokListesi(UserItem);
            stoklistesi.Show();
        }

        private void StokHareketleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            StokHareketleri stokhareketleri = new StokHareketleri(UserItem);
            stokhareketleri.Show();
        }

        private void ListeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kullanıcı kullanıcı = new Kullanıcı(UserItem);
            kullanıcı.Show();
        }

        private void EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullanıcıEkle kullanıcıEkle = new KullanıcıEkle(UserItem);
            kullanıcıEkle.Show();
        }

        private void KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatışEkranı satisEkrani = new SatışEkranı(UserItem);
            satisEkrani.Show();
        }

        private void BakiyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BakiyeEkle bakiyeEkle = new BakiyeEkle(UserItem);
            bakiyeEkle.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Açık Form Form1 Değilse işlem yaptırma
            MainWindow mw = new MainWindow(UserItem);
            mw.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
