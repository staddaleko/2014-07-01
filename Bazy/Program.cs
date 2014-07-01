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
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Select Count(*) from Ksiazki";
                comm.CommandType = System.Data.CommandType.Text;//w zasadzie ta komenda nie jest potrzebna, bo w domyśle komendy są wydawane w tekście... natomiast pokazuje możlwiości i składnię...
                comm.Connection = conn;//pokazuje z którą bazą danych mamy się połączyć.
                
                
                int ilosc = (int)comm.ExecuteScalar();//--powyższe zapytanie zwraca pojedyńczą wartość, więc można tę komendę zastosować--
                Console.WriteLine("Ilość książek: {0}.", ilosc);
            }
            catch (SqlException ex)//łapiemy wyjątka typowo sqlowego
            {
                foreach (SqlError item in ex.Errors)//wyszczególniamy wszystkie errory
                {
                    Console.WriteLine("Klasa błędu: {0}, \nNumer błędu: {1}, \nOpis błędu: {2}.", item.Class, item.Number, item.Message);
                }
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
