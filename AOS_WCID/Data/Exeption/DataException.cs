using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOS_WCID.Data.Exeption
{
    [Serializable]
    public class DataException : Exception
    {
        public DataException() { }

        public DataException(string path)
            : base(String.Format("There was an errror with the JSON Serializer: {0}", path))
        {

        }
    }
}
