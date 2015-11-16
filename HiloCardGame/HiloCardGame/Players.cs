using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiloCardGame
{
    class Players
    {
        private string _Name;
        private int _Score;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Score
        {
            get { return _Score; }
            set { _Score = value; }
        }
        

    }
}
