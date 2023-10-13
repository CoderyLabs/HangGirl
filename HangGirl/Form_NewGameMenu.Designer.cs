namespace HangGirl
{
    partial class Form_NewGameMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewRadioButton = new System.Windows.Forms.RadioButton();
            this.ExistingRadioButton = new System.Windows.Forms.RadioButton();
            this.ExistingPanel = new System.Windows.Forms.Panel();
            this.ExistingListBox = new System.Windows.Forms.ListBox();
            this.NewPanel = new System.Windows.Forms.Panel();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BkButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.ExistingPanel.SuspendLayout();
            this.NewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.NewRadioButton);
            this.panel1.Controls.Add(this.ExistingRadioButton);
            this.panel1.Location = new System.Drawing.Point(348, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 99);
            this.panel1.TabIndex = 6;
            // 
            // NewRadioButton
            // 
            this.NewRadioButton.AutoSize = true;
            this.NewRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewRadioButton.Font = new System.Drawing.Font("Britannic Bold", 15F);
            this.NewRadioButton.ForeColor = System.Drawing.Color.Tan;
            this.NewRadioButton.Location = new System.Drawing.Point(26, 51);
            this.NewRadioButton.Name = "NewRadioButton";
            this.NewRadioButton.Size = new System.Drawing.Size(124, 26);
            this.NewRadioButton.TabIndex = 1;
            this.NewRadioButton.Text = "New Player";
            this.NewRadioButton.UseVisualStyleBackColor = true;
            this.NewRadioButton.CheckedChanged += new System.EventHandler(this.NewRadioButton_CheckedChanged);
            // 
            // ExistingRadioButton
            // 
            this.ExistingRadioButton.AutoSize = true;
            this.ExistingRadioButton.Checked = true;
            this.ExistingRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExistingRadioButton.Font = new System.Drawing.Font("Britannic Bold", 15F);
            this.ExistingRadioButton.ForeColor = System.Drawing.Color.Tan;
            this.ExistingRadioButton.Location = new System.Drawing.Point(26, 19);
            this.ExistingRadioButton.Name = "ExistingRadioButton";
            this.ExistingRadioButton.Size = new System.Drawing.Size(97, 26);
            this.ExistingRadioButton.TabIndex = 0;
            this.ExistingRadioButton.TabStop = true;
            this.ExistingRadioButton.Text = "Existing";
            this.ExistingRadioButton.UseVisualStyleBackColor = true;
            this.ExistingRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.ExistingRadioButton.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ExistingPanel
            // 
            this.ExistingPanel.Controls.Add(this.ExistingListBox);
            this.ExistingPanel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ExistingPanel.Location = new System.Drawing.Point(343, 271);
            this.ExistingPanel.Name = "ExistingPanel";
            this.ExistingPanel.Size = new System.Drawing.Size(211, 121);
            this.ExistingPanel.TabIndex = 7;
            this.ExistingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ExistingPanel_Paint);
            // 
            // ExistingListBox
            // 
            this.ExistingListBox.BackColor = System.Drawing.Color.Black;
            this.ExistingListBox.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExistingListBox.ForeColor = System.Drawing.Color.Tan;
            this.ExistingListBox.FormattingEnabled = true;
            this.ExistingListBox.ItemHeight = 17;
            this.ExistingListBox.Items.AddRange(new object[] {
            "DonDude",
            "Jack Slayer",
            "Orphan Nag",
            "Ben",
            "Lissa"});
            this.ExistingListBox.Location = new System.Drawing.Point(15, 16);
            this.ExistingListBox.Name = "ExistingListBox";
            this.ExistingListBox.Size = new System.Drawing.Size(181, 89);
            this.ExistingListBox.TabIndex = 0;
            this.ExistingListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // NewPanel
            // 
            this.NewPanel.Controls.Add(this.LNameTextBox);
            this.NewPanel.Controls.Add(this.FNameTextBox);
            this.NewPanel.Controls.Add(this.UserNameTextBox);
            this.NewPanel.Controls.Add(this.label5);
            this.NewPanel.Controls.Add(this.label4);
            this.NewPanel.Controls.Add(this.label3);
            this.NewPanel.Location = new System.Drawing.Point(263, 274);
            this.NewPanel.Name = "NewPanel";
            this.NewPanel.Size = new System.Drawing.Size(371, 165);
            this.NewPanel.TabIndex = 8;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.BackColor = System.Drawing.Color.Tan;
            this.LNameTextBox.Location = new System.Drawing.Point(147, 122);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.LNameTextBox.TabIndex = 5;
            // 
            // FNameTextBox
            // 
            this.FNameTextBox.BackColor = System.Drawing.Color.Tan;
            this.FNameTextBox.Location = new System.Drawing.Point(145, 67);
            this.FNameTextBox.Name = "FNameTextBox";
            this.FNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.FNameTextBox.TabIndex = 4;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.Tan;
            this.UserNameTextBox.Location = new System.Drawing.Point(145, 17);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.UserNameTextBox.TabIndex = 3;
            this.UserNameTextBox.TextChanged += new System.EventHandler(this.UserNameTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.label5.ForeColor = System.Drawing.Color.Tan;
            this.label5.Location = new System.Drawing.Point(4, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.label4.ForeColor = System.Drawing.Color.Tan;
            this.label4.Location = new System.Drawing.Point(4, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // BkButton
            // 
            this.BkButton.BackColor = System.Drawing.Color.Black;
            this.BkButton.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.BkButton.ForeColor = System.Drawing.Color.Tan;
            this.BkButton.Location = new System.Drawing.Point(183, 471);
            this.BkButton.Name = "BkButton";
            this.BkButton.Size = new System.Drawing.Size(144, 52);
            this.BkButton.TabIndex = 9;
            this.BkButton.Text = "BACK";
            this.BkButton.UseVisualStyleBackColor = false;
            this.BkButton.Click += new System.EventHandler(this.BkButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Black;
            this.NextButton.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.NextButton.ForeColor = System.Drawing.Color.Tan;
            this.NextButton.Location = new System.Drawing.Point(612, 471);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(144, 52);
            this.NextButton.TabIndex = 10;
            this.NextButton.Text = "NEXT";
            this.toolTip1.SetToolTip(this.NextButton, "Ensure that all fields are filled");
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form_NewGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::HangGirl.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.NewPanel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.BkButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExistingPanel);
            this.Name = "Form_NewGameMenu";
            this.Text = "Form_NewGameMenu";
            this.Load += new System.EventHandler(this.Form_NewGameMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ExistingPanel.ResumeLayout(false);
            this.NewPanel.ResumeLayout(false);
            this.NewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton NewRadioButton;
        private System.Windows.Forms.RadioButton ExistingRadioButton;
        private System.Windows.Forms.Panel ExistingPanel;
        private System.Windows.Forms.ListBox ExistingListBox;
        private System.Windows.Forms.Panel NewPanel;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.TextBox FNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BkButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}