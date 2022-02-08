
namespace ProductDetails
{
    partial class BlueberryPie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueberryPie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blueberryPieType = new System.Windows.Forms.Label();
            this.blueberrryPrice = new System.Windows.Forms.Label();
            this.blueberrryDescrption = new System.Windows.Forms.Label();
            this.blueberryIngredients = new System.Windows.Forms.Label();
            this.blueberryBack = new System.Windows.Forms.Button();
            this.blueberryAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blueberry Pie\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // blueberryPieType
            // 
            this.blueberryPieType.AutoSize = true;
            this.blueberryPieType.Location = new System.Drawing.Point(551, 136);
            this.blueberryPieType.Name = "blueberryPieType";
            this.blueberryPieType.Size = new System.Drawing.Size(52, 13);
            this.blueberryPieType.TabIndex = 2;
            this.blueberryPieType.Text = "Type: Pie";
            this.blueberryPieType.UseMnemonic = false;
            // 
            // blueberrryPrice
            // 
            this.blueberrryPrice.AutoSize = true;
            this.blueberrryPrice.Location = new System.Drawing.Point(551, 172);
            this.blueberrryPrice.Name = "blueberrryPrice";
            this.blueberrryPrice.Size = new System.Drawing.Size(70, 13);
            this.blueberrryPrice.TabIndex = 3;
            this.blueberrryPrice.Text = "Price: $10.99";
            // 
            // blueberrryDescrption
            // 
            this.blueberrryDescrption.AutoSize = true;
            this.blueberrryDescrption.Location = new System.Drawing.Point(551, 235);
            this.blueberrryDescrption.Name = "blueberrryDescrption";
            this.blueberrryDescrption.Size = new System.Drawing.Size(201, 13);
            this.blueberrryDescrption.TabIndex = 4;
            this.blueberrryDescrption.Text = "Description: Made with fresh blueberries. \r\n";
            // 
            // blueberryIngredients
            // 
            this.blueberryIngredients.AutoSize = true;
            this.blueberryIngredients.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.blueberryIngredients.Location = new System.Drawing.Point(551, 283);
            this.blueberryIngredients.Name = "blueberryIngredients";
            this.blueberryIngredients.Size = new System.Drawing.Size(210, 26);
            this.blueberryIngredients.TabIndex = 5;
            this.blueberryIngredients.Text = "Ingredients: eggs, flour, butter, blueberries, \r\nsugar, vanilla\r\n";
            // 
            // blueberryBack
            // 
            this.blueberryBack.Location = new System.Drawing.Point(554, 376);
            this.blueberryBack.Name = "blueberryBack";
            this.blueberryBack.Size = new System.Drawing.Size(75, 23);
            this.blueberryBack.TabIndex = 6;
            this.blueberryBack.Text = "Back";
            this.blueberryBack.UseVisualStyleBackColor = true;
            // 
            // blueberryAdd
            // 
            this.blueberryAdd.Location = new System.Drawing.Point(686, 376);
            this.blueberryAdd.Name = "blueberryAdd";
            this.blueberryAdd.Size = new System.Drawing.Size(75, 23);
            this.blueberryAdd.TabIndex = 7;
            this.blueberryAdd.Text = "Add to Cart";
            this.blueberryAdd.UseVisualStyleBackColor = true;
            // 
            // BlueberryPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blueberryAdd);
            this.Controls.Add(this.blueberryBack);
            this.Controls.Add(this.blueberryIngredients);
            this.Controls.Add(this.blueberrryDescrption);
            this.Controls.Add(this.blueberrryPrice);
            this.Controls.Add(this.blueberryPieType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BlueberryPie";
            this.Text = "BlueberryPie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blueberryPieType;
        private System.Windows.Forms.Label blueberrryPrice;
        private System.Windows.Forms.Label blueberrryDescrption;
        private System.Windows.Forms.Label blueberryIngredients;
        private System.Windows.Forms.Button blueberryBack;
        private System.Windows.Forms.Button blueberryAdd;
    }
}