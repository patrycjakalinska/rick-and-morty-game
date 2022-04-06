using System;
using System.Collections.Generic;
using System.Text;

namespace gra
{
    public static class StringToWordConv
    {
        public static Cables Convert(string word)
        {
            return word.ToLower() switch
            {
                "gazorpazorp" => Cables.Gazorpazorp,
                "schwifty" => Cables.Schwifty,
                "eyeholes" => Cables.Eyeholes,
                "meeseeks" => Cables.Meeseeks,
                "poopybutthole" => Cables.Poopybutthole,
                "morty" => Cables.Morty,
                "birdperson" => Cables.Birdperson,
                "squanchy" => Cables.Squanchy,
                _ => Cables.Unknown,
            };
        }
    }
}
