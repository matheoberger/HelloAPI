using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class HelloGenerator
    {
        Hello msg;
        private int buffSize = 100;
        List<int> results = new List<int>();

        public HelloGenerator()
        {
             msg = new Hello {HelloContent="Hello world!" };
        }

        public Hello DoThisSweetSound()
        {
            for(int i = 0; i < buffSize; i++)
            {
                results.Add(i * i);
                for (int z = 0; z < buffSize; z++)
                {
                    results.Add(i *z);
                }
            }
            return msg; // the object Hello is supposed to be the model
        }
    }
}
 