
namespace BirthdayTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackerPanel = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.monthPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.calendarTextBox = new System.Windows.Forms.TextBox();
            this.birthdayButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.feontButton = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.listTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.birthMonthTextBox = new System.Windows.Forms.TextBox();
            this.birthdayTextBox = new System.Windows.Forms.TextBox();
            this.dislikeTextBox = new System.Windows.Forms.TextBox();
            this.likesTextBox = new System.Windows.Forms.TextBox();
            this.personTextBox = new System.Windows.Forms.TextBox();
            this.findTextbox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.dislikeLabel = new System.Windows.Forms.Label();
            this.likesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.trackerPanel.SuspendLayout();
            this.monthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackerPanel
            // 
            this.trackerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trackerPanel.BackgroundImage")));
            this.trackerPanel.Controls.Add(this.clearBtn);
            this.trackerPanel.Controls.Add(this.monthPanel);
            this.trackerPanel.Controls.Add(this.backButton);
            this.trackerPanel.Controls.Add(this.nextButton);
            this.trackerPanel.Controls.Add(this.prevButton);
            this.trackerPanel.Controls.Add(this.feontButton);
            this.trackerPanel.Controls.Add(this.listLabel);
            this.trackerPanel.Controls.Add(this.listTextBox);
            this.trackerPanel.Controls.Add(this.deleteBtn);
            this.trackerPanel.Controls.Add(this.updateBtn);
            this.trackerPanel.Controls.Add(this.newBtn);
            this.trackerPanel.Controls.Add(this.birthMonthTextBox);
            this.trackerPanel.Controls.Add(this.birthdayTextBox);
            this.trackerPanel.Controls.Add(this.dislikeTextBox);
            this.trackerPanel.Controls.Add(this.likesTextBox);
            this.trackerPanel.Controls.Add(this.personTextBox);
            this.trackerPanel.Controls.Add(this.findTextbox);
            this.trackerPanel.Controls.Add(this.findButton);
            this.trackerPanel.Controls.Add(this.monthLabel);
            this.trackerPanel.Controls.Add(this.dayLabel);
            this.trackerPanel.Controls.Add(this.dislikeLabel);
            this.trackerPanel.Controls.Add(this.likesLabel);
            this.trackerPanel.Controls.Add(this.nameLabel);
            this.trackerPanel.Controls.Add(this.birthdayLabel);
            this.trackerPanel.Location = new System.Drawing.Point(1, 1);
            this.trackerPanel.Name = "trackerPanel";
            this.trackerPanel.Size = new System.Drawing.Size(622, 491);
            this.trackerPanel.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(546, 45);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 23;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click_1);
            // 
            // monthPanel
            // 
            this.monthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monthPanel.Controls.Add(this.exitButton);
            this.monthPanel.Controls.Add(this.calendarTextBox);
            this.monthPanel.Controls.Add(this.birthdayButton);
            this.monthPanel.Controls.Add(this.searchLabel);
            this.monthPanel.Location = new System.Drawing.Point(0, 410);
            this.monthPanel.Name = "monthPanel";
            this.monthPanel.Size = new System.Drawing.Size(357, 81);
            this.monthPanel.TabIndex = 22;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(279, 55);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // calendarTextBox
            // 
            this.calendarTextBox.Location = new System.Drawing.Point(4, 53);
            this.calendarTextBox.Name = "calendarTextBox";
            this.calendarTextBox.Size = new System.Drawing.Size(210, 23);
            this.calendarTextBox.TabIndex = 2;
            this.calendarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // birthdayButton
            // 
            this.birthdayButton.Location = new System.Drawing.Point(4, 23);
            this.birthdayButton.Name = "birthdayButton";
            this.birthdayButton.Size = new System.Drawing.Size(210, 23);
            this.birthdayButton.TabIndex = 1;
            this.birthdayButton.Text = "Birthdays in Month of";
            this.birthdayButton.UseVisualStyleBackColor = true;
            this.birthdayButton.Click += new System.EventHandler(this.birthdayButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(3, 4);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(42, 15);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(166, 381);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(48, 23);
            this.backButton.TabIndex = 21;
            this.backButton.Text = ">|";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(112, 381);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(48, 23);
            this.nextButton.TabIndex = 20;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(58, 381);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(48, 23);
            this.prevButton.TabIndex = 19;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // feontButton
            // 
            this.feontButton.Location = new System.Drawing.Point(4, 381);
            this.feontButton.Name = "feontButton";
            this.feontButton.Size = new System.Drawing.Size(48, 23);
            this.feontButton.TabIndex = 18;
            this.feontButton.Text = "|<";
            this.feontButton.UseVisualStyleBackColor = true;
            this.feontButton.Click += new System.EventHandler(this.frontButton_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listLabel.Location = new System.Drawing.Point(3, 162);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(106, 19);
            this.listLabel.TabIndex = 17;
            this.listLabel.Text = "Birthday List";
            // 
            // listTextBox
            // 
            this.listTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Person ",
            "Likes ",
            "Dislikes",
            "Day",
            "Month"});
            this.listTextBox.Location = new System.Drawing.Point(3, 184);
            this.listTextBox.Multiline = true;
            this.listTextBox.Name = "listTextBox";
            this.listTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listTextBox.Size = new System.Drawing.Size(311, 171);
            this.listTextBox.TabIndex = 16;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(465, 45);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 15;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(303, 45);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "NEW";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(384, 45);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 13;
            this.newBtn.Text = "UPDATE";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // birthMonthTextBox
            // 
            this.birthMonthTextBox.Location = new System.Drawing.Point(93, 135);
            this.birthMonthTextBox.Name = "birthMonthTextBox";
            this.birthMonthTextBox.Size = new System.Drawing.Size(204, 23);
            this.birthMonthTextBox.TabIndex = 12;
            this.birthMonthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthdayTextBox
            // 
            this.birthdayTextBox.Location = new System.Drawing.Point(93, 112);
            this.birthdayTextBox.Name = "birthdayTextBox";
            this.birthdayTextBox.Size = new System.Drawing.Size(204, 23);
            this.birthdayTextBox.TabIndex = 11;
            this.birthdayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dislikeTextBox
            // 
            this.dislikeTextBox.Location = new System.Drawing.Point(93, 89);
            this.dislikeTextBox.Name = "dislikeTextBox";
            this.dislikeTextBox.Size = new System.Drawing.Size(204, 23);
            this.dislikeTextBox.TabIndex = 10;
            this.dislikeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // likesTextBox
            // 
            this.likesTextBox.Location = new System.Drawing.Point(93, 66);
            this.likesTextBox.Name = "likesTextBox";
            this.likesTextBox.Size = new System.Drawing.Size(204, 23);
            this.likesTextBox.TabIndex = 9;
            this.likesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // personTextBox
            // 
            this.personTextBox.Location = new System.Drawing.Point(93, 42);
            this.personTextBox.Name = "personTextBox";
            this.personTextBox.Size = new System.Drawing.Size(204, 23);
            this.personTextBox.TabIndex = 8;
            this.personTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // findTextbox
            // 
            this.findTextbox.Location = new System.Drawing.Point(430, 10);
            this.findTextbox.Name = "findTextbox";
            this.findTextbox.Size = new System.Drawing.Size(189, 23);
            this.findTextbox.TabIndex = 7;
            // 
            // findButton
            // 
            this.findButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Location = new System.Drawing.Point(303, 11);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(120, 23);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "FIND FRIEND ==>";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(3, 138);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(93, 15);
            this.monthLabel.TabIndex = 5;
            this.monthLabel.Text = "Birthday Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(3, 115);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(77, 15);
            this.dayLabel.TabIndex = 4;
            this.dayLabel.Text = "Birthday Day:";
            // 
            // dislikeLabel
            // 
            this.dislikeLabel.AutoSize = true;
            this.dislikeLabel.Location = new System.Drawing.Point(3, 92);
            this.dislikeLabel.Name = "dislikeLabel";
            this.dislikeLabel.Size = new System.Drawing.Size(49, 15);
            this.dislikeLabel.TabIndex = 3;
            this.dislikeLabel.Text = "Dislikes:";
            // 
            // likesLabel
            // 
            this.likesLabel.AutoSize = true;
            this.likesLabel.Location = new System.Drawing.Point(3, 69);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(36, 15);
            this.likesLabel.TabIndex = 2;
            this.likesLabel.Text = "Likes:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 45);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Person\'s name:";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdayLabel.Location = new System.Drawing.Point(3, 8);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(138, 19);
            this.birthdayLabel.TabIndex = 0;
            this.birthdayLabel.Text = "Birthday Tracker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 496);
            this.Controls.Add(this.trackerPanel);
            this.Name = "Form1";
            this.Text = "Birthday Tracker";
            this.trackerPanel.ResumeLayout(false);
            this.trackerPanel.PerformLayout();
            this.monthPanel.ResumeLayout(false);
            this.monthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trackerPanel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label dislikeLabel;
        private System.Windows.Forms.Label likesLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox dislikeTextBox;
        private System.Windows.Forms.TextBox likesTextBox;
        private System.Windows.Forms.TextBox personTextBox;
        private System.Windows.Forms.TextBox findTextbox;
        private System.Windows.Forms.TextBox birthMonthTextBox;
        private System.Windows.Forms.TextBox birthdayTextBox;
        private System.Windows.Forms.TextBox listTextBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Panel monthPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button feontButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox calendarTextBox;
        private System.Windows.Forms.Button birthdayButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button clearBtn;
    }
}

