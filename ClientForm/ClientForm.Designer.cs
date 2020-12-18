
namespace ClientForm
{
    partial class ClientForm
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFlowsToRun = new System.Windows.Forms.ListBox();
            this.listBoxSavedFlows = new System.Windows.Forms.ListBox();
            this.radioInputExcel = new System.Windows.Forms.RadioButton();
            this.radioInputXML = new System.Windows.Forms.RadioButton();
            this.radioInputRest = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInputRest = new System.Windows.Forms.Button();
            this.buttonOpenXml = new System.Windows.Forms.Button();
            this.buttonOpenExcel = new System.Windows.Forms.Button();
            this.textBoxInputRest = new System.Windows.Forms.TextBox();
            this.textBoxInputXml = new System.Windows.Forms.TextBox();
            this.textBoxInputExcel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeleteRun = new System.Windows.Forms.Button();
            this.buttonDeleteSaved = new System.Windows.Forms.Button();
            this.buttonAddToRun = new System.Windows.Forms.Button();
            this.buttonSaveFlow = new System.Windows.Forms.Button();
            this.buttonSaveHtml = new System.Windows.Forms.Button();
            this.radioOutputHtml = new System.Windows.Forms.RadioButton();
            this.textBoxOutputHtml = new System.Windows.Forms.TextBox();
            this.radioOutputRest = new System.Windows.Forms.RadioButton();
            this.textBoxOutputRest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOutputXml = new System.Windows.Forms.Button();
            this.textBoxOutputXml = new System.Windows.Forms.TextBox();
            this.radioOutputXml = new System.Windows.Forms.RadioButton();
            this.btnOutputRest = new System.Windows.Forms.Button();
            this.buttonAddFlow = new System.Windows.Forms.Button();
            this.buttonImportFlows = new System.Windows.Forms.Button();
            this.comboBoxWorkSheet = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRun.Location = new System.Drawing.Point(357, 463);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(80, 41);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INPUT TYPE";
            // 
            // listBoxFlowsToRun
            // 
            this.listBoxFlowsToRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFlowsToRun.FormattingEnabled = true;
            this.listBoxFlowsToRun.Location = new System.Drawing.Point(12, 279);
            this.listBoxFlowsToRun.Name = "listBoxFlowsToRun";
            this.listBoxFlowsToRun.Size = new System.Drawing.Size(340, 199);
            this.listBoxFlowsToRun.TabIndex = 5;
            // 
            // listBoxSavedFlows
            // 
            this.listBoxSavedFlows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSavedFlows.FormattingEnabled = true;
            this.listBoxSavedFlows.Location = new System.Drawing.Point(442, 279);
            this.listBoxSavedFlows.Name = "listBoxSavedFlows";
            this.listBoxSavedFlows.Size = new System.Drawing.Size(346, 199);
            this.listBoxSavedFlows.TabIndex = 6;
            // 
            // radioInputExcel
            // 
            this.radioInputExcel.AutoSize = true;
            this.radioInputExcel.Location = new System.Drawing.Point(24, 60);
            this.radioInputExcel.Name = "radioInputExcel";
            this.radioInputExcel.Size = new System.Drawing.Size(59, 17);
            this.radioInputExcel.TabIndex = 7;
            this.radioInputExcel.TabStop = true;
            this.radioInputExcel.Text = "EXCEL";
            this.radioInputExcel.UseVisualStyleBackColor = true;
            // 
            // radioInputXML
            // 
            this.radioInputXML.AutoSize = true;
            this.radioInputXML.Location = new System.Drawing.Point(24, 119);
            this.radioInputXML.Name = "radioInputXML";
            this.radioInputXML.Size = new System.Drawing.Size(47, 17);
            this.radioInputXML.TabIndex = 8;
            this.radioInputXML.TabStop = true;
            this.radioInputXML.Text = "XML";
            this.radioInputXML.UseVisualStyleBackColor = true;
            // 
            // radioInputRest
            // 
            this.radioInputRest.AutoSize = true;
            this.radioInputRest.Location = new System.Drawing.Point(24, 180);
            this.radioInputRest.Name = "radioInputRest";
            this.radioInputRest.Size = new System.Drawing.Size(64, 17);
            this.radioInputRest.TabIndex = 9;
            this.radioInputRest.TabStop = true;
            this.radioInputRest.Text = "RestAPI";
            this.radioInputRest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.comboBoxWorkSheet);
            this.groupBox1.Controls.Add(this.btnInputRest);
            this.groupBox1.Controls.Add(this.buttonOpenXml);
            this.groupBox1.Controls.Add(this.buttonOpenExcel);
            this.groupBox1.Controls.Add(this.textBoxInputRest);
            this.groupBox1.Controls.Add(this.textBoxInputXml);
            this.groupBox1.Controls.Add(this.textBoxInputExcel);
            this.groupBox1.Controls.Add(this.radioInputExcel);
            this.groupBox1.Controls.Add(this.radioInputXML);
            this.groupBox1.Controls.Add(this.radioInputRest);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 226);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnInputRest
            // 
            this.btnInputRest.Location = new System.Drawing.Point(100, 176);
            this.btnInputRest.Name = "btnInputRest";
            this.btnInputRest.Size = new System.Drawing.Size(33, 27);
            this.btnInputRest.TabIndex = 11;
            this.btnInputRest.Text = "...";
            this.btnInputRest.UseVisualStyleBackColor = true;
            this.btnInputRest.Click += new System.EventHandler(this.btnInputRest_Click);
            // 
            // buttonOpenXml
            // 
            this.buttonOpenXml.Location = new System.Drawing.Point(100, 114);
            this.buttonOpenXml.Name = "buttonOpenXml";
            this.buttonOpenXml.Size = new System.Drawing.Size(33, 27);
            this.buttonOpenXml.TabIndex = 10;
            this.buttonOpenXml.Text = "...";
            this.buttonOpenXml.UseVisualStyleBackColor = true;
            this.buttonOpenXml.Click += new System.EventHandler(this.buttonOpenXml_Click);
            // 
            // buttonOpenExcel
            // 
            this.buttonOpenExcel.Location = new System.Drawing.Point(100, 55);
            this.buttonOpenExcel.Name = "buttonOpenExcel";
            this.buttonOpenExcel.Size = new System.Drawing.Size(33, 27);
            this.buttonOpenExcel.TabIndex = 10;
            this.buttonOpenExcel.Text = "...";
            this.buttonOpenExcel.UseVisualStyleBackColor = true;
            this.buttonOpenExcel.Click += new System.EventHandler(this.buttonOpenExcel_Click);
            // 
            // textBoxInputRest
            // 
            this.textBoxInputRest.Location = new System.Drawing.Point(150, 180);
            this.textBoxInputRest.Name = "textBoxInputRest";
            this.textBoxInputRest.ReadOnly = true;
            this.textBoxInputRest.Size = new System.Drawing.Size(222, 20);
            this.textBoxInputRest.TabIndex = 1;
            // 
            // textBoxInputXml
            // 
            this.textBoxInputXml.Location = new System.Drawing.Point(150, 118);
            this.textBoxInputXml.Name = "textBoxInputXml";
            this.textBoxInputXml.ReadOnly = true;
            this.textBoxInputXml.Size = new System.Drawing.Size(222, 20);
            this.textBoxInputXml.TabIndex = 1;
            // 
            // textBoxInputExcel
            // 
            this.textBoxInputExcel.Location = new System.Drawing.Point(251, 59);
            this.textBoxInputExcel.Name = "textBoxInputExcel";
            this.textBoxInputExcel.ReadOnly = true;
            this.textBoxInputExcel.Size = new System.Drawing.Size(121, 20);
            this.textBoxInputExcel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "FLOWS TO RUN";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SAVED FLOWS";
            // 
            // buttonDeleteRun
            // 
            this.buttonDeleteRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteRun.Location = new System.Drawing.Point(92, 485);
            this.buttonDeleteRun.Name = "buttonDeleteRun";
            this.buttonDeleteRun.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRun.TabIndex = 14;
            this.buttonDeleteRun.Text = "Delete";
            this.buttonDeleteRun.UseVisualStyleBackColor = true;
            this.buttonDeleteRun.Click += new System.EventHandler(this.buttonDeleteRun_Click);
            // 
            // buttonDeleteSaved
            // 
            this.buttonDeleteSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteSaved.Location = new System.Drawing.Point(543, 485);
            this.buttonDeleteSaved.Name = "buttonDeleteSaved";
            this.buttonDeleteSaved.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSaved.TabIndex = 14;
            this.buttonDeleteSaved.Text = "Delete";
            this.buttonDeleteSaved.UseVisualStyleBackColor = true;
            this.buttonDeleteSaved.Click += new System.EventHandler(this.buttonDeleteSaved_Click);
            // 
            // buttonAddToRun
            // 
            this.buttonAddToRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddToRun.Location = new System.Drawing.Point(624, 485);
            this.buttonAddToRun.Name = "buttonAddToRun";
            this.buttonAddToRun.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToRun.TabIndex = 14;
            this.buttonAddToRun.Text = "Add To Run";
            this.buttonAddToRun.UseVisualStyleBackColor = true;
            this.buttonAddToRun.Click += new System.EventHandler(this.buttonAddToRun_Click);
            // 
            // buttonSaveFlow
            // 
            this.buttonSaveFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveFlow.Location = new System.Drawing.Point(357, 336);
            this.buttonSaveFlow.Name = "buttonSaveFlow";
            this.buttonSaveFlow.Size = new System.Drawing.Size(79, 23);
            this.buttonSaveFlow.TabIndex = 14;
            this.buttonSaveFlow.Text = "Export Flows";
            this.buttonSaveFlow.UseVisualStyleBackColor = true;
            this.buttonSaveFlow.Click += new System.EventHandler(this.buttonExportFlows_Click);
            // 
            // buttonSaveHtml
            // 
            this.buttonSaveHtml.Location = new System.Drawing.Point(109, 55);
            this.buttonSaveHtml.Name = "buttonSaveHtml";
            this.buttonSaveHtml.Size = new System.Drawing.Size(35, 27);
            this.buttonSaveHtml.TabIndex = 18;
            this.buttonSaveHtml.Text = "...";
            this.buttonSaveHtml.UseVisualStyleBackColor = true;
            this.buttonSaveHtml.Click += new System.EventHandler(this.buttonSaveHtml_Click);
            // 
            // radioOutputHtml
            // 
            this.radioOutputHtml.AutoSize = true;
            this.radioOutputHtml.Location = new System.Drawing.Point(39, 60);
            this.radioOutputHtml.Name = "radioOutputHtml";
            this.radioOutputHtml.Size = new System.Drawing.Size(55, 17);
            this.radioOutputHtml.TabIndex = 20;
            this.radioOutputHtml.TabStop = true;
            this.radioOutputHtml.Text = "HTML";
            this.radioOutputHtml.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputHtml
            // 
            this.textBoxOutputHtml.Location = new System.Drawing.Point(158, 59);
            this.textBoxOutputHtml.Name = "textBoxOutputHtml";
            this.textBoxOutputHtml.Size = new System.Drawing.Size(192, 20);
            this.textBoxOutputHtml.TabIndex = 15;
            // 
            // radioOutputRest
            // 
            this.radioOutputRest.AutoSize = true;
            this.radioOutputRest.Location = new System.Drawing.Point(39, 181);
            this.radioOutputRest.Name = "radioOutputRest";
            this.radioOutputRest.Size = new System.Drawing.Size(64, 17);
            this.radioOutputRest.TabIndex = 19;
            this.radioOutputRest.TabStop = true;
            this.radioOutputRest.Text = "RestAPI";
            this.radioOutputRest.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputRest
            // 
            this.textBoxOutputRest.Location = new System.Drawing.Point(158, 179);
            this.textBoxOutputRest.Name = "textBoxOutputRest";
            this.textBoxOutputRest.ReadOnly = true;
            this.textBoxOutputRest.Size = new System.Drawing.Size(192, 20);
            this.textBoxOutputRest.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "OUTPUT TYPE";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnOutputXml);
            this.groupBox2.Controls.Add(this.buttonSaveHtml);
            this.groupBox2.Controls.Add(this.textBoxOutputXml);
            this.groupBox2.Controls.Add(this.radioOutputHtml);
            this.groupBox2.Controls.Add(this.textBoxOutputHtml);
            this.groupBox2.Controls.Add(this.radioOutputXml);
            this.groupBox2.Controls.Add(this.radioOutputRest);
            this.groupBox2.Controls.Add(this.btnOutputRest);
            this.groupBox2.Controls.Add(this.textBoxOutputRest);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(404, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 226);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnOutputXml
            // 
            this.btnOutputXml.Location = new System.Drawing.Point(109, 114);
            this.btnOutputXml.Name = "btnOutputXml";
            this.btnOutputXml.Size = new System.Drawing.Size(35, 27);
            this.btnOutputXml.TabIndex = 15;
            this.btnOutputXml.Text = "...";
            this.btnOutputXml.UseVisualStyleBackColor = true;
            this.btnOutputXml.Click += new System.EventHandler(this.btnOutputXml_Click);
            // 
            // textBoxOutputXml
            // 
            this.textBoxOutputXml.Location = new System.Drawing.Point(158, 118);
            this.textBoxOutputXml.Name = "textBoxOutputXml";
            this.textBoxOutputXml.Size = new System.Drawing.Size(192, 20);
            this.textBoxOutputXml.TabIndex = 14;
            // 
            // radioOutputXml
            // 
            this.radioOutputXml.AutoSize = true;
            this.radioOutputXml.Location = new System.Drawing.Point(39, 118);
            this.radioOutputXml.Name = "radioOutputXml";
            this.radioOutputXml.Size = new System.Drawing.Size(47, 17);
            this.radioOutputXml.TabIndex = 13;
            this.radioOutputXml.TabStop = true;
            this.radioOutputXml.Text = "XML";
            this.radioOutputXml.UseVisualStyleBackColor = false;
            // 
            // btnOutputRest
            // 
            this.btnOutputRest.Location = new System.Drawing.Point(109, 174);
            this.btnOutputRest.Name = "btnOutputRest";
            this.btnOutputRest.Size = new System.Drawing.Size(35, 27);
            this.btnOutputRest.TabIndex = 12;
            this.btnOutputRest.Text = "...";
            this.btnOutputRest.UseVisualStyleBackColor = true;
            this.btnOutputRest.Click += new System.EventHandler(this.btnOutputRest_Click);
            // 
            // buttonAddFlow
            // 
            this.buttonAddFlow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAddFlow.Location = new System.Drawing.Point(357, 243);
            this.buttonAddFlow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFlow.Name = "buttonAddFlow";
            this.buttonAddFlow.Size = new System.Drawing.Size(80, 33);
            this.buttonAddFlow.TabIndex = 22;
            this.buttonAddFlow.Text = "Add Flow";
            this.buttonAddFlow.UseVisualStyleBackColor = true;
            this.buttonAddFlow.Click += new System.EventHandler(this.buttonAddFlow_Click);
            // 
            // buttonImportFlows
            // 
            this.buttonImportFlows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonImportFlows.Location = new System.Drawing.Point(357, 377);
            this.buttonImportFlows.Name = "buttonImportFlows";
            this.buttonImportFlows.Size = new System.Drawing.Size(80, 23);
            this.buttonImportFlows.TabIndex = 24;
            this.buttonImportFlows.Text = "Import Flows";
            this.buttonImportFlows.UseVisualStyleBackColor = true;
            this.buttonImportFlows.Click += new System.EventHandler(this.buttonImportFlows_Click);
            // 
            // comboBoxWorkSheet
            // 
            this.comboBoxWorkSheet.FormattingEnabled = true;
            this.comboBoxWorkSheet.Location = new System.Drawing.Point(150, 60);
            this.comboBoxWorkSheet.Name = "comboBoxWorkSheet";
            this.comboBoxWorkSheet.Size = new System.Drawing.Size(95, 21);
            this.comboBoxWorkSheet.TabIndex = 12;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.buttonImportFlows);
            this.Controls.Add(this.buttonAddFlow);
            this.Controls.Add(this.buttonDeleteSaved);
            this.Controls.Add(this.buttonAddToRun);
            this.Controls.Add(this.buttonSaveFlow);
            this.Controls.Add(this.buttonDeleteRun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxSavedFlows);
            this.Controls.Add(this.listBoxFlowsToRun);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = " Data Sources Converter Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFlowsToRun;
        private System.Windows.Forms.ListBox listBoxSavedFlows;
        private System.Windows.Forms.RadioButton radioInputExcel;
        private System.Windows.Forms.RadioButton radioInputXML;
        private System.Windows.Forms.RadioButton radioInputRest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInputXml;
        private System.Windows.Forms.TextBox textBoxInputExcel;
        private System.Windows.Forms.Button buttonOpenExcel;
        private System.Windows.Forms.Button buttonOpenXml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteRun;
        private System.Windows.Forms.Button buttonDeleteSaved;
        private System.Windows.Forms.Button buttonAddToRun;
        private System.Windows.Forms.Button buttonSaveFlow;
        private System.Windows.Forms.Button buttonSaveHtml;
        private System.Windows.Forms.RadioButton radioOutputHtml;
        private System.Windows.Forms.TextBox textBoxOutputHtml;
        private System.Windows.Forms.RadioButton radioOutputRest;
        private System.Windows.Forms.TextBox textBoxOutputRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddFlow;
        private System.Windows.Forms.Button btnInputRest;
        private System.Windows.Forms.Button btnOutputRest;
        private System.Windows.Forms.Button btnOutputXml;
        private System.Windows.Forms.TextBox textBoxOutputXml;
        private System.Windows.Forms.RadioButton radioOutputXml;
        private System.Windows.Forms.Button buttonImportFlows;
        private System.Windows.Forms.TextBox textBoxInputRest;
        private System.Windows.Forms.ComboBox comboBoxWorkSheet;
    }
}

