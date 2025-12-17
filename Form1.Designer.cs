namespace Pizza_Project
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
            this.frmMain = new System.Windows.Forms.Label();
            this.chkBox1 = new System.Windows.Forms.CheckBox();
            this.chkBox3 = new System.Windows.Forms.CheckBox();
            this.chkBox2 = new System.Windows.Forms.CheckBox();
            this.grBoxToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.grBoxSize = new System.Windows.Forms.GroupBox();
            this.grBoxCrust = new System.Windows.Forms.GroupBox();
            this.rdThick = new System.Windows.Forms.RadioButton();
            this.rdThin = new System.Windows.Forms.RadioButton();
            this.rdIn = new System.Windows.Forms.RadioButton();
            this.rdTakeOut = new System.Windows.Forms.RadioButton();
            this.grEatPlace = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbTopping = new System.Windows.Forms.Label();
            this.lbCrust = new System.Windows.Forms.Label();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grBoxToppings.SuspendLayout();
            this.grBoxSize.SuspendLayout();
            this.grBoxCrust.SuspendLayout();
            this.grEatPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.frmMain.AutoSize = true;
            this.frmMain.BackColor = System.Drawing.SystemColors.Control;
            this.frmMain.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.frmMain.Location = new System.Drawing.Point(200, 29);
            this.frmMain.Name = "frmMain";
            this.frmMain.Size = new System.Drawing.Size(439, 59);
            this.frmMain.TabIndex = 0;
            this.frmMain.Text = "Make Your Pizza";
            // 
            // chkBox1
            // 
            this.chkBox1.AutoSize = true;
            this.chkBox1.Location = new System.Drawing.Point(36, 24);
            this.chkBox1.Name = "chkBox1";
            this.chkBox1.Size = new System.Drawing.Size(109, 20);
            this.chkBox1.TabIndex = 1;
            this.chkBox1.Text = "Extra Cheese";
            this.chkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkBox1.UseVisualStyleBackColor = true;
            this.chkBox1.CheckedChanged += new System.EventHandler(this.chkBox1_CheckedChanged);
            // 
            // chkBox3
            // 
            this.chkBox3.AutoSize = true;
            this.chkBox3.Location = new System.Drawing.Point(36, 114);
            this.chkBox3.Name = "chkBox3";
            this.chkBox3.Size = new System.Drawing.Size(91, 20);
            this.chkBox3.TabIndex = 2;
            this.chkBox3.Text = "Tomatoes";
            this.chkBox3.UseVisualStyleBackColor = true;
            this.chkBox3.CheckedChanged += new System.EventHandler(this.chkBox3_CheckedChanged);
            // 
            // chkBox2
            // 
            this.chkBox2.AutoSize = true;
            this.chkBox2.Location = new System.Drawing.Point(36, 67);
            this.chkBox2.Name = "chkBox2";
            this.chkBox2.Size = new System.Drawing.Size(99, 20);
            this.chkBox2.TabIndex = 3;
            this.chkBox2.Text = "Mushrooms";
            this.chkBox2.UseVisualStyleBackColor = true;
            this.chkBox2.CheckedChanged += new System.EventHandler(this.chkBox2_CheckedChanged);
            // 
            // grBoxToppings
            // 
            this.grBoxToppings.Controls.Add(this.chkGreenPappers);
            this.grBoxToppings.Controls.Add(this.chkOlives);
            this.grBoxToppings.Controls.Add(this.chkOnion);
            this.grBoxToppings.Controls.Add(this.chkBox2);
            this.grBoxToppings.Controls.Add(this.chkBox3);
            this.grBoxToppings.Controls.Add(this.chkBox1);
            this.grBoxToppings.Location = new System.Drawing.Point(226, 122);
            this.grBoxToppings.Name = "grBoxToppings";
            this.grBoxToppings.Size = new System.Drawing.Size(340, 167);
            this.grBoxToppings.TabIndex = 4;
            this.grBoxToppings.TabStop = false;
            this.grBoxToppings.Text = "Toppings";
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Location = new System.Drawing.Point(215, 114);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPappers.TabIndex = 6;
            this.chkGreenPappers.Text = "Green Peppers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkGreenPappers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(214, 63);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 5;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(214, 24);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 4;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(27, 28);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 5;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(27, 63);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Location = new System.Drawing.Point(27, 97);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(55, 20);
            this.rbLarg.TabIndex = 7;
            this.rbLarg.TabStop = true;
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // grBoxSize
            // 
            this.grBoxSize.Controls.Add(this.rbLarg);
            this.grBoxSize.Controls.Add(this.rbMedium);
            this.grBoxSize.Controls.Add(this.rbSmall);
            this.grBoxSize.Location = new System.Drawing.Point(28, 122);
            this.grBoxSize.Name = "grBoxSize";
            this.grBoxSize.Size = new System.Drawing.Size(167, 158);
            this.grBoxSize.TabIndex = 8;
            this.grBoxSize.TabStop = false;
            this.grBoxSize.Text = "Size";
            // 
            // grBoxCrust
            // 
            this.grBoxCrust.Controls.Add(this.rdThick);
            this.grBoxCrust.Controls.Add(this.rdThin);
            this.grBoxCrust.Location = new System.Drawing.Point(74, 316);
            this.grBoxCrust.Name = "grBoxCrust";
            this.grBoxCrust.Size = new System.Drawing.Size(191, 130);
            this.grBoxCrust.TabIndex = 9;
            this.grBoxCrust.TabStop = false;
            this.grBoxCrust.Text = "Crust Type";
            // 
            // rdThick
            // 
            this.rdThick.AutoSize = true;
            this.rdThick.Location = new System.Drawing.Point(34, 74);
            this.rdThick.Name = "rdThick";
            this.rdThick.Size = new System.Drawing.Size(94, 20);
            this.rdThick.TabIndex = 1;
            this.rdThick.TabStop = true;
            this.rdThick.Text = "Thick Crust";
            this.rdThick.UseVisualStyleBackColor = true;
            this.rdThick.CheckedChanged += new System.EventHandler(this.rdThick_CheckedChanged);
            // 
            // rdThin
            // 
            this.rdThin.AutoSize = true;
            this.rdThin.Location = new System.Drawing.Point(34, 33);
            this.rdThin.Name = "rdThin";
            this.rdThin.Size = new System.Drawing.Size(87, 20);
            this.rdThin.TabIndex = 0;
            this.rdThin.TabStop = true;
            this.rdThin.Text = "Thin Crust";
            this.rdThin.UseVisualStyleBackColor = true;
            this.rdThin.CheckedChanged += new System.EventHandler(this.rdThin_CheckedChanged);
            // 
            // rdIn
            // 
            this.rdIn.AutoSize = true;
            this.rdIn.Location = new System.Drawing.Point(41, 28);
            this.rdIn.Name = "rdIn";
            this.rdIn.Size = new System.Drawing.Size(61, 20);
            this.rdIn.TabIndex = 10;
            this.rdIn.TabStop = true;
            this.rdIn.Text = "Eat In";
            this.rdIn.UseVisualStyleBackColor = true;
            this.rdIn.CheckedChanged += new System.EventHandler(this.rdIn_CheckedChanged);
            // 
            // rdTakeOut
            // 
            this.rdTakeOut.AutoSize = true;
            this.rdTakeOut.Location = new System.Drawing.Point(124, 28);
            this.rdTakeOut.Name = "rdTakeOut";
            this.rdTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rdTakeOut.TabIndex = 12;
            this.rdTakeOut.TabStop = true;
            this.rdTakeOut.Text = "Take Out";
            this.rdTakeOut.UseVisualStyleBackColor = true;
            this.rdTakeOut.CheckedChanged += new System.EventHandler(this.rdTakeOut_CheckedChanged);
            // 
            // grEatPlace
            // 
            this.grEatPlace.Controls.Add(this.rdTakeOut);
            this.grEatPlace.Controls.Add(this.rdIn);
            this.grEatPlace.Location = new System.Drawing.Point(310, 316);
            this.grEatPlace.Name = "grEatPlace";
            this.grEatPlace.Size = new System.Drawing.Size(231, 69);
            this.grEatPlace.TabIndex = 13;
            this.grEatPlace.TabStop = false;
            this.grEatPlace.Text = "Where To Eat";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(310, 403);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(102, 35);
            this.btnOrder.TabIndex = 14;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(461, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset From";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Location = new System.Drawing.Point(588, 106);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(101, 16);
            this.lbOrder.TabIndex = 16;
            this.lbOrder.Text = "Order Summary";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(598, 146);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(53, 19);
            this.lbSize.TabIndex = 17;
            this.lbSize.Text = "Size :";
            // 
            // lbTopping
            // 
            this.lbTopping.AutoSize = true;
            this.lbTopping.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopping.Location = new System.Drawing.Point(598, 185);
            this.lbTopping.Name = "lbTopping";
            this.lbTopping.Size = new System.Drawing.Size(92, 19);
            this.lbTopping.TabIndex = 18;
            this.lbTopping.Text = "Toppings :";
            // 
            // lbCrust
            // 
            this.lbCrust.AutoSize = true;
            this.lbCrust.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrust.Location = new System.Drawing.Point(598, 252);
            this.lbCrust.Name = "lbCrust";
            this.lbCrust.Size = new System.Drawing.Size(106, 19);
            this.lbCrust.TabIndex = 19;
            this.lbCrust.Text = "Crust Type :";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(598, 296);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(127, 19);
            this.lbWhereToEat.TabIndex = 20;
            this.lbWhereToEat.Text = "Where To Eat :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(598, 390);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(103, 19);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "Total Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 189);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "No Toppings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(708, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 48);
            this.label5.TabIndex = 26;
            this.label5.Text = "$0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbWhereToEat);
            this.Controls.Add(this.lbCrust);
            this.Controls.Add(this.lbTopping);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.grEatPlace);
            this.Controls.Add(this.grBoxCrust);
            this.Controls.Add(this.grBoxSize);
            this.Controls.Add(this.grBoxToppings);
            this.Controls.Add(this.frmMain);
            this.Name = "Form1";
            this.Text = "Pizza Order";
            this.grBoxToppings.ResumeLayout(false);
            this.grBoxToppings.PerformLayout();
            this.grBoxSize.ResumeLayout(false);
            this.grBoxSize.PerformLayout();
            this.grBoxCrust.ResumeLayout(false);
            this.grBoxCrust.PerformLayout();
            this.grEatPlace.ResumeLayout(false);
            this.grEatPlace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmMain;
        private System.Windows.Forms.CheckBox chkBox1;
        private System.Windows.Forms.CheckBox chkBox3;
        private System.Windows.Forms.CheckBox chkBox2;
        private System.Windows.Forms.GroupBox grBoxToppings;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.GroupBox grBoxSize;
        private System.Windows.Forms.GroupBox grBoxCrust;
        private System.Windows.Forms.RadioButton rdThick;
        private System.Windows.Forms.RadioButton rdThin;
        private System.Windows.Forms.RadioButton rdIn;
        private System.Windows.Forms.RadioButton rdTakeOut;
        private System.Windows.Forms.GroupBox grEatPlace;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbTopping;
        private System.Windows.Forms.Label lbCrust;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

