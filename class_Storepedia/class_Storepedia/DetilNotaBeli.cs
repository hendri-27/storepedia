using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace class_Storepedia
{
    public class DetilNotaBeli
    {
        private int harga;
        private int jumlah;
        private Barang barang;

        #region Constructor
        public DetilNotaBeli(int harga, int jumlah, Barang barang)
        {
            this.Harga = harga;
            this.Jumlah = jumlah;
            this.Barang = barang;
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
        public static List<DetilNotaBeli> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM detil_notabeli";
            }
            else
            {
                sql = $"SELECT * FROM detil_notabeli WHERE {kriteria} = '{nilaiKriteria}'";
            }

            List<DetilNotaBeli> listDetilNota = new List<DetilNotaBeli>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    DetilNotaBeli detilNota = new DetilNotaBeli(hasil.GetInt32(2), hasil.GetInt32(3), Barang.BacaData("B.idBarang", hasil.GetString(1))[0]);
                    listDetilNota.Add(detilNota);
                }
            }
            return listDetilNota;
        }
        #endregion
    }
}