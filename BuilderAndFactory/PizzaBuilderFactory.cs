using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndFactory
{
    public class PizzaBuilderFactory
    {
        PizzaFactory _pizzaFactory;
        public PizzaBuilderFactory() {
        
            _pizzaFactory = new PizzaFactory();
        }

        public PizzaBuilder CheesePizza()
        {
            return new PizzaBuilder(_pizzaFactory.CheesePizza());
        }

        public PizzaBuilder VeggiePizza()
        {
            return new PizzaBuilder(_pizzaFactory.VeggiePizza());
        }

        public PizzaBuilder HawaiianPizza()
        {
            return new PizzaBuilder(_pizzaFactory.HawaiianPizza());
        }

        public PizzaBuilder BBQChickenPizza()
        {
            return new PizzaBuilder(_pizzaFactory.BBQChickenPizza());
        }

        public PizzaBuilder VeggieDeluxe()
        {
            return new PizzaBuilder(_pizzaFactory.VeggieDeluxe());
        }
    }
}
