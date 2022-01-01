using System;
namespace Methodsofsequencesarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
        int[] sequencesofnumbers = {23,12,4,86,72,3,11,17} ;
        Console.WriteLine("****Sirasiz dizi***") ; 
        foreach (var number in sequencesofnumbers)
            Console.WriteLine(number) ; 

        Console.WriteLine("****Sirali dizi***") ; 
        Array.Sort(sequencesofnumbers) ;
        foreach (var number in sequencesofnumbers)
            Console.WriteLine(number) ; 
        
        //Clear 
        Console.WriteLine("****Array Clear***") ; 
        // sequencesofnumbers elemanlarini kullanarak 2. indexten itibaren 2 tane elemani 0'lar

        Array.Clear(sequencesofnumbers,2,2) ;
        foreach (var number in sequencesofnumbers)
            Console.WriteLine(number) ;


        //Reverse
        Console.WriteLine("****Array Reverse***") ; 
        Array.Reverse(sequencesofnumbers) ;
        foreach (var number in sequencesofnumbers)
            Console.WriteLine(number) ;

        //IndexOf
        Console.WriteLine("****Array IndexOf***") ; 
        Console.WriteLine(Array.IndexOf(sequencesofnumbers,23)) ;

        //Resize

        Console.WriteLine("**** Array Resize****");
        Array.Resize<int>(ref sequencesofnumbers, 9 );
        sequencesofnumbers[8]=99 ;
        foreach(var number in sequencesofnumbers)
            Console.WriteLine(number);






        
        
        }
    }
}