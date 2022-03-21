using System;
using System.Data;
using System.Data.SqlClient;
namespace ADOUsingStoredProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionString = "data source=.; database=EmployeeManagement; integrated security=true";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {

                    
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "InsertData";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param1 = new SqlParameter();

                    param1.ParameterName = "@EmpNO"; 
                    param1.SqlDbType = SqlDbType.Int; 
                    param1.Value = 80; 
                    param1.Direction = ParameterDirection.Input; 
                    

                    cmd.Parameters.Add(param1);

                    SqlParameter param2 = new SqlParameter();

                    param2.ParameterName = "@EmpName"; 
                    param2.SqlDbType = SqlDbType.VarChar; 
                    param2.Value = "NoName"; 
                    param2.Direction = ParameterDirection.Input; 
                    

                    cmd.Parameters.Add(param2);

                    SqlParameter param3 = new SqlParameter();

                    param3.ParameterName = "@EmpSal"; 
                    param3.SqlDbType = SqlDbType.Int; 
                    param3.Value = "45000"; 
                    param3.Direction = ParameterDirection.Input; 
                    
                    cmd.Parameters.Add(param3);

                    SqlParameter param4 = new SqlParameter();

                    param4.ParameterName = "@EmpType";
                    param4.SqlDbType = SqlDbType.Char;
                    param4.Value = "C";
                    param4.Direction = ParameterDirection.Input;
                    
                    cmd.Parameters.Add(param4);

                    con.Open();
                    
                    SqlDataReader rd = cmd.ExecuteReader();
                    Console.WriteLine("Employee Data");
                    while (rd.Read())
                    {
                        Console.WriteLine(rd[0] +"," + rd[1] + "," + rd[2] + "," + rd[3]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            Console.ReadKey();
        }
    }
}