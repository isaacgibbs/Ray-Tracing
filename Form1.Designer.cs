namespace Ray_Tracing
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.screen = new System.Windows.Forms.PictureBox();
            this.graphicsTimer = new System.Windows.Forms.Timer(this.components);
            this.logicTimer = new System.Windows.Forms.Timer(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.camdistlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exposureScroll = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(885, 885);
            this.screen.TabIndex = 0;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(382, 910);
            this.hScrollBar1.Maximum = -1;
            this.hScrollBar1.Minimum = -20;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(157, 17);
            this.hScrollBar1.TabIndex = 1;
            this.hScrollBar1.Value = -5;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // camdistlabel
            // 
            this.camdistlabel.AutoSize = true;
            this.camdistlabel.Location = new System.Drawing.Point(286, 910);
            this.camdistlabel.Name = "camdistlabel";
            this.camdistlabel.Size = new System.Drawing.Size(91, 13);
            this.camdistlabel.TabIndex = 2;
            this.camdistlabel.Text = "Camera Distance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 936);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exposure:";
            // 
            // exposureScroll
            // 
            this.exposureScroll.Location = new System.Drawing.Point(382, 936);
            this.exposureScroll.Maximum = 360;
            this.exposureScroll.Name = "exposureScroll";
            this.exposureScroll.Size = new System.Drawing.Size(157, 17);
            this.exposureScroll.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 996);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exposureScroll);
            this.Controls.Add(this.camdistlabel);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Timer graphicsTimer;
        private System.Windows.Forms.Timer logicTimer;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label camdistlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar exposureScroll;
    }
}

