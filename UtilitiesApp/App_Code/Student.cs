using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Student
/// </summary>
public class Student
{
    public string id { set; get; }
    public string lastName { set; get; }
    public string firstMidName { set; get; }
    public string enrollmentDate { set; get; }
    public Student()
    {
    }

    public override string ToString()
    {
        return "?id=" + id + "&ln=" + lastName + "&fm=" + firstMidName + "&d=" + enrollmentDate;
    }

}