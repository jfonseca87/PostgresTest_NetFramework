using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppPostgresTest.Models;

namespace ConsoleAppPostgresTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (PgContext db = new PgContext())
                {
                    var posts = db.Posts.Include("comments").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
