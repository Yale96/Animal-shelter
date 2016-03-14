namespace DierenAsiel
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
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.comboBoxAnimals = new System.Windows.Forms.ComboBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblLastWalkDate = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpLastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.tbRegNumber = new System.Windows.Forms.TextBox();
            this.tbInformation = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBoxAddAnimal = new System.Windows.Forms.GroupBox();
            this.listBoxReservedAnimals = new System.Windows.Forms.ListBox();
            this.listBoxUnreservedAnimals = new System.Windows.Forms.ListBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnUnreserve = new System.Windows.Forms.Button();
            this.groupBoxManage = new System.Windows.Forms.GroupBox();
            this.labelReserveUnreserve = new System.Windows.Forms.Label();
            this.groupBoxAddAnimal.SuspendLayout();
            this.groupBoxManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(6, 19);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(104, 23);
            this.btnAddAnimal.TabIndex = 0;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // comboBoxAnimals
            // 
            this.comboBoxAnimals.FormattingEnabled = true;
            this.comboBoxAnimals.Items.AddRange(new object[] {
            "Dog",
            "Cat"});
            this.comboBoxAnimals.Location = new System.Drawing.Point(150, 21);
            this.comboBoxAnimals.Name = "comboBoxAnimals";
            this.comboBoxAnimals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAnimals.TabIndex = 1;
            this.comboBoxAnimals.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimals_SelectedIndexChanged);
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(6, 69);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(104, 13);
            this.lblRegNumber.TabIndex = 2;
            this.lblRegNumber.Text = "Registration number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(6, 198);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfBirth.TabIndex = 5;
            this.lblDateOfBirth.Text = "Date of birth:";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(6, 242);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(62, 13);
            this.lblInformation.TabIndex = 6;
            this.lblInformation.Text = "Information:";
            // 
            // lblLastWalkDate
            // 
            this.lblLastWalkDate.AutoSize = true;
            this.lblLastWalkDate.Location = new System.Drawing.Point(6, 286);
            this.lblLastWalkDate.Name = "lblLastWalkDate";
            this.lblLastWalkDate.Size = new System.Drawing.Size(79, 13);
            this.lblLastWalkDate.TabIndex = 7;
            this.lblLastWalkDate.Text = "Last walk date:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(150, 192);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // dtpLastWalkDate
            // 
            this.dtpLastWalkDate.Location = new System.Drawing.Point(150, 280);
            this.dtpLastWalkDate.Name = "dtpLastWalkDate";
            this.dtpLastWalkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastWalkDate.TabIndex = 9;
            // 
            // tbRegNumber
            // 
            this.tbRegNumber.Location = new System.Drawing.Point(150, 69);
            this.tbRegNumber.Name = "tbRegNumber";
            this.tbRegNumber.Size = new System.Drawing.Size(100, 20);
            this.tbRegNumber.TabIndex = 10;
            // 
            // tbInformation
            // 
            this.tbInformation.Location = new System.Drawing.Point(150, 235);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.Size = new System.Drawing.Size(100, 20);
            this.tbInformation.TabIndex = 11;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(150, 150);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 12;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 13;
            // 
            // groupBoxAddAnimal
            // 
            this.groupBoxAddAnimal.Controls.Add(this.btnAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.tbName);
            this.groupBoxAddAnimal.Controls.Add(this.comboBoxAnimals);
            this.groupBoxAddAnimal.Controls.Add(this.tbPrice);
            this.groupBoxAddAnimal.Controls.Add(this.lblRegNumber);
            this.groupBoxAddAnimal.Controls.Add(this.tbInformation);
            this.groupBoxAddAnimal.Controls.Add(this.lblName);
            this.groupBoxAddAnimal.Controls.Add(this.tbRegNumber);
            this.groupBoxAddAnimal.Controls.Add(this.lblPrice);
            this.groupBoxAddAnimal.Controls.Add(this.dtpLastWalkDate);
            this.groupBoxAddAnimal.Controls.Add(this.lblDateOfBirth);
            this.groupBoxAddAnimal.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxAddAnimal.Controls.Add(this.lblInformation);
            this.groupBoxAddAnimal.Controls.Add(this.lblLastWalkDate);
            this.groupBoxAddAnimal.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddAnimal.Name = "groupBoxAddAnimal";
            this.groupBoxAddAnimal.Size = new System.Drawing.Size(508, 314);
            this.groupBoxAddAnimal.TabIndex = 14;
            this.groupBoxAddAnimal.TabStop = false;
            this.groupBoxAddAnimal.Text = "Add an animal";
            // 
            // listBoxReservedAnimals
            // 
            this.listBoxReservedAnimals.FormattingEnabled = true;
            this.listBoxReservedAnimals.Location = new System.Drawing.Point(551, 247);
            this.listBoxReservedAnimals.Name = "listBoxReservedAnimals";
            this.listBoxReservedAnimals.Size = new System.Drawing.Size(814, 225);
            this.listBoxReservedAnimals.TabIndex = 15;
            // 
            // listBoxUnreservedAnimals
            // 
            this.listBoxUnreservedAnimals.FormattingEnabled = true;
            this.listBoxUnreservedAnimals.Location = new System.Drawing.Point(551, 12);
            this.listBoxUnreservedAnimals.Name = "listBoxUnreservedAnimals";
            this.listBoxUnreservedAnimals.Size = new System.Drawing.Size(814, 225);
            this.listBoxUnreservedAnimals.TabIndex = 16;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(9, 53);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(110, 23);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.Text = "Reserve animal";
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnUnreserve
            // 
            this.btnUnreserve.Location = new System.Drawing.Point(9, 96);
            this.btnUnreserve.Name = "btnUnreserve";
            this.btnUnreserve.Size = new System.Drawing.Size(110, 23);
            this.btnUnreserve.TabIndex = 18;
            this.btnUnreserve.Text = "Unreserve animal";
            this.btnUnreserve.UseVisualStyleBackColor = true;
            // 
            // groupBoxManage
            // 
            this.groupBoxManage.Controls.Add(this.labelReserveUnreserve);
            this.groupBoxManage.Controls.Add(this.btnReserve);
            this.groupBoxManage.Controls.Add(this.btnUnreserve);
            this.groupBoxManage.Location = new System.Drawing.Point(12, 339);
            this.groupBoxManage.Name = "groupBoxManage";
            this.groupBoxManage.Size = new System.Drawing.Size(508, 225);
            this.groupBoxManage.TabIndex = 19;
            this.groupBoxManage.TabStop = false;
            this.groupBoxManage.Text = "Manage animals";
            // 
            // labelReserveUnreserve
            // 
            this.labelReserveUnreserve.AutoSize = true;
            this.labelReserveUnreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReserveUnreserve.Location = new System.Drawing.Point(8, 26);
            this.labelReserveUnreserve.Name = "labelReserveUnreserve";
            this.labelReserveUnreserve.Size = new System.Drawing.Size(497, 13);
            this.labelReserveUnreserve.TabIndex = 19;
            this.labelReserveUnreserve.Text = "NOTE: Select an animal in the listbox before clicking the button Reserve or Unres" +
    "erve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 575);
            this.Controls.Add(this.groupBoxManage);
            this.Controls.Add(this.listBoxUnreservedAnimals);
            this.Controls.Add(this.listBoxReservedAnimals);
            this.Controls.Add(this.groupBoxAddAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxAddAnimal.ResumeLayout(false);
            this.groupBoxAddAnimal.PerformLayout();
            this.groupBoxManage.ResumeLayout(false);
            this.groupBoxManage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ComboBox comboBoxAnimals;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblLastWalkDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpLastWalkDate;
        private System.Windows.Forms.TextBox tbRegNumber;
        private System.Windows.Forms.TextBox tbInformation;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBoxAddAnimal;
        private System.Windows.Forms.ListBox listBoxReservedAnimals;
        private System.Windows.Forms.ListBox listBoxUnreservedAnimals;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnUnreserve;
        private System.Windows.Forms.GroupBox groupBoxManage;
        private System.Windows.Forms.Label labelReserveUnreserve;
    }
}

