using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace MobilyaOtomasyonu
{
    public class Veritabani
    {
        // Bağlantı Cümlesi (Şifre kısmını kendi şifrenle değiştirmeyi unutma!)
        // Eğer port değiştirdiysen 5432 yerine onu yaz.
        private static string baglantiAdresi = "Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=postgres;";

        public static NpgsqlConnection Baglan()
        {
            NpgsqlConnection baglanti = new NpgsqlConnection(baglantiAdresi);
            try
            {
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
            }
            return baglanti;
        }
    }
}