using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedChecker
{
    public class Data
    {
        public Token token { get; set; }
    }

    public class UnitedToken
    {
        public Data data { get; set; }
        public object valid { get; set; }
        public object TokenExpiration { get; set; }
    }

    public class Token
    {
        public string hash { get; set; }
        public DateTime expiresAt { get; set; }
    }

}
