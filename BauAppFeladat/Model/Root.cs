using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauAppFeladat.Model
{
    [Serializable]
    public class Root
    {
        public int resultCode { get; set; }
        public string message { get; set; }
        public List<Result> result { get; set; }

        public Root()
        {
        }

        public Root(int resultCode, string message, List<Result> result)
        {
            this.resultCode = resultCode;
            this.message = message;
            this.result = result;
        }
    }
}
