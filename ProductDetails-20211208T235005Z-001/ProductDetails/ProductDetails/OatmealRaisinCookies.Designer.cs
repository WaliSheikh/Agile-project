
namespace ProductDetails
{
    partial class OatmealRaisinCookies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OatmealRaisinCookies));
            this.oatmealImage = new System.Windows.Forms.PictureBox();
            this.oatmealLabel = new System.Windows.Forms.Label();
            this.oatmealType = new System.Windows.Forms.Label();
            this.oatmealPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oatmealImage)).BeginInit();
            this.SuspendLayout();
            // 
            // oatmealImage
            // 
            this.oatmealImage.Image = ((System.Drawing.Image)(resources.GetObject("oatmealImage.Image")));
            this.oatmealImage.Location = new System.Drawing.Point(33, 61);
            this.oatmealImage.Name = "oatmealImage";
            this.oatmealImage.Size = new System.Drawing.Size(435, 274);
            this.oatmealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oatmealImage.TabIndex = 0;
            this.oatmealImage.TabStop = false;
            // 
            // oatmealLabel
            // 
            this.oatmealLabel.AutoSize = true;
            this.oatmealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oatmealLabel.Location = new System.Drawing.Point(497, 61);
            this.oatmealLabel.Name = "oatmealLabel";
            this.oatmealLabel.Size = new System.Drawing.Size(242, 25);
            this.oatmealLabel.TabIndex = 1;
            this.oatmealLabel.Text = "Oatmeal Raisin Cookies";
            this.oatmealLabel.Click += new System.EventHandler(this.oatmealLabel_Click);
            // 
            // oatmealType
            // 
            this.oatmealType.AutoSize = true;
            this.oatmealType.Location = new System.Drawing.Point(499, 117);
            this.oatmealType.Name = "oatmealType";
            this.oatmealType.Size = new System.Drawing.Size(70, 13);
            this.oatmealType.TabIndex = 2;
            this.oatmealType.Text = "Type: Cookie";
            this.oatmealType.Click += new System.EventHandler(this.label3_Click);
            // 
            // oatmealPrice
            // 
            this.oatmealPrice.AutoSize = true;
            this.oatmealPrice.Location = new System.Drawing.Point(499, 154);
            this.oatmealPrice.Name = "oatmealPrice";
            this.oatmealPrice.Size = new System.Drawing.Size(64, 13);
            this.oatmealPrice.TabIndex = 3;
            this.oatmealPrice.Text = "Price: $1.75";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calories: 83";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description: Oatmeal Raisin Cookies made with sweet \r\nraisin and ots.\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(664, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrediaents: oatmeal, raisins, sugar, butter, \r\nflour,eggs";
            // 
            // OatmealRaisinCookies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oatmealPrice);
            this.Controls.Add(this.oatmealType);
            this.Controls.Add(this.oatmealLabel);
            this.Controls.Add(this.oatmealImage);
            this.Name = "OatmealRaisinCookies";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.oatmealImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNamelabel;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox oatmealImage;
        private System.Windows.Forms.Label oatmealLabel;
        private System.Windows.Forms.Label oatmealType;
        private System.Windows.Forms.Label oatmealPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}