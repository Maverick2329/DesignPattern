using DesingnPattern.Repository;
using DesingPatternsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPatternsAsp.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;
        public IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public  BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);
        }
    }
}
