using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADBTool.Controller
{
    public interface IForm
    {
        public void SetController(ADBToolController controller);
        public void SetTracehost(string tracehost);
        public void SetPackageName(string packageName);
        public void SetInsightsPath(string path);
        public void SetCommandLinePath(string path);

        public void AddOutputLog(string outputLog);
    }
}
