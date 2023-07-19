using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagochi.Models;
using System.Collections.Generic;
using System;

namespace Tamagochi.Tests
{
  [TestClass]
  public class PetTests
  {

    [TestMethod]
    public void PetConstructor_CreateInstanceOfTypePet_Pet()
    {
      Fox Inda = new Fox("Inda");
      bool expected = true;
      Assert.AreEqual(expected, (Inda is GochiPet));
    }
  }
}