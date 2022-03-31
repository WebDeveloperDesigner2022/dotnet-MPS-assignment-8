using System;

namespace MPS_Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = 100;
            BeerSong song = new BeerSong(range);
            song.Sing();
        }
    }
}
