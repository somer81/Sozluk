using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozluk
{
    public class MyDictionary<Tkey,Tval>:IEnumerable
    {

        public Tkey[] _keys { get; set; }
        public Tval[] _values { get; set; }
     

        Tkey[] _tempkeys;
        Tval[] _tempvals; 



        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new Tval[0];
        }

        public void Add(Tkey key, Tval value)
        {
            _tempkeys = _keys;
            _tempvals = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new Tval[_values.Length + 1];

            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
                _values[i] = _tempvals[i]; 
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;

        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
