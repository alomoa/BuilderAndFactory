namespace BuilderAndFactory
{
    public struct Pizza
    {
        public List<PizzaToppings> PizzaToppings { get; private set; }
        public PizzaBase PizzaBase { get; private set; }
        public CheeseType CheeseType { get; private set; }
        public PizzaDough PizzaDough { get; private set; }
        public bool CheeseStuffedCrust { get; private set; }

        public Pizza(List<PizzaToppings> pizzaToppings, PizzaBase pizzaBase, CheeseType cheeseType, PizzaDough pizzaDough, bool cheeseStuffedCrust)
        {
            PizzaToppings = pizzaToppings;
            PizzaBase = pizzaBase;
            CheeseType = cheeseType;
            CheeseStuffedCrust = cheeseStuffedCrust;
            PizzaDough = pizzaDough;
        }

    }

    public enum PizzaDough
    {
        DeepPan,
        ThinCrust
    }

    public enum PizzaToppings
    {
        Chicken,
        Beef,
        Pepperoni,
        Sweetcorn,
        GreenChilli,
        BellPepper,
        Basil,
        Pineapple,
        ChickenTikka,
        SpicyChicken,
        BBQChicken,
        Tomato,
        Olive,
        Mushroom,
        Eggplant,
        RedOnion,
        YellowOnion,
        GroundBeef,
        Sausage,
        Ham,
        Spinach
    }

    public enum CheeseType
    {
        None,
        Cheddar,
        Mozzorella,
        Gorgonzola,
        ParmigianoReggiano,
        Provolone,
        GoatCheese,
        BlueCheese
    }

    public enum PizzaBase
    {
        None,
        BBQ,
        Tomato,
        Buffalo
    }
}
