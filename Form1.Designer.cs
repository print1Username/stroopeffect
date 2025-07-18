namespace Stroop_Test
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            languageButton = new Button();
            startButton = new Button();
            helpButton = new Button();
            titleLabel = new Label();
            descriptionLabel = new Label();
            markLabel = new Label();
            exitButton = new Button();
            colorLabel = new Label();
            timeLabel = new Label();
            colorButton1 = new Button();
            colorButton2 = new Button();
            colorButton3 = new Button();
            colorButton4 = new Button();
            SuspendLayout();
            // 
            // languageButton
            // 
            languageButton.BackColor = SystemColors.GradientInactiveCaption;
            resources.ApplyResources(languageButton, "languageButton");
            languageButton.Cursor = Cursors.Hand;
            languageButton.Name = "languageButton";
            languageButton.UseVisualStyleBackColor = false;
            languageButton.Click += languageButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.Info;
            startButton.Cursor = Cursors.Hand;
            startButton.DialogResult = DialogResult.OK;
            resources.ApplyResources(startButton, "startButton");
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.GradientInactiveCaption;
            resources.ApplyResources(helpButton, "helpButton");
            helpButton.Cursor = Cursors.Help;
            helpButton.Name = "helpButton";
            helpButton.UseVisualStyleBackColor = false;
            helpButton.Click += helpButton_Click;
            // 
            // titleLabel
            // 
            resources.ApplyResources(titleLabel, "titleLabel");
            titleLabel.Name = "titleLabel";
            // 
            // descriptionLabel
            // 
            resources.ApplyResources(descriptionLabel, "descriptionLabel");
            descriptionLabel.Name = "descriptionLabel";
            // 
            // markLabel
            // 
            resources.ApplyResources(markLabel, "markLabel");
            markLabel.Name = "markLabel";
            // 
            // exitButton
            // 
            exitButton.AccessibleRole = AccessibleRole.TitleBar;
            resources.ApplyResources(exitButton, "exitButton");
            exitButton.Cursor = Cursors.Hand;
            exitButton.Name = "exitButton";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // colorLabel
            // 
            colorLabel.BackColor = SystemColors.HighlightText;
            colorLabel.BorderStyle = BorderStyle.Fixed3D;
            colorLabel.CausesValidation = false;
            colorLabel.Cursor = Cursors.Help;
            resources.ApplyResources(colorLabel, "colorLabel");
            colorLabel.ForeColor = SystemColors.ActiveCaptionText;
            colorLabel.Name = "colorLabel";
            // 
            // timeLabel
            // 
            resources.ApplyResources(timeLabel, "timeLabel");
            timeLabel.Name = "timeLabel";
            // 
            // colorButton1
            // 
            colorButton1.AccessibleRole = AccessibleRole.Grip;
            colorButton1.AutoEllipsis = true;
            colorButton1.Cursor = Cursors.Hand;
            resources.ApplyResources(colorButton1, "colorButton1");
            colorButton1.ForeColor = SystemColors.MenuBar;
            colorButton1.Name = "colorButton1";
            colorButton1.UseVisualStyleBackColor = true;
            colorButton1.Click += colorButton1_Click;
            // 
            // colorButton2
            // 
            colorButton2.AccessibleRole = AccessibleRole.Grip;
            colorButton2.AutoEllipsis = true;
            colorButton2.Cursor = Cursors.Hand;
            resources.ApplyResources(colorButton2, "colorButton2");
            colorButton2.ForeColor = SystemColors.MenuBar;
            colorButton2.Name = "colorButton2";
            colorButton2.UseVisualStyleBackColor = true;
            colorButton2.Click += colorButton2_Click;
            // 
            // colorButton3
            // 
            colorButton3.AccessibleRole = AccessibleRole.Grip;
            colorButton3.AutoEllipsis = true;
            colorButton3.Cursor = Cursors.Hand;
            resources.ApplyResources(colorButton3, "colorButton3");
            colorButton3.ForeColor = SystemColors.MenuBar;
            colorButton3.Name = "colorButton3";
            colorButton3.UseVisualStyleBackColor = true;
            colorButton3.Click += colorButton3_Click;
            // 
            // colorButton4
            // 
            colorButton4.AccessibleRole = AccessibleRole.Grip;
            colorButton4.AutoEllipsis = true;
            colorButton4.Cursor = Cursors.Hand;
            resources.ApplyResources(colorButton4, "colorButton4");
            colorButton4.ForeColor = SystemColors.MenuBar;
            colorButton4.Name = "colorButton4";
            colorButton4.UseVisualStyleBackColor = true;
            colorButton4.Click += colorButton4_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = SystemColors.Menu;
            Controls.Add(colorButton4);
            Controls.Add(colorButton3);
            Controls.Add(colorButton2);
            Controls.Add(colorButton1);
            Controls.Add(timeLabel);
            Controls.Add(colorLabel);
            Controls.Add(exitButton);
            Controls.Add(markLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            Controls.Add(helpButton);
            Controls.Add(startButton);
            Controls.Add(languageButton);
            MaximizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
        }


        #endregion

        private Button languageButton;
        private Button startButton;
        private Button helpButton;
        private Label titleLabel;
        private Label descriptionLabel;
        private Label markLabel;
        private Button exitButton;
        private Label colorLabel;
        private Label timeLabel;
        private Button colorButton1;
        private Button colorButton2;
        private Button colorButton3;
        private Button colorButton4;
    }
}
