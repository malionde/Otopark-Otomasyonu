using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Otopark_Otomasyon
{

    public class Database 
    {
        public string aracModel = "";
        public string aracTipi = "";
        public string plaka = "";
        public string odeme= "";
        public string musteri = "";

        private bool hasInitialized = false;
        public Database()
       {
           
       
        }

        //public bool Init()
        //{
        //    try
        //    {
        //        if (!System.IO.File.Exists("myDB.sqlite"))
        //        { //Bağlantıyı sağla
        //            string Otopark = "myDB.sqlite";
        //            SQLiteConnection.CreateFile(Otopark);
        //            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Otopark + ";Version=3;");
        //            conn.Open();

        //            // Tabloları oluştur.
        //            //ARABA -ARAÇ BİLGİLERİNİ TUT
        //            string sql = "create table araba (id INTEGER PRIMARY KEY, insanId int, model varchar(50), tipi varchar(50), odeme varchar(50), plaka varchar(10))";
        //            SQLiteCommand command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            //İNSAN - MÜŞTERİ BİLGİLERİ
        //            sql = "create table insan (id INTEGER PRIMARY KEY, isim varchar(50), telefon int)";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            //HİZMET TİPİ
        //            sql = "create table hizmet_tipi (id INTEGER PRIMARY KEY, ad varchar(50), ucret int)";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            sql = "INSERT INTO hizmet_tipi (ad,ucret) VALUES ('Dış Yıkama', 10),('İç-Dış Yıkama',20),('Motor temizliği',20),('Döşeme Temizliği',200),('Tavan Temizliği',100),('Pasta - Cila',300)";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            //ARAÇ TİPİ
        //            sql = "create table arac_tipi (id INTEGER PRIMARY KEY, ad varchar(50))";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            sql = "INSERT INTO arac_tipi (ad) VALUES ('Otomobil'),('Arazi, SUV & Pick-up'),('Motosiklet'),('Minivan & Panelvan'),('Karavan'),('Kamyon'),('Kamyonet'),('Tır')";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            //ARAÇ MODELLERİ
        //            sql = "create table arac_modelleri (id INTEGER PRIMARY KEY, ad varchar(50))";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            sql = "INSERT INTO arac_modelleri (ad) VALUES ('Anadol'),('Aston Martin'),('Audi'),('Bentley'),('BMW'),('Cadillac'),('Chery'),('Chevrolet'),('Chrysler'),('Citroën'),('Dacia'),('Daihatsu'),('Dodge'),('DS Automobiles'),('Eagle'),('Ferrari'),('Fiat'),('Ford'),('Geely'),('Honda'),('Hyundai'),('Infiniti'),('Jaguar'),('Kia'),('Lada'),('Lamborghini'),('Lancia'),('Lexus'),('Lincoln'),('Lotus'),('Maserati'),('Mazda'),('Mercedes-Benz'),('Mini'),('Mitsubishi'),('Nissan'),('Otomobil'),('Opel'),('Peugeot'),('Porsche'),('Proton'),('Renault'),('Rolls Royce'),('Rover'),('Saab'),('Seat'),('Skoda'),('Smart'),('Ssangyong'),('Subaru'),('Suzuki'),('Tata'),('Tofaş'),('Toyota'),('Volkswagen'),('Volvo')";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();


        //            // HİZMETLER - RAPORLAMAK İÇİN 
        //            sql = "create table hizmetler (id INTEGER PRIMARY KEY,arabaId int, hizmetTipiId int, tarih datetime, odemeTipi varchar(20), ucret int)";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            //PARAMETERS
        //            sql = "create table parameters (id INTEGER PRIMARY KEY, [group] varchar(20),name varchar(20),value varchar(20))";
        //            command = new SQLiteCommand(sql, conn);
        //            command.ExecuteNonQuery();

        //            conn.Close();
        //        }
        //        else return true; 

        //            hasInitialized = true;
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        hasInitialized = false;
        //        return false;
        //    }
        //}

        public void ExecuteCmd()
        {
            SQLiteTransaction trans;
            string SQL = "INSERT INTO araba (model,tipi,plaka,odeme,musteri,tarih) VALUES";
            SQL += "(@model, @tipi, @plaka, @odeme, @musteri, @tarih)";

            SQLiteCommand cmd = new SQLiteCommand(SQL);
            //cmd.Parameters.AddWithValue("@id", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@model", aracModel);
            cmd.Parameters.AddWithValue("@tipi", aracTipi);
            cmd.Parameters.AddWithValue("@plaka", plaka);
            cmd.Parameters.AddWithValue("@odeme", odeme);
            cmd.Parameters.AddWithValue("@musteri", musteri);
            cmd.Parameters.AddWithValue("@tarih", DateTime.Now);


            SQLiteConnection conn = new SQLiteConnection("Data Source=myDB.sqlite;Version=3;");
            conn.Open();
            cmd.Connection = conn;
            int retval = 0;
            try
            {
                retval = cmd.ExecuteNonQuery();
                if (retval == 1)
                    MessageBox.Show("Başarıyla Kaydedildi!");
                else
                    MessageBox.Show("Hata! Kayıt yapılamadı.");
                //trans.Commit();

             }

            catch (Exception ex)
            {
                

                //trans.Rollback();
            }
            finally
            {

                cmd.Dispose();
                conn.Close();
            }
            //if (!hasInitialized)
            //{
            //    if (!Init())
            //        throw new Exception("olmadı");
            //}
        }

        //Araç Modelleri listesindeki ad column'ı list yap
        public List<string> GetAdFromAracModelleri()
        {
            List<string> ImportedFiles = new List<string>();
            using (SQLiteConnection connect = new SQLiteConnection("Data Source=myDB.sqlite;Version=3;"))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT DISTINCT  ad FROM arac_modelleri";
                    fmd.CommandType = CommandType.Text;
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        ImportedFiles.Add(Convert.ToString(r["ad"]));
                    }
                }
            }
            return ImportedFiles;
        }
        public void UpdateOptions()
        {
           
        }

    }
}

