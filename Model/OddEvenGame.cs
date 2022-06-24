using System;
using System.Collections.Generic;
using System.Text;

namespace OddEven.Model
{
    public class OddEvenGame
    {
        public void Odd()
        {
            for(int i=1;i < 100; i+= 2)
            {
                Console.Write(i + " ");
            }
        }
        public void Even()
        {
            for (int i = 2; i <= 100; i+= 2)
            {
                Console.Write(i + " ");
            }
        }        
    }
}
