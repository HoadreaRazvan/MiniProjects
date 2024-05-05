using App.services;
using System;

using App.exceptions;

namespace Parc_Auto_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MasinaService service = new MasinaService();
            //int y = 0;
            //try
            //{
            //    //service.create(new App.Masina("Dacia", "Logan", 321, 47));
            //    int x = 7 / y;

            //}catch(MasinaExistsException e)
            //{
            //    Console.WriteLine("atentie");       
            //}

            //service.create(new App.Masina("1", "1", 1, 1));

            //service.deleteByMarca("1");
            //service.deleteById(123);


        }
    }
}