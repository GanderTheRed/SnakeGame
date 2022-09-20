using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Windows.Forms;

namespace SnakeGame
{
    internal class Input
    {
        private static Hashtable keyTable = new Hashtable();
        //A hashtable class which is used to create a "table"

        public static bool KeyPress(Keys key)
        {
            //Function to return a key back to the hashtable class.
            if (keyTable[key] == null)
            {
                //If hashtable is empty return false
                return false;
            }
            return (bool)keyTable[key];
            //If hashtable isn't empty return true.
        }

        public static void changeState(Keys key, bool state)
        {
            //A function to change the state of a key press and also the player object
            keyTable[key] = state;
        }
    }
}
