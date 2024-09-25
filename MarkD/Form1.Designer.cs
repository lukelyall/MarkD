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
            this.components = new System.ComponentModel.Container();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.saveAllBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.renderedMD = new System.Windows.Forms.WebBrowser();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(42)))), ((int)(((byte)(19)))));
            this.btnPanel.Controls.Add(this.saveAllBtn);
            this.btnPanel.Controls.Add(this.panel3);
            this.btnPanel.Controls.Add(this.newNoteBtn);
            this.btnPanel.Controls.Add(this.saveBtn);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPanel.Location = new System.Drawing.Point(0, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(200, 450);
            this.btnPanel.TabIndex = 6;
            // 
            // saveAllBtn
            // 
            this.saveAllBtn.BackgroundImage = global::MarkD.Properties.Resources.save_all_svgrepo_com;
            this.saveAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveAllBtn.Location = new System.Drawing.Point(82, 12);
            this.saveAllBtn.Name = "saveAllBtn";
            this.saveAllBtn.Size = new System.Drawing.Size(20, 20);
            this.saveAllBtn.TabIndex = 0;
            this.saveAllBtn.UseVisualStyleBackColor = true;
            this.saveAllBtn.Click += new System.EventHandler(this.saveAllBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(151, 2);
            this.panel3.TabIndex = 10;
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.BackgroundImage = global::MarkD.Properties.Resources.add_square_svgrepo_com_1_;
            this.newNoteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteBtn.Location = new System.Drawing.Point(38, 12);
            this.newNoteBtn.Name = "newNoteBtn";
            this.newNoteBtn.Size = new System.Drawing.Size(20, 20);
            this.newNoteBtn.TabIndex = 5;
            this.newNoteBtn.UseVisualStyleBackColor = true;
            this.newNoteBtn.Click += new System.EventHandler(this.newNoteBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::MarkD.Properties.Resources.save_svgrepo_com_1_;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(130, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(20, 20);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 30);
            this.panel2.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(6, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(71, 22);
            this.title.TabIndex = 0;
            this.title.Text = "MarkD";
            // 
            // renderedMD
            // 
            this.renderedMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renderedMD.Location = new System.Drawing.Point(507, 32);
            this.renderedMD.MinimumSize = new System.Drawing.Size(20, 20);
            this.renderedMD.Name = "renderedMD";
            this.renderedMD.Size = new System.Drawing.Size(293, 418);
            this.renderedMD.TabIndex = 9;
            // 
            // notesPanel
            // 
            this.notesPanel.Location = new System.Drawing.Point(200, 29);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(312, 615);
            this.notesPanel.TabIndex = 10;
            // 
            // MarkD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renderedMD);
            this.Controls.Add(this.notesPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MarkD";
            this.Text = "MarkD";
            this.btnPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newNoteBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser renderedMD;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button saveAllBtn;
    }
}

