using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;
using System.Drawing;
using System.IO;

namespace class_Storepedia
{
    public class NotaJual
    {
        private string noNota;
        private DateTime tanggal;
        private int ongkosKirim;
        private string tipePembayaran;
        private Pelanggan pelanggan;
        private List<DetilNotaJual> listDetilNotaJual;

        #region Constructors
        public NotaJual(string pNoNota, DateTime pTanggal, int pOngkosKirim, string pTipePembayaran, Pelanggan pPelanggan)
        {
            this.NoNota = pNoNota;
            this.Tanggal = pTanggal;
            this.OngkosKirim = pOngkosKirim;
            this.TipePembayaran = pTipePembayaran;
            this.Pelanggan = pPelanggan;
            this.ListDetilNotaJual = new List<DetilNotaJual>();
        }
        #endregion

        #region Properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public int OngkosKirim 
        { 
            get => ongkosKirim; 
            set
            {
                if (value > 0)
                    ongkosKirim = value;
                else
                    throw new ArgumentException("Ongkos kirim tidak boleh bernilai negatif atau bernilai nol.");
            }
        }
        public string TipePembayaran 
        { 
            get => tipePembayaran; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    tipePembayaran = value;
                else
                    throw new ArgumentException("Tipe Pembayaran tidak boleh kosong.");
            }
        }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public List<DetilNotaJual> ListDetilNotaJual { get => listDetilNotaJual; private set => listDetilNotaJual = value; }
        #endregion

        #region Methods
        public static string GenerateNoNota(DateTime tanggal)
        {
            string sql = $"SELECT MAX(RIGHT(NoNota, 3)) FROM notajual WHERE DATE(Tanggal) = DATE('{tanggal:yyyy-MM-dd}')";
            int noUrutNota;
            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true && !hasil.IsDBNull(0))
                {
                    noUrutNota = int.Parse(hasil.GetString(0)) + 1;
                }
                else
                    noUrutNota = 1;
            }
            return $"{tanggal:yy}{tanggal:MM}{tanggal:dd}_{noUrutNota.ToString().PadLeft(3, '0')}";
        }

        public void TambahDetilNotaJual(Barang b, int harga, int jumlah)
        {
            DetilNotaJual detilNota = new DetilNotaJual(harga, jumlah, b);
            ListDetilNotaJual.Add(detilNota);
        }

        public static void TambahData(NotaJual nota)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    string sql1 = $"INSERT INTO notajual(NoNota, Tanggal, OngkosKirim, TipePembayaran, IdPelanggan) VALUES('{nota.NoNota}','{nota.Tanggal:yyyy-MM-dd HH:mm:ss}','{nota.OngkosKirim}','{nota.TipePembayaran}','{nota.Pelanggan.IdPelanggan}')";
                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (DetilNotaJual detilNota in nota.ListDetilNotaJual)
                    {
                        string sql2 = $"INSERT INTO detil_notajual(NoNota, IdBarang, Harga, Jumlah) VALUES ('{nota.NoNota}','{detilNota.Barang.IdBarang}','{detilNota.Harga}','{detilNota.Jumlah}')";
                        Koneksi.JalankanPerintahDML(sql2);

                        Barang.UpdateStok("penjualan", detilNota.Barang.IdBarang, detilNota.Jumlah);
                    }
                    transScope.Complete();
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    throw new Exception($"Penyimpanan transaksi penjualan gagal. Pesan kesalahan: {ex.Message}");
                }
            }
        }

        public static List<NotaJual> BacaData(string kriteria, string nilaiKriteria, string orderBy)
        {
            string sql;
            if (kriteria == "")
            {
                sql = $"SELECT N.NoNota, N.Tanggal, N.OngkosKirim, N.TipePembayaran, N.IdPelanggan, Plg.Nama AS NamaPelanggan, Plg.Alamat AS AlamatPelanggan FROM NotaJual N INNER JOIN Pelanggan Plg ON N.IdPelanggan = Plg.IdPelanggan ORDER BY {orderBy}";
            }
            else
            {
                sql = $"SELECT N.NoNota, N.Tanggal, N.OngkosKirim, N.TipePembayaran, N.IdPelanggan, Plg.Nama AS NamaPelanggan, Plg.Alamat AS AlamatPelanggan FROM NotaJual N INNER JOIN Pelanggan Plg ON N.IdPelanggan = Plg.IdPelanggan WHERE {kriteria} LIKE '%{nilaiKriteria}%' ORDER BY {orderBy}";
            }

            List<NotaJual> listNotaJual = new List<NotaJual>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Pelanggan pel = new Pelanggan(Pelanggan.BacaData("idPelanggan", hasil.GetString(4))[0]);
                    NotaJual nota = new NotaJual(hasil.GetString(0), hasil.GetDateTime(1), hasil.GetInt32(2), hasil.GetString(3), pel);
                    nota.ListDetilNotaJual = DetilNotaJual.BacaData("noNota", nota.NoNota);
                    listNotaJual.Add(nota);
                }
            }
            return listNotaJual;
        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<NotaJual> listNotaJual = NotaJual.BacaData(pKriteria, pNilaiKriteria, "N.NoNota DESC");
            List<int> jumNota = new List<int>();
            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (NotaJual nota in listNotaJual)
            {
                file.WriteLine("");
                file.WriteLine("STOREPEDIA");
                file.WriteLine("Jl. Megah Jaya Selatan No.30 - Jakarta");
                file.WriteLine("Telp. (031) - 8754321");
                file.WriteLine("=".PadRight(76, '='));

                file.WriteLine($"No.Nota : {nota.NoNota}");
                file.WriteLine($"Tanggal : {nota.Tanggal}");
                file.WriteLine("");
                file.WriteLine($"Pelanggan : {nota.Pelanggan.Nama}");
                file.WriteLine($"Alamat    : {nota.Pelanggan.Alamat}");
                file.WriteLine("");
                file.WriteLine("=".PadRight(76, '='));

                long grandTotal = 0;
                foreach (DetilNotaJual dnj in nota.ListDetilNotaJual)
                {
                    string nama = dnj.Barang.NamaBarang;
                    string sisa = "";

                    if (nama.Length > 36)
                    {
                        sisa = nama.Substring(36, nama.Length - 36);
                        nama = nama.Substring(0, 36);
                    }

                    int jumlah = dnj.Jumlah;

                    long harga = dnj.Harga;

                    long subTotal = jumlah * harga;

                    file.Write(nama.PadRight(37, ' '));
                    file.Write(jumlah.ToString().PadLeft(5, ' '));
                    file.Write(harga.ToString("#,###").PadLeft(16, ' '));
                    file.Write(subTotal.ToString("#,###").PadLeft(18, ' '));
                    file.WriteLine("");
                    if (sisa != "")
                        file.WriteLine(sisa);

                    grandTotal += subTotal;
                }

                file.WriteLine("=".PadRight(76, '='));
                file.WriteLine($"TOTAL : Rp{grandTotal:#,###}");
                file.WriteLine("=".PadRight(76, '='));
            }
            file.Close();

            string[] list = File.ReadAllLines(pNamaFile);
            int count = 0;
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] != "STOREPEDIA" || i == 1)
                {
                    count++;
                }
                else
                {
                    jumNota.Add(count);
                    count = 1;
                }
            }
            jumNota.Add(count);
            Cetak c = new Cetak(pNamaFile, pFont, 20, 20, 10, 10, jumNota);
            c.CetakKePrinter("text");
        }
        #endregion
    }
}