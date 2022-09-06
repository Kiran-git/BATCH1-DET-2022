using BATCH1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BATCH1_DET_2022
{
    public class Database1stApporach
    {
        public static void Main()
        {
           
            //  getAllEmpDetailsByID();
            // updateNewEmployee();
            //tsqlContext();
          //  GetEmpSP();

            Console.ReadLine();

        }
        //    // public static void updateNewEmployee()

        //    //  {
        //    //  var ctx = new tsqlContext();
        //    //   var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    //   Console.WriteLine(emp.Ename + " " + emp.Sal + " " + emp.Job);
        //    // }
        //    //{
        //    //    var ctx = new tsqlContext();
        //    //    try
        //    //    {
        //    //        Emp employee = new Emp();
        //    //        employee.Empno = 1002;
        //    //        employee.Ename = "jtffdrg";
        //    //        employee.Sal = 1000;
        //    //        employee.Deptno = 30;
        //    //        employee.Job = "Trainer";
        //    //        ctx.Update(employee);
        //    //        ctx.SaveChanges();
        //    //        Console.WriteLine("New employee updated");
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        Console.WriteLine(ex.InnerException.Message);
        //    //    }
        //    //}

        //    private static void GetEmpSP()
        //    {
        //        var ctx = new tsqlContext();

        //        var employee = ctx.Emps.FromSqlRaw($"GetEmployee1").ToList();

        //        foreach (var e in employee)
        //        {
        //            Console.WriteLine(e.Ename);
        //        }
        //    }

     

    }
}
