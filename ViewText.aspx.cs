using System;
using System.Data.SqlClient;
using System.Configuration;

public partial class ViewText : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string text = "";
        string CS = ConfigurationManager.ConnectionStrings["SummernoteCS"].ConnectionString;
        using (SqlConnection connect = new SqlConnection(CS))
        {
            using (SqlCommand cmd = new SqlCommand("Select Text from tblTypedText"))
            {
                cmd.Connection = connect;
                connect.Open();
                text = cmd.ExecuteScalar().ToString();
            }
        }

        lblMyText.Text = System.Web.HttpUtility.HtmlDecode(text);
    }
}