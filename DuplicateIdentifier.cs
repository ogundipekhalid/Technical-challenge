using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_challenge
{
    public class DuplicateIdentifierr<T> where T : IEquatable<T>
    {

        private readonly List<T> _collectionA;
        private readonly List<T> _collectionS;

        public DuplicateIdentifierr(List<T> collectionA, List<T> collectionS)
        {
            _collectionA = collectionA;
            _collectionS = collectionS;
        }

        public void IdentifyDuplicates()
        {
            foreach (var item in _collectionS)
            {
                bool isPresent = _collectionA.Contains(item);
                Console.WriteLine($"{item}:{isPresent.ToString().ToLower()}");
            }
        }

       
    }
}


