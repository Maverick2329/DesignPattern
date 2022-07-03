using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.BuilderParttern
{
    public class PreparedAlcoholicDrinkConcreteBuilder : IBuilder
    {
        private PreparedDrink _preparedDrink;

        public PreparedAlcoholicDrinkConcreteBuilder()
        {
            //_preparedDrink = new PreparedDrink();
            Reset();
        }
        public void AddIngredients(string ingredients)
        {
            if (_preparedDrink.Ingredientes == null)
                _preparedDrink.Ingredientes = new List<string>();

            _preparedDrink.Ingredientes.Add(ingredients);
        }

        public void Mix()
        {
            string ingredients = _preparedDrink.Ingredientes.Aggregate((i, j) => i + ", " + j);
            _preparedDrink.Result = $"Bebida preparada con {_preparedDrink.Alcohol} de alcohol" + 
                                    $"con los siguientes ingredientes; {ingredients}";
            Console.WriteLine("Mezclamos los ingredientes");
        }

        public void Reset()
        {
            _preparedDrink = new PreparedDrink();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beberse");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _preparedDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _preparedDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _preparedDrink.Water = water;
        }

        public PreparedDrink GetPreparedDrink() => _preparedDrink;
    }
}
