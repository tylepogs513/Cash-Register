namespace Cash_Register
{
    partial class burgerTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(burgerTown));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.Label();
            this.burgerCounter = new System.Windows.Forms.TextBox();
            this.drinkCounter = new System.Windows.Forms.TextBox();
            this.fryCounter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.print = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tender = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Label();
            this.checkLabel1 = new System.Windows.Forms.Label();
            this.checkLabel2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Burger Town";
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(206, 392);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(235, 24);
            this.order.TabIndex = 0;
            this.order.Text = "New Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Burgers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Fries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Drinks";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(18, 162);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(145, 22);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(25, 187);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(0, 16);
            this.subtotal.TabIndex = 9;
            // 
            // burgerCounter
            // 
            this.burgerCounter.Location = new System.Drawing.Point(126, 83);
            this.burgerCounter.Name = "burgerCounter";
            this.burgerCounter.Size = new System.Drawing.Size(38, 21);
            this.burgerCounter.TabIndex = 1;
            // 
            // drinkCounter
            // 
            this.drinkCounter.Location = new System.Drawing.Point(126, 136);
            this.drinkCounter.Name = "drinkCounter";
            this.drinkCounter.Size = new System.Drawing.Size(38, 21);
            this.drinkCounter.TabIndex = 10;
            // 
            // fryCounter
            // 
            this.fryCounter.Location = new System.Drawing.Point(126, 110);
            this.fryCounter.Name = "fryCounter";
            this.fryCounter.Size = new System.Drawing.Size(38, 21);
            this.fryCounter.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 16);
            this.panel3.TabIndex = 2;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(18, 395);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(145, 22);
            this.print.TabIndex = 12;
            this.print.Text = "Print Receipt";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tendered";
            // 
            // tender
            // 
            this.tender.Location = new System.Drawing.Point(97, 291);
            this.tender.Name = "tender";
            this.tender.Size = new System.Drawing.Size(57, 21);
            this.tender.TabIndex = 14;
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(18, 347);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(145, 22);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(24, 372);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(109, 20);
            this.change.TabIndex = 16;
            this.change.Text = "Change $0.00";
            // 
            // checkLabel1
            // 
            this.checkLabel1.AutoSize = true;
            this.checkLabel1.Location = new System.Drawing.Point(9, 53);
            this.checkLabel1.Name = "checkLabel1";
            this.checkLabel1.Size = new System.Drawing.Size(0, 13);
            this.checkLabel1.TabIndex = 17;
            // 
            // checkLabel2
            // 
            this.checkLabel2.AutoSize = true;
            this.checkLabel2.Location = new System.Drawing.Point(12, 314);
            this.checkLabel2.Name = "checkLabel2";
            this.checkLabel2.Size = new System.Drawing.Size(0, 13);
            this.checkLabel2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(169, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 375);
            this.panel2.TabIndex = 3;
            // 
            // burgerTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.checkLabel2);
            this.Controls.Add(this.checkLabel1);
            this.Controls.Add(this.change);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.print);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.fryCounter);
            this.Controls.Add(this.drinkCounter);
            this.Controls.Add(this.burgerCounter);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.order);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "burgerTown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burger Town";
            this.Load += new System.EventHandler(this.burgerTown_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.TextBox burgerCounter;
        private System.Windows.Forms.TextBox drinkCounter;
        private System.Windows.Forms.TextBox fryCounter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tender;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label checkLabel1;
        private System.Windows.Forms.Label checkLabel2;
        private System.Windows.Forms.Panel panel2;
    }
}

