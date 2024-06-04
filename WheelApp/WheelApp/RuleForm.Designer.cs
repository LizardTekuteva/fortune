using System.ComponentModel;

namespace WheelApp
{
    partial class RuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleForm));
            this.ruleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ruleLabel
            // 
            this.ruleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ruleLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruleLabel.ForeColor = System.Drawing.Color.White;
            this.ruleLabel.Location = new System.Drawing.Point(0, -2);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(928, 578);
            this.ruleLabel.TabIndex = 34;
            this.ruleLabel.Text = resources.GetString("ruleLabel.Text");
            // 
            // RuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(943, 605);
            this.Controls.Add(this.ruleLabel);
            this.Name = "RuleForm";
            this.Text = "RuleForm";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ruleLabel;

        #endregion
    }
}