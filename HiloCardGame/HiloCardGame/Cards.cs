using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HiloCardGame
{
    class Cards
    {
        private int _Rank;
        private string _Suit;
        private bool _used = false;
        //private string _Suitcase;

        public int Ranks
        {
            get { return _Rank; }
        }

        public bool Use
        {
            get { return _used; }
            set { _used = value; }
        }
        public Cards()
        {

        }
        public Cards(string suit, int rank)
        {
            _Suit = suit;
            _Rank = rank;
        }

        public override string ToString()
        {
            string tell;
            switch (Ranks)
            {
                case 1: tell = "suit: " + _Suit + "\trank: " + _Rank + " (Ace)";
                    break;
                case 11: tell = "suit: " + _Suit + "\trank: " + _Rank + " (Jack)";
                        break;
                case 12: tell = "suit: " + _Suit + "\trank: "+ _Rank +" (Queen)";
                        break;
                case 13: tell = "suit: " + _Suit + "\trank: "+ _Rank + " (King) " ;
                        break;
                default: tell = "suit: " + _Suit + "\trank: " + _Rank;
                        break;
            }
            return tell;
        }






    }
}
