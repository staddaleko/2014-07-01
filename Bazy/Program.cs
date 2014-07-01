using System;
using System.Collections.Generic;
using System.Data.SqlClient;//dodane na potrzeby połączenia z sql server
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=Ksiazki;Integrated Security=True;";//logowanie zintegrowane korzysta z windows user account //'@' musi być, bo są backslashe

            SqlConnection conn = new SqlConnection(connString);
//piszemy 'starą szkołę', ale pokazuje dokładnie w jaki sposób działa połączenie            
            try
            {
                conn.Open();//otwieramy połączenie
            }
            catch (Exception ex)//łapiemy wyjątka ;)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                conn.Close();//zamykamy połączenie
            }
            Console.ReadKey();
        }
    }
}
