using NUnit.Framework;
using Project4.Models;
using System.Collections.Generic;

namespace JeoNUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        PizzaBO _context = new PizzaBO();
        [Test]
        public void GetAllPizzas()
        {
            List<PizzaModel> ExpectedPizzaList = new List<PizzaModel>
            {
                 new PizzaModel{Id=001,PizzaType="Panner", Size=50,Price=300,Quantity=50},
                new PizzaModel{Id=002,PizzaType="Veg loaded", Size=60,Price=800,Quantity=25},
                new PizzaModel{Id=003,PizzaType="Margarita", Size=70,Price=500,Quantity=40},
                new PizzaModel{Id=004,PizzaType="Veggy Farm", Size=150,Price=1000,Quantity=49},
            };
            List<PizzaModel> acutalPizzaList = _context.getAllPizza();
            Assert.AreEqual(acutalPizzaList, ExpectedPizzaList);
        }
        [Test]
        public void GetPizzaById()
        {
            PizzaModel ExpectedPizza = new PizzaModel { Id = 001, PizzaType = "Panner", Size = 50, Price = 300, Quantity = 50 };
            PizzaModel acutalPizza = _context.getPizzaById(001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }
        [Test]
        public void Order()
        {
            PizzaModel ExpectedPizza = new PizzaModel { Id = 001, PizzaType = "Panner", Size = 50, Price = 300, Quantity = 50 };
            _context.order(ExpectedPizza);
            PizzaModel acutalPizza = _context.getPizzaById(001);
            Assert.AreEqual(acutalPizza, ExpectedPizza);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}