// chci, aby se program opakoval po stisku klávesy "a"
        string again = "a";
        while(again == "a") {
            //Console.Clear();
            Console.WriteLine("*************************************");
            Console.WriteLine("******* Součet a součin cifer *******");
            Console.WriteLine("*************************************");
            Console.WriteLine("*********** Tomáš Žižka *************");
            Console.WriteLine("*************************************\n\n");
            Console.WriteLine();

            // Vstup od uživatele - lepší varianta
            Console.Write("Zadejte celé číslo: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo: ");
            }

            // Výpis vstupní hodnoty
            Console.WriteLine("============================");
            Console.WriteLine("Uživatel zadal: {0}", number);
            Console.WriteLine("============================\n\n");

            int suma = 0;
            int numberBackup = number;
            int digit;

            // pokud je číslo záporné, tak mínus odstraníme
            if(number < 0) {
                number = - number;
            }

            while(number >= 10) {
              digit = number % 10; // % operátor modulo
              number = (number - digit) / 10;
              Console.WriteLine("Digit = {0}", digit);
              suma = suma + digit;  
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }