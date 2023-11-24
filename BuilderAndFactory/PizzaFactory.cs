namespace BuilderAndFactory
{
    public class PizzaFactory
    {
        public PizzaFactory()
        {
            
        }

        public Pizza CheesePizza()
        {
            var toppings = new List<PizzaToppings>();
            var pizzaBase = PizzaBase.Tomato;
            var cheeseType = CheeseType.Cheddar;
            var pizzaDough = PizzaDough.ThinCrust;
            var stuffedCrust = false;
            return new Pizza(
                toppings, pizzaBase, cheeseType, pizzaDough, stuffedCrust
            ); ;
        }

        public Pizza VeggiePizza()
        {
            var toppings = new List<PizzaToppings>() {
                PizzaToppings.RedOnion,
                PizzaToppings.Mushroom,
                PizzaToppings.Sweetcorn,
                PizzaToppings.BellPepper
            };
            var pizzaBase = PizzaBase.Tomato;
            var cheeseType = CheeseType.Cheddar;
            var pizzaDough = PizzaDough.ThinCrust;
            var stuffedCrust = false;
            return new Pizza(
                toppings, pizzaBase, cheeseType, pizzaDough, stuffedCrust
            ); ;
        }

        public Pizza VeggieDeluxe()
        {
            var toppings = new List<PizzaToppings>() {
                PizzaToppings.RedOnion,
                PizzaToppings.Mushroom,
                PizzaToppings.Spinach,
                PizzaToppings.Tomato,
                PizzaToppings.Olive,
            };
            var pizzaBase = PizzaBase.Tomato;
            var cheeseType = CheeseType.Cheddar;
            var pizzaDough = PizzaDough.ThinCrust;
            var stuffedCrust = false;
            return new Pizza(
                toppings, pizzaBase, cheeseType, pizzaDough, stuffedCrust
            );
        }

        public Pizza HawaiianPizza()
        {
            var toppings = new List<PizzaToppings>() {
                PizzaToppings.Ham,
                PizzaToppings.Pineapple
            };

            var pizzaBase = PizzaBase.Tomato;
            var cheeseType = CheeseType.Cheddar;
            var pizzaDough = PizzaDough.ThinCrust;
            var stuffedCrust = false;

            return new Pizza(
                toppings, pizzaBase, cheeseType, pizzaDough, stuffedCrust
            );
        }

        public Pizza BBQChickenPizza()
        {
            var toppings = new List<PizzaToppings>() {
                PizzaToppings.BBQChicken,
                PizzaToppings.Tomato,
                PizzaToppings.BellPepper,
                PizzaToppings.RedOnion
            };
            var pizzaBase = PizzaBase.BBQ;
            var cheeseType = CheeseType.Cheddar;
            var pizzaDough = PizzaDough.ThinCrust;
            var stuffedCrust = false;

            return new Pizza(
                toppings, pizzaBase, cheeseType, pizzaDough, stuffedCrust
            );
        }
    }
}
