
namespace KartRider
{
    partial class GetKart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetKart));
            this.button1 = new System.Windows.Forms.Button();
            this.tx_ItemCode = new System.Windows.Forms.TextBox();
            this.tx_ItemType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "생성";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_ItemCode
            // 
            this.tx_ItemCode.Location = new System.Drawing.Point(51, 38);
            this.tx_ItemCode.MaxLength = 5;
            this.tx_ItemCode.Name = "tx_ItemCode";
            this.tx_ItemCode.Size = new System.Drawing.Size(100, 21);
            this.tx_ItemCode.TabIndex = 360;
            this.tx_ItemCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ItemCode_KeyPress);
            // 
            // tx_ItemType
            // 
            this.tx_ItemType.Location = new System.Drawing.Point(51, 11);
            this.tx_ItemType.MaxLength = 5;
            this.tx_ItemType.Name = "tx_ItemType";
            this.tx_ItemType.Size = new System.Drawing.Size(100, 21);
            this.tx_ItemType.TabIndex = 361;
            this.tx_ItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ItemType_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 362;
            this.label1.Text = "타입:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 363;
            this.label2.Text = "코드:";
            // 
            // GetKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 69);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_ItemCode);
            this.Controls.Add(this.tx_ItemType);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetKart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "아이템 추가";
            this.Load += new System.EventHandler(this.FormItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_ItemCode;
        private System.Windows.Forms.TextBox tx_ItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}