using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class BuktiTransaksi
    {
        private int id;
        private string namaPemilikRek;
        private string noRekening;
        private string bankAsal;
        private string bankTujuan;
        private byte[] buktiFoto;

        #region Constructors
        public BuktiTransaksi(int pId, string pNamaPemilikRek, string pNoRekening, string pBankAsal, string pBankTujuan, byte[] pBuktiFoto)
        {
            this.Id = pId;
            this.NamaPemilikRek = pNamaPemilikRek;
            this.NoRekening = pNoRekening;
            this.BankAsal = pBankAsal;
            this.BankTujuan = pBankTujuan;
            this.BuktiFoto = pBuktiFoto;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string NamaPemilikRek 
        { 
            get => namaPemilikRek; 
            set
            {
                namaPemilikRek = value;
            }
        }
        public string NoRekening 
        { 
            get => noRekening; 
            set
            {
                noRekening = value;
            }
        }
        public string BankAsal 
        { 
            get => bankAsal;
            set
            {
                bankAsal = value;
            }
        }
        public string BankTujuan 
        { 
            get => bankTujuan; 
            set
            {
                bankTujuan = value;
            }
        }
        public byte[] BuktiFoto { get => buktiFoto; set => buktiFoto = value; }
        #endregion

        #region Methods
        public static int GenerateKode()
        {
            string sql = "SELECT MAX(id) FROM bukti_transaksi";

            DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int kode;
            if (hasil.Read() == true && !hasil.IsDBNull(0))
            {
                kode = hasil.GetInt32(0) + 1;
            }
            else
                kode = 1;

            return kode;
        }

        public static void TambahData (BuktiTransaksi bukti)
        {
            string sql = $"INSERT INTO bukti_transaksi(id, namaPemilikRek, noRekening, bankAsal, bankTujuan, buktiTransaksi) VALUES('{bukti.Id}', '{bukti.NamaPemilikRek}', '{bukti.NoRekening}', '{bukti.BankAsal}', '{bukti.BankTujuan}', @gambar)";

            Koneksi.JalankanPerintahDML(sql, bukti.BuktiFoto);
        }

        public static List<BuktiTransaksi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT * FROM bukti_transaksi";
            }
            else
            {
                sql = $"SELECT * FROM bukti_transaksi WHERE {kriteria} LIKE '%{nilaiKriteria}%'";
            }

            List<BuktiTransaksi> listBukti = new List<BuktiTransaksi>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    listBukti.Add(new BuktiTransaksi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), (byte[])hasil.GetValue(5)));
                }
            }
            return listBukti;
        }
        #endregion
    }
}