using BuilderAndFactory;

namespace Test
{
    internal class FactoryTest
    {
        PizzaFactory pizzaFactory;

        [SetUp]
        public void Setup()
        {
            pizzaFactory = new PizzaFactory();
        }

        [Test]
        public void CreatesCheesePizza()
        {
            //Arrange

            //Act
            var result = pizzaFactory.CheesePizza();
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            //Assert
            Assert.That(toppings.Count, Is.EqualTo(0));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Tomato));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

        [Test]
        public void CreatesVeggiePizza()
        {
            //Arrange
            var expectedToppings = new List<PizzaToppings>() {
                PizzaToppings.RedOnion,
                PizzaToppings.Mushroom,
                PizzaToppings.Sweetcorn,
                PizzaToppings.BellPepper
            };

            //Act
            var result = pizzaFactory.VeggiePizza();
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            //Assert
            Assert.That(toppings.Count, Is.EqualTo(expectedToppings.Count));
            Assert.That(toppings, Is.EqualTo(expectedToppings));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Tomato));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

        [Test]
        public void CreatesVeggieDeluxePizza()
        {
            //Arrange
            var expectedToppings = new List<PizzaToppings>() {
                PizzaToppings.RedOnion,
                PizzaToppings.Mushroom,
                PizzaToppings.Spinach,
                PizzaToppings.Tomato,
                PizzaToppings.Olive,
            };

            //Act
            var result = pizzaFactory.VeggieDeluxe();
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            //Assert
            Assert.That(toppings.Count, Is.EqualTo(expectedToppings.Count));
            Assert.That(toppings, Is.EqualTo(expectedToppings));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Tomato));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

        [Test]
        public void CreatesHawaiianPizza()
        {
            //Arrange
            var expectedToppings = new List<PizzaToppings>() {
                PizzaToppings.Ham,
                PizzaToppings.Pineapple
            };

            //Act
            var result = pizzaFactory.HawaiianPizza();
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            //Assert
            Assert.That(toppings.Count, Is.EqualTo(expectedToppings.Count));
            Assert.That(toppings, Is.EqualTo(expectedToppings));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.Tomato));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }

        [Test]
        public void CreatesBBQChickenPizza()
        {
            //Arrange
            var expectedToppings = new List<PizzaToppings>() {
                PizzaToppings.BBQChicken,
                PizzaToppings.Tomato,
                PizzaToppings.BellPepper,
                PizzaToppings.RedOnion
            };

            //Act
            var result = pizzaFactory.BBQChickenPizza();
            var toppings = result.PizzaToppings;
            var dough = result.PizzaDough;
            var pizzaBase = result.PizzaBase;
            var cheeseType = result.CheeseType;
            var cheeseStuffedCrust = result.CheeseStuffedCrust;

            //Assert
            Assert.That(toppings.Count, Is.EqualTo(expectedToppings.Count));
            Assert.That(toppings, Is.EqualTo(expectedToppings));
            Assert.That(dough, Is.EqualTo(PizzaDough.ThinCrust));
            Assert.That(pizzaBase, Is.EqualTo(PizzaBase.BBQ));
            Assert.That(cheeseType, Is.EqualTo(CheeseType.Cheddar));
            Assert.That(cheeseStuffedCrust, Is.EqualTo(false));
        }
    }
}
