using System;
using System.Data.SqlClient;

namespace FormUtamaMovieApp
{
    public class KoneksiDB
    {
        private static string connString = @"Server=RIZOO\MUHAMMADRIO;Database=MovieDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }

    // Class SesiUser untuk menyimpan informasi user yang sedang login
    public static class SesiUser
    {
        public static int IdUser { get; set; } = 0;
        public static string Nama { get; set; } = "";
        public static int RoleId { get; set; } = 0;
    }
}