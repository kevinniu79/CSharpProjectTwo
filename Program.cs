using System.Collections;
// See https://aka.ms/new-console-template for more information
ArrayList arlist = new ArrayList();
Boolean checker = true;
while(checker){
Console.WriteLine("Please input a number, input done when you're done");
String number = Console.ReadLine();
if(number.Equals("done")){
    checker = false;
    break;
}
int finalNum = Convert.ToInt32(number);
arlist.Add(finalNum);
}
Boolean checkerTwo = true;
while(checkerTwo){
    Console.WriteLine("1. Display all input");
    Console.WriteLine("2. Display all evens");
    Console.WriteLine("3. Display all odds");
    Console.WriteLine("4. Display every 5th number");
    Console.WriteLine("5. Display the sum of all input");
    Console.WriteLine("6. Display all input divisible by 3");
    Console.WriteLine("7. Add a new number");
    Console.WriteLine("8. Quit");
    Console.WriteLine("Please input what you want to do");
    String option = Console.ReadLine();
    int finalOption = Convert.ToInt32(option);
    if(checkerTwo){} //delete this line!!
    else if(finalOption == 7){
        Console.WriteLine("Input the number to add to the list");
        String numToAddstr = Console.ReadLine();
        int numToAdd = Convert.ToInt32(numToAddstr);
        arlist.Add(numToAdd);
    }
    else if(finalOption == 8){
        checkerTwo = false;
        break;
    }
}