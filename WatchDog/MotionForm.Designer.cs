﻿namespace WatchDog
{
    partial class MotionForm
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
            this.LogLabel = new System.Windows.Forms.Label();
            this.MotionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MotionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogLabel
            // 
            this.LogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogLabel.ForeColor = System.Drawing.Color.White;
            this.LogLabel.Location = new System.Drawing.Point(242, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Padding = new System.Windows.Forms.Padding(5);
            this.LogLabel.Size = new System.Drawing.Size(400, 411);
            this.LogLabel.TabIndex = 0;
            // 
            // MotionPictureBox
            // 
            this.MotionPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MotionPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MotionPictureBox.Location = new System.Drawing.Point(0, 186);
            this.MotionPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.MotionPictureBox.MaximumSize = new System.Drawing.Size(400, 225);
            this.MotionPictureBox.MinimumSize = new System.Drawing.Size(400, 225);
            this.MotionPictureBox.Name = "MotionPictureBox";
            this.MotionPictureBox.Size = new System.Drawing.Size(400, 225);
            this.MotionPictureBox.TabIndex = 1;
            this.MotionPictureBox.TabStop = false;
            // 
            // MotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(642, 411);
            this.Controls.Add(this.MotionPictureBox);
            this.Controls.Add(this.LogLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "爸爸，吃饭！";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MotionForm_FormClosing);
            this.Shown += new System.EventHandler(this.MotionForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MotionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.PictureBox MotionPictureBox;
    }
}

