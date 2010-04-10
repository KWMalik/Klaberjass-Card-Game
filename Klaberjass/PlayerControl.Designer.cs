namespace Klaberjass
{
    partial class PlayerControl
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
            this.PassButton = new System.Windows.Forms.Button();
            this.TakeButton = new System.Windows.Forms.Button();
            this.SchmeissButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassButton
            // 
            this.PassButton.Location = new System.Drawing.Point(13, 12);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(75, 23);
            this.PassButton.TabIndex = 0;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = true;
            // 
            // TakeButton
            // 
            this.TakeButton.Location = new System.Drawing.Point(13, 27);
            this.TakeButton.Name = "TakeButton";
            this.TakeButton.Size = new System.Drawing.Size(75, 23);
            this.TakeButton.TabIndex = 1;
            this.TakeButton.Text = "Take";
            this.TakeButton.UseVisualStyleBackColor = true;
            // 
            // SchmeissButton
            // 
            this.SchmeissButton.Location = new System.Drawing.Point(13, 41);
            this.SchmeissButton.Name = "SchmeissButton";
            this.SchmeissButton.Size = new System.Drawing.Size(75, 23);
            this.SchmeissButton.TabIndex = 2;
            this.SchmeissButton.Text = "Schmeiss";
            this.SchmeissButton.UseVisualStyleBackColor = true;
            // 
            // YesButton
            // 
            this.YesButton.Location = new System.Drawing.Point(13, 56);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 3;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(13, 70);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(13, 85);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.SchmeissButton);
            this.Controls.Add(this.TakeButton);
            this.Controls.Add(this.PassButton);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(296, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Button TakeButton;
        private System.Windows.Forms.Button SchmeissButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button PlayButton;
    }
}
