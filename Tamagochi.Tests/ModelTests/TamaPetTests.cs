using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagochi.Models;
using System.Collections.Generic;
using System;

namespace Tamagochi.Tests
{
  [TestClass]
  public class TamaPetTests
  {

    [TestMethod]
    public void TamaPetConstructor_CreateInstanceOfTypeTamaPet_TamaPet()
    {
      Fox Inda = new Fox("Inda");
      bool expected = true;
      Assert.AreEqual(expected, (Inda is GochiPet));

    }
  }
}