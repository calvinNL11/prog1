namespace HowManyClicks
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
            plusButton = new Button();
            clicksAmountText = new Label();
            clicksText = new Label();
            SuspendLayout();
            // 
            // plusButton
            // 
            plusButton.Location = new Point(304, 69);
            plusButton.Margin = new Padding(3, 4, 3, 4);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(371, 377);
            plusButton.TabIndex = 0;
            plusButton.Text = "click me";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // clicksAmountText
            // 
            clicksAmountText.AutoSize = true;
            clicksAmountText.Location = new Point(67, 31);
            clicksAmountText.Name = "clicksAmountText";
            clicksAmountText.Size = new Size(17, 20);
            clicksAmountText.TabIndex = 1;
            clicksAmountText.Text = "0";
            // 
            // clicksText
            // 
            clicksText.AutoSize = true;
            clicksText.Location = new Point(14, 31);
            clicksText.Name = "clicksText";
            clicksText.Size = new Size(49, 20);
            clicksText.TabIndex = 2;
            clicksText.Text = "Clicks:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(clicksText);
            Controls.Add(clicksAmountText);
            Controls.Add(plusButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plusButton;
        private Label clicksAmountText;
        private Label clicksText;
    }
}
