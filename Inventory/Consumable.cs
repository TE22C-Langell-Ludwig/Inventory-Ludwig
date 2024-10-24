public class Consumable : Item
{
    public int UsesMax = 5;
    public int UsesCurrent = 5;
    public void Use(Character target)
    {

        if (UsesCurrent > 0)
        {
            UsesCurrent -= 1;
            target.Hp -= 10;
        }
    }
}
