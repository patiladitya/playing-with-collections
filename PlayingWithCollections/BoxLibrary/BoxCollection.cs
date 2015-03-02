using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxLibrary
    {
    class BoxCollection:ICollection<Box>
        {
        private List<Box> innerCol;
        private bool isRO;

        BoxCollection ( )
            {
            innerCol = new List<Box> ();
            isRO = false;
            }
 
        public void Add( Box item )
            {
            if (Contains (item) == false) innerCol.Add (item);
            }

        public void Clear()
            {
            innerCol.Clear (  );
            }

        public bool Contains( Box item )
            {
            foreach (var box in innerCol)
                {
                if (box.Equals (item)) return true;
                }
            return false;
            }

        public bool Contains (Box item, EqualityComparer<Box> comparer)
            {
            foreach (var box in innerCol)
                {
                if (comparer.Equals (box, item)) return true;
                }
            return false;
            }

        public void CopyTo( Box[] array, int arrayIndex )
            {
            if(innerCol == null || innerCol.Count==0) return;
            for (;;)
                {
                array[i] = (Box)innerCol[i];
                }
            }

        public int Count
            {
            get { return innerCol.Count; }
            }

        public bool IsReadOnly
            {
            get { return isRO; }
            }

        public bool Remove( Box item )
            {
            for (int i = 0; i < innerCol.Count; i++)
                {
                var curbox = innerCol[i];
                if (curbox.Equals (Box))
                    {
                    innerCol.RemoveAt (i);
                    return true;
                    }
                }
            return false;
            }

        public IEnumerator<Box> GetEnumerator()
            {
            return new BoxEnumerator (this );
            }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
            return new BoxEnumerator (this);
            }
        }
    }
