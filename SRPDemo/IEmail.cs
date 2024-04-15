using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
