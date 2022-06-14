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
    
}