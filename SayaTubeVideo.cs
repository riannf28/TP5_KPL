using System;
using System.Collections.Generic;
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
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;

        }

        public void IncreasePlayCount(int n)
        {
            for (playCount = 0; playCount <= n; playCount++)
            {

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
