 using System.Diagnostics;
    
    string opakovani = "a";

    while (opakovani == "a")
      {
      Console.Clear();
      Console.WriteLine("*******************************");  
      Console.WriteLine("Generátor pseudonáhodných čísel");
      Console.WriteLine("*******************************");

      Console.Write("\n\nKolik čísel budete chtít vygenerovat? ");
      int n;
      while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("!!! Nebylo zadáno celé číslo. Zadejte znovu počet generovaných čísel:");

      Console.Write("Zadejte dolní mez: ");
      int dm;
      while (!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("!!! Nebylo zadáno celé číslo. Zadejte znovu dolní mez:");

      Console.Write("Zadejte horní mez: ");
      int hm;
      while (!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("!!! Nebylo zadáno celé číslo. Zadejte znovu horní mez:");  

      Console.WriteLine("\nPočet čísel: {0}; dolní mez: {1}; horní mez: {2} \n",n,dm,hm);

      int[] pole = new int[n];
      int[] pole1 = new int[n]; 
      Random nahodne = new Random(); 
      
      for(int i=0;i<n;i++)
      {
        pole1[i]=pole[i] = nahodne.Next(dm, hm+1);
        Console.Write("{0}; ",pole[i]);
      }
      

      // Bubble sort
      int pocetVymenB=0;
      Stopwatch stopky = new Stopwatch();
      stopky.Start();
      for(int i=0;i<n-1;i++)
        for(int j=0;j<n-i-1;j++)
          if(pole[j]<pole[j+1])
          {
            int pom = pole[j+1];
            pole[j+1] = pole[j];
            pole[j] = pom;
            //pocetVymenB++;
          }
      

      stopky.Stop();
      
      Console.WriteLine("\n\nSeřazené pole (Bubble sort): ");
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",pole[i]);
      
      Console.WriteLine("\n\nČas řazení (Bubble sort): {0}", stopky.Elapsed);   
      Console.WriteLine("\n\n==============================================");
      
      // Insertion sort
      int pocetVymenI=0;
      Stopwatch stopky1 = new Stopwatch();
      Console.WriteLine("\n\nNeseřazené pole1 (před Insertion sortem): ");
      
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",pole1[i]);


      
      stopky1.Start();
      for (int i = 0; i < pole1.Length - 1; i++)
      {
        int j = i + 1;
        int pom = pole1[j];
        while (j > 0 && pom > pole1[j - 1])
        {
            pole1[j] = pole1[j - 1];
            j--;
            
        }
        pole1[j] = pom;
        //pocetVymenI++;
      }
      

      stopky1.Stop();
      
      Console.WriteLine("\n\nSeřazené pole1 (Insertion sort): ");
      
      for(int i=0;i<n;i++)
        Console.Write("{0}; ",pole1[i]);
      
      Console.WriteLine("\n\nČas řazení (Insertion): {0}", stopky1.Elapsed);
      Console.WriteLine("\n\n==============================================");
      Console.WriteLine("==============================================");
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("\n\nČas řazení (Bubble sort): {0}", stopky.Elapsed);
      //Console.WriteLine("Počet výměn (Bubble sort): {0}", pocetVymenB);
      
      
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("\nČas řazení (Insertion sort): {0}", stopky1.Elapsed);
      //Console.WriteLine("Počet výměn (Insertion sort): {0}", pocetVymenI);

      
      
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
      opakovani = Console.ReadLine();
      }
