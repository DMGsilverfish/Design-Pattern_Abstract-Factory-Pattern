# 🍕 Abstract Factory Pattern Example (C#)
<p align="center">
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/">
    <img src="https://upload.wikimedia.org/wikipedia/commons/4/4f/Csharp_Logo.png" alt="C# Logo" width="150"/>
  </a>
</p>

---

This project demonstrates the **Abstract Factory Design Pattern** using a **Global Pizza Factory** example in C#.

The Abstract Factory pattern provides an interface for creating **families of related objects** without specifying their concrete classes.  
Here, each **region (USA, Italy, China)** represents a factory capable of producing **multiple pizza types** such as `Cheese` and `Veggie`.

---

## 🧩 How It Works

1. **IPizza** – Defines the base pizza interface (`Prepare`, `Bake`, `Serve`).  
2. **Concrete Pizzas** – Each region (USA, Italy, China) has its own cheese and veggie pizzas with unique preparation styles.  
3. **IPizzaFactory** – The abstract factory that defines methods for creating multiple related pizzas.  
4. **USAPizzaFactory**, **ItalianPizzaFactory**, **ChinesePizzaFactory** – Concrete factories implementing region-specific pizzas.  
5. **PizzaFactoryProducer** – A helper class that returns the correct factory based on user input.  
6. **Program (Client)** – The entry point that asks for region and pizza type, then uses the appropriate factory.


---

## 🚀 Key Takeaways

- The **Factory Pattern** creates one type of object, while the **Abstract Factory Pattern** creates *families* of related objects.  
- Promotes **scalability** — adding a new region only requires a new factory, not changes to existing ones.  
- Encourages **encapsulation** and **loose coupling** between client code and product creation.  
- Ideal for building systems where multiple variants of related products exist.


---

## 🧪 How to Run

1. Open the project in **Visual Studio** or any C# IDE.  
2. Build and run the console application.  
3. Enter a region (`USA`, `Italy`, or `China`).  
4. Enter a pizza type (`cheese` or `veggie`).  
5. Watch as the program creates and serves a pizza specific to your chosen region and type.

---

**Pattern Type:** Creational  
**Language:** C# (.NET Console Application)  
**Design Goal:** Provide an interface for creating families of related objects without specifying their concrete implementations.

---


