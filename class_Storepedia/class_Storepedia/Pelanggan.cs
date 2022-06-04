using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Transactions;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace class_Storepedia
{
    public class Pelanggan
    {
        private string idPelanggan;
        private string nama;
        private string namaPanggilan;
        private DateTime tglLahir;
        private string email;
        private string alamat;
        private string noTelp;
        private string username;
        private string password;
        private long saldo;
        private List<Barang> listCart;
        private List<Barang> listFavorit;
        private List<HistorySaldo> listHistorySaldo;

        #region Constructors
        public Pelanggan(string pIdPelanggan, string pNama, string pNamaPanggilan, DateTime pTglLahir, string pEmail, string pAlamat, string pNoTelp, string pUsername, string pPassword, long pSaldo)
        {
            this.IdPelanggan = pIdPelanggan;
            this.Nama = pNama;
            this.NamaPanggilan = pNamaPanggilan;
            this.TglLahir = pTglLahir;
            this.Email = pEmail;
            this.Alamat = pAlamat;
            this.NoTelp = pNoTelp;
            this.Username = pUsername;
            this.Password = pPassword;
            this.Saldo = pSaldo;
            this.ListCart = this.listFavorit = new List<Barang>();
            this.ListHistorySaldo = new List<HistorySaldo>();
        }

        public Pelanggan(Pelanggan p, string alamat)
        {
            this.IdPelanggan = p.IdPelanggan;
            this.Nama = p.Nama;
            this.NamaPanggilan = p.NamaPanggilan;
            this.TglLahir = p.TglLahir;
            this.Email = p.Email;
            this.Alamat = alamat;
            this.NoTelp = p.NoTelp;
            this.Username = p.Username;
            this.Password = p.Password;
            this.Saldo = p.Saldo;
            this.ListCart = this.listFavorit = new List<Barang>();
            this.ListHistorySaldo = new List<HistorySaldo>();
        }

        public Pelanggan(Pelanggan p)
        {
            this.IdPelanggan = p.IdPelanggan;
            this.Nama = p.Nama;
            this.NamaPanggilan = p.NamaPanggilan;
            this.TglLahir = p.TglLahir;
            this.Email = p.Email;
            this.Alamat = p.Alamat;
            this.NoTelp = p.NoTelp;
            this.Username = p.Username;
            this.Password = p.Password;
            this.Saldo = p.Saldo;
            this.ListCart = this.listFavorit = new List<Barang>();
            this.ListHistorySaldo = new List<HistorySaldo>();
        }
        #endregion

        #region Properties
        public string IdPelanggan { get => idPelanggan; set => idPelanggan = value; }
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
        public string NamaPanggilan
        {
            get => namaPanggilan; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    namaPanggilan = value;
                }
                else
                {
                    throw new ArgumentException("Nama Panggilan tidak boleh kosong.");
                }
            }
        }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Email
        {
            get => email; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (new Regex(@"^([\w\.\-]+)@([\w]+)\.([\w]{2,3})$").IsMatch(value))
                        email = value;
                    else
                        throw new ArgumentException("Email harus sesuai format.\nContoh Format: storepedia@email.com");
                }
                else
                {
                    throw new ArgumentException("Email tidak boleh kosong.");
                }
            }
        }
        public string Alamat
        {
            get => alamat; 
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    alamat = value;
                }
                else
                {
                    throw new ArgumentException("Alamat tidak boleh kosong.");
                }
            }
        }
        public string NoTelp
        {
            get => noTelp; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (new Regex(@"^((\+62)|(0))\d{9,12}$").IsMatch(value))
                        noTelp = value;
                    else
                        throw new ArgumentException("Nomor Telepon harus sesuai format.\nContoh Format: +62081261798456 / 081261798456");
                }
                else
                {
                    throw new ArgumentException("Nomor Telepon tidak boleh kosong.");
                }
            }
        }
        public string Username
        {
            get => username; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (new Regex(@"^(\w{4,50})$").IsMatch(value))
                        username = value;
                    else
                        throw new ArgumentException("Username harus terdiri dari 4 - 50 karakter.");
                }
                else
                {
                    throw new ArgumentException("Username tidak boleh kosong.");
                }
            }
        }
        public string Password
        {
            get => password; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    if (new Regex(@"^((\w|\W){8,16})$").IsMatch(value))
                        password = value;
                    else
                        throw new ArgumentException("Password harus terdiri dari 8 - 16 karakter.");
                }
                else
                {
                    throw new ArgumentException("Password tidak boleh kosong.");
                }
            }
        }
        public long Saldo 
        { 
            get => saldo; 
            private set
            {
                if (value >= 0)
                    saldo = value;
                else
                    throw new ArgumentException("Saldo tidak boleh bernilai negatif.");
            }
        }
        public List<Barang> ListCart { get => listCart; private set => listCart = value; }
        public List<Barang> ListFavorit { get => listFavorit; private set => listFavorit = value; }
        public List<HistorySaldo> ListHistorySaldo { get => listHistorySaldo; set => listHistorySaldo = value; }

        #endregion

        #region Methods
        public static void TambahData(Pelanggan pel)
        {
            string sql = $"INSERT INTO pelanggan(idPelanggan, nama, namaPanggilan, tglLahir, email, alamat,  noTelp, username, password) VALUES('{pel.IdPelanggan}','{pel.Nama.Replace("'", "\\'")}','{pel.NamaPanggilan.Replace("'", "\\'")}','{pel.TglLahir:yyyy-MM-dd}','{pel.Email.Replace("'", "\\'")}','{pel.Alamat.Replace("'", "\\'")}','{pel.NoTelp}','{pel.Username}','{pel.Password.Replace("'", "\\'")}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Pelanggan pel)
        {
            string sql = $"UPDATE pelanggan SET nama = '{pel.Nama.Replace("'", "\\'")}', namaPanggilan = '{pel.NamaPanggilan.Replace("'", "\\'")}', tglLahir = '{pel.TglLahir:yyyy-MM-dd}', email = '{pel.Email.Replace("'", "\\'")}', alamat = '{pel.Alamat.Replace("'", "\\'")}', noTelp = '{pel.NoTelp}', username = '{pel.Username}', password = '{pel.Password.Replace("'", "\\'")}' WHERE idPelanggan = '{pel.IdPelanggan}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Pelanggan pel)
        {
            string sql = $"DELETE FROM pelanggan WHERE idPelanggan = '{pel.IdPelanggan}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria, [Optional] bool exact)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM pelanggan";
            }
            else
            {
                if (exact)
                {
                    sql = $"SELECT * FROM pelanggan WHERE {kriteria} = '{nilaiKriteria.Replace("'", "\\'")}'";
                }
                else
                {
                    sql = $"SELECT * FROM pelanggan WHERE {kriteria} LIKE '%{nilaiKriteria.Replace("'", "\\'")}%'";
                }
            }

            List<Pelanggan> listPelanggan = new List<Pelanggan>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read())
                {
                    Pelanggan pel = new Pelanggan(hasil.GetString(0), hasil.GetString(1), hasil.GetString(2), hasil.GetDateTime(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetInt64(9));
                    listPelanggan.Add(pel);
                }
            }
            return listPelanggan;
        }

        public static List<Pelanggan> BacaData(string nilaiKriteria)
        {
            string sql;

            sql = $"SELECT * FROM pelanggan WHERE username = '{nilaiKriteria.Replace("'", "\\'")}'";

            List<Pelanggan> listPelanggan = new List<Pelanggan>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Pelanggan pel = new Pelanggan(hasil.GetString(0), hasil.GetString(1), hasil.GetString(2), hasil.GetDateTime(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetInt64(9));
                    listPelanggan.Add(pel);
                }
            }
            return listPelanggan;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(idPelanggan) FROM pelanggan";

            string hasilKode;

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
            return hasilKode;
        }

        public void TambahSaldo(long jumlah, BuktiTransaksi bukti)
        {
            using (TransactionScope transScope = new TransactionScope())
            {
                try
                {
                    if ((Saldo + jumlah) <= 99999999)
                    {
                        this.TambahHistorySaldo(new HistorySaldo(HistorySaldo.GenerateKode(IdPelanggan, "I"), this, jumlah, DateTime.Now, bukti, "Isi Saldo"));
                        string sql = $"UPDATE pelanggan SET saldo = saldo + {jumlah} WHERE idPelanggan = '{this.IdPelanggan}'";
                        Koneksi.JalankanPerintahDML(sql);
                        this.Saldo += jumlah;
                        transScope.Complete();
                    }
                    else
                    {
                        transScope.Dispose();
                        throw new ArgumentException($"Saldo melebihi batas maxsimum tiap pelanggan");
                    }
                }
                catch (ArgumentException ex) 
                { 
                    throw new ArgumentException(ex.Message);
                }
                catch (Exception ex)
                {
                    transScope.Dispose();
                    throw new Exception($"Penambahan saldo gagal. Pesan kesalahan: {ex.Message}");
                }
            }
        }

        public void MengurangiSaldo(long jumlah)
        {
            if (jumlah <= this.Saldo)
            {
                using (TransactionScope transScope = new TransactionScope())
                {
                    try
                    {
                        this.TambahHistorySaldo(new HistorySaldo(HistorySaldo.GenerateKode(IdPelanggan, "P"), this, jumlah, DateTime.Now, "Pembayaran"));
                        string sql = $"UPDATE pelanggan SET saldo = saldo - {jumlah} WHERE idPelanggan = '{this.IdPelanggan}'";
                        Koneksi.JalankanPerintahDML(sql);
                        this.Saldo -= jumlah;
                        transScope.Complete();
                    }
                    catch (Exception ex)
                    {
                        transScope.Dispose();
                        throw new Exception($"Pengurangan saldo gagal. Pesan kesalahan: {ex.Message}");
                    }
                }
            }
            else
                throw new ArgumentException("Saldo tidak mencukupi");
        }

        public void BacaPref()
        {
            ListCart = Barang.BacaCart("idPelanggan", this.IdPelanggan);
            listFavorit = Barang.BacaFavorit("idPelanggan", this.IdPelanggan);
            listHistorySaldo = HistorySaldo.BacaData("HS.idPelanggan", this.IdPelanggan);
        }

        public void UpdateJumlahCart(Barang b, int jumlah)
        {
            int idx = ListCart.FindIndex(x => x.IdBarang == b.IdBarang);

            listCart[idx].Stok = b.Stok = jumlah;
            string sql = $"UPDATE cart SET Jumlah = {jumlah} WHERE idBarang = '{b.IdBarang}' AND idPelanggan = '{this.IdPelanggan}'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public void TambahCart(Barang b, int jumlah)
        {
            Barang brg = new Barang(b)
            {
                Stok = jumlah
            };
            listCart.Add(brg);
            string sql = $"INSERT INTO cart(idPelanggan, idBarang, jumlah) VALUES('{this.IdPelanggan}', '{b.IdBarang}', '{jumlah}')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public void HapusCart(Barang b)
        {
            ListCart.Remove(ListCart.Find(x => x.IdBarang == b.IdBarang));
            string sql = $"DELETE FROM cart WHERE IdBarang = '{b.IdBarang}' AND idPelanggan = '{this.IdPelanggan}'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public void TambahFavorit(Barang b)
        {
            ListFavorit.Add(b);
            string sql = $"INSERT INTO favorit(idPelanggan, idBarang) VALUES('{this.IdPelanggan}', '{b.IdBarang}')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public void HapusFavorit(Barang b)
        {
            ListFavorit.Remove(ListFavorit.Find(x => x.IdBarang == b.IdBarang));
            string sql = $"DELETE FROM favorit WHERE idPelanggan = '{this.IdPelanggan}' AND idBarang = '{b.IdBarang}'";
            Koneksi.JalankanPerintahDML(sql);
        }

        private void TambahHistorySaldo(HistorySaldo history)
        {
            ListHistorySaldo.Add(history);
            string idBukti = history.Bukti != null ? history.Bukti.Id.ToString() : "NULL";
            string sql = $"INSERT INTO history_saldo(noTransaksi, idPelanggan, nominal, tanggal, keterangan, idBukti) VALUES('{history.NoTransaksi}','{IdPelanggan}','{history.Nominal}','{history.Tanggal:yyyy-MM-dd HH:mm:ss}','{history.Keterangan}',{idBukti})";
            Koneksi.JalankanPerintahDML(sql);
        }
        #endregion
    }
}