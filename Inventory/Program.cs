
using System.Runtime.CompilerServices;

while (true)
{
    Character Player = new();

    Weapon Dagger = new Weapon()
    {
        Name = "Dagger",
        MinDamage = 5,
        MaxDamage = 10,
        Weight = 10
    };

    Consumable HealPot = new Consumable()
    {
        Name = "Potion",
        UsesMax = 3,
        Weight = 5
    };
    Armor Helmet = new Armor()
    {   
        Name = "Copper Helmet",
        Protection = 15,
        Weight = 20
    };
    
    Player.Backpack.itemList.Add(Dagger);
    Player.Backpack.itemList.Add(HealPot);

    Console.WriteLine("You currently have this in your inventory");
    Player.Backpack.Display();
    Console.WriteLine($"You find a {Helmet.Name} on the ground do you want to pick it up Y/N");
    string Choice = Console.ReadLine().ToUpper();
    
    if (Choice=="Y"){
    Player.Backpack.itemList.Add(Helmet);
    }
    else if(Choice=="N")
    {
    Console.WriteLine($"You didnt pick up the {Helmet.Name}");
    }
    else if (Choice != "Y" || Choice != "N")
    {
    Console.WriteLine("Pick a Choice Dumb Dumb");    
    }    
    Console.WriteLine("You now have:");
    Player.Backpack.Display();
    Console.ReadLine();
    break;
}













