using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace snakeGame
{
    internal class Input
    {
        //creating instance for hastable class for optimizing the key inserted in it
        private static Hashtable keyTable= new Hashtable();

        public static bool KeyPress(Keys key)
        {
            if (keyTable[key] == null)
            {
                //return false if the hastable is empty
                return false;
            }

            //return true if hastable is non empty
            return (bool)keyTable[key];
        }

        public static void changeStates(Keys key, bool state) 
        {
            keyTable[key] = state;
        }
    }
}
