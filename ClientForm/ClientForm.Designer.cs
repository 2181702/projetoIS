
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
            this.textBoxInputRest = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(476, 570);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(107, 50);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "INPUT TYPE";
            // 
            // listBoxFlowsToRun
            // 
            this.listBoxFlowsToRun.FormattingEnabled = true;
            this.listBoxFlowsToRun.ItemHeight = 16;
            this.listBoxFlowsToRun.Location = new System.Drawing.Point(16, 343);
            this.listBoxFlowsToRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFlowsToRun.Name = "listBoxFlowsToRun";
            this.listBoxFlowsToRun.Size = new System.Drawing.Size(452, 244);
            this.listBoxFlowsToRun.TabIndex = 5;
            // 
            // listBoxSavedFlows
            // 
            this.listBoxSavedFlows.FormattingEnabled = true;
            this.listBoxSavedFlows.ItemHeight = 16;
            this.listBoxSavedFlows.Location = new System.Drawing.Point(589, 343);
            this.listBoxSavedFlows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxSavedFlows.Name = "listBoxSavedFlows";
            this.listBoxSavedFlows.Size = new System.Drawing.Size(460, 244);
            this.listBoxSavedFlows.TabIndex = 6;
            // 
            // radioInputExcel
            // 
            this.radioInputExcel.AutoSize = true;
            this.radioInputExcel.Location = new System.Drawing.Point(32, 74);
            this.radioInputExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInputExcel.Name = "radioInputExcel";
            this.radioInputExcel.Size = new System.Drawing.Size(68, 20);
            this.radioInputExcel.TabIndex = 7;
            this.radioInputExcel.TabStop = true;
            this.radioInputExcel.Text = "EXCEL";
            this.radioInputExcel.UseVisualStyleBackColor = true;
            // 
            // radioInputXML
            // 
            this.radioInputXML.AutoSize = true;
            this.radioInputXML.Location = new System.Drawing.Point(32, 143);
            this.radioInputXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInputXML.Name = "radioInputXML";
            this.radioInputXML.Size = new System.Drawing.Size(52, 20);
            this.radioInputXML.TabIndex = 8;
            this.radioInputXML.TabStop = true;
            this.radioInputXML.Text = "XML";
            this.radioInputXML.UseVisualStyleBackColor = true;
            // 
            // radioInputRest
            // 
            this.radioInputRest.AutoSize = true;
            this.radioInputRest.Location = new System.Drawing.Point(32, 222);
            this.radioInputRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioInputRest.Name = "radioInputRest";
            this.radioInputRest.Size = new System.Drawing.Size(75, 20);
            this.radioInputRest.TabIndex = 9;
            this.radioInputRest.TabStop = true;
            this.radioInputRest.Text = "RestAPI";
            this.radioInputRest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(515, 278);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnInputRest
            // 
            this.btnInputRest.Location = new System.Drawing.Point(134, 216);
            this.btnInputRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInputRest.Name = "btnInputRest";
            this.btnInputRest.Size = new System.Drawing.Size(44, 33);
            this.btnInputRest.TabIndex = 11;
            this.btnInputRest.Text = "...";
            this.btnInputRest.UseVisualStyleBackColor = true;
            this.btnInputRest.Click += new System.EventHandler(this.btnInputRest_Click);
            // 
            // buttonOpenXml
            // 
            this.buttonOpenXml.Location = new System.Drawing.Point(134, 137);
            this.buttonOpenXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenXml.Name = "buttonOpenXml";
            this.buttonOpenXml.Size = new System.Drawing.Size(44, 33);
            this.buttonOpenXml.TabIndex = 10;
            this.buttonOpenXml.Text = "...";
            this.buttonOpenXml.UseVisualStyleBackColor = true;
            this.buttonOpenXml.Click += new System.EventHandler(this.buttonOpenXml_Click);
            // 
            // buttonOpenExcel
            // 
            this.buttonOpenExcel.Location = new System.Drawing.Point(134, 68);
            this.buttonOpenExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenExcel.Name = "buttonOpenExcel";
            this.buttonOpenExcel.Size = new System.Drawing.Size(44, 33);
            this.buttonOpenExcel.TabIndex = 10;
            this.buttonOpenExcel.Text = "...";
            this.buttonOpenExcel.UseVisualStyleBackColor = true;
            this.buttonOpenExcel.Click += new System.EventHandler(this.buttonOpenExcel_Click);
            // 
            // textBoxInputXml
            // 
            this.textBoxInputXml.Location = new System.Drawing.Point(214, 142);
            this.textBoxInputXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputXml.Name = "textBoxInputXml";
            this.textBoxInputXml.ReadOnly = true;
            this.textBoxInputXml.Size = new System.Drawing.Size(252, 22);
            this.textBoxInputXml.TabIndex = 1;
            // 
            // textBoxInputExcel
            // 
            this.textBoxInputExcel.Location = new System.Drawing.Point(215, 73);
            this.textBoxInputExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInputExcel.Name = "textBoxInputExcel";
            this.textBoxInputExcel.ReadOnly = true;
            this.textBoxInputExcel.Size = new System.Drawing.Size(252, 22);
            this.textBoxInputExcel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "FLOWS TO RUN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "SAVED FLOWS";
            // 
            // buttonDeleteRun
            // 
            this.buttonDeleteRun.Location = new System.Drawing.Point(123, 597);
            this.buttonDeleteRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteRun.Name = "buttonDeleteRun";
            this.buttonDeleteRun.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteRun.TabIndex = 14;
            this.buttonDeleteRun.Text = "Delete";
            this.buttonDeleteRun.UseVisualStyleBackColor = true;
            this.buttonDeleteRun.Click += new System.EventHandler(this.buttonDeleteRun_Click);
            // 
            // buttonDeleteSaved
            // 
            this.buttonDeleteSaved.Location = new System.Drawing.Point(724, 597);
            this.buttonDeleteSaved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteSaved.Name = "buttonDeleteSaved";
            this.buttonDeleteSaved.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteSaved.TabIndex = 14;
            this.buttonDeleteSaved.Text = "Delete";
            this.buttonDeleteSaved.UseVisualStyleBackColor = true;
            this.buttonDeleteSaved.Click += new System.EventHandler(this.buttonDeleteSaved_Click);
            // 
            // buttonAddToRun
            // 
            this.buttonAddToRun.Location = new System.Drawing.Point(832, 597);
            this.buttonAddToRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddToRun.Name = "buttonAddToRun";
            this.buttonAddToRun.Size = new System.Drawing.Size(100, 28);
            this.buttonAddToRun.TabIndex = 14;
            this.buttonAddToRun.Text = "Add To Run";
            this.buttonAddToRun.UseVisualStyleBackColor = true;
            this.buttonAddToRun.Click += new System.EventHandler(this.buttonAddToRun_Click);
            // 
            // buttonSaveFlow
            // 
            this.buttonSaveFlow.Location = new System.Drawing.Point(476, 414);
            this.buttonSaveFlow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveFlow.Name = "buttonSaveFlow";
            this.buttonSaveFlow.Size = new System.Drawing.Size(105, 28);
            this.buttonSaveFlow.TabIndex = 14;
            this.buttonSaveFlow.Text = "Export Flows";
            this.buttonSaveFlow.UseVisualStyleBackColor = true;
            this.buttonSaveFlow.Click += new System.EventHandler(this.buttonExportFlows_Click);
            // 
            // buttonSaveHtml
            // 
            this.buttonSaveHtml.Location = new System.Drawing.Point(145, 68);
            this.buttonSaveHtml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveHtml.Name = "buttonSaveHtml";
            this.buttonSaveHtml.Size = new System.Drawing.Size(47, 33);
            this.buttonSaveHtml.TabIndex = 18;
            this.buttonSaveHtml.Text = "...";
            this.buttonSaveHtml.UseVisualStyleBackColor = true;
            this.buttonSaveHtml.Click += new System.EventHandler(this.buttonSaveHtml_Click);
            // 
            // radioOutputHtml
            // 
            this.radioOutputHtml.AutoSize = true;
            this.radioOutputHtml.Location = new System.Drawing.Point(52, 74);
            this.radioOutputHtml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOutputHtml.Name = "radioOutputHtml";
            this.radioOutputHtml.Size = new System.Drawing.Size(63, 20);
            this.radioOutputHtml.TabIndex = 20;
            this.radioOutputHtml.TabStop = true;
            this.radioOutputHtml.Text = "HTML";
            this.radioOutputHtml.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputHtml
            // 
            this.textBoxOutputHtml.Location = new System.Drawing.Point(210, 73);
            this.textBoxOutputHtml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutputHtml.Name = "textBoxOutputHtml";
            this.textBoxOutputHtml.ReadOnly = true;
            this.textBoxOutputHtml.Size = new System.Drawing.Size(255, 22);
            this.textBoxOutputHtml.TabIndex = 15;
            // 
            // radioOutputRest
            // 
            this.radioOutputRest.AutoSize = true;
            this.radioOutputRest.Location = new System.Drawing.Point(52, 145);
            this.radioOutputRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOutputRest.Name = "radioOutputRest";
            this.radioOutputRest.Size = new System.Drawing.Size(75, 20);
            this.radioOutputRest.TabIndex = 19;
            this.radioOutputRest.TabStop = true;
            this.radioOutputRest.Text = "RestAPI";
            this.radioOutputRest.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputRest
            // 
            this.textBoxOutputRest.Location = new System.Drawing.Point(210, 143);
            this.textBoxOutputRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutputRest.Name = "textBoxOutputRest";
            this.textBoxOutputRest.ReadOnly = true;
            this.textBoxOutputRest.Size = new System.Drawing.Size(255, 22);
            this.textBoxOutputRest.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "OUTPUT TYPE";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(539, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(523, 278);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // btnOutputXml
            // 
            this.btnOutputXml.Location = new System.Drawing.Point(145, 216);
            this.btnOutputXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputXml.Name = "btnOutputXml";
            this.btnOutputXml.Size = new System.Drawing.Size(47, 33);
            this.btnOutputXml.TabIndex = 15;
            this.btnOutputXml.Text = "...";
            this.btnOutputXml.UseVisualStyleBackColor = true;
            this.btnOutputXml.Click += new System.EventHandler(this.btnOutputXml_Click);
            // 
            // textBoxOutputXml
            // 
            this.textBoxOutputXml.Location = new System.Drawing.Point(210, 221);
            this.textBoxOutputXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOutputXml.Name = "textBoxOutputXml";
            this.textBoxOutputXml.ReadOnly = true;
            this.textBoxOutputXml.Size = new System.Drawing.Size(255, 22);
            this.textBoxOutputXml.TabIndex = 14;
            // 
            // radioOutputXml
            // 
            this.radioOutputXml.AutoSize = true;
            this.radioOutputXml.Location = new System.Drawing.Point(52, 222);
            this.radioOutputXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOutputXml.Name = "radioOutputXml";
            this.radioOutputXml.Size = new System.Drawing.Size(52, 20);
            this.radioOutputXml.TabIndex = 13;
            this.radioOutputXml.TabStop = true;
            this.radioOutputXml.Text = "XML";
            this.radioOutputXml.UseVisualStyleBackColor = false;
            // 
            // btnOutputRest
            // 
            this.btnOutputRest.Location = new System.Drawing.Point(145, 137);
            this.btnOutputRest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOutputRest.Name = "btnOutputRest";
            this.btnOutputRest.Size = new System.Drawing.Size(47, 33);
            this.btnOutputRest.TabIndex = 12;
            this.btnOutputRest.Text = "...";
            this.btnOutputRest.UseVisualStyleBackColor = true;
            this.btnOutputRest.Click += new System.EventHandler(this.btnOutputRest_Click);
            // 
            // buttonAddFlow
            // 
            this.buttonAddFlow.Location = new System.Drawing.Point(476, 299);
            this.buttonAddFlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFlow.Name = "buttonAddFlow";
            this.buttonAddFlow.Size = new System.Drawing.Size(107, 41);
            this.buttonAddFlow.TabIndex = 22;
            this.buttonAddFlow.Text = "Add Flow";
            this.buttonAddFlow.UseVisualStyleBackColor = true;
            this.buttonAddFlow.Click += new System.EventHandler(this.buttonAddFlow_Click);
            // 
            // buttonImportFlows
            // 
            this.buttonImportFlows.Location = new System.Drawing.Point(476, 464);
            this.buttonImportFlows.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonImportFlows.Name = "buttonImportFlows";
            this.buttonImportFlows.Size = new System.Drawing.Size(107, 28);
            this.buttonImportFlows.TabIndex = 24;
            this.buttonImportFlows.Text = "Import Flows";
            this.buttonImportFlows.UseVisualStyleBackColor = true;
            this.buttonImportFlows.Click += new System.EventHandler(this.buttonImportFlows_Click);
            // 
            // textBoxInputRest
            // 
            this.textBoxInputRest.Location = new System.Drawing.Point(214, 221);
            this.textBoxInputRest.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputRest.Name = "textBoxInputRest";
            this.textBoxInputRest.ReadOnly = true;
            this.textBoxInputRest.Size = new System.Drawing.Size(252, 22);
            this.textBoxInputRest.TabIndex = 1;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 645);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}

