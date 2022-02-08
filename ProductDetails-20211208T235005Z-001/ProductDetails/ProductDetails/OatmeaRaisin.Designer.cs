namespace ProductDetails
{
    partial class ChocoCookie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChocoCookie));
            this.productNamelabel = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.Type = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productNamelabel
            // 
            this.productNamelabel.AutoSize = true;
            this.productNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNamelabel.Location = new System.Drawing.Point(452, 40);
            this.productNamelabel.Name = "productNamelabel";
            this.productNamelabel.Size = new System.Drawing.Size(253, 25);
            this.productNamelabel.TabIndex = 0;
            this.productNamelabel.Text = "Chocolate Chip Cookie";
            // 
            // productImage
            // 
            this.productImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.productImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
            this.productImage.Location = new System.Drawing.Point(103, 40);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(257, 338);
            this.productImage.TabIndex = 1;
            this.productImage.TabStop = false;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(458, 101);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(70, 13);
            this.Type.TabIndex = 2;
            this.Type.Text = "Type: Cookie";
            this.Type.Click += new System.EventHandler(this.Type_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(457, 134);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(67, 13);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price:  $1.50";
            this.Price.UseMnemonic = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(457, 214);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(251, 26);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Description: Classic chocalate chip cookies backed\r\nto a golden brown. ";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(631, 355);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "Add to Cart";
            this.addbtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(507, 355);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Calories: 78";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "ingredients: Chocolate chips, flour, sugar, \r\neggs, butter, vanilla\r\n";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.productImage);
            this.Controls.Add(this.productNamelabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Details";
            this.Text = "Details";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
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
    }
}

