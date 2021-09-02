namespace BaiTapTuDienAV
{
    partial class frmMainApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbItem = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btTraTu = new System.Windows.Forms.Button();
            this.txtVN = new System.Windows.Forms.TextBox();
            this.txtVNShort = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbItem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Từ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbItem
            // 
            this.lbItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbItem.FormattingEnabled = true;
            this.lbItem.ItemHeight = 31;
            this.lbItem.Location = new System.Drawing.Point(3, 35);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(191, 412);
            this.lbItem.TabIndex = 0;
            this.lbItem.Click += new System.EventHandler(this.lbItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btTraTu);
            this.groupBox2.Controls.Add(this.txtVN);
            this.groupBox2.Controls.Add(this.txtVNShort);
            this.groupBox2.Controls.Add(this.txtEnglish);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(200, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 450);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Từ";
            // 
            // btTraTu
            // 
            this.btTraTu.Location = new System.Drawing.Point(383, 60);
            this.btTraTu.Name = "btTraTu";
            this.btTraTu.Size = new System.Drawing.Size(178, 58);
            this.btTraTu.TabIndex = 2;
            this.btTraTu.Text = "Tra";
            this.btTraTu.UseVisualStyleBackColor = true;
            this.btTraTu.Click += new System.EventHandler(this.btTraTu_Click);
            // 
            // txtVN
            // 
            this.txtVN.Location = new System.Drawing.Point(40, 202);
            this.txtVN.Multiline = true;
            this.txtVN.Name = "txtVN";
            this.txtVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVN.Size = new System.Drawing.Size(527, 242);
            this.txtVN.TabIndex = 1;
            // 
            // txtVNShort
            // 
            this.txtVNShort.Location = new System.Drawing.Point(178, 95);
            this.txtVNShort.Name = "txtVNShort";
            this.txtVNShort.Size = new System.Drawing.Size(141, 39);
            this.txtVNShort.TabIndex = 1;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(178, 44);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(141, 39);
            this.txtEnglish.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nghĩa Chi Tiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nghĩa Ngắn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Cần Tra:";
            // 
            // frmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainApp";
            this.Text = "Tra Từ";
            this.Load += new System.EventHandler(this.frmMainApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btTraTu;
        private System.Windows.Forms.TextBox txtVN;
        private System.Windows.Forms.TextBox txtVNShort;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbItem;
    }
}