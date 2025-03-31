namespace LanzouLinkBuilder
{
    partial class Main_Window
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.pageHeader = new AntdUI.PageHeader();
            this.label_FileLink = new AntdUI.Label();
            this.input_FileLink = new AntdUI.Input();
            this.tooltipComponent1 = new AntdUI.TooltipComponent();
            this.label_Section = new AntdUI.Label();
            this.inputNumber_Section = new AntdUI.InputNumber();
            this.inputNumber_Sc_Num = new AntdUI.InputNumber();
            this.label_Sc_Num = new AntdUI.Label();
            this.label_Output = new AntdUI.Label();
            this.input1_Output = new AntdUI.Input();
            this.button_Copy = new AntdUI.Button();
            this.button_Build = new AntdUI.Button();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.HandCursor = System.Windows.Forms.Cursors.Default;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximizeBox = false;
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowButton = true;
            this.pageHeader.ShowIcon = true;
            this.pageHeader.Size = new System.Drawing.Size(540, 30);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Text = "Main_Window";
            // 
            // label_FileLink
            // 
            this.label_FileLink.Location = new System.Drawing.Point(12, 36);
            this.label_FileLink.Name = "label_FileLink";
            this.label_FileLink.Size = new System.Drawing.Size(120, 30);
            this.label_FileLink.TabIndex = 1;
            this.label_FileLink.Text = "原始文件分享链接：";
            // 
            // input_FileLink
            // 
            this.input_FileLink.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input_FileLink.Location = new System.Drawing.Point(127, 36);
            this.input_FileLink.Name = "input_FileLink";
            this.input_FileLink.Size = new System.Drawing.Size(401, 30);
            this.input_FileLink.SuffixText = "";
            this.input_FileLink.TabIndex = 2;
            // 
            // label_Section
            // 
            this.label_Section.Location = new System.Drawing.Point(12, 72);
            this.label_Section.Name = "label_Section";
            this.label_Section.Size = new System.Drawing.Size(40, 30);
            this.label_Section.TabIndex = 3;
            this.label_Section.Text = "节数:";
            // 
            // inputNumber_Section
            // 
            this.inputNumber_Section.HandCursor = System.Windows.Forms.Cursors.Default;
            this.inputNumber_Section.Location = new System.Drawing.Point(58, 72);
            this.inputNumber_Section.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.inputNumber_Section.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber_Section.Name = "inputNumber_Section";
            this.inputNumber_Section.Size = new System.Drawing.Size(90, 30);
            this.inputNumber_Section.TabIndex = 4;
            this.inputNumber_Section.Text = "1";
            this.inputNumber_Section.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inputNumber_Sc_Num
            // 
            this.inputNumber_Sc_Num.HandCursor = System.Windows.Forms.Cursors.Default;
            this.inputNumber_Sc_Num.Location = new System.Drawing.Point(233, 72);
            this.inputNumber_Sc_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumber_Sc_Num.Name = "inputNumber_Sc_Num";
            this.inputNumber_Sc_Num.Size = new System.Drawing.Size(90, 30);
            this.inputNumber_Sc_Num.TabIndex = 6;
            this.inputNumber_Sc_Num.Text = "1";
            this.inputNumber_Sc_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Sc_Num
            // 
            this.label_Sc_Num.Location = new System.Drawing.Point(154, 72);
            this.label_Sc_Num.Name = "label_Sc_Num";
            this.label_Sc_Num.Size = new System.Drawing.Size(73, 30);
            this.label_Sc_Num.TabIndex = 5;
            this.label_Sc_Num.Text = "每节字符数:";
            // 
            // label_Output
            // 
            this.label_Output.Location = new System.Drawing.Point(12, 117);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(40, 21);
            this.label_Output.TabIndex = 8;
            this.label_Output.Text = "输出:";
            // 
            // input1_Output
            // 
            this.input1_Output.AutoScroll = true;
            this.input1_Output.HandCursor = System.Windows.Forms.Cursors.Default;
            this.input1_Output.Location = new System.Drawing.Point(12, 144);
            this.input1_Output.MaxLength = 2147483647;
            this.input1_Output.Multiline = true;
            this.input1_Output.Name = "input1_Output";
            this.input1_Output.ReadOnly = true;
            this.input1_Output.Size = new System.Drawing.Size(516, 124);
            this.input1_Output.SuffixText = "";
            this.input1_Output.TabIndex = 7;
            // 
            // button_Copy
            // 
            this.button_Copy.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Copy.Location = new System.Drawing.Point(437, 115);
            this.button_Copy.Name = "button_Copy";
            this.button_Copy.Size = new System.Drawing.Size(91, 30);
            this.button_Copy.TabIndex = 9;
            this.button_Copy.Text = "复制";
            this.button_Copy.Click += new System.EventHandler(this.button_Copy_Click);
            // 
            // button_Build
            // 
            this.button_Build.HandCursor = System.Windows.Forms.Cursors.Default;
            this.button_Build.Location = new System.Drawing.Point(340, 117);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(91, 30);
            this.button_Build.TabIndex = 11;
            this.button_Build.Text = "生成";
            this.button_Build.Type = AntdUI.TTypeMini.Primary;
            this.button_Build.Click += new System.EventHandler(this.button_Build_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 280);
            this.Controls.Add(this.button_Build);
            this.Controls.Add(this.button_Copy);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.input1_Output);
            this.Controls.Add(this.inputNumber_Sc_Num);
            this.Controls.Add(this.label_Sc_Num);
            this.Controls.Add(this.inputNumber_Section);
            this.Controls.Add(this.label_Section);
            this.Controls.Add(this.input_FileLink);
            this.Controls.Add(this.label_FileLink);
            this.Controls.Add(this.pageHeader);
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main_Window";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Window";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader pageHeader;
        private AntdUI.Label label_FileLink;
        private AntdUI.Input input_FileLink;
        private AntdUI.TooltipComponent tooltipComponent1;
        private AntdUI.Label label_Section;
        private AntdUI.InputNumber inputNumber_Section;
        private AntdUI.InputNumber inputNumber_Sc_Num;
        private AntdUI.Label label_Sc_Num;
        private AntdUI.Label label_Output;
        private AntdUI.Input input1_Output;
        private AntdUI.Button button_Copy;
        private AntdUI.Button button_Build;
    }
}

