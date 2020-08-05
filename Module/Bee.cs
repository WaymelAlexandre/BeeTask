using System;
using System.Collections.Generic;
using System.Linq;
namespace Beestask
{
    public class Bee
    {
        public string BeeName { get; set; }
        public float BeeSize { get; set; }

        public Bee(){}
        public Bee(string beeName, float beeSize)
        {
            BeeName = beeName;
            BeeSize = beeSize;
        }

        public string PrintBee()
        {
            return $"{this.BeeName} {this.BeeSize}";
        }
       

            
        
    }
}