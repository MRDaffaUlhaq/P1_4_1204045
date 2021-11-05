using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU PERSEGI PANJANG");
            Console.WriteLine("1. Hitung Luas \n2. Hitung Keliling \n3. Hitung Panjang Diagonal");

            Console.WriteLine("");
            Console.Write("Menu Pilihan : ");

            int input = Convert.ToInt16(Console.ReadLine());

            if(input == 1)
            {
                Console.WriteLine("LUAS PERSEGI PANJANG");
                
                Console.Write("Masukkan Panjang = ");
                int p = Convert.ToInt16(Console.ReadLine());
                
                Console.Write("\nMasukkan Lebar = ");
                int l = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nLuas Persegi Panjang = "+ p * l);
            }
            else if(input == 2)
            {
                Console.WriteLine("KELILING PERSEGI PANJANG");

                Console.Write("Masukkan Panjang = ");
                int p = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nMasukkan Lebar = ");
                int l = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nKeliling Persegi Panjang = " + 2 * ( p + l ));
            }
            else if (input == 3)
            {
                Console.WriteLine("PANJANG DIAGONAL PERSEGI PANJANG");

                Console.Write("Masukkan Panjang = ");
                int p = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nMasukkan Lebar = ");
                int l = Convert.ToInt16(Console.ReadLine());

                int d = (p * p) + (l * l);
                double diagonal = Math.Sqrt(d);
                Console.Write("\nPanjang Diagonal Persegi Panjang = "  + diagonal);
            }

        }
    }
}
