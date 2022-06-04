using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class DetilNotaJual
    {
        private int harga;
        private int jumlah;
        private Barang barang;

        #region Constructors
        public DetilNotaJual(int pHarga, int pJumlah, Barang pBarang)
        {
            this.Harga = pHarga;
            this.Jumlah = pJumlah;
            this.Barang = pBarang;
        }
        #endregion

        #region Properties
        public int Harga
        {
            get => harga;
            set
            {
                if (value > 0)
                    harga = value;
                else
                    throw new ArgumentException("Harga tidak boleh bernilai negatif atau bernilai nol.");
            }
        }
        public int Jumlah
        {
            get => jumlah;
            set
            {
                if (value > 0)
                    jumlah = value;
                else
                    throw new ArgumentException("Jumlah minimal berisikan satu.");
            }
        }
        public Barang Barang { get => barang; set => barang = value; }
        #endregion

        #region Method
        public static List<DetilNotaJual> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM detil_notajual";
            }
            else
            {
                sql = $"SELECT * FROM detil_notajual WHERE {kriteria} LIKE '%{nilaiKriteria}%'";
            }

            List<DetilNotaJual> listDetilNota = new List<DetilNotaJual>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Barang b = new Barang(Barang.BacaData("B.idBarang", hasil.GetString(1))[0]);
                    DetilNotaJual detilNota = new DetilNotaJual(hasil.GetInt32(2), hasil.GetInt32(3), b);
                    listDetilNota.Add(detilNota);
                }
            }
            return listDetilNota;
        }

        public static string JumlahTerjual(string idBarang)
        {
            string sql = $"SELECT SUM(jumlah) FROM detil_notajual WHERE idBarang = '{idBarang}'";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);
            int jumlah = 0;
            if (hasil.Read() == true && !hasil.IsDBNull(0))
            {
                jumlah = int.Parse(hasil.GetValue(0).ToString());
            }

            string text;
            if (jumlah >= 1000000){
                text = $"{jumlah / 1000000}JT+ Terjual";
            }
            else if (jumlah >= 1000){
                text = $"{jumlah / 1000}RB+ Terjual";
            }
            else{
                text = $"{jumlah} Terjual";
            }

            return text;
        }
        #endregion
    }
}