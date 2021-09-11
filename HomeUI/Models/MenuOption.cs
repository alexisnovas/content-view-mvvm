using System;
using System.Collections.Generic;
using System.Text;

namespace HomeUI.Models
{
    class MenuOption
    {
        public MenuOption(string image, string title, string subtitle)
        {
            Image = image;
            Title = title;
            Subtitle = subtitle;
        }
        public string Image { get; }
        public string Title { get; }
        public string Subtitle { get; }
    }
}
