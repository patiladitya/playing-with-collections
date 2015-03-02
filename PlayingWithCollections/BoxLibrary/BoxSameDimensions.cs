using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxLibrary
    {
    class BoxSameDimensions:EqualityComparer<Box>
        {

        public override bool Equals( Box x, Box y )
            {
            return (x.Height == y.Height && x.Length == y.Length && x.Weight == y.Weight) ? true : false;
            }

        public override int GetHashCode( Box obj )
            {
            var hCode = obj.Height ^ obj.Length ^ obj.Weight;
            return hCode.GetHashCode ( );
            }
        }
    }
