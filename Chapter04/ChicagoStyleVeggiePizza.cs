﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Study.Chapter04
{
    internal class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add( "Shredded Mozzarella Cheese" );
            toppings.Add( "Black Olives" );
            toppings.Add( "Spinach" );
            toppings.Add( "Eggplant" );
        }

        void Cut()
        {
            Console.WriteLine( "Cutting the pizza into square slices" );
        }
    }
}
