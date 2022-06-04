using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "başarıyla eklendi";

        public static string Deleted { get; internal set; }
        public static string Listed { get; internal set; }
        public static string Updated { get; internal set; }
        public static bool RentError { get; internal set; }
    }
}
