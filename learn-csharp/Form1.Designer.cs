namespace learn_csharp
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.cbxSaveActiveTab = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTJ = new System.Windows.Forms.TabPage();
            this.tabBJ = new System.Windows.Forms.TabPage();
            this.tabReferences = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabReferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabTJ);
            this.tabMain.Controls.Add(this.tabBJ);
            this.tabMain.Controls.Add(this.tabReferences);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(988, 654);
            this.tabMain.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.cbxSaveActiveTab);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(980, 628);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // cbxSaveActiveTab
            // 
            this.cbxSaveActiveTab.AutoSize = true;
            this.cbxSaveActiveTab.Checked = true;
            this.cbxSaveActiveTab.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSaveActiveTab.Location = new System.Drawing.Point(10, 43);
            this.cbxSaveActiveTab.Name = "cbxSaveActiveTab";
            this.cbxSaveActiveTab.Size = new System.Drawing.Size(127, 17);
            this.cbxSaveActiveTab.TabIndex = 2;
            this.cbxSaveActiveTab.Text = "Remember active tab";
            this.cbxSaveActiveTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "I setup this tab page so that we could have seperate work areas to play around.";
            // 
            // tabTJ
            // 
            this.tabTJ.Location = new System.Drawing.Point(4, 22);
            this.tabTJ.Name = "tabTJ";
            this.tabTJ.Padding = new System.Windows.Forms.Padding(3);
            this.tabTJ.Size = new System.Drawing.Size(980, 628);
            this.tabTJ.TabIndex = 1;
            this.tabTJ.Text = "TJ Stuff";
            this.tabTJ.UseVisualStyleBackColor = true;
            // 
            // tabBJ
            // 
            this.tabBJ.Location = new System.Drawing.Point(4, 22);
            this.tabBJ.Name = "tabBJ";
            this.tabBJ.Size = new System.Drawing.Size(980, 628);
            this.tabBJ.TabIndex = 2;
            this.tabBJ.Text = "BJ Stuff";
            this.tabBJ.UseVisualStyleBackColor = true;
            // 
            // tabReferences
            // 
            this.tabReferences.Controls.Add(this.webBrowser1);
            this.tabReferences.Location = new System.Drawing.Point(4, 22);
            this.tabReferences.Name = "tabReferences";
            this.tabReferences.Size = new System.Drawing.Size(980, 628);
            this.tabReferences.TabIndex = 3;
            this.tabReferences.Text = "References";
            this.tabReferences.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(980, 628);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 667);
            this.Controls.Add(this.tabMain);
            this.Name = "Form1";
            this.Text = "Learn C# Kitchen Sink Forms App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabReferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabTJ;
        private System.Windows.Forms.TabPage tabBJ;
        private System.Windows.Forms.TabPage tabReferences;
        private System.Windows.Forms.CheckBox cbxSaveActiveTab;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

