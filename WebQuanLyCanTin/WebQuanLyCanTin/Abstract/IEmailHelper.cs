using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanLyCanTin.Abstract
{
    interface IEmailHelper
    {
        void Send(string email, string subject, string body, List<string> cc);
    }
}
