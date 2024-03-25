using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


namespace LTimer
{
    public partial class Form1 : Form
    {
        public Stopwatch sTime = new Stopwatch();
        public int intLtTime = 3;
        public DataSet iniXml;

        public string strRM30Color = "";
        public string strFinColor = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting.xmlの値の読込（EXEファイルと同じフォルダに保存）
            LTimer.XmlRW xmlrw = new LTimer.XmlRW();
            try
            {
                iniXml = xmlrw.SetXML("setting.xml");
            }
            catch
            {
                MessageBox.Show("Can't read setting.xml file.");
                System.Windows.Forms.Application.Exit();
            }
            // setting.xmlの値の読込
            try
            {
                this.Top = int.Parse(iniXml.Tables[0].Rows[0]["START_Y"].ToString());
                this.Left = int.Parse(iniXml.Tables[0].Rows[0]["START_X"].ToString());
                intLtTime = int.Parse(iniXml.Tables[0].Rows[0]["LTTIME"].ToString());
                strRM30Color = iniXml.Tables[0].Rows[0]["RM30_COLOR"].ToString();
                strFinColor = iniXml.Tables[0].Rows[0]["FIN_COLOR"].ToString();
            }
            catch
            {
                MessageBox.Show("Can't read key in setting.xml file.");
                System.Windows.Forms.Application.Exit();
            }

            System.Drawing.Point p = new System.Drawing.Point(50, 10);

            label1.ForeColor = Color.DarkGray;
            label1.Text = "LT:" + intLtTime.ToString() + "min";

            timer1.Enabled = false;

            progressBar1.Value = 100;
            progressBar1.Visible = true;

            this.ContextMenuStrip = this.contextMenuStrip1;
            this.TopMost = true;
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            TimeSpan ts = sTime.Elapsed;
            try
            {
                int interval = (((intLtTime * 60) - (int)ts.TotalSeconds) * 100) / (intLtTime * 60);

                // 20～30%の間はメッセージを表示
                if (interval > 20 && interval < 30)
                {
                    progressBar1.Visible = false;
                    label1.Visible = true;
                    label1.BackColor = Color.Transparent;
                    label1.ForeColor = Color.FromName(strRM30Color);
                    label1.Text = iniXml.Tables[0].Rows[0]["RM30_MESSAGE"].ToString();
                    AutoAdjustFontSize(label1);
                }

                // 20未満はプログレスバーを表示
                if (interval < 20)
                {
                    progressBar1.Visible = true;
                    label1.Visible = false;
                }

                // 0%になったら終了メッセージを表示
                if (interval == 0)
                {
                    progressBar1.Visible = false;
                    timer1.Enabled = false;
                    label1.BackColor = Color.FromArgb(224, 224, 224);
                    label1.Visible = true;
                    label1.ForeColor = Color.FromName(strFinColor);
                    label1.Text = iniXml.Tables[0].Rows[0]["FIN_MESSAGE"].ToString();
                    AutoAdjustFontSize(label1);
                }
                progressBar1.Value = interval;
            }
            catch
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            sTime.Start();
        }

        private void AutoAdjustFontSize(Label label)
        {
            // ラベルのテキストが枠からはみ出る場合のみ処理を実行
            if (label.Width < TextRenderer.MeasureText(label.Text, label.Font).Width ||
                label.Height < TextRenderer.MeasureText(label.Text, label.Font).Height)
            {
                // ラベルのテキストが枠からはみ出ないフォントサイズまで縮小
                float fontSize = label.Font.Size;
                Size labelSize = label.ClientSize;

                while (TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, fontSize)).Width > labelSize.Width ||
                       TextRenderer.MeasureText(label.Text, new Font(label.Font.FontFamily, fontSize)).Height > labelSize.Height)
                {
                    fontSize -= 0.5f;
                }

                // 新しいフォントを設定
                label.Font = new Font(label.Font.FontFamily, fontSize);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void aboutLTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Top = this.Top + 50;
            form2.Left = this.Left + 50;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", System.Windows.Forms.Application.StartupPath + "\\setting.xml");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }
    }
}