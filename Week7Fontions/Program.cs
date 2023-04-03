string Hello = "Hello World!";

string panic = "Don't panic";


//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(Hello);
//}


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(panic);
//}



PrintStringTenTimes(Hello);
PrintStringTenTimes(panic);




PrintStringTenTimes("Aly");
PrintStringTenTimes("Djabir");

static void PrintStringTenTimes(string someString)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(someString);
    }
}