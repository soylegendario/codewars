/*
The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a 
hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. 
Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

The following are examples of expected output values:

Rgb(255, 255, 255) # returns FFFFFF
Rgb(255, 255, 300) # returns FFFFFF
Rgb(0,0,0) # returns 000000
Rgb(148, 0, 211) # returns 9400D3

 */
using System;
using System.Text;

namespace CodeWars
{
    public static class RgbToHex
    {
        public static string Rgb(int r, int g, int b) 
        {
            var st = new StringBuilder();
            var rgb = new[] {r, g, b};
            foreach (var color in rgb) {
                st.Append (Math.Clamp (color, 0, 255).ToString ("X2"));
            }
            return st.ToString ();
        }   
    }
}