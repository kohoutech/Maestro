namespace Maestro.Widgets
{
    partial class ControlPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.hsbSeqPos = new System.Windows.Forms.HScrollBar();
            this.lblPosCounter = new System.Windows.Forms.Label();
            this.cbxTracks = new System.Windows.Forms.ComboBox();
            this.chkHalfSpeed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Location = new System.Drawing.Point(396, 14);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(37, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(437, 14);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // hsbSeqPos
            // 
            this.hsbSeqPos.Enabled = false;
            this.hsbSeqPos.Location = new System.Drawing.Point(167, 14);
            this.hsbSeqPos.Name = "hsbSeqPos";
            this.hsbSeqPos.Size = new System.Drawing.Size(166, 21);
            this.hsbSeqPos.TabIndex = 4;
            this.hsbSeqPos.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbSeqPos_Scroll);
            // 
            // lblPosCounter
            // 
            this.lblPosCounter.BackColor = System.Drawing.Color.Black;
            this.lblPosCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosCounter.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblPosCounter.Location = new System.Drawing.Point(496, 14);
            this.lblPosCounter.Name = "lblPosCounter";
            this.lblPosCounter.Size = new System.Drawing.Size(134, 23);
            this.lblPosCounter.TabIndex = 5;
            this.lblPosCounter.Text = "00:00:00:000";
            this.lblPosCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTracks
            // 
            this.cbxTracks.FormattingEnabled = true;
            this.cbxTracks.Location = new System.Drawing.Point(20, 14);
            this.cbxTracks.Name = "cbxTracks";
            this.cbxTracks.Size = new System.Drawing.Size(134, 21);
            this.cbxTracks.TabIndex = 10;
            this.cbxTracks.SelectedIndexChanged += new System.EventHandler(this.cbxTracks_SelectedIndexChanged);
            // 
            // chkHalfSpeed
            // 
            this.chkHalfSpeed.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHalfSpeed.AutoSize = true;
            this.chkHalfSpeed.Location = new System.Drawing.Point(358, 14);
            this.chkHalfSpeed.Name = "chkHalfSpeed";
            this.chkHalfSpeed.Size = new System.Drawing.Size(34, 23);
            this.chkHalfSpeed.TabIndex = 11;
            this.chkHalfSpeed.Text = "1/2";
            this.chkHalfSpeed.UseVisualStyleBackColor = true;
            this.chkHalfSpeed.CheckedChanged += new System.EventHandler(this.chkHalfSpeed_CheckedChanged);
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.chkHalfSpeed);
            this.Controls.Add(this.cbxTracks);
            this.Controls.Add(this.lblPosCounter);
            this.Controls.Add(this.hsbSeqPos);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Name = "ControlPanel";
            this.Size = new System.Drawing.Size(650, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.HScrollBar hsbSeqPos;
        private System.Windows.Forms.Label lblPosCounter;
        private System.Windows.Forms.ComboBox cbxTracks;
        private System.Windows.Forms.CheckBox chkHalfSpeed;
    }
}
