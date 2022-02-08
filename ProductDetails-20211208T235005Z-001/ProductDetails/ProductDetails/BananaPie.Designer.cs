
namespace ProductDetails
{
    partial class BananaPie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BananaPie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bananaPieType = new System.Windows.Forms.Label();
            this.bananaType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bananaDescription = new System.Windows.Forms.Label();
            this.bananaIngredients = new System.Windows.Forms.Label();
            this.bananaBack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bananaPieType
            // 
            this.bananaPieType.AutoSize = true;
            this.bananaPieType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bananaPieType.Location = new System.Drawing.Point(500, 64);
            this.bananaPieType.Name = "bananaPieType";
            this.bananaPieType.Size = new System.Drawing.Size(123, 25);
            this.bananaPieType.TabIndex = 1;
            this.bananaPieType.Text = "Banana Pie";
            // 
            // bananaType
            // 
            this.bananaType.AutoSize = true;
            this.bananaType.Location = new System.Drawing.Point(502, 118);
            this.bananaType.Name = "bananaType";
            this.bananaType.Size = new System.Drawing.Size(52, 13);
            this.bananaType.TabIndex = 2;
            this.bananaType.Text = "Type: Pie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price: $9.99";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bananaDescription
            // 
            this.bananaDescription.AutoSize = true;
            this.bananaDescription.Location = new System.Drawing.Point(505, 209);
            this.bananaDescription.Name = "bananaDescription";
            this.bananaDescription.Size = new System.Drawing.Size(272, 26);
            this.bananaDescription.TabIndex = 4;
            this.bananaDescription.Text = "Description: Banana pie with whipped cream on top with\r\nwhite flour\r\n";
            this.bananaDescription.Click += new System.EventHandler(this.bananaDescription_Click);
            // 
            // bananaIngredients
            // 
            this.bananaIngredients.AutoSize = true;
            this.bananaIngredients.Location = new System.Drawing.Point(505, 284);
            this.bananaIngredients.Name = "bananaIngredients";
            this.bananaIngredients.Size = new System.Drawing.Size(257, 26);
            this.bananaIngredients.TabIndex = 5;
            this.bananaIngredients.Text = "Ingerdients: Bananas, eggs, flour, sugar, whip cream,\r\nvanilla\r\n";
            // 
            // bananaBack
            // 
            this.bananaBack.Location = new System.Drawing.Point(508, 382);
            this.bananaBack.Name = "bananaBack";
            this.bananaBack.Size = new System.Drawing.Size(75, 23);
            this.bananaBack.TabIndex = 6;
            this.bananaBack.Text = "Back";
            this.bananaBack.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add to Cart";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BananaPie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bananaBack);
            this.Controls.Add(this.bananaIngredients);
            this.Controls.Add(this.bananaDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bananaType);
            this.Controls.Add(this.bananaPieType);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BananaPie";
            this.Text = "BananaPie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bananaPieType;
        private System.Windows.Forms.Label bananaType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bananaDescription;
        private System.Windows.Forms.Label bananaIngredients;
        private System.Windows.Forms.Button bananaBack;
        private System.Windows.Forms.Button button2;
    }
}