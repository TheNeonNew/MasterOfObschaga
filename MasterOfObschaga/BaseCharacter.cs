using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterOfObschaga
{
    abstract class BaseCharacter
    {
        protected Point location;
        protected int hp, level;


        internal BaseCharacter() { 
            location = new Point(0, 0);
            level = 1;
        }



    }
}
