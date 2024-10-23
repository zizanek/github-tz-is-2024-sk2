﻿﻿string opakovani = "a";
while(opakovani == "a")
{
    Console.Clear();    
    Console.WriteLine("*****************************************");
    Console.WriteLine("**** Ciferný součet - nematematicky ****");
    Console.WriteLine("****************************************");
    
    Console.Write("\nZadejte textový řetězec obsahující číslice: ");
    string number = Console.ReadLine();
    // while(!int.TryParse(Console.ReadLine(), out a))
    //     Console.Write("Zřejmě jste nezadali celočíselnou hodnotu.\nZadejte znovu a: ");
    int suma = 0;
    int multi = 1;
    foreach(char digitChar in number)
    {
        if(char.IsDigit(digitChar)) {
            int digitNumber = int.Parse(digitChar.ToString());
            suma = suma + digitNumber;
            multi = multi * digitNumber;
        }
    }
    
    Console.WriteLine();    
    Console.WriteLine("\nSoučet cifer v zadaném textu {0} = {1}", number, suma);
    Console.WriteLine("\nSoučin cifer v zadaném textu {0} = {1}", number, multi);
    
    Console.WriteLine("\n\n\nPro opakování programu stiskněte klávesu a");
    opakovani=Console.ReadLine(); 
}
