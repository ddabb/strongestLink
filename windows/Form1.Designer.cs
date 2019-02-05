using System;
using System.Windows.Forms;

namespace windows
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtDectrion = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtExcept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 286);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDectrion);
            this.splitContainer1.Size = new System.Drawing.Size(1287, 243);
            this.splitContainer1.SplitterDistance = 643;
            this.splitContainer1.TabIndex = 16;
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(643, 243);
            this.txtResult.TabIndex = 15;
            // 
            // txtDectrion
            // 
            this.txtDectrion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDectrion.Location = new System.Drawing.Point(0, 0);
            this.txtDectrion.Multiline = true;
            this.txtDectrion.Name = "txtDectrion";
            this.txtDectrion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDectrion.Size = new System.Drawing.Size(640, 243);
            this.txtDectrion.TabIndex = 16;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 12);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1263, 269);
            this.splitContainer2.SplitterDistance = 863;
            this.splitContainer2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(863, 269);
            this.dataGridView1.TabIndex = 1;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnRun);
            this.splitContainer3.Panel1.Controls.Add(this.btnInit);
            this.splitContainer3.Panel1.Controls.Add(this.lblStart);
            this.splitContainer3.Panel1.Controls.Add(this.lblRows);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.txtStart);
            this.splitContainer3.Panel1.Controls.Add(this.txtRows);
            this.splitContainer3.Panel1.Controls.Add(this.txtColumns);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.txtExcept);
            this.splitContainer3.Panel2.Controls.Add(this.label1);
            this.splitContainer3.Size = new System.Drawing.Size(396, 269);
            this.splitContainer3.SplitterDistance = 105;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(304, 61);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(70, 27);
            this.btnRun.TabIndex = 19;
            this.btnRun.Text = "运行";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnInit
            // 
            this.btnInit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInit.Location = new System.Drawing.Point(304, 15);
            this.btnInit.Margin = new System.Windows.Forms.Padding(2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(70, 32);
            this.btnInit.TabIndex = 18;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click_1);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(30, 83);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(65, 12);
            this.lblStart.TabIndex = 17;
            this.lblStart.Text = "起始位置：";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(28, 15);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(41, 12);
            this.lblRows.TabIndex = 15;
            this.lblRows.Text = "行数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "列数：";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(147, 80);
            this.txtStart.Margin = new System.Windows.Forms.Padding(2);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(76, 21);
            this.txtStart.TabIndex = 14;
            this.txtStart.Text = "0";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(147, 12);
            this.txtRows.Margin = new System.Windows.Forms.Padding(2);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(76, 21);
            this.txtRows.TabIndex = 12;
            this.txtRows.Text = "6";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(147, 53);
            this.txtColumns.Margin = new System.Windows.Forms.Padding(2);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(76, 21);
            this.txtColumns.TabIndex = 13;
            this.txtColumns.Text = "6";
            // 
            // txtExcept
            // 
            this.txtExcept.Location = new System.Drawing.Point(32, 47);
            this.txtExcept.Margin = new System.Windows.Forms.Padding(2);
            this.txtExcept.Multiline = true;
            this.txtExcept.Name = "txtExcept";
            this.txtExcept.Size = new System.Drawing.Size(319, 52);
            this.txtExcept.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "不包含以下位置";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 529);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "最强连一连";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer splitContainer1;
        private TextBox txtDectrion;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer3;
        private Button btnRun;
        private Button btnInit;
        private Label lblStart;
        private Label lblRows;
        private Label label3;
        private TextBox txtStart;
        private TextBox txtRows;
        private TextBox txtColumns;
        private TextBox txtExcept;
        private Label label1;
        private TextBox txtResult;
    }
}

