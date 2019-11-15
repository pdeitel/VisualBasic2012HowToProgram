namespace FavoriteTwitterSearches
{
   partial class FTSForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.taggedSearchesGroupBox = new System.Windows.Forms.GroupBox();
         this.webBrowser = new System.Windows.Forms.WebBrowser();
         this.tagsListBox = new System.Windows.Forms.ListBox();
         this.saveSearchButton = new System.Windows.Forms.Button();
         this.tagTextBox = new System.Windows.Forms.TextBox();
         this.queryTextBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.addSearchGroupBox = new System.Windows.Forms.GroupBox();
         this.manageSearchesButton = new System.Windows.Forms.Button();
         this.groupTagTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.taggedSearchesGroupBox.SuspendLayout();
         this.addSearchGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // taggedSearchesGroupBox
         // 
         this.taggedSearchesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.taggedSearchesGroupBox.Controls.Add(this.webBrowser);
         this.taggedSearchesGroupBox.Controls.Add(this.tagsListBox);
         this.taggedSearchesGroupBox.Enabled = false;
         this.taggedSearchesGroupBox.Location = new System.Drawing.Point(12, 145);
         this.taggedSearchesGroupBox.Name = "taggedSearchesGroupBox";
         this.taggedSearchesGroupBox.Size = new System.Drawing.Size(612, 344);
         this.taggedSearchesGroupBox.TabIndex = 10;
         this.taggedSearchesGroupBox.TabStop = false;
         this.taggedSearchesGroupBox.Text = "Tagged Searches";
         // 
         // webBrowser
         // 
         this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.webBrowser.Location = new System.Drawing.Point(131, 20);
         this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
         this.webBrowser.Name = "webBrowser";
         this.webBrowser.Size = new System.Drawing.Size(475, 316);
         this.webBrowser.TabIndex = 3;
         // 
         // tagsListBox
         // 
         this.tagsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.tagsListBox.FormattingEnabled = true;
         this.tagsListBox.Location = new System.Drawing.Point(7, 20);
         this.tagsListBox.Name = "tagsListBox";
         this.tagsListBox.Size = new System.Drawing.Size(118, 316);
         this.tagsListBox.TabIndex = 0;
         this.tagsListBox.SelectedIndexChanged += new System.EventHandler(this.tagsListBox_SelectedIndexChanged);
         // 
         // saveSearchButton
         // 
         this.saveSearchButton.Location = new System.Drawing.Point(372, 71);
         this.saveSearchButton.Name = "saveSearchButton";
         this.saveSearchButton.Size = new System.Drawing.Size(88, 23);
         this.saveSearchButton.TabIndex = 8;
         this.saveSearchButton.Text = "Save Search";
         this.saveSearchButton.UseVisualStyleBackColor = true;
         this.saveSearchButton.Click += new System.EventHandler(this.saveSearchButton_Click);
         // 
         // tagTextBox
         // 
         this.tagTextBox.Location = new System.Drawing.Point(112, 45);
         this.tagTextBox.Name = "tagTextBox";
         this.tagTextBox.Size = new System.Drawing.Size(348, 20);
         this.tagTextBox.TabIndex = 5;
         // 
         // queryTextBox
         // 
         this.queryTextBox.Location = new System.Drawing.Point(112, 19);
         this.queryTextBox.Name = "queryTextBox";
         this.queryTextBox.Size = new System.Drawing.Size(348, 20);
         this.queryTextBox.TabIndex = 4;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(22, 48);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(84, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Tag your search";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 22);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(103, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Twitter search query";
         // 
         // addSearchGroupBox
         // 
         this.addSearchGroupBox.Controls.Add(this.saveSearchButton);
         this.addSearchGroupBox.Controls.Add(this.tagTextBox);
         this.addSearchGroupBox.Controls.Add(this.queryTextBox);
         this.addSearchGroupBox.Controls.Add(this.label3);
         this.addSearchGroupBox.Controls.Add(this.label2);
         this.addSearchGroupBox.Enabled = false;
         this.addSearchGroupBox.Location = new System.Drawing.Point(12, 38);
         this.addSearchGroupBox.Name = "addSearchGroupBox";
         this.addSearchGroupBox.Size = new System.Drawing.Size(466, 101);
         this.addSearchGroupBox.TabIndex = 9;
         this.addSearchGroupBox.TabStop = false;
         this.addSearchGroupBox.Text = "Add a Search";
         // 
         // manageSearchesButton
         // 
         this.manageSearchesButton.Location = new System.Drawing.Point(365, 9);
         this.manageSearchesButton.Name = "manageSearchesButton";
         this.manageSearchesButton.Size = new System.Drawing.Size(113, 23);
         this.manageSearchesButton.TabIndex = 8;
         this.manageSearchesButton.Text = "Manage Searches";
         this.manageSearchesButton.UseVisualStyleBackColor = true;
         this.manageSearchesButton.Click += new System.EventHandler(this.manageSearchesButton_Click);
         // 
         // groupTagTextBox
         // 
         this.groupTagTextBox.Location = new System.Drawing.Point(98, 11);
         this.groupTagTextBox.Name = "groupTagTextBox";
         this.groupTagTextBox.Size = new System.Drawing.Size(261, 20);
         this.groupTagTextBox.TabIndex = 7;
         this.toolTip1.SetToolTip(this.groupTagTextBox, "The tag you enter here is used to locate a group of searches. You can have many s" +
        "eparate groups.");
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 14);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(80, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Enter group tag";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.pictureBox1.Image = global::FavoriteTwitterSearches.Properties.Resources.bug;
         this.pictureBox1.Location = new System.Drawing.Point(484, 9);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(140, 130);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 11;
         this.pictureBox1.TabStop = false;
         // 
         // FTSForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(636, 500);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.taggedSearchesGroupBox);
         this.Controls.Add(this.addSearchGroupBox);
         this.Controls.Add(this.manageSearchesButton);
         this.Controls.Add(this.groupTagTextBox);
         this.Controls.Add(this.label1);
         this.Name = "FTSForm";
         this.Text = "Favorite Twitter Searches";
         this.taggedSearchesGroupBox.ResumeLayout(false);
         this.addSearchGroupBox.ResumeLayout(false);
         this.addSearchGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox taggedSearchesGroupBox;
      private System.Windows.Forms.ListBox tagsListBox;
      private System.Windows.Forms.Button saveSearchButton;
      private System.Windows.Forms.TextBox tagTextBox;
      private System.Windows.Forms.TextBox queryTextBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.GroupBox addSearchGroupBox;
      private System.Windows.Forms.Button manageSearchesButton;
      private System.Windows.Forms.TextBox groupTagTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.WebBrowser webBrowser;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.ToolTip toolTip1;
   }
}

