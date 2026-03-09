namespace Metronome
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
            CountBox = new TextBox();
            OnpuBox = new TextBox();
            TempoBox = new TextBox();
            label1 = new Label();
            StartButton = new Button();
            StopButton = new Button();
            SuspendLayout();
            // 
            // CountBox
            // 
            CountBox.Font = new Font("Yu Gothic UI", 50F);
            CountBox.Location = new Point(12, 12);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(162, 96);
            CountBox.TabIndex = 0;
            CountBox.Text = "4";
            CountBox.TextAlign = HorizontalAlignment.Center;
            // 
            // OnpuBox
            // 
            OnpuBox.Font = new Font("Yu Gothic UI", 50F);
            OnpuBox.Location = new Point(12, 128);
            OnpuBox.Name = "OnpuBox";
            OnpuBox.Size = new Size(162, 96);
            OnpuBox.TabIndex = 1;
            OnpuBox.Text = "4";
            OnpuBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TempoBox
            // 
            TempoBox.Font = new Font("Yu Gothic UI", 50F);
            TempoBox.Location = new Point(12, 325);
            TempoBox.Name = "TempoBox";
            TempoBox.Size = new Size(162, 96);
            TempoBox.TabIndex = 2;
            TempoBox.Text = "100";
            TempoBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 30F);
            label1.Location = new Point(180, 367);
            label1.Name = "label1";
            label1.Size = new Size(104, 54);
            label1.TabIndex = 3;
            label1.Text = "BPM";
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Yu Gothic UI", 20F);
            StartButton.Location = new Point(180, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(132, 71);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Font = new Font("Yu Gothic UI", 20F);
            StopButton.Location = new Point(180, 89);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(132, 71);
            StopButton.TabIndex = 5;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(label1);
            Controls.Add(TempoBox);
            Controls.Add(OnpuBox);
            Controls.Add(CountBox);
            Name = "MainForm";
            Text = "Offline Metronome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CountBox;
        private TextBox OnpuBox;
        private TextBox TempoBox;
        private Label label1;
        private Button StartButton;
        private Button StopButton;
    }
}
