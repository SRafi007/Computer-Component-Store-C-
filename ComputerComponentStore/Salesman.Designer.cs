namespace ComputerComponentStore
{
    partial class Salesman
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
            this.dgvSalesmanComponent = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComponentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pctbCart = new System.Windows.Forms.PictureBox();
            this.lblIteamCount = new System.Windows.Forms.Label();
            this.lblITeamCountTitle = new System.Windows.Forms.Label();
            this.ShowCart = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmanComponent)).BeginInit();
            this.panelbutton.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCart)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesmanComponent
            // 
            this.dgvSalesmanComponent.AllowUserToAddRows = false;
            this.dgvSalesmanComponent.AllowUserToDeleteRows = false;
            this.dgvSalesmanComponent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalesmanComponent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesmanComponent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.ComponentId,
            this.Component,
            this.Model,
            this.Quantity,
            this.UnitPrice});
            this.dgvSalesmanComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesmanComponent.Location = new System.Drawing.Point(3, 98);
            this.dgvSalesmanComponent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSalesmanComponent.Name = "dgvSalesmanComponent";
            this.dgvSalesmanComponent.ReadOnly = true;
            this.dgvSalesmanComponent.RowHeadersWidth = 51;
            this.dgvSalesmanComponent.RowTemplate.Height = 28;
            this.dgvSalesmanComponent.Size = new System.Drawing.Size(1070, 493);
            this.dgvSalesmanComponent.TabIndex = 0;
            this.dgvSalesmanComponent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesmanComponent_CellClick);
            // 
            // Serial
            // 
            this.Serial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.ReadOnly = true;
            this.Serial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Serial.ToolTipText = "Component Serial";
            // 
            // ComponentId
            // 
            this.ComponentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComponentId.DataPropertyName = "Id";
            this.ComponentId.HeaderText = "Id";
            this.ComponentId.MinimumWidth = 6;
            this.ComponentId.Name = "ComponentId";
            this.ComponentId.ReadOnly = true;
            this.ComponentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ComponentId.ToolTipText = "Component ID";
            // 
            // Component
            // 
            this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Component.DataPropertyName = "Components";
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Component.ToolTipText = "Component Name";
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Model.ToolTipText = "Component Model";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.ToolTipText = "Component Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.ToolTipText = "Price";
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelbutton.Controls.Add(this.labelHeadLine);
            this.panelbutton.Controls.Add(this.buttonRefresh);
            this.panelbutton.Controls.Add(this.buttonBack);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelbutton.Location = new System.Drawing.Point(3, 2);
            this.panelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(1070, 92);
            this.panelbutton.TabIndex = 2;
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeadLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeadLine.Location = new System.Drawing.Point(132, 10);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(381, 29);
            this.labelHeadLine.TabIndex = 3;
            this.labelHeadLine.Text = "Select and Add Product To Cart";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(7, 50);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(77, 38);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Tomato;
            this.buttonBack.Location = new System.Drawing.Point(7, 10);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(76, 38);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Log Out";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.00433F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.99567F));
            this.tableLayoutPanel1.Controls.Add(this.dgvSalesmanComponent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.29393F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.70607F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1362, 593);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.10152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89848F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel2.Controls.Add(this.pctbCart, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblIteamCount, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblITeamCountTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ShowCart, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1079, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.66666F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 90);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // pctbCart
            // 
            this.pctbCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbCart.Image = global::ComputerComponentStore.Properties.Resources.Screenshot_2021_08_23_133433;
            this.pctbCart.Location = new System.Drawing.Point(193, 24);
            this.pctbCart.Name = "pctbCart";
            this.pctbCart.Size = new System.Drawing.Size(84, 63);
            this.pctbCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbCart.TabIndex = 3;
            this.pctbCart.TabStop = false;
            this.pctbCart.Click += new System.EventHandler(this.pctbCart_Click);
            // 
            // lblIteamCount
            // 
            this.lblIteamCount.AutoSize = true;
            this.lblIteamCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIteamCount.Font = new System.Drawing.Font("MingLiU-ExtB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteamCount.Location = new System.Drawing.Point(3, 21);
            this.lblIteamCount.Name = "lblIteamCount";
            this.lblIteamCount.Size = new System.Drawing.Size(70, 69);
            this.lblIteamCount.TabIndex = 4;
            this.lblIteamCount.Text = "0";
            this.lblIteamCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblITeamCountTitle
            // 
            this.lblITeamCountTitle.AutoSize = true;
            this.lblITeamCountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblITeamCountTitle.Location = new System.Drawing.Point(3, 0);
            this.lblITeamCountTitle.Name = "lblITeamCountTitle";
            this.lblITeamCountTitle.Size = new System.Drawing.Size(49, 18);
            this.lblITeamCountTitle.TabIndex = 5;
            this.lblITeamCountTitle.Text = " count";
            // 
            // ShowCart
            // 
            this.ShowCart.AutoSize = true;
            this.ShowCart.Location = new System.Drawing.Point(193, 0);
            this.ShowCart.Name = "ShowCart";
            this.ShowCart.Size = new System.Drawing.Size(72, 17);
            this.ShowCart.TabIndex = 4;
            this.ShowCart.Text = "Show Cart";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblPriceTitle, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblPrice, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1079, 99);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.07692F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.92308F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(280, 491);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPriceTitle.Location = new System.Drawing.Point(3, 28);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(134, 37);
            this.lblPriceTitle.TabIndex = 5;
            this.lblPriceTitle.Text = "Total Price";
            this.lblPriceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(143, 28);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(134, 37);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "0";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Salesman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salesman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Salesman_FormClosed);
            this.Load += new System.EventHandler(this.Salesman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesmanComponent)).EndInit();
            this.panelbutton.ResumeLayout(false);
            this.panelbutton.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCart)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalesmanComponent;
        private System.Windows.Forms.Panel panelbutton;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComponentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pctbCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblIteamCount;
        private System.Windows.Forms.Label lblITeamCountTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label ShowCart;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelHeadLine;
    }
}