using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;

namespace Tamagochi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      return View(GochiPet.AllPets);
    }
      [HttpGet("/pets/new")]
    public ActionResult Create()
    {
      return View();
    }
      [HttpPost("/pets/{id}")]
    public ActionResult Show(int petId, string action)
    {
      GochiPet foundPet = GochiPet.Find(petId);
      if (action == "play")
      {
        foundGochiPet.Play()
      }
      {
        return View(foundGochiPet);
      }
    }
    
    [HttpPost("/pets/delete")]
    public ActionResult DeleteAll()
    {
      GochiPet.ClearAll();
      return View();
    }
  }
}