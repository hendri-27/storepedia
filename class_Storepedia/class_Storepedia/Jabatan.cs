using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class Jabatan
    {
        private string idJabatan;
        private string nama;

        #region Constructors
        public Jabatan(string pIdJabatan, string pNama)
        {
            this.IdJabatan = pIdJabatan;
            this.Nama = pNama;
        }
        #endregion

        #region Properties
        public string IdJabatan { get => idJabatan; set => idJabatan = value; }
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
        public static void TambahData(Jabatan j)
        {
            string sql = $"INSERT INTO jabatan(idJabatan, nama) VALUES('{j.IdJabatan}','{j.Nama.Replace("'", "\\'")}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Jabatan j)
        {
            string sql = $"UPDATE jabatan SET nama = '{j.Nama.Replace("'", "\\'")}' WHERE idJabatan = '{j.IdJabatan}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Jabatan j)
        {
            string sql = $"DELETE FROM jabatan WHERE idJabatan = '{j.IdJabatan}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Jabatan> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM jabatan";
            }
            else
            {
                sql = $"SELECT * FROM jabatan WHERE {kriteria} LIKE '%{nilaiKriteria}%'";
            }

            List<Jabatan> listJabatan = new List<Jabatan>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Jabatan j = new Jabatan(hasil.GetString(0), hasil.GetString(1));
                    listJabatan.Add(j);
                }
            }
            return listJabatan;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(idJabatan) FROM jabatan";

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