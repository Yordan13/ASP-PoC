using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class students : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Student[] studentsList;

    protected void Table1_Load(object sender, EventArgs e)
    {
        var api = new API();
        studentsList = api.getData<Student>("student", "", null);
        updateRows((Table)sender);
    }

    private void updateRows(Table table)
    {
        foreach (var student in studentsList) {
            TableRow row = new TableRow();
            row.Cells.Add(new TableCell() { Text = student.lastName });
            row.Cells.Add(new TableCell() { Text = student.firstMidName });
            row.Cells.Add(new TableCell() { Text = student.enrollmentDate });
            row.Cells.Add(new CustomCell<Student>(student));
            table.Rows.Add(row);
        }
    }
}