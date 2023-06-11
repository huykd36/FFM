using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace FFM
{
    public class LopDungChung :System.Web.UI.Page
    {
        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDIO\Project FFM\FFM\FFM\App_Data\FFMDatabase.mdf;Integrated Security=True";
        SqlConnection conn;

        public LopDungChung()
        {
            conn = new SqlConnection(sqlcon);
        }

        public void ketnoi()
        {
            //string sqlcon = @"Data Source=LAPTOP-BJGRVBV0\HUY;Initial Catalog=FFM;Integrated Security=True";
            //string sqlcon = @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Server.MapPath("App_Data / FFMDatabase.mdf") + "; Integrated Security = True";

            conn = new SqlConnection(sqlcon);
            conn.Open();
        }

        public void dongketnoi()
        {
            conn.Close();
        }

        public void Nonquery(string sql)
        {
            SqlCommand com = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int ketqua = com.ExecuteNonQuery();
                if (ketqua >= 1) Response.Write("<script>alert('Create account successful');</script>");/*MessageBox.Show("Thêm thành công");*/
                else
                    Response.Write("<script>alert('Cannot create account');</script>");
                //else MessageBox.Show("Lỗi TRY, .....");

            }
            catch
            {
                Response.Write("<script>alert('erro!!!');</script>");
                //MessageBox.Show("Lỗi Catch, Lỗi trùng mã, Lỗi SQL .....");
            }
            finally
            {
                conn.Close();
            }
        }
        public object Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int dem = (int)comm.ExecuteScalar();
            conn.Close();
            return dem;
        }

        public DataTable docdulieu(string sql)
        {

            DataTable dt = new DataTable();

            try
            {
                ketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);

            }
            catch
            {
                // thong bao loi
            }
            finally
            {
                dongketnoi();

            }

            return dt;
        }
    }
}