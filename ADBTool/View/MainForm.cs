using ADBTool.Model;
using ADBTool.Controller;
using System.Windows.Forms;

namespace ADBTool.View
{
    public partial class MainForm : Form, IForm
    {
        ADBToolController _controller;
        public MainForm()
        {
            InitializeComponent();
        }

        public void SetController(ADBToolController controller)
        {
            _controller = controller;
        }

        public void SetTracehost(string tracehost)
        {
            text_Tracehost.Text = tracehost;
        }

        public void SetPackageName(string packageName)
        {
            text_PackageName.Text = packageName;
        }

        public void SetInsightsPath(string path)
        {
            text_InsightsPath.Text = path;
        }

        public void SetCommandLinePath(string path)
        {
            text_CommandLinePath.Text = path;
        }

        public void AddOutputLog(string outputLog)
        {
            text_execute.AppendText("\n" + outputLog);
        }

        private void btn_InsightsPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.UpdateInsightsPath(fileDialog.FileName);
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            text_execute.Clear();
            _controller.ExecuteAllProcesses();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _controller.InitView();
        }

        private void text_PackageName_TextChanged(object sender, EventArgs e)
        {
            _controller.UpdatePackageName(text_PackageName.Text);
        }

        private void btn_CommandlinePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _controller.UpdateCommandLinePath(fileDialog.FileName);
            }
        }

        private void text_TraceHost_TextChanged(object sender, EventArgs e)
        {
            _controller.UpdateTracehost(text_Tracehost.Text);
        }
    }
}