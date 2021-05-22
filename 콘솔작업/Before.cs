using System;
using System.Collections.Generic;

namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");

            List<int> bubblesort = new List<int>()
        { 3, 5, 10, -2, 24};
            Console.WriteLine(bubblesort[3]);

            //2. 왼쪽부터 수를 두개씩 비교한다.
            //큰 수를 오른쪽으로 보낸다. -> 왼쪽 수가 오른쪽 보다 크면 위치를 바꾼다.
            if (bubblesort[0] > bubblesort[1])
            {

                //바꾼다? 즉, 오른쪽에 있는 수를 왼쪽에 넣고 왼쪽에 있는 수를 오른쪽으로 넣는다?
                Console.WriteLine(bubblesort[0] = bubblesort[1]);
                Console.WriteLine(bubblesort[1] = bubblesort[0]);
            }
            else
            {
                Console.WriteLine(bubblesort[0]);
                Console.WriteLine(bubblesort[1]);
            }

        }
    }
}

