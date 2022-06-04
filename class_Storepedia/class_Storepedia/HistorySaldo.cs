using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class HistorySaldo
    {
        private Pelanggan pelanggan;
        private string noTransaksi;
        private long nominal;
        private DateTime tanggal;
        private string keterangan;
        private BuktiTransaksi bukti;

        #region Constructors
        public HistorySaldo(string pNoTransaksi, Pelanggan pPelanggan, long pNominal, DateTime pTanggal, BuktiTransaksi pBukti, string pKeterangan)
        {
            this.Pelanggan = pPelanggan;
            this.NoTransaksi = pNoTransaksi;
            this.Nominal = pNominal;
            this.Tanggal = pTanggal;
            this.Bukti = pBukti;
            this.Keterangan = pKeterangan;
        }

        public HistorySaldo(string pNoTransaksi, Pelanggan pPelanggan, long pNominal, DateTime pTanggal, string pKeterangan)
        {
            this.Pelanggan = pPelanggan;
            this.NoTransaksi = pNoTransaksi;
            this.Nominal = pNominal;
            this.Tanggal = pTanggal;
            this.Keterangan = pKeterangan;
        }
        #endregion

        #region Properties
        public string NoTransaksi { get => noTransaksi; set => noTransaksi = value; }
        public long Nominal 
        { 
            get => nominal; 
            set
            {
                if (value > 0)
                    nominal = value;
                else
                    throw new ArgumentException("Nominal minimal berisikan Rp1.");
            }
        }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Keterangan 
        { 
            get => keterangan; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    keterangan = value;
                else
                    throw new ArgumentException("Keterangan tidak boleh kosong.");
            }
        }
        public BuktiTransaksi Bukti { get => bukti; set => bukti = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        #endregion

        #region Methods
        public static string GenerateKode(string idPelanggan, string ket)
        {
            string sql = $"SELECT MAX(RIGHT(noTransaksi, 2)) FROM history_saldo WHERE idPelanggan = '{idPelanggan}' AND DATE(Tanggal) = DATE(CURRENT_DATE) AND LEFT(noTransaksi, 1) = '{ket}'";

            string hasilKode = "";

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true && !hasil.IsDBNull(0))
                {
                    int kodeTerbaru = int.Parse(hasil.GetString(0)) + 1;

                    hasilKode = kodeTerbaru.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilKode = "001";
                }
            }
            return $"{ket}{DateTime.Now:yyMMdd}{hasilKode}";
        }

        public static List<HistorySaldo> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "" || nilaiKriteria == "")
            {
                sql = "SELECT HS.NoTransaksi, HS.IdPelanggan, Pel.Nama, HS.Nominal, HS.Tanggal, HS.Keterangan, HS.IdBukti, BT.NamaPemilikRek, BT.NoRekening, BT.BankAsal, BT.BankTujuan, BT.BuktiTransaksi FROM history_saldo HS INNER JOIN Pelanggan Pel ON HS.IdPelanggan = Pel.IdPelanggan LEFT JOIN bukti_transaksi BT ON HS.IdBukti = BT.Id ORDER BY DATE(Tanggal) DESC, TIME(Tanggal) DESC";
            }
            else
            {
                sql = $"SELECT HS.NoTransaksi, HS.IdPelanggan, Pel.Nama, HS.Nominal, HS.Tanggal, HS.Keterangan, HS.IdBukti, BT.NamaPemilikRek, BT.NoRekening, BT.BankAsal, BT.BankTujuan, BT.BuktiTransaksi FROM history_saldo HS INNER JOIN Pelanggan Pel ON HS.IdPelanggan = Pel.IdPelanggan LEFT JOIN bukti_transaksi BT ON HS.IdBukti = BT.Id WHERE {kriteria} LIKE '%{nilaiKriteria}%' ORDER BY DATE(Tanggal) DESC, TIME(Tanggal) DESC";
            }

            List<HistorySaldo> listHistorySaldo = new List<HistorySaldo>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true && !hasil.IsDBNull(0))
                {
                    BuktiTransaksi bukti = null;
                    if (!hasil.IsDBNull(6))
                    {
                        bukti = BuktiTransaksi.BacaData("id", hasil.GetInt32(6).ToString())[0];
                    }
                    HistorySaldo history = new HistorySaldo( hasil.GetString(0), Pelanggan.BacaData("idPelanggan", hasil.GetString(1))[0], hasil.GetInt64(3), hasil.GetDateTime(4), bukti, hasil.GetString(5));

                    listHistorySaldo.Add(history);
                }
            }
            return listHistorySaldo;
        }
        #endregion
    }
}