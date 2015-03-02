using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLibrary
    {
    class Box:IEquatable<Box>
        {
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }

        public Box (int h, int l, int w)
            {
            Height = h;
            Length = l;
            Weight = w;
            }

        public bool Equals (Box other)
            {
            return (new BoxSameDimensions ( ).Equals (this, other)) ? true : false;
            }

        public override bool Equals (object obj)
            {
            return base.Equals (obj);
            }

        public override int GetHashCode ( )
            {
            return base.GetHashCode ( );
            }
        }
    }
