using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;
using System.IO;
using System.Drawing;

namespace class_Storepedia
{
    public class NotaBeli
    {
        private string noNota;
        private DateTime tanggalPesan;
        private Pegawai pegawai;
        private Supplier supplier;
        private List<DetilNotaBeli> listDetilNotaBeli;
        private string namaKurir;
        private DateTime tanggalTerima;

        #region Constructor
        public NotaBeli(string noNota, DateTime tanggalPesan, Pegawai pegawai, Supplier supplier, [Optional]DateTime tanggalTerima, [Optional] string namaKurir)
        {
            this.NoNota = noNota;
            this.TanggalPesan = tanggalPesan;
            this.Pegawai = pegawai;
            this.Supplier = supplier;
            ListDetilNotaBeli = new List<DetilNotaBeli>();
            this.TanggalTerima = tanggalTerima;
            this.NamaKurir = namaKurir;
        }
        #endregion

        #region Properties
        public string NoNota { get => noNota; set => noNota = value; }
        public DateTime TanggalPesan { get => tanggalPesan; set => tanggalPesan = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public List<DetilNotaBeli> ListDetilNotaBeli { get => listDetilNotaBeli; private set => listDetilNotaBeli = value; }
        public string NamaKurir { get => namaKurir; set => namaKurir = value; }
        public DateTime TanggalTerima { get => tanggalTerima; set => tanggalTerima = value; }
        #endregion

        #region Method
        public static string GenerateNoNota(DateTime tanggalPesan)
        {
            string sql = $"SELECT MAX(RIGHT(NoNota, 3)) FROM notabeli WHERE DATE(TanggalPesan) = DATE('{tanggalPesan:yyyy-MM-dd}')";
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
            return $"{tanggalPesan:yy}{tanggalPesan:MM}{tanggalPesan:dd}_{noUrutNota.ToString().PadLeft(3, '0')}";
        }

        public void TambahDetilNotaBeli(Barang b, int harga, int jumlah)
        {
            DetilNotaBeli detilNota = new DetilNotaBeli(harga, jumlah, b);
            ListDetilNotaBeli.Add(detilNota);
        }

        public static void TambahData(NotaBeli nota)
        {
            using (TransactionScope transScopeClass = new TransactionScope())
            {
                try
                {
                    string sql1 = $"INSERT INTO notabeli(NoNota, TanggalPesan, IdPegawai, IdSupplier) VALUES('{nota.NoNota}','{nota.TanggalPesan:yyyy-MM-dd HH:mm:ss}','{nota.Pegawai.IdPegawai}','{nota.Supplier.IdSupplier}')";
                    Koneksi.JalankanPerintahDML(sql1);

                    foreach (DetilNotaBeli detilNota in nota.ListDetilNotaBeli)
                    {
                        string sql2 = $"INSERT INTO detil_notabeli(NoNota, IdBarang, Harga, Jumlah) VALUES ('{nota.NoNota}','{detilNota.Barang.IdBarang}','{detilNota.Harga}','{detilNota.Jumlah}')";
                        Koneksi.JalankanPerintahDML(sql2);

                        Barang.UpdateStok("pembelian", detilNota.Barang.IdBarang, detilNota.Jumlah);
                    }
                    transScopeClass.Complete();
                }
                catch (Exception ex)
                {
                    transScopeClass.Dispose();
                    throw new Exception($"Penyimpanan transaksi pembelian gagal. Pesan kesalahan: {ex.Message}");
                }
            }
        }

        public static void UpdateTerimaBarang(NotaBeli nota)
        {
            string sql = $"UPDATE notabeli SET TanggalTerima = '{nota.TanggalTerima:yyyy-MM-dd HH:mm:ss}', NamaKurir = '{nota.NamaKurir}' WHERE NoNota = '{nota.NoNota}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<NotaBeli> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "" || nilaiKriteria == "")
            {
                sql = $"SELECT N.NoNota, N.TanggalPesan, N.IdPegawai, Peg.Nama AS NamaPegawai, N.IdSupplier, S.Nama AS NamaSupplier, S.Alamat AS AlamatSupplier, N.TanggalTerima, N.NamaKurir FROM NotaBeli N INNER JOIN Supplier S ON N.IdSupplier = S.IdSupplier INNER JOIN Pegawai Peg ON N.IdPegawai = Peg.IdPegawai ORDER BY N.NoNota DESC";
            }
            else
            {
                if (nilaiKriteria == "NULL")
                {
                    sql = $"SELECT N.NoNota, N.TanggalPesan, N.IdPegawai, Peg.Nama AS NamaPegawai, N.IdSupplier, S.Nama AS NamaSupplier, S.Alamat AS AlamatSupplier, N.TanggalTerima, N.NamaKurir FROM NotaBeli N INNER JOIN Supplier S ON N.IdSupplier = S.IdSupplier INNER JOIN Pegawai Peg ON N.IdPegawai = Peg.IdPegawai WHERE {kriteria} IS NULL ORDER BY N.NoNota DESC";
                }
                else
                {
                    sql = $"SELECT N.NoNota, N.TanggalPesan, N.IdPegawai, Peg.Nama AS NamaPegawai, N.IdSupplier, S.Nama AS NamaSupplier, S.Alamat AS AlamatSupplier, N.TanggalTerima, N.NamaKurir FROM NotaBeli N INNER JOIN Supplier S ON N.IdSupplier = S.IdSupplier INNER JOIN Pegawai Peg ON N.IdPegawai = Peg.IdPegawai WHERE {kriteria} LIKE '%{nilaiKriteria}%' ORDER BY N.NoNota DESC";
                }
            }

            List<NotaBeli> listNotaBeli = new List<NotaBeli>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read())
                {
                    NotaBeli nota = new NotaBeli(hasil.GetString(0), hasil.GetDateTime(1), Pegawai.BacaData("idPegawai", hasil.GetString(2))[0], Supplier.BacaData("idSupplier",hasil.GetString(4))[0], hasil.IsDBNull(7) ? DateTime.MinValue : hasil.GetDateTime(7), hasil.IsDBNull(8) ? null : hasil.GetString(8));
                    nota.ListDetilNotaBeli = DetilNotaBeli.BacaData("noNota", nota.NoNota);
                    listNotaBeli.Add(nota);
                }
            }
            return listNotaBeli;
        }

