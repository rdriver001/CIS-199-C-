namespace Program1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            seniorBox = new TextBox();
            staffBox = new TextBox();
            partCostBox = new TextBox();
            workHoursBox = new TextBox();
            carTypeBox = new TextBox();
            clientNameBox = new TextBox();
            button1 = new Button();
            label7 = new Label();
            costBox = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Client Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Car Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Work Hours:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Parts Cost:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 134);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Staff Assigned:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 166);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 5;
            label6.Text = "Senior Citizen? (0 or 1):";
            // 
            // seniorBox
            // 
            seniorBox.Location = new Point(145, 163);
            seniorBox.Name = "seniorBox";
            seniorBox.Size = new Size(100, 23);
            seniorBox.TabIndex = 6;
            // 
            // staffBox
            // 
            staffBox.Location = new Point(145, 131);
            staffBox.Name = "staffBox";
            staffBox.Size = new Size(100, 23);
            staffBox.TabIndex = 7;
            // 
            // partCostBox
            // 
            partCostBox.Location = new Point(145, 100);
            partCostBox.Name = "partCostBox";
            partCostBox.Size = new Size(100, 23);
            partCostBox.TabIndex = 8;
            // 
            // workHoursBox
            // 
            workHoursBox.Location = new Point(145, 69);
            workHoursBox.Name = "workHoursBox";
            workHoursBox.Size = new Size(100, 23);
            workHoursBox.TabIndex = 9;
            // 
            // carTypeBox
            // 
            carTypeBox.Location = new Point(145, 37);
            carTypeBox.Name = "carTypeBox";
            carTypeBox.Size = new Size(100, 23);
            carTypeBox.TabIndex = 10;
            // 
            // clientNameBox
            // 
            clientNameBox.Location = new Point(145, 6);
            clientNameBox.Name = "clientNameBox";
            clientNameBox.Size = new Size(100, 23);
            clientNameBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(69, 213);
            button1.Name = "button1";
            button1.Size = new Size(103, 24);
            button1.TabIndex = 12;
            button1.Text = "Get Quote!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 256);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 13;
            label7.Text = "Total Cost:";
            // 
            // costBox
            // 
            costBox.BorderStyle = BorderStyle.FixedSingle;
            costBox.Location = new Point(145, 255);
            costBox.Name = "costBox";
            costBox.Size = new Size(101, 21);
            costBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 369);
            Controls.Add(costBox);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(clientNameBox);
            Controls.Add(carTypeBox);
            Controls.Add(workHoursBox);
            Controls.Add(partCostBox);
            Controls.Add(staffBox);
            Controls.Add(seniorBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox seniorBox;
        private TextBox staffBox;
        private TextBox partCostBox;
        private TextBox workHoursBox;
        private TextBox carTypeBox;
        private TextBox clientNameBox;
        private Button button1;
        private Label label7;
        private Label costBox;
    }
}
