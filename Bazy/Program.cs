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
                #region Pierwsze zapytanie
                Console.WriteLine("\n****** Pierwsze zapytanie ******");
		conn.Open();//otwieramy połączenie
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "Select Count(*) from Ksiazki;";//srednik w cudzyslowie, bo zapytanie sqlowe jest
                comm.CommandType = System.Data.CommandType.Text;//w zasadzie ta komenda nie jest potrzebna, bo w domyśle komendy są wydawane w tekście... natomiast pokazuje możlwiości i składnię...
                comm.Connection = conn;//pokazuje z którą bazą danych mamy się połączyć.
                int ilosc = (int)comm.ExecuteScalar();//--powyższe zapytanie zwraca pojedyńczą wartość, więc można tę komendę zastosować--
                int i = 0;
                Console.WriteLine(++i);
                Console.WriteLine("Ilość książek: {0}.", ilosc); 
	#endregion

                #region Drugie zapytanie
                Console.WriteLine("\n****** Drugie zapytanie ******");
		comm.CommandText = "Select * from Ksiazki;";
                SqlDataReader dr = comm.ExecuteReader();//sqldatareader przypomina enumeratora - mozna go potraktowac komenda while
                int ii = 0;
                while (dr.Read())
                {
                    
                    Console.WriteLine(++ii);
                    Console.WriteLine("\nID książki: {0,2}  Tytuł: {1,5}  \nIDKategorii:{2}", dr[0], dr["Tytul"], dr.IsDBNull(2)?"BRAK":dr[2]);//ten zapis wyszczególnia BRAK gdy nie ma IDKategorii! :)
                } 
                dr.Close();
	#endregion

                #region Trzecie zapytanie
                //nazwa kategorii i tytuł książki mamy uzyskać
                Console.WriteLine("\n****** Trzecie zapytanie ******");
                comm.CommandText = "Select Tytul, Kategoria FROM Ksiazki LEFT JOIN Kategorie ON Ksiazki.IDKategorii = Kategorie.IDKategorii;";
                //comm.CommandText = "Select Tytul, Kategoria FROM Ksiazki K LEFT JOIN Kategorie R ON K.IDKategorii = R.IDKategorii";
                dr = comm.ExecuteReader();
                int iii = 0;
                while (dr.Read())
                {
                    
                    Console.WriteLine(++iii);
                    Console.WriteLine("{0} {1} ", dr["Tytul"], (dr.IsDBNull(1) ? "BRAK" : dr[1]));//ten zapis wyszczególnia BRAK gdy nie ma IDKategorii! :)
                }
                dr.Close(); 
                #endregion

                
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
