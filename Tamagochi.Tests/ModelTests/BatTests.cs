using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagochi.Models;
using System.Collections.Generic;
using System;

namespace Tamagochi.Tests
{
  [TestClass]
  public class BatTests : IDisposable
  {
    public void Dispose()
    {
      BatTests.ClearAll();
    }
    [TestMethod]
    public void BatConstructor_CreateIntanceOfBat_Bat()
    {
      Bat bruce = new Bat("Bruce");
      Assert.AreEqual(typeof(Bat), bruce.GetType());
    }
  }
}