using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace class_Storepedia
{
    public class Pegawai
    {
        private string idPegawai;
        private string nama;
        private string namaPanggilan;
        private DateTime tglLahir;
        private string email;
        private string alamat;
        private long gaji;
        private string username;
        private string password;
        private Jabatan jabatan;

        #region Constructors
        public Pegawai(string pIdPegawai, string pNama, string pNamaPanggilan, DateTime pTglLahir, string pEmail, string pAlamat, long pGaji, string pUsername, string pPassword, Jabatan pJabatan)
        {
            this.IdPegawai = pIdPegawai;
            this.Nama = pNama;
            this.NamaPanggilan = pNamaPanggilan;
            this.TglLahir = pTglLahir;
            this.Email = pEmail;
            this.Alamat = pAlamat;
            this.Gaji = pGaji;
            this.Username = pUsername;
            this.Password = pPassword;
            this.Jabatan = pJabatan;
        }
        #endregion

        #region Properties
        public string IdPegawai { get => idPegawai; set => idPegawai = value; }
        public string Nama 
        { 
            get => nama; 
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
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
                        throw new ArgumentException("Email harus sesuai format.\nFormat: storepedia@email.com");
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
        public long Gaji { get => gaji; set => gaji = value; }
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
        public Jabatan Jabatan { get => jabatan; set => jabatan = value; }
        #endregion

        #region Methods
        public static void TambahData(Pegawai peg)
        {
            string sql = $"INSERT INTO pegawai(idPegawai, nama, namaPanggilan, tglLahir, email, alamat, gaji, username, password, idJabatan) VALUES('{peg.IdPegawai}','{peg.Nama.Replace("'", "\\'")}','{peg.NamaPanggilan.Replace("'", "\\'")}','{peg.TglLahir:yyyy-MM-dd}','{peg.Email.Replace("'", "\\'")}','{peg.Alamat.Replace("'", "\\'")}','{peg.Gaji}','{peg.Username}','{peg.Password.Replace("'", "\\'")}','{peg.Jabatan.IdJabatan}')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Pegawai peg)
        {
            string sql = $"UPDATE pegawai SET Nama = '{peg.Nama.Replace("'", "\\'")}', namaPanggilan = '{peg.NamaPanggilan.Replace("'", "\\'")}', tglLahir = '{peg.TglLahir:yyyy-MM-dd}', email = '{peg.Email.Replace("'", "\\'")}', alamat = '{peg.Alamat.Replace("'", "\\'")}', gaji = '{peg.Gaji}', username = '{peg.Username}', password = '{peg.Password.Replace("'", "\\'")}', idJabatan = '{peg.Jabatan.IdJabatan}' WHERE idPegawai = '{peg.IdPegawai}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Pegawai peg)
        {
            string sql = $"DELETE FROM pegawai WHERE idPegawai = '{peg.IdPegawai}'";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria, [Optional] bool exact)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT peg.idPegawai, peg.nama, peg.namaPanggilan, peg.tglLahir, peg.email, peg.alamat, peg.gaji, peg.username, peg.password, peg.idJabatan, j.nama as 'namaJabatan' " +
                      "FROM pegawai peg INNER JOIN jabatan j ON peg.idJabatan = j.idJabatan ORDER BY peg.idPegawai ASC";
            }
            else
            {
                if (exact)
                {
                    sql = "SELECT peg.idPegawai, peg.nama, peg.namaPanggilan, peg.tglLahir, peg.email, peg.alamat, peg.gaji, peg.username, peg.password, peg.idJabatan, j.nama as 'namaJabatan' " +
                          "FROM pegawai peg INNER JOIN jabatan j ON peg.idJabatan = j.idJabatan " +
                          $"WHERE {kriteria} = '{nilaiKriteria}' ORDER BY peg.idPegawai ASC";
                }
                else
                {
                    sql = "SELECT peg.idPegawai, peg.nama, peg.namaPanggilan, peg.tglLahir, peg.email, peg.alamat, peg.gaji, peg.username, peg.password, peg.idJabatan, j.nama as 'namaJabatan' " +
                          "FROM pegawai peg INNER JOIN jabatan j ON peg.idJabatan = j.idJabatan " +
                          $"WHERE {kriteria} LIKE '%{nilaiKriteria}%' ORDER BY peg.idPegawai ASC";
                }
            }

            List<Pegawai> listPegawai = new List<Pegawai>();

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                while (hasil.Read() == true)
                {
                    Jabatan j = new Jabatan(hasil.GetString(9), hasil.GetString(10));
                    Pegawai peg = new Pegawai(hasil.GetString(0), hasil.GetString(1), hasil.GetString(2), hasil.GetDateTime(3), hasil.GetString(4), hasil.GetString(5), hasil.GetInt64(6), hasil.GetString(7), hasil.GetString(8), j);
                    listPegawai.Add(peg);
                }
            }
            return listPegawai;
        }

        public static string GenerateKode()
        {
            string sql = "SELECT MAX(RIGHT(idPegawai, 2)) FROM pegawai";

            string hasilKode;

            using (DataTableReader hasil = Koneksi.JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true && !hasil.IsDBNull(0))
                {
                    int kodeTerbaru = int.Parse(hasil.GetString(0)) + 1;

                    hasilKode = "P" + kodeTerbaru.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilKode = "P01";
                }
            }
            return hasilKode;
        }
        #endregion
    }
}