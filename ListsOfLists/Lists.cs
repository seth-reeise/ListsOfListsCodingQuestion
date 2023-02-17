namespace ListsOfLists;

public class Lists
{
    // We are taking in an Lists of lists<string> and returning one without duplicates
    // Each item can only be used once across all list
    public static IEnumerable<IList<string>> Execute(IEnumerable<IList<string>> input)
    {
        var fruits = new HashSet<string>();
        var inputList = input.ToList();
        
        foreach (var list in inputList)
        {
            foreach (var fruit in list)
            {
                fruits.Add(fruit);
            }
        }
        
        var newList = new List<IList<string>>();
        // Loop through the original list again and add each fruit to the new list
        // Once a fruit is added, it is also removed from hashset so it can not be added to a second list 
        foreach (var list in inputList)
        {
            var l = new List<string>();
            foreach (var fruit in list)
            {
                if (fruits.Contains(fruit))
                {
                    l.Add(fruit);
                    fruits.Remove(fruit);
                }
            }
            newList.Add(l);
        }
        return newList;
    }
}