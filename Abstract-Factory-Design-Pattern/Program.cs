using System;

namespace AbstractFactoryPatternExample
{
    // ------------------------------
    // Product Interfaces
    // ------------------------------
    interface IPizza
    {
        void Prepare();
        void Bake();
        void Serve();
    }

    // ------------------------------
    // Concrete Products - USA
    // ------------------------------
    class USACheesePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing an American Cheese Pizza with mozzarella and pepperoni 🇺🇸");
        public void Bake() => Console.WriteLine("Baking in a deep-dish oven.");
        public void Serve() => Console.WriteLine("Serving with ranch dip.\n");
    }

    class USAVeggiePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing an American Veggie Pizza with mushrooms and olives 🇺🇸");
        public void Bake() => Console.WriteLine("Baking in an electric oven.");
        public void Serve() => Console.WriteLine("Serving with garlic sauce.\n");
    }

    // ------------------------------
    // Concrete Products - Italy
    // ------------------------------
    class ItalianCheesePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing an Italian Margherita Pizza with fresh basil and mozzarella 🇮🇹");
        public void Bake() => Console.WriteLine("Baking in a wood-fired oven.");
        public void Serve() => Console.WriteLine("Serving with olive oil drizzle.\n");
    }

    class ItalianVeggiePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing an Italian Veggie Pizza with artichokes and bell peppers 🇮🇹");
        public void Bake() => Console.WriteLine("Baking in a brick oven.");
        public void Serve() => Console.WriteLine("Serving with balsamic glaze.\n");
    }

    // ------------------------------
    // Concrete Products - China
    // ------------------------------
    class ChineseCheesePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing a Chinese Cheese Pizza with tofu and sesame sauce 🇨🇳");
        public void Bake() => Console.WriteLine("Baking in a clay oven.");
        public void Serve() => Console.WriteLine("Serving with sweet chili sauce.\n");
    }

    class ChineseVeggiePizza : IPizza
    {
        public void Prepare() => Console.WriteLine("Preparing a Chinese Veggie Pizza with bok choy and hoisin glaze 🇨🇳");
        public void Bake() => Console.WriteLine("Baking in a bamboo steamer oven.");
        public void Serve() => Console.WriteLine("Serving with soy dip.\n");
    }

    // ------------------------------
    // Abstract Factory Interface
    // ------------------------------
    interface IPizzaFactory
    {
        IPizza CreateCheesePizza();
        IPizza CreateVeggiePizza();
    }

    // ------------------------------
    // Concrete Factories
    // ------------------------------
    class USAPizzaFactory : IPizzaFactory
    {
        public IPizza CreateCheesePizza() => new USACheesePizza();
        public IPizza CreateVeggiePizza() => new USAVeggiePizza();
    }

    class ItalianPizzaFactory : IPizzaFactory
    {
        public IPizza CreateCheesePizza() => new ItalianCheesePizza();
        public IPizza CreateVeggiePizza() => new ItalianVeggiePizza();
    }

    class ChinesePizzaFactory : IPizzaFactory
    {
        public IPizza CreateCheesePizza() => new ChineseCheesePizza();
        public IPizza CreateVeggiePizza() => new ChineseVeggiePizza();
    }

    // ------------------------------
    // Factory Producer (Selector)
    // ------------------------------
    class PizzaFactoryProducer
    {
        public static IPizzaFactory GetFactory(string region)
        {
            switch (region.ToLower())
            {
                case "usa":
                    return new USAPizzaFactory();
                case "italy":
                    return new ItalianPizzaFactory();
                case "china":
                    return new ChinesePizzaFactory();
                default:
                    throw new ArgumentException("Invalid region. Choose from USA, Italy, or China.");
            }
        }
    }

    // ------------------------------
    // Client
    // ------------------------------
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🌍 Welcome to the Global Abstract Pizza Factory!");
            Console.Write("Enter your region (USA, Italy, China): ");
            string region = Console.ReadLine();

            try
            {
                IPizzaFactory factory = PizzaFactoryProducer.GetFactory(region);

                Console.Write("Enter pizza type (cheese, veggie): ");
                string type = Console.ReadLine();

                IPizza pizza = type.ToLower() switch
                {
                    "cheese" => factory.CreateCheesePizza(),
                    "veggie" => factory.CreateVeggiePizza(),
                    _ => throw new ArgumentException("Invalid pizza type. Choose 'cheese' or 'veggie'.")
                };

                pizza.Prepare();
                pizza.Bake();
                pizza.Serve();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
