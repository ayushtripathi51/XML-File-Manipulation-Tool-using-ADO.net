﻿namespace ReadWriteXML
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
            this.btnReadXML = new System.Windows.Forms.Button();
            this.btnCreateXML = new System.Windows.Forms.Button();
            this.txtXMLFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveXML = new System.Windows.Forms.Button();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadXML
            // 
            this.btnReadXML.Location = new System.Drawing.Point(289, 47);
            this.btnReadXML.Name = "btnReadXML";
            this.btnReadXML.Size = new System.Drawing.Size(133, 22);
            this.btnReadXML.TabIndex = 0;
            this.btnReadXML.Text = "Read XML File";
            this.btnReadXML.UseVisualStyleBackColor = true;
            this.btnReadXML.Click += new System.EventHandler(this.btnReadXML_Click);
            // 
            // btnCreateXML
            // 
            this.btnCreateXML.Location = new System.Drawing.Point(114, 47);
            this.btnCreateXML.Name = "btnCreateXML";
            this.btnCreateXML.Size = new System.Drawing.Size(133, 22);
            this.btnCreateXML.TabIndex = 1;
            this.btnCreateXML.Text = "Create XML File";
            this.btnCreateXML.UseVisualStyleBackColor = true;
            this.btnCreateXML.Click += new System.EventHandler(this.btnCreateXML_Click);
            // 
            // txtXMLFilePath
            // 
            this.txtXMLFilePath.BackColor = System.Drawing.SystemColors.Info;
            this.txtXMLFilePath.Location = new System.Drawing.Point(112, 21);
            this.txtXMLFilePath.Name = "txtXMLFilePath";
            this.txtXMLFilePath.Size = new System.Drawing.Size(310, 20);
            this.txtXMLFilePath.TabIndex = 2;
            this.txtXMLFilePath.Text = "C:\\Users\\Ayush\\Desktop\\netProjectXML\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "XML File Path :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 194);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnSaveXML
            // 
            this.btnSaveXML.Location = new System.Drawing.Point(12, 317);
            this.btnSaveXML.Name = "btnSaveXML";
            this.btnSaveXML.Size = new System.Drawing.Size(112, 22);
            this.btnSaveXML.TabIndex = 5;
            this.btnSaveXML.Text = "Save XML File";
            this.btnSaveXML.UseVisualStyleBackColor = true;
            this.btnSaveXML.Click += new System.EventHandler(this.btnSaveXML_Click);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.Location = new System.Drawing.Point(342, 317);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(106, 22);
            this.btnClearGrid.TabIndex = 6;
            this.btnClearGrid.Text = "Clear Grid";
            this.btnClearGrid.UseVisualStyleBackColor = true;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "search a tag";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchbox
            // 
            this.searchbox.AcceptsReturn = true;
            this.searchbox.BackColor = System.Drawing.SystemColors.Info;
            this.searchbox.Location = new System.Drawing.Point(150, 293);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(210, 20);
            this.searchbox.TabIndex = 9;
            this.searchbox.Text = "enter tag name to search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnSaveXML);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtXMLFilePath);
            this.Controls.Add(this.btnCreateXML);
            this.Controls.Add(this.btnReadXML);
            this.Name = "Form1";
            this.Text = "Read/Write XML file using Dataset";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadXML;
        private System.Windows.Forms.Button btnCreateXML;
        private System.Windows.Forms.TextBox txtXMLFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveXML;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchbox;
    }
}

