using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace Kalkulator1

{

class Program

{

static void Main(string[] args)

{

double a, b, bagi;

Console.WriteLine("Pilihlah Sistem Operasi Yang Anda Inginkan ");

Console.WriteLine("1. Penjumlahan");

Console.WriteLine("2. Pengurangan");

Console.WriteLine("3. Perkalian");

Console.WriteLine("4. Pembagian");

int opsi;

opsi = int.Parse(System.Console.ReadLine

switch (opsi)

{

case 1

Console.WriteLine("Masukan angka pertama :");

a = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Masukan angka kedua :");

b = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Hasil dari penjumlahan");

Console.WriteLine(a + b);

Console.WriteLine("Apakah Anda Ingin Menghitung Kembali ?");

break;

case 2:

Console.WriteLine("Masukan angka pertama :");

a = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Masukan angka kedua :");

b = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Hasil dari pengurangan");

Console.WriteLine(a - b);

Console.WriteLine("Apakah Anda Ingin Menghitung Kembali ?");

break;

case 3:

Console.WriteLine("Masukan angka pertama :");

a = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Masukan angka kedua :");

b = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Hasil dari perkalian");

Console.WriteLine(a * b);

Console.WriteLine("Apakah Anda Ingin Menghitung Kembali ?");

break;

case 4:

Console.WriteLine("Masukan angka pertama :");

a = Convert.ToDouble(System.Console.ReadLine());

Console.WriteLine("Masukan angka kedua :");

b = Convert.ToDouble(System.Console.ReadLine());

bagi = a / b;

bagi = Math.Round(bagi,2);

Console.WriteLine("Hasil dari pembagian");

Console.WriteLine(bagi);

Console.WriteLine("Apakah Anda Ingin Menghitung Kembali ?");

break;

}

string ric;

Console.WriteLine("ketik lanjut/tidak");

ric= Convert.ToString(System.Console.ReadLine());

switch (ric)

{

case "lanjut":

Console.WriteLine("Silahkan Menghitung lagi");

Console.ReadLine();

Console.Clear();

break ;

case "tidak":

Console.WriteLine("Thank you");

Console.ReadLine();

break ;

}

System.Console.ReadLine();

}

}

}