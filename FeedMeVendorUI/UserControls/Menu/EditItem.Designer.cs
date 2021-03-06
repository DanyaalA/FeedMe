﻿namespace FeedMeVendorUI.UserControls.Menu
{
    partial class EditItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemName = new System.Windows.Forms.Label();
            this.EditItemPanel = new System.Windows.Forms.Panel();
            this.avatarPBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateItemButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.PriceTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.DescTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.EditCategoryPanel = new System.Windows.Forms.Panel();
            this.UpdateCategoryButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EditCategoryTBox = new FeedMeLogic.Controls.FeedMeTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewCat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.feedMeTextBox1 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.feedMeTextBox2 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.feedMeTextBox3 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.feedMeTextBox4 = new FeedMeLogic.Controls.FeedMeTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EditItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPBox)).BeginInit();
            this.EditCategoryPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(270, 12);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(256, 32);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "Category/Item Name";
            this.ItemName.TextChanged += new System.EventHandler(this.ItemName_TextChanged);
            // 
            // EditItemPanel
            // 
            this.EditItemPanel.Controls.Add(this.avatarPBox);
            this.EditItemPanel.Controls.Add(this.label5);
            this.EditItemPanel.Controls.Add(this.UpdateItemButton);
            this.EditItemPanel.Controls.Add(this.label6);
            this.EditItemPanel.Controls.Add(this.label4);
            this.EditItemPanel.Controls.Add(this.NameTBox);
            this.EditItemPanel.Controls.Add(this.label2);
            this.EditItemPanel.Controls.Add(this.CategoryTBox);
            this.EditItemPanel.Controls.Add(this.PriceTBox);
            this.EditItemPanel.Controls.Add(this.DescTBox);
            this.EditItemPanel.Location = new System.Drawing.Point(287, 58);
            this.EditItemPanel.Name = "EditItemPanel";
            this.EditItemPanel.Size = new System.Drawing.Size(263, 354);
            this.EditItemPanel.TabIndex = 29;
            // 
            // avatarPBox
            // 
            this.avatarPBox.Location = new System.Drawing.Point(85, 17);
            this.avatarPBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avatarPBox.Name = "avatarPBox";
            this.avatarPBox.Size = new System.Drawing.Size(154, 113);
            this.avatarPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPBox.TabIndex = 27;
            this.avatarPBox.TabStop = false;
            this.avatarPBox.Click += new System.EventHandler(this.avatarPBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Description:";
            // 
            // UpdateItemButton
            // 
            this.UpdateItemButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateItemButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItemButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateItemButton.Location = new System.Drawing.Point(47, 294);
            this.UpdateItemButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateItemButton.Name = "UpdateItemButton";
            this.UpdateItemButton.Size = new System.Drawing.Size(189, 44);
            this.UpdateItemButton.TabIndex = 26;
            this.UpdateItemButton.Text = "Update";
            this.UpdateItemButton.UseVisualStyleBackColor = false;
            this.UpdateItemButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Category:";
            // 
            // NameTBox
            // 
            this.NameTBox.AutoResize = false;
            this.NameTBox.BaseColor = System.Drawing.Color.Black;
            this.NameTBox.BorderColor = System.Drawing.Color.Black;
            this.NameTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTBox.FocusColor = System.Drawing.Color.White;
            this.NameTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.NameTBox.ForeColor = System.Drawing.Color.Gray;
            this.NameTBox.Location = new System.Drawing.Point(92, 140);
            this.NameTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.SingleLine = true;
            this.NameTBox.Size = new System.Drawing.Size(144, 22);
            this.NameTBox.TabIndex = 12;
            this.NameTBox.Watermark = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // CategoryTBox
            // 
            this.CategoryTBox.AutoResize = false;
            this.CategoryTBox.BaseColor = System.Drawing.Color.Black;
            this.CategoryTBox.BorderColor = System.Drawing.Color.Black;
            this.CategoryTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTBox.FocusColor = System.Drawing.Color.White;
            this.CategoryTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.CategoryTBox.ForeColor = System.Drawing.Color.Gray;
            this.CategoryTBox.Location = new System.Drawing.Point(92, 172);
            this.CategoryTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CategoryTBox.Name = "CategoryTBox";
            this.CategoryTBox.SingleLine = true;
            this.CategoryTBox.Size = new System.Drawing.Size(144, 22);
            this.CategoryTBox.TabIndex = 13;
            this.CategoryTBox.Watermark = "";
            // 
            // PriceTBox
            // 
            this.PriceTBox.AutoResize = false;
            this.PriceTBox.BaseColor = System.Drawing.Color.Black;
            this.PriceTBox.BorderColor = System.Drawing.Color.Black;
            this.PriceTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTBox.FocusColor = System.Drawing.Color.White;
            this.PriceTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.PriceTBox.ForeColor = System.Drawing.Color.Gray;
            this.PriceTBox.Location = new System.Drawing.Point(92, 236);
            this.PriceTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.SingleLine = true;
            this.PriceTBox.Size = new System.Drawing.Size(144, 22);
            this.PriceTBox.TabIndex = 15;
            this.PriceTBox.Watermark = "";
            // 
            // DescTBox
            // 
            this.DescTBox.AutoResize = false;
            this.DescTBox.BaseColor = System.Drawing.Color.Black;
            this.DescTBox.BorderColor = System.Drawing.Color.Black;
            this.DescTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescTBox.FocusColor = System.Drawing.Color.White;
            this.DescTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.DescTBox.ForeColor = System.Drawing.Color.Gray;
            this.DescTBox.Location = new System.Drawing.Point(92, 204);
            this.DescTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescTBox.Name = "DescTBox";
            this.DescTBox.SingleLine = true;
            this.DescTBox.Size = new System.Drawing.Size(144, 22);
            this.DescTBox.TabIndex = 14;
            this.DescTBox.Watermark = "";
            // 
            // EditCategoryPanel
            // 
            this.EditCategoryPanel.Controls.Add(this.pictureBox2);
            this.EditCategoryPanel.Controls.Add(this.UpdateCategoryButton);
            this.EditCategoryPanel.Controls.Add(this.label7);
            this.EditCategoryPanel.Controls.Add(this.EditCategoryTBox);
            this.EditCategoryPanel.Location = new System.Drawing.Point(556, 61);
            this.EditCategoryPanel.Name = "EditCategoryPanel";
            this.EditCategoryPanel.Size = new System.Drawing.Size(263, 354);
            this.EditCategoryPanel.TabIndex = 30;
            // 
            // UpdateCategoryButton
            // 
            this.UpdateCategoryButton.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCategoryButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategoryButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateCategoryButton.Location = new System.Drawing.Point(47, 181);
            this.UpdateCategoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdateCategoryButton.Name = "UpdateCategoryButton";
            this.UpdateCategoryButton.Size = new System.Drawing.Size(189, 44);
            this.UpdateCategoryButton.TabIndex = 26;
            this.UpdateCategoryButton.Text = "Update";
            this.UpdateCategoryButton.UseVisualStyleBackColor = false;
            this.UpdateCategoryButton.Click += new System.EventHandler(this.UpdateCategory_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Category:";
            // 
            // EditCategoryTBox
            // 
            this.EditCategoryTBox.AutoResize = false;
            this.EditCategoryTBox.BaseColor = System.Drawing.Color.Black;
            this.EditCategoryTBox.BorderColor = System.Drawing.Color.Black;
            this.EditCategoryTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditCategoryTBox.FocusColor = System.Drawing.Color.White;
            this.EditCategoryTBox.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.EditCategoryTBox.ForeColor = System.Drawing.Color.Gray;
            this.EditCategoryTBox.Location = new System.Drawing.Point(92, 135);
            this.EditCategoryTBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditCategoryTBox.Name = "EditCategoryTBox";
            this.EditCategoryTBox.SingleLine = true;
            this.EditCategoryTBox.Size = new System.Drawing.Size(144, 22);
            this.EditCategoryTBox.TabIndex = 13;
            this.EditCategoryTBox.Watermark = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddNewCat);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.feedMeTextBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.feedMeTextBox2);
            this.panel1.Controls.Add(this.feedMeTextBox3);
            this.panel1.Controls.Add(this.feedMeTextBox4);
            this.panel1.Location = new System.Drawing.Point(18, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 354);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Description:";
            // 
            // AddNewCat
            // 
            this.AddNewCat.BackColor = System.Drawing.SystemColors.Control;
            this.AddNewCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewCat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCat.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewCat.Location = new System.Drawing.Point(47, 294);
            this.AddNewCat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddNewCat.Name = "AddNewCat";
            this.AddNewCat.Size = new System.Drawing.Size(189, 44);
            this.AddNewCat.TabIndex = 26;
            this.AddNewCat.Text = "Add";
            this.AddNewCat.UseVisualStyleBackColor = false;
            this.AddNewCat.Click += new System.EventHandler(this.AddNewCat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Category:";
            // 
            // feedMeTextBox1
            // 
            this.feedMeTextBox1.AutoResize = false;
            this.feedMeTextBox1.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox1.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox1.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox1.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox1.Location = new System.Drawing.Point(92, 140);
            this.feedMeTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox1.Name = "feedMeTextBox1";
            this.feedMeTextBox1.SingleLine = true;
            this.feedMeTextBox1.Size = new System.Drawing.Size(144, 22);
            this.feedMeTextBox1.TabIndex = 12;
            this.feedMeTextBox1.Watermark = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Name:";
            // 
            // feedMeTextBox2
            // 
            this.feedMeTextBox2.AutoResize = false;
            this.feedMeTextBox2.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox2.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox2.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox2.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox2.Location = new System.Drawing.Point(92, 172);
            this.feedMeTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox2.Name = "feedMeTextBox2";
            this.feedMeTextBox2.SingleLine = true;
            this.feedMeTextBox2.Size = new System.Drawing.Size(144, 22);
            this.feedMeTextBox2.TabIndex = 13;
            this.feedMeTextBox2.Watermark = "";
            // 
            // feedMeTextBox3
            // 
            this.feedMeTextBox3.AutoResize = false;
            this.feedMeTextBox3.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox3.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox3.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox3.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox3.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox3.Location = new System.Drawing.Point(92, 236);
            this.feedMeTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox3.Name = "feedMeTextBox3";
            this.feedMeTextBox3.SingleLine = true;
            this.feedMeTextBox3.Size = new System.Drawing.Size(144, 22);
            this.feedMeTextBox3.TabIndex = 15;
            this.feedMeTextBox3.Watermark = "";
            // 
            // feedMeTextBox4
            // 
            this.feedMeTextBox4.AutoResize = false;
            this.feedMeTextBox4.BaseColor = System.Drawing.Color.Black;
            this.feedMeTextBox4.BorderColor = System.Drawing.Color.Black;
            this.feedMeTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.feedMeTextBox4.FocusColor = System.Drawing.Color.White;
            this.feedMeTextBox4.Font = new System.Drawing.Font("Nirmala UI", 7.25F, System.Drawing.FontStyle.Italic);
            this.feedMeTextBox4.ForeColor = System.Drawing.Color.Gray;
            this.feedMeTextBox4.Location = new System.Drawing.Point(92, 204);
            this.feedMeTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feedMeTextBox4.Name = "feedMeTextBox4";
            this.feedMeTextBox4.SingleLine = true;
            this.feedMeTextBox4.Size = new System.Drawing.Size(144, 22);
            this.feedMeTextBox4.TabIndex = 14;
            this.feedMeTextBox4.Watermark = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(66, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EditCategoryPanel);
            this.Controls.Add(this.EditItemPanel);
            this.Controls.Add(this.ItemName);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(776, 451);
            this.Load += new System.EventHandler(this.EditItem_Load);
            this.EditItemPanel.ResumeLayout(false);
            this.EditItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPBox)).EndInit();
            this.EditCategoryPanel.ResumeLayout(false);
            this.EditCategoryPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Panel EditItemPanel;
        private System.Windows.Forms.PictureBox avatarPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateItemButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private FeedMeLogic.Controls.FeedMeTextBox NameTBox;
        private System.Windows.Forms.Label label2;
        private FeedMeLogic.Controls.FeedMeTextBox CategoryTBox;
        private FeedMeLogic.Controls.FeedMeTextBox PriceTBox;
        private FeedMeLogic.Controls.FeedMeTextBox DescTBox;
        private System.Windows.Forms.Panel EditCategoryPanel;
        private System.Windows.Forms.Button UpdateCategoryButton;
        private System.Windows.Forms.Label label7;
        private FeedMeLogic.Controls.FeedMeTextBox EditCategoryTBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox1;
        private System.Windows.Forms.Label label9;
        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox2;
        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox3;
        private FeedMeLogic.Controls.FeedMeTextBox feedMeTextBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
