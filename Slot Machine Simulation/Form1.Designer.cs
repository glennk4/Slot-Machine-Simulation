namespace Slot_Machine_Simulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AmountInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpinButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.WinningsOutput = new System.Windows.Forms.Label();
            this.TotalBetOutput = new System.Windows.Forms.Label();
            this.TotalWinOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ResultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Bell.png");
            this.imageList1.Images.SetKeyName(1, "Cherry.png");
            this.imageList1.Images.SetKeyName(2, "Seven.png");
            this.imageList1.Images.SetKeyName(3, "Diamond.png");
            this.imageList1.Images.SetKeyName(4, "Lemon.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(601, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(901, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1201, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // AmountInput
            // 
            this.AmountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountInput.Location = new System.Drawing.Point(969, 382);
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(198, 26);
            this.AmountInput.TabIndex = 3;
            this.AmountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(812, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Amount to Bet (£) : ";
            // 
            // SpinButton
            // 
            this.SpinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinButton.Location = new System.Drawing.Point(612, 444);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(114, 34);
            this.SpinButton.TabIndex = 5;
            this.SpinButton.Text = "Spin";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1224, 444);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 34);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Cash Out";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.Controls.Add(this.TotalWinOutput);
            this.ResultPanel.Controls.Add(this.TotalBetOutput);
            this.ResultPanel.Location = new System.Drawing.Point(576, 506);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(800, 143);
            this.ResultPanel.TabIndex = 7;
            this.ResultPanel.Visible = false;
            // 
            // WinningsOutput
            // 
            this.WinningsOutput.AutoSize = true;
            this.WinningsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningsOutput.Location = new System.Drawing.Point(939, 444);
            this.WinningsOutput.Name = "WinningsOutput";
            this.WinningsOutput.Size = new System.Drawing.Size(0, 20);
            this.WinningsOutput.TabIndex = 0;
            this.WinningsOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WinningsOutput.Visible = false;
            // 
            // TotalBetOutput
            // 
            this.TotalBetOutput.AutoSize = true;
            this.TotalBetOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBetOutput.Location = new System.Drawing.Point(245, 36);
            this.TotalBetOutput.Name = "TotalBetOutput";
            this.TotalBetOutput.Size = new System.Drawing.Size(159, 20);
            this.TotalBetOutput.TabIndex = 1;
            this.TotalBetOutput.Text = "Total Amount Bet: ";
            this.TotalBetOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalWinOutput
            // 
            this.TotalWinOutput.AutoSize = true;
            this.TotalWinOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWinOutput.Location = new System.Drawing.Point(245, 82);
            this.TotalWinOutput.Name = "TotalWinOutput";
            this.TotalWinOutput.Size = new System.Drawing.Size(167, 20);
            this.TotalWinOutput.TabIndex = 2;
            this.TotalWinOutput.Text = "Total Amount Won: ";
            this.TotalWinOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 663);
            this.Controls.Add(this.ResultPanel);
            this.Controls.Add(this.WinningsOutput);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountInput);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Slot Machine Simulator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox AmountInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.Label TotalWinOutput;
        private System.Windows.Forms.Label TotalBetOutput;
        private System.Windows.Forms.Label WinningsOutput;
    }
}

