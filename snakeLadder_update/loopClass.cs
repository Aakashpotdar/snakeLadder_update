using System;
using System.Collections.Generic;
using System.Text;

namespace snakeLadder_update
{
    public class loopClass
    {
        public int loopMethod(int nextMove1,int dai)
        {
            int position=0;
            switch (nextMove1)
            {
                case 0://no Move
                    break;
                case 1://ladder
                    position = position + dai;
                    if (position > 100)
                    {
                        position = position - dai;
                    }
                    break;
                case 2://snake
                    position = position - dai;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    break;
            }
            return position;
        }
    }
}
