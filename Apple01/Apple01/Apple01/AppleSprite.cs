﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Apple01
{
    class AppleSprite : Sprite
    {
        // Random number generator - Needed to randomly select spawn points for this sprite
        static Random random = new Random();
        
        // AppleSprite Constructor
        public AppleSprite(Texture2D image, Point frameSize, int collisionOffset, Vector2 speed, Rectangle clientBounds) :
            base(image, new Vector2(getRandom(clientBounds.Width), getRandom(50)), frameSize, collisionOffset, new Point(0, 0),
                new Point(1, 1), speed) { }

        // Helper Function to get random position - Needs to be static
        static int getRandom(int max)
        {
            return random.Next(max);
        }

        public override Vector2 direction
        {
            get { return speed; }
        }

        public override void Update(GameTime gameTime, Rectangle clientBounds)
        {
            position += direction;

            base.Update(gameTime, clientBounds);
        }
    }
}
