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
            this.newNoteBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.renderedMD = new System.Windows.Forms.WebBrowser();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bottomPnl = new System.Windows.Forms.Panel();
            this.currFile = new System.Windows.Forms.Label();
            this.homePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lineNums = new System.Windows.Forms.Panel();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.linesLabel = new System.Windows.Forms.Label();
            this.btnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.bottomPnl.SuspendLayout();
            this.homePnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.lineNums.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPanel
            // 
            this.btnPanel.AutoScroll = true;
            this.btnPanel.BackColor = System.Drawing.Color.Red;
            this.btnPanel.Controls.Add(this.panel1);
            this.btnPanel.Controls.Add(this.homePnl);
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
            this.saveAllBtn.Location = new System.Drawing.Point(92, 2);
            this.saveAllBtn.Name = "saveAllBtn";
            this.saveAllBtn.Size = new System.Drawing.Size(20, 20);
            this.saveAllBtn.TabIndex = 0;
            this.saveAllBtn.UseVisualStyleBackColor = true;
            this.saveAllBtn.Click += new System.EventHandler(this.saveAllBtn_Click);
            // 
            // newNoteBtn
            // 
            this.newNoteBtn.BackgroundImage = global::MarkD.Properties.Resources.add_square_svgrepo_com_1_;
            this.newNoteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newNoteBtn.Location = new System.Drawing.Point(57, 2);
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
            this.saveBtn.Location = new System.Drawing.Point(127, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(20, 20);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // renderedMD
            // 
            this.renderedMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.renderedMD.Location = new System.Drawing.Point(544, 0);
            this.renderedMD.MinimumSize = new System.Drawing.Size(20, 20);
            this.renderedMD.Name = "renderedMD";
            this.renderedMD.Size = new System.Drawing.Size(256, 418);
            this.renderedMD.TabIndex = 9;
            // 
            // bottomPnl
            // 
            this.bottomPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bottomPnl.Controls.Add(this.currFile);
            this.bottomPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPnl.Location = new System.Drawing.Point(200, 416);
            this.bottomPnl.Name = "bottomPnl";
            this.bottomPnl.Size = new System.Drawing.Size(600, 34);
            this.bottomPnl.TabIndex = 11;
            // 
            // currFile
            // 
            this.currFile.AutoSize = true;
            this.currFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currFile.Location = new System.Drawing.Point(20, 8);
            this.currFile.Name = "currFile";
            this.currFile.Size = new System.Drawing.Size(55, 18);
            this.currFile.TabIndex = 0;
            this.currFile.Text = "MarkD";
            // 
            // homePnl
            // 
            this.homePnl.BackColor = System.Drawing.Color.Maroon;
            this.homePnl.Controls.Add(this.newNoteBtn);
            this.homePnl.Controls.Add(this.saveBtn);
            this.homePnl.Controls.Add(this.saveAllBtn);
            this.homePnl.Location = new System.Drawing.Point(0, 12);
            this.homePnl.Name = "homePnl";
            this.homePnl.Size = new System.Drawing.Size(160, 25);
            this.homePnl.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder";
            // 
            // lineNums
            // 
            this.lineNums.BackColor = System.Drawing.Color.PaleGreen;
            this.lineNums.Controls.Add(this.linesLabel);
            this.lineNums.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineNums.Location = new System.Drawing.Point(200, 0);
            this.lineNums.Name = "lineNums";
            this.lineNums.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lineNums.Size = new System.Drawing.Size(44, 416);
            this.lineNums.TabIndex = 0;
            // 
            // notesPanel
            // 
            this.notesPanel.Location = new System.Drawing.Point(242, 0);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(303, 418);
            this.notesPanel.TabIndex = 12;
            // 
            // linesLabel
            // 
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesLabel.Location = new System.Drawing.Point(3, 0);
            this.linesLabel.MaximumSize = new System.Drawing.Size(30, 0);
            this.linesLabel.MinimumSize = new System.Drawing.Size(35, 20);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(35, 20);
            this.linesLabel.TabIndex = 0;
            this.linesLabel.Text = "1";
            this.linesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MarkD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.notesPanel);
            this.Controls.Add(this.lineNums);
            this.Controls.Add(this.bottomPnl);
            this.Controls.Add(this.renderedMD);
            this.Controls.Add(this.btnPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MarkD";
            this.Text = "MarkD";
            this.btnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.bottomPnl.ResumeLayout(false);
            this.bottomPnl.PerformLayout();
            this.homePnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.lineNums.ResumeLayout(false);
            this.lineNums.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newNoteBtn;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.WebBrowser renderedMD;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button saveAllBtn;
        private System.Windows.Forms.Panel bottomPnl;
        private System.Windows.Forms.Label currFile;
        private System.Windows.Forms.Panel homePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lineNums;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Label linesLabel;
    }
}

