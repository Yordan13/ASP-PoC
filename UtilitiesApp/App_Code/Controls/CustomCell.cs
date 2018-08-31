using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de CustomCell
/// </summary>
public class CustomCell<T> : TableCell
{
    public T Data { get; set; }
    public LinkButton Edit { get; set; }
    public LinkButton Details { get; set; }
    public LinkButton Delete { get; set; }
    public CustomCell(T Data)
    {
        this.Data = Data;
        Edit = new LinkButton() { Text = "Edit" };
        Details = new LinkButton() { Text = "Detail" };
        Edit.Click += this.ClickToEdit;
        Details.Click += this.ClickToDetail;
        Delete = new LinkButton() { Text = "Delete" };
        base.Controls.Add(Edit);
        base.Controls.Add(new Label() { Text = " | " });
        base.Controls.Add(Details);
        base.Controls.Add(new Label() { Text = " | " });
        base.Controls.Add(Delete);
    }

    private void ClickToEdit(object sender, EventArgs e) {
        var name = "Edit" + typeof(T).Name + ".aspx";
        var path = name + this.Data.ToString();
        base.Page.Server.Transfer(path);
    }
    private void ClickToDetail(object sender, EventArgs e)
    {
        var name = "Detail" + typeof(T).Name + ".aspx";
        var path = name + this.Data.ToString();
        base.Page.Server.Transfer(path);
    }
}