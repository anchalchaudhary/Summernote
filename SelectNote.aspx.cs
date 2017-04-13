using System;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class SelectNote : System.Web.UI.Page
{
    string CS = ConfigurationManager.ConnectionStrings["SummernoteCS"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        this.BindRepeater();
    }
    private void BindRepeater()
    {
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
        string title = ((LinkButton)e.CommandSource).Text;
        int titleID = 0;
        using (SqlConnection connect = new SqlConnection(CS))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM tblTypedText where Title='" + title + "'"))
            {
                cmd.Connection = connect;
                connect.Open();
                titleID = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
        }
        Session["titleID"] = titleID;
        Response.Redirect("ViewText.aspx");
    }
}