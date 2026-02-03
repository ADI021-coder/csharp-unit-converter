{
    Console.WriteLine("Hello World");
    Console.WriteLine("Simple Unit Converter");

    Console.Write("enter a number: ");
    string userNum = Console.ReadLine();
    double num = Convert.ToDouble(userNum);

    double cmNum = (double) num*100;
    double fNum = (double) num*3.28;
    double iNum = (double) num*39.3;

    Console.WriteLine("you entered " + num + "m which is " + cmNum + "cm and " + fNum + "feet and " + iNum + "inches");

}
