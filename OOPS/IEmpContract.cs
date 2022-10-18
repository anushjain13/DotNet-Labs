using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS;

public interface IEmpContract
{
    int WorkHoursClause();
    string SickLeavesClause();

}
public class KpmgEmployee : IEmpContract
{
    public int EmpId { get; set; }

    public string Name { get; set; }

    public string Designation { get; set; }
    public string SickLeavesClause()
    {
        return "Employee is allowed to take five sick leave per month";
    }

    public int WorkHoursClause()
    {
        return 8;
    }
}
public class DellEmployee : IEmpContract
{
    public string SickLeavesClause()
    {
        return "Employee is allowed to take five sick leave per month";
    }

    public int WorkHoursClause()
    {
        return 8;
    }
}

class Myclass : ParentClass, IContract1, IContract2
{
    //Myclass can inherit only from 1 other class 
    //multiple classes
    //But-, it can implemet multiple interfaces
    //It can also inherit from 1 class and implement
}

internal interface IContract2
{
}

internal interface IContract1
{
}

internal class ParentClass
{
}

