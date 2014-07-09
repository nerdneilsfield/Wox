﻿using System.Collections.Generic;
using System.Linq;

namespace Wox.RPC
{
    public class JsonRPC
    {
        public static string Send(string method, List<string> paras)
        {
            var list = paras.Select(s => string.Format(@"\""{0}\""", s));
            return string.Format(@"{{\""jsonrpc\"": \""2.0\"",\""method\"": \""{0}\"", \""parameters\"": [{1}], \""id\"": 1}}",
                method, string.Join(",", list.ToArray()));
        }

        public static string Send(string method, string para)
        {
            return string.Format(@"{{\""jsonrpc\"": \""2.0\"",\""method\"": \""{0}\"", \""parameters\"": \""{1}\"", \""id\"": 1}}",
                method, para);
        }
    }
}
