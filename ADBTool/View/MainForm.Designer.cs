namespace ADBTool.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_PackageName = new System.Windows.Forms.TextBox();
            this.btn_InsightsPath = new System.Windows.Forms.Button();
            this.text_execute = new System.Windows.Forms.TextBox();
            this.btn_execute = new System.Windows.Forms.Button();
            this.text_InsightsPath = new System.Windows.Forms.TextBox();
            this.text_CommandLinePath = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_CommandlinePath = new System.Windows.Forms.Button();
            this.label_PackageName = new System.Windows.Forms.Label();
            this.label_InsightsPath = new System.Windows.Forms.Label();
            this.label_CommandLinePath = new System.Windows.Forms.Label();
            this.text_Tracehost = new System.Windows.Forms.TextBox();
            this.label_TraceHost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_PackageName
            // 
            this.text_PackageName.Location = new System.Drawing.Point(170, 74);
            this.text_PackageName.Name = "text_PackageName";
            this.text_PackageName.Size = new System.Drawing.Size(379, 27);
            this.text_PackageName.TabIndex = 0;
            this.text_PackageName.TextChanged += new System.EventHandler(this.text_PackageName_TextChanged);
            // 
            // btn_InsightsPath
            // 
            this.btn_InsightsPath.Location = new System.Drawing.Point(558, 105);
            this.btn_InsightsPath.Name = "btn_InsightsPath";
            this.btn_InsightsPath.Size = new System.Drawing.Size(148, 29);
            this.btn_InsightsPath.TabIndex = 1;
            this.btn_InsightsPath.Text = "열기";
            this.btn_InsightsPath.UseVisualStyleBackColor = true;
            this.btn_InsightsPath.Click += new System.EventHandler(this.btn_InsightsPath_Click);
            // 
            // text_execute
            // 
            this.text_execute.Location = new System.Drawing.Point(42, 173);
            this.text_execute.Multiline = true;
            this.text_execute.Name = "text_execute";
            this.text_execute.ReadOnly = true;
            this.text_execute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_execute.Size = new System.Drawing.Size(507, 229);
            this.text_execute.TabIndex = 2;
            // 
            // btn_execute
            // 
            this.btn_execute.Location = new System.Drawing.Point(558, 173);
            this.btn_execute.Name = "btn_execute";
            this.btn_execute.Size = new System.Drawing.Size(148, 229);
            this.btn_execute.TabIndex = 3;
            this.btn_execute.Text = "실행";
            this.btn_execute.UseVisualStyleBackColor = true;
            this.btn_execute.Click += new System.EventHandler(this.btn_execute_Click);
            // 
            // text_InsightsPath
            // 
            this.text_InsightsPath.Location = new System.Drawing.Point(170, 107);
            this.text_InsightsPath.Name = "text_InsightsPath";
            this.text_InsightsPath.Size = new System.Drawing.Size(379, 27);
            this.text_InsightsPath.TabIndex = 4;
            // 
            // text_CommandLinePath
            // 
            this.text_CommandLinePath.Location = new System.Drawing.Point(170, 140);
            this.text_CommandLinePath.Name = "text_CommandLinePath";
            this.text_CommandLinePath.Size = new System.Drawing.Size(379, 27);
            this.text_CommandLinePath.TabIndex = 5;
            // 
            // btn_CommandlinePath
            // 
            this.btn_CommandlinePath.Location = new System.Drawing.Point(558, 140);
            this.btn_CommandlinePath.Name = "btn_CommandlinePath";
            this.btn_CommandlinePath.Size = new System.Drawing.Size(148, 29);
            this.btn_CommandlinePath.TabIndex = 6;
            this.btn_CommandlinePath.Text = "열기";
            this.btn_CommandlinePath.UseVisualStyleBackColor = true;
            this.btn_CommandlinePath.Click += new System.EventHandler(this.btn_CommandlinePath_Click);
            // 
            // label_PackageName
            // 
            this.label_PackageName.AutoSize = true;
            this.label_PackageName.Location = new System.Drawing.Point(40, 77);
            this.label_PackageName.Name = "label_PackageName";
            this.label_PackageName.Size = new System.Drawing.Size(89, 20);
            this.label_PackageName.TabIndex = 7;
            this.label_PackageName.Text = "패키지 이름";
            // 
            // label_InsightsPath
            // 
            this.label_InsightsPath.AutoSize = true;
            this.label_InsightsPath.Location = new System.Drawing.Point(40, 109);
            this.label_InsightsPath.Name = "label_InsightsPath";
            this.label_InsightsPath.Size = new System.Drawing.Size(104, 20);
            this.label_InsightsPath.TabIndex = 8;
            this.label_InsightsPath.Text = "인사이트 경로";
            // 
            // label_CommandLinePath
            // 
            this.label_CommandLinePath.AutoSize = true;
            this.label_CommandLinePath.Location = new System.Drawing.Point(40, 144);
            this.label_CommandLinePath.Name = "label_CommandLinePath";
            this.label_CommandLinePath.Size = new System.Drawing.Size(124, 20);
            this.label_CommandLinePath.TabIndex = 9;
            this.label_CommandLinePath.Text = "커맨드 파일 경로";
            // 
            // text_Tracehost
            // 
            this.text_Tracehost.Location = new System.Drawing.Point(170, 41);
            this.text_Tracehost.Name = "text_Tracehost";
            this.text_Tracehost.Size = new System.Drawing.Size(379, 27);
            this.text_Tracehost.TabIndex = 10;
            this.text_Tracehost.TextChanged += new System.EventHandler(this.text_TraceHost_TextChanged);
            // 
            // label_TraceHost
            // 
            this.label_TraceHost.AutoSize = true;
            this.label_TraceHost.Location = new System.Drawing.Point(40, 44);
            this.label_TraceHost.Name = "label_TraceHost";
            this.label_TraceHost.Size = new System.Drawing.Size(71, 20);
            this.label_TraceHost.TabIndex = 11;
            this.label_TraceHost.Text = "tracehost";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.label_TraceHost);
            this.Controls.Add(this.text_Tracehost);
            this.Controls.Add(this.label_CommandLinePath);
            this.Controls.Add(this.label_InsightsPath);
            this.Controls.Add(this.label_PackageName);
            this.Controls.Add(this.btn_CommandlinePath);
            this.Controls.Add(this.text_CommandLinePath);
            this.Controls.Add(this.text_InsightsPath);
            this.Controls.Add(this.btn_execute);
            this.Controls.Add(this.text_execute);
            this.Controls.Add(this.btn_InsightsPath);
            this.Controls.Add(this.text_PackageName);
            this.Name = "MainForm";
            this.Text = "원클릭 안드로이드 인사이트 프로파일링";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_PackageName;
        private TextBox text_InsightsPath;
        private Button btn_InsightsPath;
        private TextBox text_execute;
        private Button btn_execute;
        private TextBox text_CommandLinePath;
        private ColorDialog colorDialog1;
        private Button btn_CommandlinePath;
        private Label label_PackageName;
        private Label label_InsightsPath;
        private Label label_CommandLinePath;
        private TextBox text_Tracehost;
        private Label label_TraceHost;
    }
}