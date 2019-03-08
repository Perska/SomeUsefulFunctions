/*
MonoGame functions.
I've used these and they're useful
*/

//these are here just because i'm too lazy to fix indentation
namespace things
{
	class morethings
	{
		/// <summary>
		/// A replacement function for Color(); this requires you to use integers.
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		Color CColor(int r, int g, int b)
		{
			return new Color(r, g, b);
		}

		/// <summary>
		/// A replacement function for Color(); this requires you to use integers.
		/// </summary>
		/// <param name="r"></param>
		/// <param name="g"></param>
		/// <param name="b"></param>
		/// <param name="a"></param>
		/// <returns></returns>
		Color CColor(int r, int g, int b, int a)
		{
			return new Color(r, g, b, a);
		}
		
		/// <summary>
		/// this function draws a rectangle
		/// make sure you have a 1x1 white pixel sprite
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="w"></param>
		/// <param name="h"></param>
		/// <param name="color"></param>
		void FillBox(int x, int y, int w, int h, Color color)
		{
			spr.Draw(pixel, new Rectangle(x, y, w, h), color);
		}
		
	}
}
