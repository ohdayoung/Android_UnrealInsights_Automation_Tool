using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ADBTool.Model;

namespace ADBTool.Controller
{
    public class ADBToolController
    {
        FileConfiguration _fileConfiguration;
        IForm _form;
        public ADBToolController(FileConfiguration fileConfiguration, IForm form)
        {
            _fileConfiguration = fileConfiguration;
            _form = form;
            _form.SetController(this);
        }

        public void LoadConfiguration()
        {
            if (_fileConfiguration.IsConfigFileExists())
            {
                _fileConfiguration.LoadConfigFile();
            }
            else
            {
                _fileConfiguration.CreateDefaultConfigFile();
            }
        }

        public void ExecuteAllProcesses()
        {
            string insightsProcessArgs = "";
            string[] parsedPackageName = _fileConfiguration.packageName.Split('.');

            if (parsedPackageName.Length > 0) 
            {
                string projectName = parsedPackageName[parsedPackageName.Length - 1];

                insightsProcessArgs =
                    _fileConfiguration.commandLinePath + " " +
                    _fileConfiguration.packageName + " " +
                    projectName + " " +
                    _fileConfiguration.insightsPath;
            }

            ExecuteProcess(_fileConfiguration.insightsProcessPath, insightsProcessArgs);
            ExecuteProcess(_fileConfiguration.insightsPath, "");
            ExecuteProcess(_fileConfiguration.appProcessPath, _fileConfiguration.packageName);
        }

        private async void ExecuteProcess(string processName, string args)
        {
            if (_fileConfiguration.IsFileExists(processName) == false)
                return;

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = processName;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.Arguments = args;

            if (process.Start())
            {
                await process.WaitForExitAsync();
                CaptureProcessOutputLog(process.StandardOutput.ReadToEnd());
            }
        }

        private void CaptureProcessOutputLog(string outputlog)
        {
            _form.AddOutputLog(outputlog);
        }

        public void InitView()
        {
            if (_fileConfiguration.IsFileExists(_fileConfiguration.commandLinePath))
                _fileConfiguration.SaveCommandLineFile();

            _form.SetTracehost(_fileConfiguration.tracehost);
            _form.SetPackageName(_fileConfiguration.packageName);
            _form.SetInsightsPath(_fileConfiguration.insightsPath);
            _form.SetCommandLinePath(_fileConfiguration.commandLinePath);
        }

        public void UpdateTracehost(string tracehost)
        {
            _fileConfiguration.tracehost = tracehost;
            _fileConfiguration.SaveConfigFile();
            
            if (_fileConfiguration.IsFileExists(_fileConfiguration.commandLinePath))
                _fileConfiguration.SaveCommandLineFile();

            _form.SetTracehost(_fileConfiguration.tracehost);
        }
        public void UpdatePackageName(string filePath)
        {
            _fileConfiguration.packageName = filePath;
            _fileConfiguration.SaveConfigFile();

            _form.SetPackageName(_fileConfiguration.packageName);
        }

        public void UpdateInsightsPath(string filePath)
        {
            _fileConfiguration.insightsPath = filePath;
            _fileConfiguration.SaveConfigFile();

            _form.SetInsightsPath(_fileConfiguration.insightsPath);
        }

        public void UpdateCommandLinePath(string filePath)
        {
            _fileConfiguration.commandLinePath = filePath;
            _fileConfiguration.SaveConfigFile();

            if (_fileConfiguration.IsFileExists(_fileConfiguration.commandLinePath))
                _fileConfiguration.SaveCommandLineFile();

            _form.SetInsightsPath(_fileConfiguration.commandLinePath);
        }
    }
}
