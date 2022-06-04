using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class Kategori
    {
        private string kodeKategori;
        private string nama;

        #region Constructors
        public Kategori(string pKodeKategori, string pNama)
        {
            this.KodeKategori = pKodeKategori;
            this.Nama = pNama;
        }
        #endregion

        #region Properties
        public string KodeKategori { get => kodeKategori; set => kodeKategori = value; }
        public string Nama
        {
            get => nama; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nama = value;
                }
                else
                {
                    throw new ArgumentException("Nama tidak boleh kosong.");
                }
            }
        }
        #endregion

        #region Methods
        public static void TambahData(Kategori k)
        {
            string sql = $"INSERT INTO kategori(kodeKategori, nama) VALUES('{k.KodeKategori}','{k.Nama.Replace("'", "\\'")}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Kategori k)
        {
            string sql = $"UPDATE kategori SET nama = '{k.Nama.Replace("'", "\\'")}' WHERE kodeKategori = '{k.KodeKategori}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Kategori k)
        {
            string sql = $"DELETE FROM kategori WHERE kodeKategori = '{k.KodeKategori}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Kategori> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM kategori";
            }
            else
            {
                sql = $"SELECT * FROM kategori WHERE {kriteria} LIKE '%{nilaiKriteria}%'";
            }

            List<Kategori> listKategori = new List<Kategori>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Kategori k = new Kategori(hasil.GetString(0), hasil.GetString(1));
                    listKategori.Add(k);
                }
            }
            return listKategori;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(kodeKategori) FROM kategori";

            string hasilKode;

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true && !hasil.IsDBNull(0))
                {
                    int kodeTerbaru = int.Parse(hasil.GetString(0)) + 1;

                    hasilKode = kodeTerbaru.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilKode = "01";
                }
            }
            return hasilKode;
        }
        #endregion
    }
}