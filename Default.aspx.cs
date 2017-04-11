using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGetHtml_Click(object sender, EventArgs e)
    {
        string htmlCode = myHtml.Value;
        string CS = ConfigurationManager.ConnectionStrings["SummernoteCS"].ConnectionString;
        using (SqlConnection connect = new SqlConnection(CS))
        {
            using (SqlCommand cmd = new SqlCommand("insert into tblTypedText (Text) values (@Text)"))
            {
                cmd.Connection = connect;
                connect.Open();
                cmd.Parameters.AddWithValue("@Text", htmlCode);
                cmd.ExecuteNonQuery();
            }
        }
    }
}