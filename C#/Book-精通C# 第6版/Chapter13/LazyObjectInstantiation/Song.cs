using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LazyObjectInstantiation
{
    //  表示一首歌曲
    class Song
    {
        public string Artist { get; set; }
        public string TrackName { get; set; }
        public double TrackLength { get; set; }
    }

    //  表示播放器上的所有歌曲
    class AllTracks
    {
        //  该多媒体播放器最多可容纳10 000首歌曲
        private Song[] allSongs = new Song[10000];

        public AllTracks()
        {
            //  假设Song对象填充了数组
            Console.WriteLine("Filling up the songs");
        }
    }

    //  MediaPlayer包含AllTracks对象
    class MediaPlayer
    {
        //  假设这些方法包含相应的功能
        public void Play() { /* 播放歌曲 */}
        public void Pause() { /* 暂停歌曲 */}
        public void Stop() { /* 停止播放 */}

        private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() =>
            {
                Console.WriteLine("Create AllTracks object!");
                return new AllTracks();
            });

        public AllTracks GetAllTracks()
        {
            //  返回所有的歌曲
            return allSongs.Value;
        }
    }
}
