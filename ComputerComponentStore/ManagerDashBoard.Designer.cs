namespace ComputerComponentStore
{
    partial class ManagerDashBoard
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
            this.panelManagerDashboard = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonComponentList = new System.Windows.Forms.Button();
            this.buttonSalesmanList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelManagerDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManagerDashboard
            // 
            this.panelManagerDashboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelManagerDashboard.Controls.Add(this.pictureBox2);
            this.panelManagerDashboard.Controls.Add(this.pictureBox1);
            this.panelManagerDashboard.Controls.Add(this.buttonLogOut);
            this.panelManagerDashboard.Controls.Add(this.buttonComponentList);
            this.panelManagerDashboard.Controls.Add(this.buttonSalesmanList);
            this.panelManagerDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManagerDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelManagerDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelManagerDashboard.Name = "panelManagerDashboard";
            this.panelManagerDashboard.Size = new System.Drawing.Size(344, 337);
            this.panelManagerDashboard.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Red;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonLogOut.Location = new System.Drawing.Point(124, 227);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(93, 42);
            this.buttonLogOut.TabIndex = 2;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonComponentList
            // 
            this.buttonComponentList.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonComponentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComponentList.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonComponentList.Location = new System.Drawing.Point(195, 153);
            this.buttonComponentList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComponentList.Name = "buttonComponentList";
            this.buttonComponentList.Size = new System.Drawing.Size(93, 42);
            this.buttonComponentList.TabIndex = 1;
            this.buttonComponentList.Text = "Component List";
            this.buttonComponentList.UseVisualStyleBackColor = false;
            this.buttonComponentList.Click += new System.EventHandler(this.buttonComponentList_Click);
            // 
            // buttonSalesmanList
            // 
            this.buttonSalesmanList.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSalesmanList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesmanList.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonSalesmanList.Location = new System.Drawing.Point(60, 153);
            this.buttonSalesmanList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSalesmanList.Name = "buttonSalesmanList";
            this.buttonSalesmanList.Size = new System.Drawing.Size(93, 42);
            this.buttonSalesmanList.TabIndex = 0;
            this.buttonSalesmanList.Text = "Salesman List";
            this.buttonSalesmanList.UseVisualStyleBackColor = false;
            this.buttonSalesmanList.Click += new System.EventHandler(this.buttonSalesmanList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ComputerComponentStore.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(69, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ComputerComponentStore.Properties.Resources.unnamed;
            this.pictureBox2.Image = global::ComputerComponentStore.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(186, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // ManagerDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 337);
            this.Controls.Add(this.panelManagerDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ManagerDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.ManagerDashBoard_Load);
            this.panelManagerDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManagerDashboard;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonComponentList;
        private System.Windows.Forms.Button buttonSalesmanList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}