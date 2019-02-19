using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class BasicCoffeeMachine : IBrewCoffee, IBlend, IDecaf, IMilk
    {

    }
    class PremiumCoffeeMachine
    {

    }
    interface IBeans
    {
        //Light Roast, Medium Roast, Dark Roast
    }
    interface IDecaf
    {
        //Full Strength
    }
    interface IMilk
    {
        //Milky or Black
    }
    interface IBlend
    {
        //Instant of Brewed
    }
    interface IBrewCoffee
    {
        //Make Coffee
    }
}
