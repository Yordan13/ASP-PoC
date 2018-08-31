using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditStudent : System.Web.UI.Page
{
    private string IDStudent;

    protected void Page_Init(object sender, EventArgs e)
    {
        this.IDStudent = Request.QueryString["id"];
        var txtlastName = Request.QueryString["ln"];
        var txtFirstMidName = Request.QueryString["fm"];
        var txtEnrollmentDate = Request.QueryString["d"];
        this.LastName.Text= txtlastName;
        this.FirstMidName.Text = txtFirstMidName;
        this.EnrollmentDate.Text = txtEnrollmentDate;
    }

    protected void Save_Click(object sender, EventArgs e)
    {
        var txtlastName = this.LastName.Text;
        var txtFirstMidName = this.FirstMidName.Text;
        var txtEnrollmentDate = this.EnrollmentDate.Text;
        var api = new API();
        api.getData<object>("student", "update", new [] { this.IDStudent, txtlastName, txtFirstMidName, txtEnrollmentDate });
        Server.TransferRequest("students.aspx");
    }
}