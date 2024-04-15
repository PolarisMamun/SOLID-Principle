using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    public interface IPrintScanContent
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);
    }
    public interface IFaxContent
    {
        bool FaxContent(string content);

    }
    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
