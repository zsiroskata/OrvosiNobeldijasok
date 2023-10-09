using System;
using System.IO;
using System.Collections.Generic;
namespace OrvosiNobeldijasok
{
    class Program
    {
        static void Main(string[] args)
        {
            var sr = new StreamReader(
                path: @"..\..\..\orvosi_nobeldijak.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream)
            {
                var sor = new Nobeldijas(sr.ReadLine());
                nobeldijasok.Add(sor);
            }
        }

        static List<Nobeldijas> nobeldijasok = new List<Nobeldijas>();
    }
}
