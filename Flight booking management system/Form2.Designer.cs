namespace Flight_booking_management_system
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button2 = new System.Windows.Forms.Button();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.CancelTicketsButton = new System.Windows.Forms.Button();
            this.bookTicketsButton = new System.Windows.Forms.Button();
            this.SlidingButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SlidingPanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 76);
            this.button2.TabIndex = 9;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SlidingPanel.Controls.Add(this.CancelTicketsButton);
            this.SlidingPanel.Controls.Add(this.button2);
            this.SlidingPanel.Controls.Add(this.bookTicketsButton);
            this.SlidingPanel.Controls.Add(this.SlidingButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(204, 549);
            this.SlidingPanel.TabIndex = 10;
            // 
            // CancelTicketsButton
            // 
            this.CancelTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelTicketsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelTicketsButton.Location = new System.Drawing.Point(0, 145);
            this.CancelTicketsButton.Name = "CancelTicketsButton";
            this.CancelTicketsButton.Size = new System.Drawing.Size(210, 76);
            this.CancelTicketsButton.TabIndex = 13;
            this.CancelTicketsButton.Text = "Cancel Tickets";
            this.CancelTicketsButton.UseVisualStyleBackColor = false;
            this.CancelTicketsButton.Click += new System.EventHandler(this.CancelTicketsButton_Click);
            // 
            // bookTicketsButton
            // 
            this.bookTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookTicketsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTicketsButton.Location = new System.Drawing.Point(0, 73);
            this.bookTicketsButton.Name = "bookTicketsButton";
            this.bookTicketsButton.Size = new System.Drawing.Size(210, 76);
            this.bookTicketsButton.TabIndex = 14;
            this.bookTicketsButton.Text = "Book Tickets";
            this.bookTicketsButton.UseVisualStyleBackColor = false;
            this.bookTicketsButton.Click += new System.EventHandler(this.bookTicketsButton_Click);
            // 
            // SlidingButton
            // 
            this.SlidingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingButton.Name = "SlidingButton";
            this.SlidingButton.Size = new System.Drawing.Size(203, 76);
            this.SlidingButton.TabIndex = 11;
            this.SlidingButton.UseVisualStyleBackColor = false;
            this.SlidingButton.Click += new System.EventHandler(this.SlidingButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContentPanel.BackgroundImage")));
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(202, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(752, 549);
            this.ContentPanel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO AIR NITTE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 549);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.SlidingPanel.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button CancelTicketsButton;
        private System.Windows.Forms.Button bookTicketsButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Label label1;
    }
}