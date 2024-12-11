using System;
using System.Diagnostics;

static ulong NactiDlouheKladneCislo(string text1, string text2)
{
    Console.Write(text1);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo))
        Console.Write(text2);
    return cislo;
}

static ulong FibonacciKlasik(ulong x) {
    if (x == 0)
        return 0;
    
    if (x == 1)
        return 1;
    
    ulong predminulyPrvek = 0;
    ulong minulyPrvek = 1;
    ulong vysledek = 0;
    for (ulong i = 1; i < x; i++) {
        vysledek = predminulyPrvek + minulyPrvek;
        predminulyPrvek = minulyPrvek;
        minulyPrvek = vysledek;
    }
    return vysledek;
}
  
string opakovani = "a";
while (opakovani == "a") {
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("Fibonacciho posloupnost - iterativní způsob");
    Console.WriteLine("********************************************");

    ulong n = NactiDlouheKladneCislo("Zadejte, kolikátý prvek Fibonacciho posloupnosti chcete určit (n): ","Neplatný vstup. Zadej znovu číslo  n: ");    

    Console.WriteLine("\n\n=========== Klasická = iterativní verze ===========");
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    // nebo asi lepší
    //  Stopwatch stopwatch = Stopwatch.StartNew(); 

    ulong suma = 0;
    for (ulong i = 0; i <= n; i++) {
        ulong aktualPrvek = FibonacciKlasik(i);
        suma = suma + aktualPrvek;
        Console.Write("{0}; ", aktualPrvek);
    }

    Console.WriteLine();
    Console.WriteLine("\n{0}. prvek Fibonacciho posloupnosti je: {1}", n, FibonacciKlasik(n));

    Console.WriteLine("\nSoučet posloupnosti (do {1} prvku): {0}", suma, n);

    stopwatch.Stop();
    Console.WriteLine("\nČas trvání výpočtu: {0}", stopwatch.Elapsed);

    Console.WriteLine("\n\nOpakování programu - zmáčkněte klávesu a");
    opakovani = Console.ReadLine();

}