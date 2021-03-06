using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DependencyInjection
{
    public class DrinkWithBeer
    {
        //private Beer _beer = new Beer("Pikantus", "Erdinger"); 
        private Beer _beer; // Si cambia la clase puede ser mas facil su cambio en todo el proyecto
        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _water = water;
            _sugar = sugar;
            _beer = beer;
        }

        public void Build()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {_water}" +
                $" azucar {_sugar} y cerveza {_beer.Name}");
        }
    }
}
