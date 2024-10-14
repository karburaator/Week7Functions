string[] fruitBasket = { "apples", "bananas", "oranges" };
string[] pets = { "cats", "dogs", "fish", "hamsters" };
string[] characters = { "Harry", "Ron", };
//int[] numbers = { 1, 2, 3, 4, 5, 6 }; Will not work, because it's not a string[]

PrintArrayElements(fruitBasket);
PrintArrayElements(pets);
PrintArrayElements(characters);


static void PrintArrayElements(string[] someArray)
{
    for(int i = 0; i < someArray.Length; i++)
    {
        Console.WriteLine($"{i+1}. {someArray[i]}");
    }
}