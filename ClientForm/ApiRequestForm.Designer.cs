
namespace ClientForm
{
    partial class ApiRequestForm
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
            this.txtBoxUrl.Location = new System.Drawing.Point(18, 38);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(327, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(21, 14);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(215, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Location = new System.Drawing.Point(56, 11);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(137, 21);
            this.comboBoxMethods.TabIndex = 3;
            // 
            // gpBoxHeaders
            // 
            this.gpBoxHeaders.Controls.Add(this.listBoxHeaders);
            this.gpBoxHeaders.Controls.Add(this.btnRemoveHeader);
            this.gpBoxHeaders.Controls.Add(this.btnAddHeader);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeaderData);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeader);
            this.gpBoxHeaders.Location = new System.Drawing.Point(12, 74);
            this.gpBoxHeaders.Name = "gpBoxHeaders";
            this.gpBoxHeaders.Size = new System.Drawing.Size(339, 205);
            this.gpBoxHeaders.TabIndex = 4;
            this.gpBoxHeaders.TabStop = false;
            this.gpBoxHeaders.Text = "Headers";
            // 
            // listBoxHeaders
            // 
            this.listBoxHeaders.FormattingEnabled = true;
            this.listBoxHeaders.Location = new System.Drawing.Point(6, 75);
            this.listBoxHeaders.Name = "listBoxHeaders";
            this.listBoxHeaders.Size = new System.Drawing.Size(327, 121);
            this.listBoxHeaders.TabIndex = 4;
            // 
            // btnRemoveHeader
            // 
            this.btnRemoveHeader.Location = new System.Drawing.Point(178, 45);
            this.btnRemoveHeader.Name = "btnRemoveHeader";
            this.btnRemoveHeader.Size = new System.Drawing.Size(155, 23);
            this.btnRemoveHeader.TabIndex = 3;
            this.btnRemoveHeader.Text = "Remove";
            this.btnRemoveHeader.UseVisualStyleBackColor = true;
            this.btnRemoveHeader.Click += new System.EventHandler(this.btnRemoveHeader_Click);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Location = new System.Drawing.Point(6, 45);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(166, 23);
            this.btnAddHeader.TabIndex = 2;
            this.btnAddHeader.Text = "Add";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // txtBoxHeaderData
            // 
            this.txtBoxHeaderData.Location = new System.Drawing.Point(119, 19);
            this.txtBoxHeaderData.Name = "txtBoxHeaderData";
            this.txtBoxHeaderData.Size = new System.Drawing.Size(214, 20);
            this.txtBoxHeaderData.TabIndex = 1;
            // 
            // txtBoxHeader
            // 
            this.txtBoxHeader.Location = new System.Drawing.Point(6, 19);
            this.txtBoxHeader.Name = "txtBoxHeader";
            this.txtBoxHeader.Size = new System.Drawing.Size(107, 20);
            this.txtBoxHeader.TabIndex = 0;
            // 
            // ApiRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 291);
            this.Controls.Add(this.gpBoxHeaders);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtBoxUrl);
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