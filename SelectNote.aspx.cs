using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class SelectNote : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.BindRepeater();
    }
    private void BindRepeater()
    {
        string CS = ConfigurationManager.ConnectionStrings["SummernoteCS"].ConnectionString;
        using (SqlConnection connect = new SqlConnection(CS))
        {
            using (SqlCommand cmd = new SqlCommand("Select Title from tblTypedText",connect))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    RepeaterTitle.DataSource = dt;
                    RepeaterTitle.DataBind();
                }
            }
        }
    }

    protected void RepeaterTitle_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
    {

    }
}