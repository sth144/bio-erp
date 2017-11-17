/************************************************************************************************************
 * Title:
 * Author:
 * Date:
 * Description:
 ************************************************************************************************************/

namespace bioERP
{
    partial class frontEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frontEnd));
            this.productBox = new System.Windows.Forms.ListBox();
            this.submit = new System.Windows.Forms.Button();
            this.componentBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.catalogue = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // productBox
            // 
            this.productBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.productBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBox.FormattingEnabled = true;
            this.productBox.ItemHeight = 14;
            this.productBox.Location = new System.Drawing.Point(361, 158);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(263, 200);
            this.productBox.TabIndex = 0;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(658, 218);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 1;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // componentBox
            // 
            this.componentBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.componentBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentBox.FormattingEnabled = true;
            this.componentBox.ItemHeight = 14;
            this.componentBox.Location = new System.Drawing.Point(770, 126);
            this.componentBox.Name = "componentBox";
            this.componentBox.Size = new System.Drawing.Size(313, 340);
            this.componentBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catalogue Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(767, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(243, 218);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(75, 23);
            this.addToCart.TabIndex = 9;
            this.addToCart.Text = "Add Project";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // catalogue
            // 
            this.catalogue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.catalogue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catalogue.FormattingEnabled = true;
            this.catalogue.ItemHeight = 14;
            this.catalogue.Location = new System.Drawing.Point(34, 158);
            this.catalogue.Name = "catalogue";
            this.catalogue.Size = new System.Drawing.Size(170, 158);
            this.catalogue.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Component Order List Generator";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 359);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // frontEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1118, 559);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.catalogue);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.componentBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.productBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frontEnd";
            this.Text = "bioERP";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox productBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListBox componentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox catalogue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

