using System;
namespace MPS_Assignment_8
{
    internal class BeerSong
    {
        private int _index;
        public BeerSong(int index)
        {
            _index = index;
        }  

        public int Index { 
            get { return _index; }
            set { _index = value; }
        }

        public void Sing()
        {
            string songLines = "";
            
            for (int i = 1; i <= _index; i++)
            {
                songLines = $"{_index - i} bottles of beer on the wall, {_index - i}  bottles of beer.\nTake one down and pass it around, {_index - i} bottles of beer on the wall.";
                Console.WriteLine(songLines);
            }
        }

    }
}