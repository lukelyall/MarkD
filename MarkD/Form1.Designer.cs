namespace MarkD
{
    partial class MarkD
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
            this.renderedMD = new System.Windows.Forms.WebBrowser();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renderedMD
            // 
            this.renderedMD.Location = new System.Drawing.Point(464, 51);
            this.renderedMD.MinimumSize = new System.Drawing.Size(20, 20);
            this.renderedMD.Name = "renderedMD";
            this.renderedMD.Size = new System.Drawing.Size(329, 387);
            this.renderedMD.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 409);
            this.tabControl1.TabIndex = 4;
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.Location = new System.Drawing.Point(129, 0);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(111, 23);
            this.newNoteBtn.TabIndex = 5;
            this.newNoteBtn.Text = "New Note";
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // MarkD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(126)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNoteBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.renderedMD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MarkD";
            this.Text = "MarkD";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser renderedMD;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button newNoteBtn;
    }
}

