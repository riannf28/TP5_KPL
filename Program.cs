using System;

namespace tpmodul5_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo saya = new SayaTubeVideo("Tutorial Design By Contract - Rian Nur Fauzi");
            saya.IncreasePlayCount(0);
            saya.PrintVideoDetails();
        }
    }
}
