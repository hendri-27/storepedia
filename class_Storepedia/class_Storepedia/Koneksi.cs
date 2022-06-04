using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace class_Storepedia
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        #region Constructors
        public Koneksi()
        {
            this.KoneksiDB = new MySqlConnection
            {
                //set connection string sesuai yang ada di App.Config
                ConnectionString = ConfigurationManager.ConnectionStrings["namakoneksi"].ConnectionString
            };
            this.Connect();
        }

        public Koneksi(string pServer, string pDatabase, string username, string password)
        {
            string strConnection;
            if (password != "")
            {
                strConnection = $"Server={pServer};Database={pDatabase};Uid={username};Pwd={password};";
            }
            else
            {
                strConnection = $"Server={pServer};Database={pDatabase};Uid={username};";
            }

            this.KoneksiDB = new MySqlConnection
            {
                ConnectionString = strConnection
            };

            //Panggil method connect
            this.Connect();
            
            this.UpdateAppConfig(strConnection);
        }
        #endregion

        #region Properties
        public MySqlConnection KoneksiDB { get => koneksiDB; private set => koneksiDB = value; }
        #endregion

        #region Methods
        public void Connect()
        {
            //jika koneksi sedang terbuka, maka tutup dahulu
            if (KoneksiDB.State == ConnectionState.Open)
            {
                KoneksiDB.Close();
            }
            KoneksiDB.Open();
        }

        public void UpdateAppConfig(String con)
        {
            //Buka konfigurasi App Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            //Set App Config pada section namaKoneksi yang telah dibuat sebelumnya sesuai parameter
            config.ConnectionStrings.ConnectionStrings["namakoneksi"].ConnectionString = con;

            //Simpan App Config yang telah diupdate
            config.Save(ConfigurationSaveMode.Modified, true);

            //Reload App Config dengan peraturan yang baru
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static void JalankanPerintahDML(string sql)
        {
            Koneksi k = new Koneksi();

            using (MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB))
            {
                c.ExecuteNonQuery();
                k.KoneksiDB.Close();
            }
        }

        public static void JalankanPerintahDML(string sql, byte[] gambar)
        {
            Koneksi k = new Koneksi();

            MySqlCommand c;
            using (c = new MySqlCommand("SET GLOBAL max_allowed_packet=32*1024*1024;", k.KoneksiDB))
            {
                c.ExecuteNonQuery();

                c = new MySqlCommand(sql, k.KoneksiDB);
                c.Parameters.AddWithValue("@gambar", gambar);
                c.ExecuteNonQuery();

                k.KoneksiDB.Close();
            }
        }

        public static DataTableReader JalankanPerintahQuery(string sql)
        {
            Koneksi k = new Koneksi();
            using (MySqlCommand c = new MySqlCommand(sql, k.KoneksiDB))
            {
                DataTableReader dataTable;
                using (MySqlDataReader hasil = c.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(hasil);
                    dataTable = dt.CreateDataReader();
                }
                k.KoneksiDB.Close();
                return dataTable;
            }
        }

        public bool CekUser(string user, string password, out string id)
        {
            string sql = $"(SELECT idPelanggan, username, password FROM pelanggan where username = '{user}' AND password = '{password}') UNION (SELECT idPegawai, username, password FROM pegawai where username = '{user}' AND password = '{password}')";

            using (DataTableReader hasil = JalankanPerintahQuery(sql))
            {
                if (hasil.Read() == true)
                {
                    id = hasil.GetString(0);
                    return true;
                }
                else
                {
                    id = "";
                    return false;
                }
            }
        }
        #endregion
    }
}
