using FSCSharp;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BlastyBird
{
    public class BlastyBirdGame : Game<BlastyBirdGame>
    {
        public BlastyBirdGame() : base("Blasty Bird", 1150, 700, Color.SkyBlue)
        {
            var location = new Vector2(WindowWidth * 0.10f, WindowHeight / 2);
            var bird = new Bird(location);
            GameObjects.Add(bird);
        }
    }
}
