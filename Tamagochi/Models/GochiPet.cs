using System.Collections.Generic;


namespace Tamagochi.Models
{
  public abstract class GochiPet
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Play { get; set; }
    public static List<GochiPet> AllPets { get; set; } = new List<GochiPet>{ };
    public static void ClearAll()
    {
        AllPets.Clear(); 
    }
      public static GochiPet Find(int searchId)
    {
      return AllPets[searchId - 1];
    }
  }
}