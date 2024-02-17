namespace Protobyte2
{
    partial class AddEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addemployee_id = new System.Windows.Forms.TextBox();
            this.addemployee_fullname = new System.Windows.Forms.TextBox();
            this.addemployee_phone = new System.Windows.Forms.TextBox();
            this.addemployee_gender = new System.Windows.Forms.ComboBox();
            this.addemployee_position = new System.Windows.Forms.ComboBox();
            this.addemployee_image = new System.Windows.Forms.PictureBox();
            this.addemployee_importp = new System.Windows.Forms.Button();
            this.AddEmployee_Addbtn = new System.Windows.Forms.Button();
            this.AddEmployee_Update = new System.Windows.Forms.Button();
            this.AddEmployee_delete = new System.Windows.Forms.Button();
            this.AddEmployee_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addemployee_status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.addemployee_image)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addemployee_id
            // 
            this.addemployee_id.Location = new System.Drawing.Point(47, 52);
            this.addemployee_id.Name = "addemployee_id";
            this.addemployee_id.Size = new System.Drawing.Size(205, 22);
            this.addemployee_id.TabIndex = 1;
            // 
            // addemployee_fullname
            // 
            this.addemployee_fullname.Location = new System.Drawing.Point(47, 118);
            this.addemployee_fullname.Name = "addemployee_fullname";
            this.addemployee_fullname.Size = new System.Drawing.Size(205, 22);
            this.addemployee_fullname.TabIndex = 3;
            // 
            // addemployee_phone
            // 
            this.addemployee_phone.Location = new System.Drawing.Point(313, 52);
            this.addemployee_phone.Name = "addemployee_phone";
            this.addemployee_phone.Size = new System.Drawing.Size(205, 22);
            this.addemployee_phone.TabIndex = 4;
            // 
            // addemployee_gender
            // 
            this.addemployee_gender.FormattingEnabled = true;
            this.addemployee_gender.Items.AddRange(new object[] {
            "male",
            "famel"});
            this.addemployee_gender.Location = new System.Drawing.Point(47, 181);
            this.addemployee_gender.Name = "addemployee_gender";
            this.addemployee_gender.Size = new System.Drawing.Size(205, 24);
            this.addemployee_gender.TabIndex = 5;
            // 
            // addemployee_position
            // 
            this.addemployee_position.FormattingEnabled = true;
            this.addemployee_position.Items.AddRange(new object[] {
            "Business Management",
            "Front-End Developer",
            "Back-End Developer",
            "Data Adminstrator"});
            this.addemployee_position.Location = new System.Drawing.Point(313, 118);
            this.addemployee_position.Name = "addemployee_position";
            this.addemployee_position.Size = new System.Drawing.Size(205, 24);
            this.addemployee_position.TabIndex = 6;
            // 
            // addemployee_image
            // 
            this.addemployee_image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addemployee_image.Location = new System.Drawing.Point(585, 52);
            this.addemployee_image.Name = "addemployee_image";
            this.addemployee_image.Size = new System.Drawing.Size(133, 107);
            this.addemployee_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addemployee_image.TabIndex = 7;
            this.addemployee_image.TabStop = false;
            // 
            // addemployee_importp
            // 
            this.addemployee_importp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addemployee_importp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addemployee_importp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addemployee_importp.Location = new System.Drawing.Point(610, 165);
            this.addemployee_importp.Name = "addemployee_importp";
            this.addemployee_importp.Size = new System.Drawing.Size(86, 34);
            this.addemployee_importp.TabIndex = 8;
            this.addemployee_importp.Text = "import";
            this.addemployee_importp.UseVisualStyleBackColor = false;
            this.addemployee_importp.Click += new System.EventHandler(this.addemployee_importp_Click);
            // 
            // AddEmployee_Addbtn
            // 
            this.AddEmployee_Addbtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AddEmployee_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee_Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_Addbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddEmployee_Addbtn.Location = new System.Drawing.Point(101, 238);
            this.AddEmployee_Addbtn.Name = "AddEmployee_Addbtn";
            this.AddEmployee_Addbtn.Size = new System.Drawing.Size(109, 46);
            this.AddEmployee_Addbtn.TabIndex = 9;
            this.AddEmployee_Addbtn.Text = "Add";
            this.AddEmployee_Addbtn.UseVisualStyleBackColor = false;
            this.AddEmployee_Addbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEmployee_Update
            // 
            this.AddEmployee_Update.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AddEmployee_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddEmployee_Update.Location = new System.Drawing.Point(239, 238);
            this.AddEmployee_Update.Name = "AddEmployee_Update";
            this.AddEmployee_Update.Size = new System.Drawing.Size(111, 46);
            this.AddEmployee_Update.TabIndex = 10;
            this.AddEmployee_Update.Text = "Update";
            this.AddEmployee_Update.UseVisualStyleBackColor = false;
            this.AddEmployee_Update.Click += new System.EventHandler(this.AddEmployee_Update_Click);
            // 
            // AddEmployee_delete
            // 
            this.AddEmployee_delete.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AddEmployee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddEmployee_delete.Location = new System.Drawing.Point(382, 238);
            this.AddEmployee_delete.Name = "AddEmployee_delete";
            this.AddEmployee_delete.Size = new System.Drawing.Size(111, 46);
            this.AddEmployee_delete.TabIndex = 11;
            this.AddEmployee_delete.Text = "delete";
            this.AddEmployee_delete.UseVisualStyleBackColor = false;
            this.AddEmployee_delete.Click += new System.EventHandler(this.AddEmployee_delete_Click);
            // 
            // AddEmployee_clear
            // 
            this.AddEmployee_clear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AddEmployee_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee_clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddEmployee_clear.Location = new System.Drawing.Point(525, 238);
            this.AddEmployee_clear.Name = "AddEmployee_clear";
            this.AddEmployee_clear.Size = new System.Drawing.Size(111, 46);
            this.AddEmployee_clear.TabIndex = 12;
            this.AddEmployee_clear.Text = "cleare";
            this.AddEmployee_clear.UseVisualStyleBackColor = false;
            this.AddEmployee_clear.Click += new System.EventHandler(this.AddEmployee_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Full  Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Postion";
            // 
            // addemployee_status
            // 
            this.addemployee_status.FormattingEnabled = true;
            this.addemployee_status.Items.AddRange(new object[] {
            "Active",
            "unactive"});
            this.addemployee_status.Location = new System.Drawing.Point(313, 181);
            this.addemployee_status.Name = "addemployee_status";
            this.addemployee_status.Size = new System.Drawing.Size(205, 24);
            this.addemployee_status.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.addemployee_status);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.AddEmployee_clear);
            this.panel.Controls.Add(this.AddEmployee_delete);
            this.panel.Controls.Add(this.AddEmployee_Update);
            this.panel.Controls.Add(this.AddEmployee_Addbtn);
            this.panel.Controls.Add(this.addemployee_importp);
            this.panel.Controls.Add(this.addemployee_image);
            this.panel.Controls.Add(this.addemployee_position);
            this.panel.Controls.Add(this.addemployee_gender);
            this.panel.Controls.Add(this.addemployee_phone);
            this.panel.Controls.Add(this.addemployee_fullname);
            this.panel.Controls.Add(this.addemployee_id);
            this.panel.Location = new System.Drawing.Point(27, 261);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(786, 298);
            this.panel.TabIndex = 20;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.Location = new System.Drawing.Point(15, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(752, 197);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "Employee,s Data";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(27, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 242);
            this.panel1.TabIndex = 22;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(851, 572);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addemployee_image)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox addemployee_id;
        private System.Windows.Forms.TextBox addemployee_fullname;
        private System.Windows.Forms.TextBox addemployee_phone;
        private System.Windows.Forms.ComboBox addemployee_gender;
        private System.Windows.Forms.ComboBox addemployee_position;
        private System.Windows.Forms.PictureBox addemployee_image;
        private System.Windows.Forms.Button addemployee_importp;
        private System.Windows.Forms.Button AddEmployee_Addbtn;
        private System.Windows.Forms.Button AddEmployee_Update;
        private System.Windows.Forms.Button AddEmployee_delete;
        private System.Windows.Forms.Button AddEmployee_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addemployee_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}
