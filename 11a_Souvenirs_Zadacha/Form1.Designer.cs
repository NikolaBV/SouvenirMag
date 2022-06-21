namespace _11a_Souvenirs_Zadacha
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
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Id = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1_Type = new System.Windows.Forms.ComboBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_GetAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Get = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // textbox_Id
            // 
            this.textbox_Id.Location = new System.Drawing.Point(47, 90);
            this.textbox_Id.Name = "textbox_Id";
            this.textbox_Id.Size = new System.Drawing.Size(100, 20);
            this.textbox_Id.TabIndex = 1;
            this.textbox_Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(198, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(347, 212);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1_Type
            // 
            this.comboBox1_Type.FormattingEnabled = true;
            this.comboBox1_Type.Location = new System.Drawing.Point(47, 294);
            this.comboBox1_Type.Name = "comboBox1_Type";
            this.comboBox1_Type.Size = new System.Drawing.Size(100, 21);
            this.comboBox1_Type.TabIndex = 3;
            this.comboBox1_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(198, 323);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 38);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(47, 144);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 6;
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // textBox3_Description
            // 
            this.textBox3_Description.Location = new System.Drawing.Point(47, 193);
            this.textBox3_Description.Name = "textBox3_Description";
            this.textBox3_Description.Size = new System.Drawing.Size(100, 20);
            this.textBox3_Description.TabIndex = 8;
            this.textBox3_Description.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox5_Price
            // 
            this.textBox5_Price.Location = new System.Drawing.Point(47, 243);
            this.textBox5_Price.Name = "textBox5_Price";
            this.textBox5_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox5_Price.TabIndex = 10;
            this.textBox5_Price.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(279, 323);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 38);
            this.button_Update.TabIndex = 13;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(360, 323);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 38);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_GetAll
            // 
            this.button_GetAll.Location = new System.Drawing.Point(441, 323);
            this.button_GetAll.Name = "button_GetAll";
            this.button_GetAll.Size = new System.Drawing.Size(75, 38);
            this.button_GetAll.TabIndex = 15;
            this.button_GetAll.Text = "Get All";
            this.button_GetAll.UseVisualStyleBackColor = true;
            this.button_GetAll.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type";
            // 
            // button_Get
            // 
            this.button_Get.Location = new System.Drawing.Point(522, 323);
            this.button_Get.Name = "button_Get";
            this.button_Get.Size = new System.Drawing.Size(75, 38);
            this.button_Get.TabIndex = 17;
            this.button_Get.Text = "Get";
            this.button_Get.UseVisualStyleBackColor = true;
            this.button_Get.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 459);
            this.Controls.Add(this.button_Get);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_GetAll);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox5_Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3_Description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.comboBox1_Type);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textbox_Id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_Id;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1_Type;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_GetAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Get;
    }
}

