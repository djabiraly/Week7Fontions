string[] fruitbasket = { "coconut", "bananas", "kiwi" };
string[] pets = { "cats", "dogs", "fishes", "hamsters" };
string[] friends = { "Yaman", "Patric", "Senan" };

PrintArrayElements(fruitbasket);
PrintArrayElements(pets);
PrintArrayElements(friends);

static void PrintArrayElements(string[] someArray)
{
   for(int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {someArray[i]}");
    }
}
