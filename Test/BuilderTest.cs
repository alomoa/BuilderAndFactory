using BuilderAndFactory;

namespace Test
{
    public class BuilderTest
    {
        PizzaBuilder pizzaBuider;

        [SetUp]
        public void Setup()
        {
            pizzaBuider = new PizzaBuilder();
        }

        [Test]
        public void BuildsPlainPizza()
        {
            //Act
            var result = pizzaBuider.Build();

            //Assert
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            Assert.That(toppings.Count, Is.EqualTo(0));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Tomato));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

        [Test]
        public void AddsToppings()
        {
            //Act
            var result = pizzaBuider
                .AddTopping(PizzaToppings.Olive)
                .Build();

            //Assert
            var toppings = result.PizzaToppings;

            Assert.That(toppings.Count, Is.EqualTo(1));
            Assert.That(toppings.First(), Is.EqualTo(PizzaToppings.Olive));
        }

        [Test]
        public void RemovesToppings()
        {
            //Act
            var result = pizzaBuider
                .AddTopping(PizzaToppings.Olive)
                .RemoveTopping(PizzaToppings.Olive)
                .Build();

            //Assert
            var toppings = result.PizzaToppings;

            Assert.That(toppings.Count, Is.EqualTo(0));
        }

        [Test]
        public void ChangesCheeseType()
        {
            //Act
            var result = pizzaBuider
                .WithCheese(CheeseType.BlueCheese)
                .Build();

            //Assert
            var cheeseType = result.CheeseType;

            Assert.That(cheeseType, Is.EqualTo(CheeseType.BlueCheese));
        }

        [Test]
        public void ChangesDough()
        {
            //Act
            var result = pizzaBuider
                .WithDough(PizzaDough.DeepPan)
                .Build();

            //Assert
            var dough = result.PizzaDough;

            Assert.That(dough, Is.EqualTo(PizzaDough.DeepPan));
        }

        [Test]
        public void AddsStuffedCheese()
        {
            //Act
            var result = pizzaBuider
                .WithStuffedCheese()
                .Build();

            //Assert
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            Assert.That(cheeseStuffedCrust, Is.EqualTo(true));
        }

        [Test]
        public void ChangesBase()
        {
            //Act
            var result = pizzaBuider
                .WithBase(PizzaBase.Buffalo)
                .Build();

            //Assert
            var pizzaBase = result.PizzaBase;

            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Buffalo));
        }

        [Test]
        public void RemovesStuffedCheese()
        {
            //Act
            var result = pizzaBuider
                .WithStuffedCheese()
                .WithoutStuffedCheese()
                .Build();

            //Assert
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

    }
}