namespace DIO.src.entities
{
  public class Wizard : Hero
  {
    public Wizard(string Name, int Level, string HeroType)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
    }
    public override string Attack()
    {
      return this.Name + " Usou uma magia!";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " usou uma magia crítica com bonus de " + Bonus;
      }
      else
      {
        return this.Name + " usou uma magia com bonus de " + Bonus;
      }
    }

  }
}