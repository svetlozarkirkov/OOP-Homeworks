using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P3_StringDisperser
{
    class StringDisperser : IComparable<StringDisperser>, ICloneable, IEnumerator, IEnumerable
    {
        public string[] StringElements { get; set; }
        public List<char> CharElements { get; set; }
        private int position = -1;

        public int CharSum
        {
            get
            {
                return this.CharElements.Sum(ch => (int) ch);
            }
        }

        public StringDisperser(params string[] args)
        {
            this.StringElements = args;
            this.CharElements = new List<char>();
            foreach (var stringElement in this.StringElements)
            {
                foreach (var charElement in stringElement)
                {
                    this.CharElements.Add(charElement);
                }
            }
        }

        protected bool Equals(StringDisperser other)
        {
            return Equals(CharElements, other.CharElements);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((StringDisperser) obj);
        }

        public override int GetHashCode()
        {
            return (CharElements != null ? CharElements.GetHashCode() : 0);
        }

        public static bool operator ==(StringDisperser left, StringDisperser right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(StringDisperser left, StringDisperser right)
        {
            return !Equals(left, right);
        }

        public override string ToString()
        {
            if (this.StringElements.Length == 0)
            {
                return "Empty";
            }
            string result = string.Format("Strings: [ {0} ]\nChars: [ {1} ]\nChar Sum: {2}",
                string.Join(", ", this.StringElements), string.Join(" ", this.CharElements),this.CharSum);
            return result;
        }

        public StringDisperser Clone()
        {
            return new StringDisperser(this.StringElements);
        }

        object ICloneable.Clone() { return Clone(); }

        public int CompareTo(StringDisperser other)
        {
            return this.CharSum - other.CharSum;
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            position++;
            return (position < this.CharElements.Count);
        }
        public void Reset()
        { position = 0; }
        public object Current
        {
            get { return this.CharElements[position]; }
        }
    }
}