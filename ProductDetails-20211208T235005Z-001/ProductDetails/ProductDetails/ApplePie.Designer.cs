
namespace ProductDetails
{
    partial class ApplePie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplePie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.appleDescription = new System.Windows.Forms.Label();
            this.appleIngredients = new System.Windows.Forms.Label();
            this.appleBack = new System.Windows.Forms.Button();
            this.appleAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apple Pie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:  Pie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price: $9.50";
            // 
            // appleDescription
            // 
            this.appleDescription.AutoSize = true;
            this.appleDescription.Location = new System.Drawing.Point(539, 209);
            this.appleDescription.Name = "appleDescription";
            this.appleDescription.Size = new System.Drawing.Size(242, 26);
            this.appleDescription.TabIndex = 4;
            this.appleDescription.Text = "Description: Classic apple pie made with three \r\ndifferent kinds of apple. Made w" +
    "ith a  golden crust\r\n";
            // 
            // appleIngredients
            // 
            this.appleIngredients.AutoSize = true;
            this.appleIngredients.Location = new System.Drawing.Point(542, 258);
            this.appleIngredients.Name = "appleIngredients";
            this.appleIngredients.Size = new System.Drawing.Size(209, 26);
            this.appleIngredients.TabIndex = 5;
            this.appleIngredients.Text = "Ingredients: apples, cinnamon, sugar, flour,\r\neggs, butter";
            // 
            // appleBack
            // 
            this.appleBack.Location = new System.Drawing.Point(542, 348);
            this.appleBack.Name = "appleBack";
            this.appleBack.Size = new System.Drawing.Size(75, 23);
            this.appleBack.TabIndex = 6;
            this.appleBack.Text = "Back";
            this.appleBack.UseVisualStyleBackColor = true;
            // 
            // appleAdd
            // 
            this.appleAdd.Location = new System.Drawing.Point(657, 348);
            this.appleAdd.Name = "appleAdd";
            this.appleAdd.Size = new System.Drawing.Size(75, 23);
            this.appleAdd.TabIndex = 7;
            this.appleAdd.Text = "Add to Cart";
            this.appleAdd.UseVisualStyleBackColor = true;
            // 
            // ApplePie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appleAdd);
            this.Controls.Add(this.appleBack);
            this.Controls.Add(this.appleIngredients);
            this.Controls.Add(this.appleDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ApplePie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label appleDescription;
        private System.Windows.Forms.Label appleIngredients;
        private System.Windows.Forms.Button appleBack;
        private System.Windows.Forms.Button appleAdd;
    }
}