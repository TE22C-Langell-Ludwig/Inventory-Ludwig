public class Inventory
{
    public List<Item> itemList = new List<Item>();

    public void Display()
    {

        for (int i = 0; i < itemList.Count; i++)
        {
            Console.WriteLine($"{i+1}.{itemList[i].Name}");
        }


    }

}
