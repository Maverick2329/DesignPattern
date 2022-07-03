using DesingnPattern.Repository;
using DesingPatternsAsp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesingPatternsAsp.Strategies
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork);
    }
}