        public static void CetakNota(string pKriteria, string pNilaiKriteria, string pNamaFile, Font pFont)
        {
            List<NotaBeli> listNotaBeli = NotaBeli.BacaData(pKriteria, pNilaiKriteria);
            List<int> jumNota = new List<int>();
            StreamWriter file = new StreamWriter(pNamaFile);

            foreach (NotaBeli nota in listNotaBeli)
            {
                file.WriteLine("");
                file.WriteLine("STOREPEDIA [NOTA BELI]");
                file.WriteLine("Jl. Megah Jaya Selatan No.30 - Jakarta");
                file.WriteLine("Telp. (031) - 8754321");
                file.WriteLine("=".PadRight(76, '='));

                file.WriteLine($"No.Nota        : {nota.NoNota}");
                file.WriteLine($"Tanggal Pesan  : {nota.TanggalPesan}");
                file.WriteLine($"Tanggal Terima : {((nota.TanggalTerima.Year == 0001) ? "-" : nota.TanggalTerima.ToString())}");
                file.WriteLine($"Nama Kurir     : {nota.NamaKurir ?? "-"}");
                file.WriteLine("");
                file.WriteLine($"Pegawai : {nota.Pegawai.Nama}");
                file.WriteLine($"Alamat  : {nota.Pegawai.Alamat}");
                file.WriteLine("");
                file.WriteLine("=".PadRight(76, '='));

                long grandTotal = 0;
                foreach (DetilNotaBeli dnb in nota.ListDetilNotaBeli)
                {
                    string nama = dnb.Barang.NamaBarang;
                    string sisa = "";

                    if (nama.Length > 36)
                    {
                        sisa = nama.Substring(36, nama.Length - 36);
                        nama = nama.Substring(0, 36);
                    }

                    int jumlah = dnb.Jumlah;

                    long harga = dnb.Harga;

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
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] != "STOREPEDIA [NOTA BELI]" || i == 1)
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