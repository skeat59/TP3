using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace boucles2
{
  class Boucles2
  {
    SpriteBatch sb;
    Texture2D img;
    SpriteFont font;
    int size;

    public Boucles2(SpriteBatch sb, Texture2D img, SpriteFont font)
    {
      this.sb = sb;
      this.img = img;
      this.font = font;
      this.size = img.Width;
    }

    private void draw(int x, int y, Color c)
    {
        x = x % 11;
        y = y / 11;

      sb.Draw(img, new Vector2(x * size, y * size), c);
      sb.DrawString(font, "x:"+x + "\ny:"+y, new Vector2(x * size + 9, y * size +2), Color.Black);
    }

    public void run()
    {
      Color c = Color.White;
      for (int x = 0; x < 121; x++)
      {
        draw(x, x, c);
      }
    }
  }
}
