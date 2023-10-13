namespace HangGirl
{
    partial class Form_TimeSheet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreGridView = new System.Windows.Forms.DataGridView();
            this.BkButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Stereofidelic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Tan;
            this.ScoreLabel.Location = new System.Drawing.Point(357, 150);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(214, 66);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score Board";
            // 
            // ScoreGridView
            // 
            this.ScoreGridView.AllowUserToOrderColumns = true;
            this.ScoreGridView.BackgroundColor = System.Drawing.Color.Black;
            this.ScoreGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScoreGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carbon Block", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScoreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.NickName,
            this.Score});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ScoreGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ScoreGridView.GridColor = System.Drawing.Color.Tan;
            this.ScoreGridView.Location = new System.Drawing.Point(240, 227);
            this.ScoreGridView.Name = "ScoreGridView";
            this.ScoreGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.ScoreGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreGridView.Size = new System.Drawing.Size(442, 217);
            this.ScoreGridView.TabIndex = 4;
            this.ScoreGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoreGridView_CellContentClick);
            // 
            // BkButton
            // 
            this.BkButton.BackColor = System.Drawing.Color.Black;
            this.BkButton.Font = new System.Drawing.Font("Stereofidelic", 27.75F);
            this.BkButton.ForeColor = System.Drawing.Color.Tan;
            this.BkButton.Location = new System.Drawing.Point(404, 471);
            this.BkButton.Name = "BkButton";
            this.BkButton.Size = new System.Drawing.Size(144, 52);
            this.BkButton.TabIndex = 10;
            this.BkButton.Text = "BACK";
            this.BkButton.UseVisualStyleBackColor = false;
            this.BkButton.Click += new System.EventHandler(this.BkButton_Click);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // NickName
            // 
            this.NickName.HeaderText = "Username";
            this.NickName.Name = "NickName";
            this.NickName.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Form_TimeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::HangGirl.Properties.Resources.background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 535);
            this.Controls.Add(this.BkButton);
            this.Controls.Add(this.ScoreGridView);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.Name = "Form_TimeSheet";
            this.Text = "Form_TimeSheet";
            this.Load += new System.EventHandler(this.Form_TimeSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.DataGridView ScoreGridView;
        private System.Windows.Forms.Button BkButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}