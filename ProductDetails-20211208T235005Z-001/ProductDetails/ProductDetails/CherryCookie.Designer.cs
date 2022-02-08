
namespace ProductDetails
{
    partial class CherryCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CherryCookie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CherryCookieLabel = new System.Windows.Forms.Label();
            this.cherryType = new System.Windows.Forms.Label();
            this.cherryPrice = new System.Windows.Forms.Label();
            this.cherryDescription = new System.Windows.Forms.Label();
            this.cherryIngredients = new System.Windows.Forms.Label();
            this.cherryBack = new System.Windows.Forms.Button();
            this.cherryAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CherryCookieLabel
            // 
            this.CherryCookieLabel.AutoSize = true;
            this.CherryCookieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CherryCookieLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CherryCookieLabel.Location = new System.Drawing.Point(537, 45);
            this.CherryCookieLabel.Name = "CherryCookieLabel";
            this.CherryCookieLabel.Size = new System.Drawing.Size(149, 25);
            this.CherryCookieLabel.TabIndex = 1;
            this.CherryCookieLabel.Text = "Cherry Cookie";
            // 
            // cherryType
            // 
            this.cherryType.AutoSize = true;
            this.cherryType.Location = new System.Drawing.Point(540, 105);
            this.cherryType.Name = "cherryType";
            this.cherryType.Size = new System.Drawing.Size(70, 13);
            this.cherryType.TabIndex = 2;
            this.cherryType.Text = "Type: Cookie";
            // 
            // cherryPrice
            // 
            this.cherryPrice.AutoSize = true;
            this.cherryPrice.Location = new System.Drawing.Point(539, 141);
            this.cherryPrice.Name = "cherryPrice";
            this.cherryPrice.Size = new System.Drawing.Size(61, 13);
            this.cherryPrice.TabIndex = 3;
            this.cherryPrice.Text = "Price: $!.25";
            this.cherryPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // cherryDescription
            // 
            this.cherryDescription.AutoSize = true;
            this.cherryDescription.Location = new System.Drawing.Point(541, 210);
            this.cherryDescription.Name = "cherryDescription";
            this.cherryDescription.Size = new System.Drawing.Size(256, 26);
            this.cherryDescription.TabIndex = 4;
            this.cherryDescription.Text = "Description: Cherry cookies made with fresh cherries \r\nfrom local farm markets. ";
            // 
            // cherryIngredients
            // 
            this.cherryIngredients.AutoSize = true;
            this.cherryIngredients.Location = new System.Drawing.Point(541, 262);
            this.cherryIngredients.Name = "cherryIngredients";
            this.cherryIngredients.Size = new System.Drawing.Size(222, 39);
            this.cherryIngredients.TabIndex = 5;
            this.cherryIngredients.Text = "Ingredients: cherries, eggs. flour, sugar, butter\r\nvanilla\r\n\r\n";
            // 
            // cherryBack
            // 
            this.cherryBack.Location = new System.Drawing.Point(543, 334);
            this.cherryBack.Name = "cherryBack";
            this.cherryBack.Size = new System.Drawing.Size(75, 23);
            this.cherryBack.TabIndex = 6;
            this.cherryBack.Text = "Back";
            this.cherryBack.UseVisualStyleBackColor = true;
            this.cherryBack.Click += new System.EventHandler(this.cherryBack_Click);
            // 
            // cherryAdd
            // 
            this.cherryAdd.Location = new System.Drawing.Point(669, 335);
            this.cherryAdd.Name = "cherryAdd";
            this.cherryAdd.Size = new System.Drawing.Size(75, 23);
            this.cherryAdd.TabIndex = 7;
            this.cherryAdd.Text = "button2";
            this.cherryAdd.UseVisualStyleBackColor = true;
            // 
            // CherryCookie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cherryAdd);
            this.Controls.Add(this.cherryBack);
            this.Controls.Add(this.cherryIngredients);
            this.Controls.Add(this.cherryDescription);
            this.Controls.Add(this.cherryPrice);
            this.Controls.Add(this.cherryType);
            this.Controls.Add(this.CherryCookieLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CherryCookie";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CherryCookieLabel;
        private System.Windows.Forms.Label cherryType;
        private System.Windows.Forms.Label cherryPrice;
        private System.Windows.Forms.Label cherryDescription;
        private System.Windows.Forms.Label cherryIngredients;
        private System.Windows.Forms.Button cherryBack;
        private System.Windows.Forms.Button cherryAdd;
    }
}