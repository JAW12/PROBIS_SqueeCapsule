using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PROBIS_SqueeCapsule
{

    public abstract class Model
    {
        public string tablename = "";
        public OracleConnection conn;
        public abstract bool save();
        public abstract bool delete(string where);
        public abstract bool update(string where);
    }

    public class KamarModel : Model
    {
        public string nomor, jenis, harga, status;
        public KamarModel(string nomor, string jenis, string harga, string status)
        {
            this.conn = Database.conn;
            this.tablename = "kamar";
            this.nomor = nomor;
            this.jenis = jenis;
            this.harga = harga;
            this.status = status;
        }

        public KamarModel()
        {
            this.conn = Database.conn;
            this.tablename = "kamar";
        }

        public override bool delete(string where)
        {
            string query = $"delete from {tablename} where {where}";
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            throw new NotImplementedException();
        }
            
        public override bool save()
        {
            string query = $"insert into {tablename} (nomor_kamar, jenis_kamar, harga_kamar, status_tersedia) values('{nomor}', '{jenis}', '{harga}', '{status}')";
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            throw new NotImplementedException();
        }

        public override bool update(string where)
        {
            string query = $"update {tablename} set nomor_kamar = '{nomor}', jenis_kamar = '{jenis}', harga_kamar = '{harga}', status_tersedia = '{status}' where {where}";
            conn.Close();
            conn.Open();
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                conn.Close();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
