using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderParttern
{
    public class PreparedDrink
    {
        public List<string> Ingredientes = new List<string>();
        public int Milk;
        public int Water;
        public decimal Alcohol;
        
        public string Result;
    }
}
