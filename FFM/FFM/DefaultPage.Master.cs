using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FFM
{
    public partial class DefaultPage : System.Web.UI.MasterPage
    {
        //string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDIO\Project FFM\FFM\FFM\App_Data\FFMDatabase.mdf;Integrated Security=True";

        LopDungChung lopchung = new LopDungChung();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CDIO\Project FFM\FFM\FFM\App_Data\FFMDatabase.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btn_register_Click(object sender, EventArgs e)
        {
            
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string sqllogin = "select count (*) from [user] where user_email = '" + login_email_txt.Value + "'and user_passwd ='" + login_pass_txt.Value + "'";
            int ketqua = (int)lopchung.Scalar(sqllogin);
            if (ketqua >= 1)
            {
                Response.Redirect("testform.aspx");
            }
            else
            {
                Response.Write("<script>alert('Account and Password Invalid');</script>");
            }
        }
    }
}