using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace tpmodul5_1302200040
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;

        }

        public void IncreasePlayCount(int n)
        {
            if (n <= 10000000)
            {
                for (playCount = 0; playCount <= n; playCount++)
                {
                    
                }
                int z = 0;
                try
                {
                    z = checked(n + 10);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Check : " + e.ToString());
                    Console.WriteLine("Melebihi batas input");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Title : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}
