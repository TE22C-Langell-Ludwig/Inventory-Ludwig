public class Weapon : Item
{
public int MinDamage =5;
public int MaxDamage =10;
public int Attack()
{
int CalculatedDamage = Random.Shared.Next(MinDamage,MaxDamage);
return CalculatedDamage;
}
}
