using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace class_Storepedia
{
    public class Barang
    {
        private string idBarang;
        private string namaBarang;
        private string barcode;
        private int harga;
        private int stok;
        private byte[] gambar;
        private string deskripsi;
        private Kategori kategori;
        private Supplier supplier;

        #region Constructors
        public Barang(string pIdBarang, string pNamaBarang, string pBarcode, int pHargaJual, int pStok, byte[] pGambar, string pDeskripsi, Kategori pKategori, Supplier pSupplier)
        {
            this.IdBarang = pIdBarang;
            this.NamaBarang = pNamaBarang;
            this.Barcode = pBarcode;
            this.Harga = pHargaJual;
            this.Stok = pStok;
            this.Gambar = pGambar;
            this.Kategori = pKategori;
            this.Supplier = pSupplier;
            this.Deskripsi = pDeskripsi;
        }

        public Barang(Barang b)
        {
            this.IdBarang = b.IdBarang;
            this.NamaBarang = b.NamaBarang;
            this.Barcode = b.Barcode;
            this.Harga = b.Harga;
            this.Stok = b.Stok;
            this.Gambar = b.Gambar;
            this.Kategori = b.Kategori;
            this.Supplier = b.Supplier;
            this.Deskripsi = b.Deskripsi;
        }
        #endregion

        #region Properties
        public string IdBarang { get => idBarang; set => idBarang = value; }
        public string NamaBarang
        {
            get => namaBarang;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    namaBarang = value;
                }
                else
                {
                    throw new ArgumentException("Nama Barang tidak boleh kosong.");
                }
            }
        }
        public string Barcode { get => barcode; set => barcode = value; }
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
        public int Stok 
        { 
            get => stok; 
            set
            {
                if (value >= 0)
                    stok = value;
                else
                    throw new ArgumentException("Stok tidak boleh bernilai negatif.");
            }
        }
        public byte[] Gambar { get => gambar; set => gambar = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public string Deskripsi 
        { 
            get => deskripsi;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    deskripsi = value;
                else
                    throw new ArgumentException("Deskripsi tidak boleh kosong.");
            }
        }

        #endregion

        #region Methods
        public static void TambahData(Barang b)
        {
            string sql = $"INSERT INTO barang(idBarang, namaBarang, barcode, hargaJual, stok, gambar, deskripsi, kodeKategori, idMerek) VALUES('{b.IdBarang}','{b.NamaBarang.Replace("'", "\\'")}','{b.Barcode}','{b.Harga}','{b.Stok}', @gambar, '{b.Deskripsi}','{b.Kategori.KodeKategori}','{b.Supplier.IdSupplier}') ";

            Koneksi.JalankanPerintahDML(sql, b.Gambar);
        }

        public static void UbahData(Barang b)
        {
            string sql = $"UPDATE barang SET namaBarang = '{b.NamaBarang.Replace("'", "\\'")}', barcode = '{b.Barcode}', hargaJual = '{b.Harga}', gambar = @gambar, deskripsi = '{b.Deskripsi}', kodeKategori = '{b.Kategori.KodeKategori}', idMerek = '{b.Supplier.IdSupplier}' WHERE idBarang = '{b.IdBarang}' ";

            Koneksi.JalankanPerintahDML(sql, b.Gambar);
        }

        public static void HapusData(Barang b)
        {
            string sql = $"DELETE FROM barang WHERE idBarang = '{b.IdBarang}' ";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Barang> BacaData(string kriteria, string nilaiKriteria, [Optional] string kriteriaTambahan)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT b.idBarang, b.namaBarang, b.barcode, b.hargaJual, b.stok, b.gambar, b.deskripsi, b.kodeKategori, k.nama as 'namaKategori', b.idMerek, sup.nama as 'namaSupplier', sup.alamat " +
                      "FROM kategori k " +
                      "INNER JOIN barang b ON b.kodeKategori = k.kodeKategori " +
                      "INNER JOIN supplier sup ON b.idMerek = sup.idSupplier ORDER BY b.idBarang ASC";
            }
            else
            {
                sql = "SELECT b.idBarang, b.namaBarang, b.barcode, b.hargaJual, b.stok, b.gambar, b.deskripsi, b.kodeKategori, k.nama as 'namaKategori', b.idMerek, sup.nama as 'namaSupplier', sup.alamat " +
                      "FROM kategori k " +
                      "INNER JOIN barang b ON b.kodeKategori = k.kodeKategori " +
                      "INNER JOIN supplier sup ON b.idMerek = sup.idSupplier " +
                      $"WHERE {kriteria} LIKE '%{nilaiKriteria}%' {kriteriaTambahan} ORDER BY b.idBarang ASC";
            }

            List<Barang> listBarang = new List<Barang>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Kategori k = new Kategori(hasil.GetValue(7).ToString(), hasil.GetValue(8).ToString());
                    Supplier sup = new Supplier(hasil.GetValue(9).ToString(), hasil.GetValue(10).ToString(), hasil.GetValue(10).ToString());
                    Barang b = new Barang(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), (byte[])(hasil.GetValue(5)), hasil.GetValue(6).ToString(), k, sup);
                    listBarang.Add(b);
                }
            }
            return listBarang;
        }

        public static List<Barang> BacaFavorit(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM favorit";
            }
            else
            {
                sql = $"SELECT * FROM favorit WHERE {kriteria} = '{nilaiKriteria}'";
            }

            List<Barang> listFavorit = new List<Barang>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Barang favorit = new Barang(Barang.BacaData("B.idBarang", hasil.GetValue(1).ToString())[0]);
                    listFavorit.Add(favorit);
                }
            }
            listFavorit.Reverse();
            return listFavorit;
        }

        public static List<Barang> BacaCart(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM cart";
            }
            else
            {
                sql = $"SELECT * FROM cart WHERE {kriteria} = '{nilaiKriteria}'";
            }

            List<Barang> listCart = new List<Barang>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                
                while (hasil.Read() == true)
                {
                    Barang cart = new Barang(Barang.BacaData("B.idBarang", hasil.GetValue(1).ToString())[0])
                    {
                        Stok = hasil.GetInt32(2)
                    };
                    listCart.Add(cart);
                }
            }
            listCart.Reverse();
            return listCart;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(idBarang) FROM barang";

            string hasilKode;

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true && hasil.IsDBNull(0) == false)
                {
                    int kodeTerbaru = int.Parse(hasil.GetValue(0).ToString()) + 1;

                    hasilKode = kodeTerbaru.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilKode = "001";
                }
            }
            return hasilKode;
        }

        public static string GenerateBarcode(string idBarang, string kodeKategori, string idSupplier)
        {
            return "B" + idSupplier + kodeKategori + idBarang;
        }

        public static void UpdateStok(string jenisTransaksi, string kodeBrg, int jumlah)
        {
            string sql = "";
            if (jenisTransaksi == "penjualan")
            {
                sql = $"UPDATE barang SET Stok = stok - {jumlah} WHERE IdBarang = {kodeBrg}";
            }
            else if (jenisTransaksi == "pembelian")
            {
                sql = $"UPDATE barang SET Stok = stok + {jumlah} WHERE IdBarang = {kodeBrg} ";
            }

            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}