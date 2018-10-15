﻿
using System;
using System.Drawing;
using System.Threading;

namespace Invaders
{
    /// <summary>
    /// 窗体包括一些定时器来通知游戏继续进行，它要传递按键事件，并完成入侵者和闪
    /// 烁星星的动画。它还有一个paint事件处理程序来绘制图形，这个事件处理程序只
    /// 需调用Game对象的draw()方法
    /// </summary>
    /// <remarks>
    /// 2018.10.13: 创建. by woan <br/>
    /// </remarks>
    partial class Form
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
        /// woan：然而我还是修改了
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startTip = new System.Windows.Forms.Label();
            this.welcomeTitle = new System.Windows.Forms.PictureBox();
            this.currentScore = new System.Windows.Forms.Label();
            this.playerShip = new System.Windows.Forms.PictureBox();
            this.lifeIcon = new System.Windows.Forms.PictureBox();
            this.playerLife = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 33;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startTip
            // 
            this.startTip.AutoSize = true;
            this.startTip.BackColor = System.Drawing.Color.Transparent;
            this.startTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTip.ForeColor = System.Drawing.SystemColors.Info;
            this.startTip.Location = new System.Drawing.Point(705, 678);
            this.startTip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTip.Name = "startTip";
            this.startTip.Size = new System.Drawing.Size(290, 31);
            this.startTip.TabIndex = 1;
            this.startTip.Text = "Press anykey to start\r\n";
            this.startTip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // welcomeTitle
            // 
            this.welcomeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.welcomeTitle.Image = global::Invaders.Properties.Resources.welcomeTitle;
            this.welcomeTitle.InitialImage = null;
            this.welcomeTitle.Location = new System.Drawing.Point(453, 82);
            this.welcomeTitle.Margin = new System.Windows.Forms.Padding(4);
            this.welcomeTitle.Name = "welcomeTitle";
            this.welcomeTitle.Size = new System.Drawing.Size(800, 500);
            this.welcomeTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.welcomeTitle.TabIndex = 0;
            this.welcomeTitle.TabStop = false;
            // 
            // currentScore
            // 
            this.currentScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.currentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currentScore.ForeColor = System.Drawing.Color.LightCyan;
            this.currentScore.Location = new System.Drawing.Point(76, 54);
            this.currentScore.Name = "currentScore";
            this.currentScore.Size = new System.Drawing.Size(296, 57);
            this.currentScore.TabIndex = 2;
            this.currentScore.Click += new System.EventHandler(this.currentScore_Click);
            // 
            // playerShip
            // 
            this.playerShip.BackgroundImage = global::Invaders.Properties.Resources.playerShip;
            this.playerShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerShip.Location = new System.Drawing.Point(800, 678);
            this.playerShip.Name = "playerShip";
            this.playerShip.Size = new System.Drawing.Size(118, 123);
            this.playerShip.TabIndex = 3;
            this.playerShip.TabStop = false;
            // 
            // lifeIcon
            // 
            this.lifeIcon.BackgroundImage = global::Invaders.Properties.Resources.playerShip;
            this.lifeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lifeIcon.Location = new System.Drawing.Point(1484, 36);
            this.lifeIcon.Name = "lifeIcon";
            this.lifeIcon.Size = new System.Drawing.Size(67, 75);
            this.lifeIcon.TabIndex = 4;
            this.lifeIcon.TabStop = false;
            // 
            // playerLife
            // 
            this.playerLife.AutoSize = true;
            this.playerLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.playerLife.ForeColor = System.Drawing.Color.Azure;
            this.playerLife.Location = new System.Drawing.Point(1557, 62);
            this.playerLife.Name = "playerLife";
            this.playerLife.Size = new System.Drawing.Size(0, 36);
            this.playerLife.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(1683, 841);
            this.Controls.Add(this.playerLife);
            this.Controls.Add(this.lifeIcon);
            this.Controls.Add(this.playerShip);
            this.Controls.Add(this.currentScore);
            this.Controls.Add(this.startTip);
            this.Controls.Add(this.welcomeTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1701, 888);
            this.MinimumSize = new System.Drawing.Size(1701, 888);
            this.Name = "Form";
            this.Text = "0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.welcomeTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lifeIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox welcomeTitle;
        private System.Windows.Forms.Label startTip;
        private System.Windows.Forms.Label currentScore;
        private System.Windows.Forms.PictureBox playerShip;
        private System.Windows.Forms.PictureBox lifeIcon;
        private System.Windows.Forms.Label playerLife;
    }
}

