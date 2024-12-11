using System;
using System.Diagnostics;

static ulong NactiDlouheKladneCislo(string text1, string text2)
{
    Console.Write(text1);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
        Console.Write(text2);
    return cislo;
}

static ulong FibonacciIterativni(ulong x) {
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

static ulong FibonacciRekurzivne(ulong x) {
    if (x == 0)
        return 0;
    if (x == 1)
        return 1;
    return FibonacciRekurzivne(x - 1) + FibonacciRekurzivne(x - 2);
}

string opakovani = "a";
while (opakovani == "a") {
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("Fibonacciho posloupnost - porovnání metod");
    Console.WriteLine("********************************************");

    ulong n = NactiDlouheKladneCislo("Zadejte, kolikátý prvek Fibonacciho posloupnosti chcete určit (n): ", "Neplatný vstup. Zadej znovu číslo n: ");

    Console.WriteLine("\n\n=========== Iterativní verze ===========");
    Stopwatch stopwatchIterativni = Stopwatch.StartNew();

    ulong sumaIterativni = 0;
    for (ulong i = 0; i <= n; i++) {
        ulong aktualPrvek = FibonacciIterativni(i);
        sumaIterativni += aktualPrvek;
        Console.Write("{0}; ", aktualPrvek);
    }

    stopwatchIterativni.Stop();
    Console.WriteLine("\n{0}. prvek Fibonacciho posloupnosti je: {1}", n, FibonacciIterativni(n));
    Console.WriteLine("\nSoučet posloupnosti (do {1} prvku): {0}", sumaIterativni, n);
    Console.WriteLine("\nČas trvání iterativního výpočtu: {0}", stopwatchIterativni.Elapsed);

    Console.WriteLine("\n\n=========== Rekurzivní verze ===========");
    Stopwatch stopwatchRekurzivni = Stopwatch.StartNew();

    ulong sumaRekurzivni = 0;
    for (ulong i = 0; i <= n; i++) {
        ulong aktualPrvek = FibonacciRekurzivne(i);
        sumaRekurzivni += aktualPrvek;
        Console.Write("{0}; ", aktualPrvek);
    }

    stopwatchRekurzivni.Stop();
    Console.WriteLine("\n{0}. prvek Fibonacciho posloupnosti je: {1}", n, FibonacciRekurzivne(n));
    Console.WriteLine("\nSoučet posloupnosti (do {1} prvku): {0}", sumaRekurzivni, n);
    Console.WriteLine("\nČas trvání rekurzivního výpočtu: {0}", stopwatchRekurzivni.Elapsed);

    Console.WriteLine("\n\nOpakování programu - zmáčkněte klávesu a");
    opakovani = Console.ReadLine();
}