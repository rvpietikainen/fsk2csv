using System;
using System.Collections.Generic;
using System.Text;

namespace fsk2csv
{
    public class FskModel
    {
        public FskEntityContainer data { get; set; }
    }

    public class FskEntityContainer : Dictionary<string, FskEntity>
    {
    }

    public class FskPasswordHistory
    {
        public string password { get; set; }
        public double changedata { get; set; }
    }

    public class FskEntity
    {
        public string rev { get; set; }
        public string service { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string notes { get; set; }
        public string color { get; set; }
        public string style { get; set; }
        public int type { get; set; }
        public List<FskPasswordHistory> passwordList { get; set; }
    }
}
