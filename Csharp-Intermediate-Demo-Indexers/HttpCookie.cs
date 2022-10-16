using System;
using System.Collections.Generic;
namespace Csharp_Intermediate_Demo_Indexers
{
    public class HttpCookie
    {

        private readonly Dictionary<string, string> _dictionary;

        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //WITH INDEXER
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        //WITHOUT INDEXER
        public void SetItem(string key, string value)
        {

        }

        public void GetItem(string key)
        {

        }
    }
}
