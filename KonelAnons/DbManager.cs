//using Microsoft.Data.Sqlite;
using KonelAnons.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonelAnons
{
    public class DbManager
    {
        public SQLiteConnection sqliteConnection = null;
        //SqliteConnection sqliteConnection;
        public void Connect()
        {
            try
            {
                sqliteConnection = new SQLiteConnection(@"Data Source=konel_anons_db.db;Version=3;");
                sqliteConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQLite Connection Error", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveAnons(Anons anons)
        {
            Connect();
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {

                cmd.CommandText = @"insert into anons (anons_name,anons_time,anons_filepath) values ('"+ anons.anons_name+ "','"+ anons.anons_time+ "','"+ anons.anons_filepath+ "')";
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        public void EditAnons(Anons anons)
        {
            Connect();
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {

                cmd.CommandText = @"update anons set anons_name='"+anons.anons_name+"',anons_time='"+anons.anons_time+"',anons_filepath='"+anons.anons_filepath+"' where id="+anons.id;
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        public void RemoveAnons(int anonsId)
        {
            Connect();
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {

                cmd.CommandText = @"delete from anons where id="+anonsId;
                cmd.ExecuteNonQuery();
                sqliteConnection.Close();
            }
        }

        public List<Anons> GetAnonsList()
        {
            Connect();
            List<Anons> anonsList = new List<Anons>();
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {
                cmd.CommandText = @"select * from anons";
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        anonsList.Add(new Anons
                        {
                            id = rdr.GetInt32(0),
                            anons_name = rdr.GetString(1),
                            anons_time = rdr.GetString(2),
                            anons_filepath = rdr.GetString(3)
                        });
                    }
                    sqliteConnection.Close();
                }
            }
            return anonsList;
        }

        public Anons GetAnons(int anonsId)
        {
            Anons anons = null;
            Connect();
            using (SQLiteCommand cmd = new SQLiteCommand(sqliteConnection))
            {
                cmd.CommandText = @"select * from anons where id="+anonsId;
                cmd.Prepare();
                using (SQLiteDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                    {
                        anons = new Anons
                        {
                            id = rdr.GetInt32(0),
                            anons_name = rdr.GetString(1),
                            anons_time = rdr.GetString(2),
                            anons_filepath = rdr.GetString(3)
                        };
                    }
                    sqliteConnection.Close();
                }
            }
            return anons;
        }
    }
}
