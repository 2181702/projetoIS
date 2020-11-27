﻿
namespace projetoIS
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFlowsToRun = new System.Windows.Forms.ListBox();
            this.listBoxSavedFlows = new System.Windows.Forms.ListBox();
            this.radioInputExcel = new System.Windows.Forms.RadioButton();
            this.radioInputXML = new System.Windows.Forms.RadioButton();
            this.radioInputRest = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.buttonAddFlow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(357, 463);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(80, 41);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
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
            this.listBoxFlowsToRun.FormattingEnabled = true;
            this.listBoxFlowsToRun.Location = new System.Drawing.Point(12, 279);
            this.listBoxFlowsToRun.Name = "listBoxFlowsToRun";
            this.listBoxFlowsToRun.Size = new System.Drawing.Size(340, 199);
            this.listBoxFlowsToRun.TabIndex = 5;
            // 
            // listBoxSavedFlows
            // 
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
            this.radioInputXML.Location = new System.Drawing.Point(24, 116);
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
            // buttonOpenXml
            // 
            this.buttonOpenXml.Location = new System.Drawing.Point(297, 111);
            this.buttonOpenXml.Name = "buttonOpenXml";
            this.buttonOpenXml.Size = new System.Drawing.Size(35, 27);
            this.buttonOpenXml.TabIndex = 10;
            this.buttonOpenXml.Text = "...";
            this.buttonOpenXml.UseVisualStyleBackColor = true;
            // 
            // buttonOpenExcel
            // 
            this.buttonOpenExcel.Location = new System.Drawing.Point(297, 55);
            this.buttonOpenExcel.Name = "buttonOpenExcel";
            this.buttonOpenExcel.Size = new System.Drawing.Size(35, 27);
            this.buttonOpenExcel.TabIndex = 10;
            this.buttonOpenExcel.Text = "...";
            this.buttonOpenExcel.UseVisualStyleBackColor = true;
            // 
            // textBoxInputRest
            // 
            this.textBoxInputRest.Location = new System.Drawing.Point(101, 179);
            this.textBoxInputRest.Name = "textBoxInputRest";
            this.textBoxInputRest.Size = new System.Drawing.Size(190, 20);
            this.textBoxInputRest.TabIndex = 1;
            // 
            // textBoxInputXml
            // 
            this.textBoxInputXml.Location = new System.Drawing.Point(101, 115);
            this.textBoxInputXml.Name = "textBoxInputXml";
            this.textBoxInputXml.Size = new System.Drawing.Size(190, 20);
            this.textBoxInputXml.TabIndex = 1;
            // 
            // textBoxInputExcel
            // 
            this.textBoxInputExcel.Location = new System.Drawing.Point(101, 59);
            this.textBoxInputExcel.Name = "textBoxInputExcel";
            this.textBoxInputExcel.Size = new System.Drawing.Size(190, 20);
            this.textBoxInputExcel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "FLOWS TO RUN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(574, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SAVED FLOWS";
            // 
            // buttonDeleteRun
            // 
            this.buttonDeleteRun.Location = new System.Drawing.Point(92, 485);
            this.buttonDeleteRun.Name = "buttonDeleteRun";
            this.buttonDeleteRun.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRun.TabIndex = 14;
            this.buttonDeleteRun.Text = "Delete";
            this.buttonDeleteRun.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSaved
            // 
            this.buttonDeleteSaved.Location = new System.Drawing.Point(543, 485);
            this.buttonDeleteSaved.Name = "buttonDeleteSaved";
            this.buttonDeleteSaved.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSaved.TabIndex = 14;
            this.buttonDeleteSaved.Text = "Delete";
            this.buttonDeleteSaved.UseVisualStyleBackColor = true;
            // 
            // buttonAddToRun
            // 
            this.buttonAddToRun.Location = new System.Drawing.Point(624, 485);
            this.buttonAddToRun.Name = "buttonAddToRun";
            this.buttonAddToRun.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToRun.TabIndex = 14;
            this.buttonAddToRun.Text = "Add To Run";
            this.buttonAddToRun.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFlow
            // 
            this.buttonSaveFlow.Location = new System.Drawing.Point(173, 485);
            this.buttonSaveFlow.Name = "buttonSaveFlow";
            this.buttonSaveFlow.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFlow.TabIndex = 14;
            this.buttonSaveFlow.Text = "Save Flow";
            this.buttonSaveFlow.UseVisualStyleBackColor = true;
            // 
            // buttonSaveHtml
            // 
            this.buttonSaveHtml.Location = new System.Drawing.Point(741, 67);
            this.buttonSaveHtml.Name = "buttonSaveHtml";
            this.buttonSaveHtml.Size = new System.Drawing.Size(35, 27);
            this.buttonSaveHtml.TabIndex = 18;
            this.buttonSaveHtml.Text = "...";
            this.buttonSaveHtml.UseVisualStyleBackColor = true;
            // 
            // radioOutputHtml
            // 
            this.radioOutputHtml.AutoSize = true;
            this.radioOutputHtml.Location = new System.Drawing.Point(468, 72);
            this.radioOutputHtml.Name = "radioOutputHtml";
            this.radioOutputHtml.Size = new System.Drawing.Size(55, 17);
            this.radioOutputHtml.TabIndex = 20;
            this.radioOutputHtml.TabStop = true;
            this.radioOutputHtml.Text = "HTML";
            this.radioOutputHtml.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputHtml
            // 
            this.textBoxOutputHtml.Location = new System.Drawing.Point(543, 71);
            this.textBoxOutputHtml.Name = "textBoxOutputHtml";
            this.textBoxOutputHtml.Size = new System.Drawing.Size(192, 20);
            this.textBoxOutputHtml.TabIndex = 15;
            // 
            // radioOutputRest
            // 
            this.radioOutputRest.AutoSize = true;
            this.radioOutputRest.Location = new System.Drawing.Point(468, 128);
            this.radioOutputRest.Name = "radioOutputRest";
            this.radioOutputRest.Size = new System.Drawing.Size(64, 17);
            this.radioOutputRest.TabIndex = 19;
            this.radioOutputRest.TabStop = true;
            this.radioOutputRest.Text = "RestAPI";
            this.radioOutputRest.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputRest
            // 
            this.textBoxOutputRest.Location = new System.Drawing.Point(543, 127);
            this.textBoxOutputRest.Name = "textBoxOutputRest";
            this.textBoxOutputRest.Size = new System.Drawing.Size(192, 20);
            this.textBoxOutputRest.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "OUTPUT TYPE";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(396, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 226);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // buttonAddFlow
            // 
            this.buttonAddFlow.Location = new System.Drawing.Point(357, 243);
            this.buttonAddFlow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddFlow.Name = "buttonAddFlow";
            this.buttonAddFlow.Size = new System.Drawing.Size(80, 33);
            this.buttonAddFlow.TabIndex = 22;
            this.buttonAddFlow.Text = "Add Flow";
            this.buttonAddFlow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.buttonAddFlow);
            this.Controls.Add(this.buttonSaveHtml);
            this.Controls.Add(this.radioOutputHtml);
            this.Controls.Add(this.textBoxOutputHtml);
            this.Controls.Add(this.radioOutputRest);
            this.Controls.Add(this.textBoxOutputRest);
            this.Controls.Add(this.label2);
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
            this.Name = "Form1";
            this.Text = " Data Sources Converter Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxInputRest;
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
    }
}
