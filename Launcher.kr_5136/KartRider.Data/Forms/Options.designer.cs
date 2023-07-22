
namespace KartRider
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.UseKartParts_CheckBox = new System.Windows.Forms.CheckBox();
            this.UseKartTune_CheckBox = new System.Windows.Forms.CheckBox();
            this.UseKartPlant_CheckBox = new System.Windows.Forms.CheckBox();
            this.UseKartLevel_CheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UseKartParts_CheckBox
            // 
            this.UseKartParts_CheckBox.AutoSize = true;
            this.UseKartParts_CheckBox.Location = new System.Drawing.Point(21, 79);
            this.UseKartParts_CheckBox.Name = "UseKartParts_CheckBox";
            this.UseKartParts_CheckBox.Size = new System.Drawing.Size(97, 16);
            this.UseKartParts_CheckBox.TabIndex = 0;
            this.UseKartParts_CheckBox.Text = "UseKartParts";
            this.UseKartParts_CheckBox.UseVisualStyleBackColor = true;
            this.UseKartParts_CheckBox.CheckedChanged += new System.EventHandler(this.UseKartParts_CheckBox_CheckedChanged);
            // 
            // UseKartTune_CheckBox
            // 
            this.UseKartTune_CheckBox.AutoSize = true;
            this.UseKartTune_CheckBox.Location = new System.Drawing.Point(21, 13);
            this.UseKartTune_CheckBox.Name = "UseKartTune_CheckBox";
            this.UseKartTune_CheckBox.Size = new System.Drawing.Size(97, 16);
            this.UseKartTune_CheckBox.TabIndex = 1;
            this.UseKartTune_CheckBox.Text = "UseKartTune";
            this.UseKartTune_CheckBox.UseVisualStyleBackColor = true;
            this.UseKartTune_CheckBox.CheckedChanged += new System.EventHandler(this.UseKartTune_CheckBox_CheckedChanged);
            // 
            // UseKartPlant_CheckBox
            // 
            this.UseKartPlant_CheckBox.AutoSize = true;
            this.UseKartPlant_CheckBox.Location = new System.Drawing.Point(21, 35);
            this.UseKartPlant_CheckBox.Name = "UseKartPlant_CheckBox";
            this.UseKartPlant_CheckBox.Size = new System.Drawing.Size(96, 16);
            this.UseKartPlant_CheckBox.TabIndex = 2;
            this.UseKartPlant_CheckBox.Text = "UseKartPlant";
            this.UseKartPlant_CheckBox.UseVisualStyleBackColor = true;
            this.UseKartPlant_CheckBox.CheckedChanged += new System.EventHandler(this.UseKartPlant_CheckBox_CheckedChanged);
            // 
            // UseKartLevel_CheckBox
            // 
            this.UseKartLevel_CheckBox.AutoSize = true;
            this.UseKartLevel_CheckBox.Location = new System.Drawing.Point(21, 57);
            this.UseKartLevel_CheckBox.Name = "UseKartLevel_CheckBox";
            this.UseKartLevel_CheckBox.Size = new System.Drawing.Size(98, 16);
            this.UseKartLevel_CheckBox.TabIndex = 3;
            this.UseKartLevel_CheckBox.Text = "UseKartLevel";
            this.UseKartLevel_CheckBox.UseVisualStyleBackColor = true;
            this.UseKartLevel_CheckBox.CheckedChanged += new System.EventHandler(this.UseKartLevel_CheckBox_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 108);
            this.Controls.Add(this.UseKartLevel_CheckBox);
            this.Controls.Add(this.UseKartPlant_CheckBox);
            this.Controls.Add(this.UseKartTune_CheckBox);
            this.Controls.Add(this.UseKartParts_CheckBox);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "강화 옵션";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox UseKartParts_CheckBox;
        public System.Windows.Forms.CheckBox UseKartTune_CheckBox;
        public System.Windows.Forms.CheckBox UseKartPlant_CheckBox;
        public System.Windows.Forms.CheckBox UseKartLevel_CheckBox;
    }
}