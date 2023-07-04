using System;
using System.Collections.Generic;
using System.Text;

namespace Lukasz_Koscielniak_Kol3
{
    class Amfibia : IJedzie , IPlywa
    {
        public void plyn()
        {
            Console.WriteLine("plywa");
        }


        public void jedz()
        {
            Console.WriteLine("jedzie");

        }
    }
}
