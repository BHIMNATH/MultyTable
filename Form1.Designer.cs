namespace Multy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.MaskedTextBox();
            this.show = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.GroupBox();
            this.te = new System.Windows.Forms.RichTextBox();
            this.tab = new System.Windows.Forms.Label();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter A Number  :";
            // 
            // num
            // 
            this.num.BeepOnError = true;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(235, 57);
            this.num.Mask = "00000";
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(78, 31);
            this.num.TabIndex = 3;
            this.num.UseWaitCursor = true;
            this.num.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.num_MaskInputRejected);
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // show
            // 
            this.show.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.show.Location = new System.Drawing.Point(319, 54);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(203, 34);
            this.show.TabIndex = 5;
            this.show.Text = "Show Me";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // result
            // 
            this.result.Controls.Add(this.te);
            this.result.Controls.Add(this.tab);
            this.result.Location = new System.Drawing.Point(24, 113);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(519, 314);
            this.result.TabIndex = 7;
            this.result.TabStop = false;
            // 
            // te
            // 
            this.te.Cursor = System.Windows.Forms.Cursors.Hand;
            this.te.Dock = System.Windows.Forms.DockStyle.Fill;
            this.te.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.te.Location = new System.Drawing.Point(3, 16);
            this.te.MinimumSize = new System.Drawing.Size(470, 276);
            this.te.Name = "te";
            this.te.ReadOnly = true;
            this.te.Size = new System.Drawing.Size(513, 295);
            this.te.TabIndex = 7;
            this.te.Text = "";
            // 
            // tab
            // 
            this.tab.AutoSize = true;
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(172, 34);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(0, 20);
            this.tab.TabIndex = 4;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(566, 452);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num);
            this.Controls.Add(this.show);
            this.Controls.Add(this.result);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multy Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox num;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.GroupBox result;
        private System.Windows.Forms.Label tab;
        private System.Windows.Forms.RichTextBox te;

    }
}

