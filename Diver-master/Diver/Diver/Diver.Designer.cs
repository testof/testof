namespace Diver
{
    partial class Diver
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
            this.headerText = new System.Windows.Forms.Label();
            this.DiverList = new System.Windows.Forms.ListBox();
            this.diverlistboxlabel = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.pointlist = new System.Windows.Forms.ListBox();
            this.pointlabel = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.labeljump = new System.Windows.Forms.Label();
            this.txtjump = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Location = new System.Drawing.Point(31, 22);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(57, 25);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Diver";
            // 
            // DiverList
            // 
            this.DiverList.FormattingEnabled = true;
            this.DiverList.ItemHeight = 25;
            this.DiverList.Location = new System.Drawing.Point(80, 142);
            this.DiverList.Name = "DiverList";
            this.DiverList.Size = new System.Drawing.Size(262, 229);
            this.DiverList.TabIndex = 1;
            this.DiverList.SelectedIndexChanged += new System.EventHandler(this.DiverList_SelectedIndexChanged);
            // 
            // diverlistboxlabel
            // 
            this.diverlistboxlabel.AutoSize = true;
            this.diverlistboxlabel.Location = new System.Drawing.Point(75, 60);
            this.diverlistboxlabel.Name = "diverlistboxlabel";
            this.diverlistboxlabel.Size = new System.Drawing.Size(92, 25);
            this.diverlistboxlabel.TabIndex = 2;
            this.diverlistboxlabel.Text = "Diver List";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(348, 238);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(133, 43);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // pointlist
            // 
            this.pointlist.FormattingEnabled = true;
            this.pointlist.ItemHeight = 25;
            this.pointlist.Location = new System.Drawing.Point(487, 142);
            this.pointlist.Name = "pointlist";
            this.pointlist.Size = new System.Drawing.Size(262, 229);
            this.pointlist.TabIndex = 1;
            this.pointlist.SelectedIndexChanged += new System.EventHandler(this.pointlist_SelectedIndexChanged);
            // 
            // pointlabel
            // 
            this.pointlabel.AutoSize = true;
            this.pointlabel.Location = new System.Drawing.Point(498, 60);
            this.pointlabel.Name = "pointlabel";
            this.pointlabel.Size = new System.Drawing.Size(91, 25);
            this.pointlabel.TabIndex = 2;
            this.pointlabel.Text = "Point List";
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(581, 387);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(135, 54);
            this.btnremove.TabIndex = 4;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(504, 486);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(98, 25);
            this.firstname.TabIndex = 5;
            this.firstname.Text = "Firstname";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(504, 543);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(98, 25);
            this.lastname.TabIndex = 5;
            this.lastname.Text = "Lastname";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(622, 489);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(160, 30);
            this.txtfirstname.TabIndex = 6;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(622, 543);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(160, 30);
            this.txtlastname.TabIndex = 6;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(735, 655);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(129, 43);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click_1);
            // 
            // labeljump
            // 
            this.labeljump.AutoSize = true;
            this.labeljump.Location = new System.Drawing.Point(504, 597);
            this.labeljump.Name = "labeljump";
            this.labeljump.Size = new System.Drawing.Size(61, 25);
            this.labeljump.TabIndex = 5;
            this.labeljump.Text = "Jump";
            // 
            // txtjump
            // 
            this.txtjump.Location = new System.Drawing.Point(622, 597);
            this.txtjump.Name = "txtjump";
            this.txtjump.Size = new System.Drawing.Size(160, 30);
            this.txtjump.TabIndex = 6;
            // 
            // Diver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 734);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.txtjump);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.labeljump);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.pointlabel);
            this.Controls.Add(this.diverlistboxlabel);
            this.Controls.Add(this.pointlist);
            this.Controls.Add(this.DiverList);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Diver";
            this.Text = "Diver";
            this.Load += new System.EventHandler(this.Diver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.Label diverlistboxlabel;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListBox pointlist;
        private System.Windows.Forms.Label pointlabel;
        private System.Windows.Forms.Button btnremove;
        public System.Windows.Forms.ListBox DiverList;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Button btnstart;
        public System.Windows.Forms.TextBox txtfirstname;
        public System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label labeljump;
        public System.Windows.Forms.TextBox txtjump;
    }
}

