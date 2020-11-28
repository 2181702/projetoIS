
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxHeader = new System.Windows.Forms.TextBox();
            this.txtBoxHeaderData = new System.Windows.Forms.TextBox();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.btnRemoveHeader = new System.Windows.Forms.Button();
            this.listBoxHeaders = new System.Windows.Forms.ListBox();
            this.listBoxParameters = new System.Windows.Forms.ListBox();
            this.btnRemoveParameter = new System.Windows.Forms.Button();
            this.btnAddParameter = new System.Windows.Forms.Button();
            this.txtBoxParameterData = new System.Windows.Forms.TextBox();
            this.txtBoxParameter = new System.Windows.Forms.TextBox();
            this.gpBoxHeaders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(174, 12);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(317, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 15);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(29, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Location = new System.Drawing.Point(47, 11);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethods.TabIndex = 3;
            // 
            // gpBoxHeaders
            // 
            this.gpBoxHeaders.Controls.Add(this.listBoxHeaders);
            this.gpBoxHeaders.Controls.Add(this.btnRemoveHeader);
            this.gpBoxHeaders.Controls.Add(this.btnAddHeader);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeaderData);
            this.gpBoxHeaders.Controls.Add(this.txtBoxHeader);
            this.gpBoxHeaders.Location = new System.Drawing.Point(15, 38);
            this.gpBoxHeaders.Name = "gpBoxHeaders";
            this.gpBoxHeaders.Size = new System.Drawing.Size(270, 205);
            this.gpBoxHeaders.TabIndex = 4;
            this.gpBoxHeaders.TabStop = false;
            this.gpBoxHeaders.Text = "Headers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxParameters);
            this.groupBox2.Controls.Add(this.btnRemoveParameter);
            this.groupBox2.Controls.Add(this.txtBoxParameter);
            this.groupBox2.Controls.Add(this.btnAddParameter);
            this.groupBox2.Controls.Add(this.txtBoxParameterData);
            this.groupBox2.Location = new System.Drawing.Point(291, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // txtBoxHeader
            // 
            this.txtBoxHeader.Location = new System.Drawing.Point(6, 19);
            this.txtBoxHeader.Name = "txtBoxHeader";
            this.txtBoxHeader.Size = new System.Drawing.Size(70, 20);
            this.txtBoxHeader.TabIndex = 0;
            // 
            // txtBoxHeaderData
            // 
            this.txtBoxHeaderData.Location = new System.Drawing.Point(82, 19);
            this.txtBoxHeaderData.Name = "txtBoxHeaderData";
            this.txtBoxHeaderData.Size = new System.Drawing.Size(182, 20);
            this.txtBoxHeaderData.TabIndex = 1;
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Location = new System.Drawing.Point(6, 45);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(124, 23);
            this.btnAddHeader.TabIndex = 2;
            this.btnAddHeader.Text = "Add";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHeader
            // 
            this.btnRemoveHeader.Location = new System.Drawing.Point(136, 45);
            this.btnRemoveHeader.Name = "btnRemoveHeader";
            this.btnRemoveHeader.Size = new System.Drawing.Size(128, 23);
            this.btnRemoveHeader.TabIndex = 3;
            this.btnRemoveHeader.Text = "Remove";
            this.btnRemoveHeader.UseVisualStyleBackColor = true;
            // 
            // listBoxHeaders
            // 
            this.listBoxHeaders.FormattingEnabled = true;
            this.listBoxHeaders.Location = new System.Drawing.Point(6, 75);
            this.listBoxHeaders.Name = "listBoxHeaders";
            this.listBoxHeaders.Size = new System.Drawing.Size(257, 121);
            this.listBoxHeaders.TabIndex = 4;
            // 
            // listBoxParameters
            // 
            this.listBoxParameters.FormattingEnabled = true;
            this.listBoxParameters.Location = new System.Drawing.Point(6, 75);
            this.listBoxParameters.Name = "listBoxParameters";
            this.listBoxParameters.Size = new System.Drawing.Size(269, 121);
            this.listBoxParameters.TabIndex = 9;
            // 
            // btnRemoveParameter
            // 
            this.btnRemoveParameter.Location = new System.Drawing.Point(143, 45);
            this.btnRemoveParameter.Name = "btnRemoveParameter";
            this.btnRemoveParameter.Size = new System.Drawing.Size(133, 23);
            this.btnRemoveParameter.TabIndex = 8;
            this.btnRemoveParameter.Text = "Remove";
            this.btnRemoveParameter.UseVisualStyleBackColor = true;
            // 
            // btnAddParameter
            // 
            this.btnAddParameter.Location = new System.Drawing.Point(6, 45);
            this.btnAddParameter.Name = "btnAddParameter";
            this.btnAddParameter.Size = new System.Drawing.Size(131, 23);
            this.btnAddParameter.TabIndex = 7;
            this.btnAddParameter.Text = "Add";
            this.btnAddParameter.UseVisualStyleBackColor = true;
            // 
            // txtBoxParameterData
            // 
            this.txtBoxParameterData.Location = new System.Drawing.Point(82, 19);
            this.txtBoxParameterData.Name = "txtBoxParameterData";
            this.txtBoxParameterData.Size = new System.Drawing.Size(194, 20);
            this.txtBoxParameterData.TabIndex = 6;
            // 
            // txtBoxParameter
            // 
            this.txtBoxParameter.Location = new System.Drawing.Point(6, 19);
            this.txtBoxParameter.Name = "txtBoxParameter";
            this.txtBoxParameter.Size = new System.Drawing.Size(70, 20);
            this.txtBoxParameter.TabIndex = 5;
            // 
            // ApiRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 257);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxHeaders;
        private System.Windows.Forms.ListBox listBoxParameters;
        private System.Windows.Forms.Button btnRemoveParameter;
        private System.Windows.Forms.TextBox txtBoxParameter;
        private System.Windows.Forms.Button btnAddParameter;
        private System.Windows.Forms.TextBox txtBoxParameterData;
    }
}