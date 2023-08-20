using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace ADBTool.Model
{
    public class FileConfiguration
    {
        private string _configPath = Application.StartupPath + "Config.txt";

        private const string _tracehostInfo = "tracehost:";
        private string _tracehost = "";
        public string tracehost
        {
            get { return _tracehost; }
            set { _tracehost = value; }
        }

        private const string _packageNameInfo = "packageName:";
        private string _packageName = "";
        public string packageName 
        {
            get { return _packageName; } 
            set { _packageName = value; }
        }

        private const string _insightsPathInfo = "InsightsPath:";
        private string _insightsPath = "";
        public string insightsPath
        {
            get { return _insightsPath; }
            set { _insightsPath = value; }
        }

        private const string _commandLinePathInfo = "CommandLinePath:";
        private string _commandLinePath = "";
        public string commandLinePath
        {
            get { return _commandLinePath; }
            set { _commandLinePath = value; }
        }

        private string _appProcessPath = Application.StartupPath + "Files/execute_app.bat";
        public string appProcessPath
        {
            get { return _appProcessPath; }
        }

        private string _insightsProcessPath = Application.StartupPath + "Files/execute_insights.bat";
        public string insightsProcessPath
        {
            get { return _insightsProcessPath; }
        }

        public bool IsConfigFileExists()
        {
            return File.Exists(_configPath);
        }

        public bool IsFileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void CreateDefaultConfigFile()
        {
            tracehost = GetLocalIPAddress();
            packageName = "com.YourCompany.AppName";
            commandLinePath = Application.StartupPath + "/Files/UECommandLine.txt";

            WriteConfigFile();
        }

        public void LoadConfigFile()
        {
            string[] configTexts = File.ReadAllLines(_configPath);

            ParseConfigFile(configTexts);
        }

        public void SaveCommandLineFile()
        {
            string value = File.ReadAllText(commandLinePath);
            string[] parsedText = value.Split(" ");
            string newCommand = "";

            string tracehostCommand = "-tracehost=";
            for (int textIndex = 0; textIndex< parsedText.Length; textIndex++)
            {
                string parsedCommand = parsedText[textIndex];
                if (parsedCommand.StartsWith(tracehostCommand))
                    newCommand += parsedCommand.Replace(parsedCommand, tracehostCommand + tracehost);
                else
                    newCommand += parsedCommand;

                newCommand += " ";
            }

            File.WriteAllText(_commandLinePath, newCommand);
        }

        public void SaveConfigFile()
        {
            WriteConfigFile();
        }

        private void WriteConfigFile()
        {
            string value = _tracehostInfo + " " + tracehost + "\n"
                + _packageNameInfo + " " + packageName + "\n"
                + _insightsPathInfo + " " + insightsPath + "\n"
                + _commandLinePathInfo + " " + commandLinePath;

            File.WriteAllText(_configPath, value);
        }
        private void ParseConfigFile(string[] configTexts)
        {
            for (int textIndex = 0; textIndex < configTexts.Length; textIndex++)
            {
                string[] parsedText = configTexts[textIndex].Split(" ");

                if (parsedText.Length < 1)
                    continue;

                string parsedName = parsedText[0];
                string parsedValue = parsedText[1];

                if (parsedName == _tracehostInfo)
                    tracehost = parsedValue;
                else if (parsedName == _packageNameInfo)
                    packageName = parsedValue;
                else if (parsedName == _insightsPathInfo)
                    insightsPath = parsedValue;
                else if (parsedName == _commandLinePathInfo)
                    commandLinePath = parsedValue;
                else
                    continue;
            }
        }

        private string GetLocalIPAddress()
        {
            string result = "127.0.0.1";

            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    result = ip.ToString();
                    break;
                }
            }

            return result;
        }
    }
}
