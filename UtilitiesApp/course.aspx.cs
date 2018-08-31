using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class course : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Course[] coursesList;

    protected void Table2_Load(object sender, EventArgs e)
    {
        var api = new API();
        coursesList = api.getData<Course>("course", "", null);
        updateRows((Table)sender);
    }
    private void updateRows(Table table)
    {
        foreach (var course in coursesList)
        {
            TableRow row = new TableRow();
            row.Cells.Add(new TableCell() { Text = course.title });
            row.Cells.Add(new TableCell() { Text = course.credits.ToString() });
            row.Cells.Add(new CustomCell<Course>(course));
            table.Rows.Add(row);
        }
    }
}