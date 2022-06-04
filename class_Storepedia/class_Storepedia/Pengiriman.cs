using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace class_Storepedia
{
    public class Pengiriman
    {
        private string status;
        private DateTime tanggal;
        private NotaJual nota;
        private Pegawai pegawai;

        #region Constructors
        public Pengiriman(NotaJual nota, Pegawai pegawai, DateTime tanggal, string status)
        {
            this.Status = status;
            this.Tanggal = tanggal;
            this.Nota = nota;
            this.Pegawai = pegawai;
        }
        #endregion

        #region Properties
        public string Status { get => status; set => status = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public NotaJual Nota { get => nota; set => nota = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        #endregion

        #region Methods
        public static void TambahData(Pengiriman peng)
        {
            string sql = $"INSERT INTO pengiriman(noNota, idPegawai) VALUES('{peng.Nota.NoNota}','{peng.Pegawai.IdPegawai}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Pengiriman peng)
        {
            string tanggal = peng.tanggal.Year == 0001 ? "NULL" : $"'{peng.Tanggal:yyyy-MM-dd HH:mm:ss}'";
            string status = peng.Status == "" ? "NULL" : $"'{peng.status}'";
            string sql = $"UPDATE pengiriman SET idPegawai = '{peng.Pegawai.IdPegawai}', tanggal = {tanggal}, status = {status} WHERE noNota = '{peng.Nota.NoNota}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Pengiriman peng)
        {
            string sql = $"DELETE FROM pengiriman WHERE noNota = '{peng.Nota.NoNota}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Pengiriman> BacaData(string kriteria, string nilaiKriteria, string orderBy)
        {
            string sql;
            if (kriteria == "" || nilaiKriteria == "")
            {
                sql = "SELECT pk.noNota, nj.tanggal, nj.ongkosKirim, nj.tipePembayaran, nj.idPelanggan, pk.status, pk.tanggal AS 'tanggalKirim', pk.idPegawai, peg.nama FROM pengiriman pk INNER JOIN notajual nj ON pk.noNota = nj.noNota INNER JOIN pegawai peg ON pk.idPegawai = peg.idPegawai ORDER BY pk.noNota ASC";
            }
            else
            {
                if (nilaiKriteria == "NULL")
                {
                    sql = $"SELECT pk.noNota, nj.tanggal, nj.ongkosKirim, nj.tipePembayaran, nj.idPelanggan, pk.status, pk.tanggal AS 'tanggalKirim', pk.idPegawai, peg.nama FROM pengiriman pk INNER JOIN notajual nj ON pk.noNota = nj.noNota INNER JOIN pegawai peg ON pk.idPegawai = peg.idPegawai WHERE {kriteria} IS NULL";
                }
                else
                    sql = $"SELECT pk.noNota, nj.tanggal, nj.ongkosKirim, nj.tipePembayaran, nj.idPelanggan, pk.status, pk.tanggal AS 'tanggalKirim', pk.idPegawai, peg.nama FROM pengiriman pk INNER JOIN notajual nj ON pk.noNota = nj.noNota INNER JOIN pegawai peg ON pk.idPegawai = peg.idPegawai WHERE {kriteria} LIKE '%{nilaiKriteria}%' ORDER BY {orderBy}";
            }

            List<Pengiriman> listPengiriman = new List<Pengiriman>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Pelanggan pel = Pelanggan.BacaData("idPelanggan", hasil.GetString(4))[0];
                    NotaJual nota = new NotaJual(hasil.GetString(0), hasil.GetDateTime(1), hasil.GetInt32(2), hasil.GetString(3), pel);
                    Pegawai peg = Pegawai.BacaData("Peg.IdPegawai", hasil.GetString(7))[0];

                    listPengiriman.Add(new Pengiriman(nota, peg, hasil.IsDBNull(6) ? DateTime.MinValue : hasil.GetDateTime(6), hasil.IsDBNull(5) ? null : hasil.GetString(5)));
                }
            }
            return listPengiriman;
        }
        #endregion
    }
}