using System.Collections.Generic;

namespace Screenplay.Core
{
    internal class Notepad
    {
        private Dictionary<string, object> _values = new Dictionary<string, object>();

        internal void WriteDown(string key, object value)
        {
            this._values.Add(key,value);
        }

        internal T Read<T>(string key)
        {
            var value = this._values[key];
            return (T) value;
        }
    }
}
