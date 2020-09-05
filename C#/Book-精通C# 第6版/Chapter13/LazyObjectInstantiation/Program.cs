using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyObjectInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            //  这里没有分配AkkTracks对象
            MediaPlayer myPlayer = new MediaPlayer();
            myPlayer.Play();

            //  在调用GetAllTracks()时分配AllTracks
            MediaPlayer yourPlayer = new MediaPlayer();
            AllTracks yourMusic = yourPlayer.GetAllTracks();

            Console.ReadLine();
        }
    }
}
