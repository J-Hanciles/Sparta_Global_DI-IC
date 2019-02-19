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
    class Coffee : IBrewCoffee, IInstant, IBlend, IDecaf, IMilk
    {

    }
    class BasicCoffeeMachine : Coffee
    {

    }
    class PremiumCoffeeMachine : Coffee
    {

    }
    interface IBeans
    {
        //Light Roast, Medium Roast, Dark Roast
        //string Lightroastbeans;
        //string Mediumroastbeans;
        //string Darkroastbeans;
    }
    interface IInstant
    {
        //Instant
    }
    interface IDecaf
    {
        //Full Strength or Decaf
    }
    interface IMilk
    {
        //Milky or Black
    }
    interface IBlend
    {
        //Brewed
    }
    interface IBrewCoffee
    {
        //Make Coffee
    }
}
