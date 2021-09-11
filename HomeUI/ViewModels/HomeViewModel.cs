using HomeUI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeUI.ViewModels
{
    class HomeViewModel
    {
        public MenuOption Bar { get; }
        public MenuOption Dining { get; }
        public MenuOption Coffee { get; }
        public MenuOption Nearby { get; }
        public MenuOption Fastfood { get; }
        public MenuOption FeaturedFood { get; }

        public HomeViewModel()
        {
            Bar = new MenuOption("bar", "Bars and Hotels", "42 place");
            Dining = new MenuOption("dining", "Fine dining", "15 place");
            Coffee = new MenuOption("coffee", "Cafes", "28 place");
            Nearby = new MenuOption("nearby", "Nearby", "34 place");
            Fastfood = new MenuOption("fastfood", "Fast Foods", "29 place");
            FeaturedFood = new MenuOption("featuredfood", "Featured Foods", "25 place");
        }
    }
}
