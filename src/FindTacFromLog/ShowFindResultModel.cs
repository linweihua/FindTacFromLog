using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTacFromLog
{
    public class ShowFindResultModel
    {
        public string tac;
        public int count;
        public List<FindResult> files;
        public ShowFindResultModel()
        {
            files = new List<FindResult>();
        }
     
    }

   public  class FindResult
    {
        public string fileName;
        public int  index;
    }
}
