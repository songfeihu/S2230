﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_0200单例
{
  public  class Song
    {
        public string SongName { get; set; }
        public string SongPath { get; set; }

        public Song() { }
        public Song(string songName,string songPath) 
        {
            this.SongName = songName;
            this.SongPath = songPath;
        }
    }
}
