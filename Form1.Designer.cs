namespace LTimer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            settingToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            aboutLTimerToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(279, 55);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 100;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("メイリオ", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(279, 56);
            label1.TabIndex = 1;
            label1.Text = "LT:99min";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { settingToolStripMenuItem, restartToolStripMenuItem, aboutLTimerToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(165, 98);
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(164, 22);
            settingToolStripMenuItem.Text = "Open setting.xml";
            settingToolStripMenuItem.Click += settingToolStripMenuItem_Click;
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.Size = new Size(164, 22);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // aboutLTimerToolStripMenuItem
            // 
            aboutLTimerToolStripMenuItem.Name = "aboutLTimerToolStripMenuItem";
            aboutLTimerToolStripMenuItem.Size = new Size(164, 22);
            aboutLTimerToolStripMenuItem.Text = "about LTimer";
            aboutLTimerToolStripMenuItem.Click += aboutLTimerToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(164, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(302, 77);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "LTimer";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem aboutLTimerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem restartToolStripMenuItem;
    }
}