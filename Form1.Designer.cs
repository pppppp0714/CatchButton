namespace CatchButton
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
            thiefbutton = new Button();
            retryButton = new Button();
            SuspendLayout();
            // 
            // thiefbutton
            // 
            thiefbutton.BackColor = SystemColors.Info;
            thiefbutton.Font = new Font("맑은 고딕", 20F);
            thiefbutton.ForeColor = SystemColors.HotTrack;
            thiefbutton.Location = new Point(267, 164);
            thiefbutton.Name = "thiefbutton";
            thiefbutton.Size = new Size(266, 122);
            thiefbutton.TabIndex = 0;
            thiefbutton.Text = "나를 잡아봐";
            thiefbutton.UseVisualStyleBackColor = false;
            thiefbutton.Click += thiefbutton_Click;
            thiefbutton.MouseEnter += thiefbutton_MouseEnter;
            // 
            // retryButton
            // 
            retryButton.Location = new Point(12, 12);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(100, 40);
            retryButton.TabIndex = 1;
            retryButton.Text = "다시 시작";
            retryButton.UseVisualStyleBackColor = true;
            retryButton.Visible = false;
            retryButton.Click += retryButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(retryButton);
            Controls.Add(thiefbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button thiefbutton;
        private Button retryButton;
    }
}
