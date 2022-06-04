using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class Supplier
    {
        private string idSupplier;
        private string nama;
        private string alamat;

        #region Constructors
        public Supplier(string pIdSupplier, string pNama, string pAlamat)
        {
            this.IdSupplier = pIdSupplier;
            this.Nama = pNama;
            this.Alamat = pAlamat;
        }
        #endregion

        #region Properties
        public string IdSupplier { get => idSupplier; set => idSupplier = value; }
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
        public string Alamat
        {
            get => alamat; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    alamat = value;
                }
                else
                {
                    throw new ArgumentException("Alamat tidak boleh kosong.");
                }
            }
        }
        #endregion

        #region Methods
        public static void TambahData(Supplier sup)
        {
            string sql = $"INSERT INTO supplier(idSupplier, nama, alamat) VALUES('{sup.idSupplier}','{sup.Nama.Replace("'", "\\'")}','{sup.Alamat.Replace("'", "\\'")}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Supplier sup)
        {
            string sql = $"UPDATE supplier SET nama = '{sup.Nama.Replace("'", "\\'")}', alamat = '{sup.Alamat.Replace("'", "\\'")}' WHERE idSupplier = '{sup.idSupplier}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Supplier sup)
        {
            string sql = $"DELETE FROM supplier WHERE idSupplier = '{sup.idSupplier}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Supplier> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM supplier";
            }
            else
            {
                sql = $"SELECT * FROM supplier WHERE {kriteria} LIKE '%{nilaiKriteria}%'";
            }

            List<Supplier> listSupplier = new List<Supplier>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Supplier sup = new Supplier(hasil.GetString(0), hasil.GetString(1), hasil.GetString(2));
                    listSupplier.Add(sup);
                }
            }
            return listSupplier;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(idSupplier) FROM supplier";

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