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
Console.WriteLine(finalNum);
arlist.Add(finalNum);
}
Boolean checkerTwo = true;
while(checkerTwo){
    Console.WriteLine("Please input what you want to do");
        String option = Console.ReadLine();
        int finalOption = Convert.ToInt32(option);
   
    if(finalOption == 5){
        int sum = 0;
        foreach(int i in arlist){
            sum = sum + i;
        }
        Console.WriteLine("Sum: " + sum);
    }
    if(finalOption == 6){
        foreach(int i in arlist){
            if((i % 3) == 0){
                Console.WriteLine("Divisible by 3: " + i);
            }
        }
    }
    
}