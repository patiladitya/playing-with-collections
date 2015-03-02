using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxLibrary
    {
    class BoxEnumerator:IEnumerator<Box>
        {
        private BoxCollection boxCollection;
        private int curIndex;
        private Box curBox;

        public BoxEnumerator (BoxCollection collection)
            {
            boxCollection = collection;
            curIndex = -1;
            curBox = default(Box);
            }

        public Box Current
            {
            get { return curBox; }
            }

        public void Dispose()
            {
            }

        object System.Collections.IEnumerator.Current
            {
            get { return Current; }
            }

        public bool MoveNext()
            {
            if (++curIndex >= boxCollection.Count) 
                return false;
            else
                {
                curBox = boxCollection[curIndex]; 
                return true;
                }
            }

        public void Reset()
            {
            curIndex = -1;
            }
        }
    }
