namespace BuilderAndFactory
{
    public class PizzaBuilder
    {

        public List<PizzaToppings> _pizzaToppings;
        public PizzaBase _pizzaBase;
        public CheeseType _cheeseType;
        public PizzaDough _pizzaDough;
        public bool _cheeseStuffedCrust;

        public PizzaBuilder()
        {
            _pizzaToppings = new List<PizzaToppings>();
            _pizzaBase = PizzaBase.Tomato;
            _cheeseType = CheeseType.Cheddar;
            _cheeseStuffedCrust = false;
            _pizzaDough = PizzaDough.ThinCrust;
        }

        public PizzaBuilder(Pizza pizza)
        {
            _pizzaToppings = pizza.PizzaToppings;
            _pizzaBase = pizza.PizzaBase;
            _cheeseType = pizza.CheeseType;
            _cheeseStuffedCrust = pizza.CheeseStuffedCrust;
            _pizzaDough = pizza.PizzaDough;
        }

        public PizzaBuilder AddTopping(PizzaToppings topping)
        {
            if (!_pizzaToppings.Contains(topping))
            {
                _pizzaToppings.Add(topping);
            }
            return this;
        }

        public PizzaBuilder RemoveTopping(PizzaToppings topping)
        {
            _pizzaToppings = _pizzaToppings.Where(x => x != topping).ToList();
            return this;
        }

        public PizzaBuilder WithBase(PizzaBase pizzaBase)
        {
            _pizzaBase = pizzaBase;
            return this;
        }

        public PizzaBuilder WithCheese(CheeseType cheeseType)
        {
            _cheeseType = cheeseType; 
            return this;
        }

        public PizzaBuilder WithDough(PizzaDough pizzaDough)
        {
            _pizzaDough = pizzaDough;
            return this;
        }

        public PizzaBuilder WithStuffedCheese()
        {
            _cheeseStuffedCrust = true;
            return this;
        }

        public PizzaBuilder WithoutStuffedCheese() {
            _cheeseStuffedCrust = false;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(_pizzaToppings, _pizzaBase, _cheeseType, _pizzaDough, _cheeseStuffedCrust);
        }
        

    }
}
