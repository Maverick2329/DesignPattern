//using DesignPattern.DependencyInjection;
using DesignPattern.Factory;
using DesignPattern.UnitOfWorkPattern;
using DesignPattern.Repository;
using System;
using System.Linq;
using DesignPattern.Models;
using DesignPattern.StrategyPattern;
using DesignPattern.BuilderParttern;
using System.Collections.Generic;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de patron Singleton
            //var log = Singleton.Log.Instance;
            //log.Save("Probando el Patron");
            //log.Save("Singleton");
            //var a = Singleton.Singleton.Instance;
            //var b = Singleton.Singleton.Instance;
            //Console.WriteLine(a == b);

            //Ejemplo de patron Factory
            //SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            //SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            //ISale sale1 = storeSaleFactory.GetSale();
            //sale1.Sell(15);

            //ISale sale2 = internetSaleFactory.GetSale();
            //sale2.Sell(15);

            //Ejemplo de patron Injeccion de dependencia
            //var beer = new Beer("Pikantus", "Erdinger");
            //var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();

            //Ejemplo de patron Repository
            // Ejemplo 1
            //using(var context = new DesingPatternsContext())
            //{
            //    var lst = context.Beers.ToList();
            //    foreach(var beer in lst)
            //    {
            //        Console.WriteLine(beer.Name);
            //    }
            //}

            // Ejemplo 2
            //using(var context = new DesingPatternsContext())
            //{
            //    var beerRepository = new BeerRepository(context);
            //    var beer = new Beer();
            //    beer.Name = "Corona";
            //    beer.Style = "Pilsner";

            //    beerRepository.Add(beer);
            //    beerRepository.Save();

            //    foreach (var b in beerRepository.Get())
            //    {
            //        Console.WriteLine(b.Name);
            //    }
            //}

            //Ejemplo 3
            //using(var context = new DesingPatternsContext())
            //{
            //    var beerRepository = new Repository<Beer>(context);
            //    var beer = new Beer() { Name = "Bud Light", Style = "Blonde" };
            //    beerRepository.Add(beer);
            //    beerRepository.Save();

            //    foreach(var b in beerRepository.Get())
            //    {
            //        Console.WriteLine($"{b.BeerId} {b.Name}");
            //    }

            //    var brandRepository = new Repository<Brand>(context);
            //    var brand = new Brand();
            //    brand.Name = "Fuller";
            //    brandRepository.Add(brand);
            //    brandRepository.Save();
            //    foreach(var br in brandRepository.Get())
            //    {
            //        Console.WriteLine(br.Name);
            //    }
            //}


            //Ejemplo patron Unit Of Work
            //using(var context = new DesingPatternsContext())
            //{
            //    var unitOfWork = new UnitOfWork(context);
            //    var beers = unitOfWork.Beers;
            //    var beer = new Beer()
            //    {
            //        Name = "Fuller",
            //        Style = "Porter"
            //    };

            //    beers.Add(beer);

            //    var brands = unitOfWork.Brands;
            //    var brand = new Brand()
            //    {
            //        Name = "Fuller"
            //    };
            //    brands.Add(brand);
            //    unitOfWork.Save();
            //}

            //Ejemplo de Strategy
            //var context = new Context(new CarStrategy());
            //context.Run();
            //context.Strategy = new MotoStrategy();
            //context.Run();
            //context.Strategy = new BicycleStrategy();
            //context.Run();

            //Ejemplo de Builder
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);
            barmanDirector.PrepareMargarita();
            var preparedDrink = builder.GetPreparedDrink();
            Console.WriteLine(preparedDrink.Result);
        }
    }
}
