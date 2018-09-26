namespace Cash_Register
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.receipt = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.Label();
            this.burgerCounter = new System.Windows.Forms.TextBox();
            this.drinkCounter = new System.Windows.Forms.TextBox();
            this.fryCounter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 51);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.receipt);
            this.panel2.Location = new System.Drawing.Point(206, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 307);
            this.panel2.TabIndex = 1;
            // 
            // receipt
            // 
            this.receipt.AutoSize = true;
            this.receipt.Location = new System.Drawing.Point(12, 32);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(0, 13);
            this.receipt.TabIndex = 0;
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
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 393);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(178, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.button2_Click);
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
            this.subtotal.Location = new System.Drawing.Point(20, 203);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(0, 13);
            this.subtotal.TabIndex = 9;
            // 
            // burgerCounter
            // 
            this.burgerCounter.Location = new System.Drawing.Point(126, 83);
            this.burgerCounter.Name = "burgerCounter";
            this.burgerCounter.Size = new System.Drawing.Size(38, 20);
            this.burgerCounter.TabIndex = 1;
            // 
            // drinkCounter
            // 
            this.drinkCounter.Location = new System.Drawing.Point(126, 136);
            this.drinkCounter.Name = "drinkCounter";
            this.drinkCounter.Size = new System.Drawing.Size(38, 20);
            this.drinkCounter.TabIndex = 10;
            // 
            // fryCounter
            // 
            this.fryCounter.Location = new System.Drawing.Point(126, 110);
            this.fryCounter.Name = "fryCounter";
            this.fryCounter.Size = new System.Drawing.Size(38, 20);
            this.fryCounter.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 429);
            this.Controls.Add(this.fryCounter);
            this.Controls.Add(this.drinkCounter);
            this.Controls.Add(this.burgerCounter);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.order);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.TextBox burgerCounter;
        private System.Windows.Forms.TextBox drinkCounter;
        private System.Windows.Forms.TextBox fryCounter;
    }
}

