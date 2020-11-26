using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week7_BDConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace Week7_BDConnect.Pages.Students
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Student StudentRecord { get; set; }

        public IActionResult OnPost()
        {
            string DbConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Week7-DBConnect;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection conn = new SqlConnection(DbConnection);
            conn.Open();

            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = conn;
                command.CommandText = @"INSERT INTO Student (StudentID, StudentName, StudentLName, StudentCourse, StudentStatus, StudentYear, StudentLevel) VALUES (@SID, @SName, @SLName, @SCourse, @SStatus, @SYear, @SLevel)";

                command.Parameters.AddWithValue("@SID", StudentRecord.StudentID);
                command.Parameters.AddWithValue("@SName", StudentRecord.StudentName);
                command.Parameters.AddWithValue("@SLName", StudentRecord.StudentLName);
                command.Parameters.AddWithValue("@SCourse", StudentRecord.StudentCourse);
                command.Parameters.AddWithValue("@SStatus", StudentRecord.StudentStatus);
                command.Parameters.AddWithValue("@SYear", StudentRecord.StudentYear);
                command.Parameters.AddWithValue("@SLevel", StudentRecord.StudentLevel);

                Console.WriteLine(StudentRecord.StudentID);
                Console.WriteLine(StudentRecord.StudentName);
                Console.WriteLine(StudentRecord.StudentLName);
                Console.WriteLine(StudentRecord.StudentCourse);
                Console.WriteLine(StudentRecord.StudentStatus);
                Console.WriteLine(StudentRecord.StudentYear);
                Console.WriteLine(StudentRecord.StudentLevel);


                command.ExecuteNonQuery();
            }


            return RedirectToPage("/Index");
        }


        public void OnGet()
        {
        }

    }

}
