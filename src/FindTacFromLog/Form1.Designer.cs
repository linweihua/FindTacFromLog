namespace FindTacFromLog
{
    partial class Form1
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
            this.btnSelectFindPath = new System.Windows.Forms.Button();
            this.txtSelectPath = new System.Windows.Forms.TextBox();
            this.txtFindContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFindPath
            // 
            this.btnSelectFindPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectFindPath.Location = new System.Drawing.Point(30, 34);
            this.btnSelectFindPath.Name = "btnSelectFindPath";
            this.btnSelectFindPath.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFindPath.TabIndex = 0;
            this.btnSelectFindPath.Text = "选择查找的目录";
            this.btnSelectFindPath.UseVisualStyleBackColor = true;
            this.btnSelectFindPath.Click += new System.EventHandler(this.btnSelectFindPath_Click);
            // 
            // txtSelectPath
            // 
            this.txtSelectPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSelectPath.Location = new System.Drawing.Point(152, 34);
            this.txtSelectPath.Name = "txtSelectPath";
            this.txtSelectPath.Size = new System.Drawing.Size(389, 21);
            this.txtSelectPath.TabIndex = 1;
            // 
            // txtFindContent
            // 
            this.txtFindContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFindContent.Location = new System.Drawing.Point(152, 76);
            this.txtFindContent.Multiline = true;
            this.txtFindContent.Name = "txtFindContent";
            this.txtFindContent.Size = new System.Drawing.Size(389, 89);
            this.txtFindContent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "查找内容";
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFind.Location = new System.Drawing.Point(560, 74);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "执行查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(12, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 179);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(560, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 385);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindContent);
            this.Controls.Add(this.txtSelectPath);
            this.Controls.Add(this.btnSelectFindPath);
            this.Name = "Form1";
            this.Text = "查找log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFindPath;
        private System.Windows.Forms.TextBox txtSelectPath;
        private System.Windows.Forms.TextBox txtFindContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSave;
    }
}

