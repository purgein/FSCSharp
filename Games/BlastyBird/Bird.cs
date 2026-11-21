using FSCSharp;
using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace BlastyBird
{
    public class Bird : VisibleGameObject
    {
        #region Constructors
        public Bird()
        {
            var texture = Raylib.LoadTexture("Resources/bird.png");
            Body = new Sprite(texture, 0.5f);
        }
        #endregion

        #region Overrides
        public override void Draw(float delta)
        {
            
        }

        public override void Update(float delta)
        {
            
        }
        #endregion

        #region Properties
        public Vector2 Location { get; set; }
        public Sprite Body { get; set; }
        #endregion
    }
}
