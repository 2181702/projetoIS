
namespace ClientForm
{
    partial class ApiRequestFormInput
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
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.gpBoxHeaders = new System.Windows.Forms.GroupBox();
            this.listBoxHeaders = new System.Windows.Forms.ListBox();
            this.btnRemoveHeader = new System.Windows.Forms.Button();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.txtBoxHeaderData = new System.Windows.Forms.TextBox();
            this.txtBoxHeader = new System.Windows.Forms.TextBox();
            this.gpBoxHeaders.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(100, 49);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(360, 22);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(28, 17);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 16);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(148, 351);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Location = new System.Drawing.Point(24, 47);
            this.comboBoxMethods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(67, 24);
            this.comboBoxMethods.TabIndex = 3;
            // 
            // gpBoxHeaders
            // 
            this.gpBoxHeaders.Controls.Add(this.listBoxHeaders);
            this.gpBoxHeaders.Controls.Add(this.btnRemoveHeader);
            this.gpBoxHeaders.Controls.Add(this.btnAddHeader);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeaderData);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeader);
            this.gpBoxHeaders.Location = new System.Drawing.Point(16, 91);
            this.gpBoxHeaders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxHeaders.Name = "gpBoxHeaders";
            this.gpBoxHeaders.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpBoxHeaders.Size = new System.Drawing.Size(452, 252);
            this.gpBoxHeaders.TabIndex = 4;
            this.gpBoxHeaders.TabStop = false;
            this.gpBoxHeaders.Text = "Headers";
            // 
            // listBoxHeaders
            // 
            this.listBoxHeaders.FormattingEnabled = true;
            this.listBoxHeaders.ItemHeight = 16;
            this.listBoxHeaders.Location = new System.Drawing.Point(8, 92);
            this.listBoxHeaders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxHeaders.Name = "listBoxHeaders";
            this.listBoxHeaders.Size = new System.Drawing.Size(435, 148);
            this.listBoxHeaders.TabIndex = 4;
            // 
            // btnRemoveHeader
            // 
            this.btnRemoveHeader.Location = new System.Drawing.Point(237, 55);
            this.btnRemoveHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveHeader.Name = "btnRemoveHeader";
            this.btnRemoveHeader.Size = new System.Drawing.Size(207, 28);
            this.btnRemoveHeader.TabIndex = 3;
            this.btnRemoveHeader.Text = "Remove";
            this.btnRemoveHeader.UseVisualStyleBackColor = true;
            this.btnRemoveHeader.Click += new System.EventHandler(this.btnRemoveHeader_Click);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Location = new System.Drawing.Point(8, 55);
            this.btnAddHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(221, 28);
            this.btnAddHeader.TabIndex = 2;
            this.btnAddHeader.Text = "Add";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // txtBoxHeaderData
            // 
            this.txtBoxHeaderData.Location = new System.Drawing.Point(159, 23);
            this.txtBoxHeaderData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxHeaderData.Name = "txtBoxHeaderData";
            this.txtBoxHeaderData.Size = new System.Drawing.Size(284, 22);
            this.txtBoxHeaderData.TabIndex = 1;
            // 
            // txtBoxHeader
            // 
            this.txtBoxHeader.Location = new System.Drawing.Point(8, 23);
            this.txtBoxHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxHeader.Name = "txtBoxHeader";
            this.txtBoxHeader.Size = new System.Drawing.Size(141, 22);
            this.txtBoxHeader.TabIndex = 0;
            // 
            // ApiRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 386);
            this.Controls.Add(this.gpBoxHeaders);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtBoxUrl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ApiRequestForm";
            this.Text = "ApiRequestForm";
            this.Load += new System.EventHandler(this.ApiRequestForm_Load);
            this.gpBoxHeaders.ResumeLayout(false);
            this.gpBoxHeaders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.GroupBox gpBoxHeaders;
        private System.Windows.Forms.Button btnRemoveHeader;
        private System.Windows.Forms.Button btnAddHeader;
        private System.Windows.Forms.TextBox txtBoxHeaderData;
        private System.Windows.Forms.TextBox txtBoxHeader;
        private System.Windows.Forms.ListBox listBoxHeaders;
    }
}