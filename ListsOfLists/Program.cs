using ListsOfLists;

/*
 Given the following lists:
{ "Apple", "Banana", "Chocolate" }
{ "Avocado", "Banana", "Banana", "Banana" }
{ "Chocolate" }
{ "Doppleganger", "Doppleganger" } 

The output should be:
    
{ "Apple", "Banana", "Chocolate" },
{ "Avocado" }
{ }
{ "Doppleganger"}
*/

var list = new List<List<string>>()
{
    new List<string>()
    {
        "Apple", "Banana", "Chocolate"
    },

    new()
    {
        "Avocado", "Banana", "Banana", "Banana"
    },

    new()
    {
        "Chocolate"
    },

    new()
    {
        "Doppleganger", "Doppleganger"
    }
};

var result = Lists.Execute(list);
foreach (var items in result)
{
    foreach (var fruit in items)
    {
        Console.Write(fruit + " ");
    }

    Console.WriteLine();
}