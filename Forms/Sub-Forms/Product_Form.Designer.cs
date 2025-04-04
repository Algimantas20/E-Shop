namespace E_Shop.Forms.Sub_Forms
{
    partial class Product_Form
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
            this.back_Button = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.product_Panel = new E_Shop.Components.A_Panel();
            this.editProduct_Button = new E_Shop.Components.A_Button();
            this.purchase_button = new E_Shop.Components.A_Button();
            this.price_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.title_Label = new System.Windows.Forms.Label();
            this.product_PictureBox = new System.Windows.Forms.PictureBox();
            this.product_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.AutoSize = true;
            this.back_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_Button.Location = new System.Drawing.Point(13, 9);
            this.back_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(24, 25);
            this.back_Button.TabIndex = 5;
            this.back_Button.Text = "<";
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(961, 9);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(26, 25);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "X";
            // 
            // product_Panel
            // 
            this.product_Panel.BackColor = System.Drawing.Color.White;
            this.product_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.product_Panel.BorderRadius = 15;
            this.product_Panel.BorderSize = 2;
            this.product_Panel.Controls.Add(this.editProduct_Button);
            this.product_Panel.Controls.Add(this.purchase_button);
            this.product_Panel.Controls.Add(this.price_label);
            this.product_Panel.Controls.Add(this.description_label);
            this.product_Panel.Controls.Add(this.title_Label);
            this.product_Panel.Controls.Add(this.product_PictureBox);
            this.product_Panel.Location = new System.Drawing.Point(16, 40);
            this.product_Panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_Panel.Name = "product_Panel";
            this.product_Panel.Size = new System.Drawing.Size(971, 547);
            this.product_Panel.TabIndex = 6;
            // 
            // editProduct_Button
            // 
            this.editProduct_Button.BackColor = System.Drawing.Color.LightGray;
            this.editProduct_Button.BackgroundColor = System.Drawing.Color.LightGray;
            this.editProduct_Button.BorderColor = System.Drawing.Color.Black;
            this.editProduct_Button.BorderRadius = 20;
            this.editProduct_Button.BorderSize = 0;
            this.editProduct_Button.FlatAppearance.BorderSize = 0;
            this.editProduct_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProduct_Button.ForeColor = System.Drawing.Color.Black;
            this.editProduct_Button.Location = new System.Drawing.Point(23, 489);
            this.editProduct_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editProduct_Button.Name = "editProduct_Button";
            this.editProduct_Button.Size = new System.Drawing.Size(200, 49);
            this.editProduct_Button.TabIndex = 5;
            this.editProduct_Button.Text = "Edit Product";
            this.editProduct_Button.TextColor = System.Drawing.Color.Black;
            this.editProduct_Button.UseVisualStyleBackColor = false;
            // 
            // purchase_button
            // 
            this.purchase_button.BackColor = System.Drawing.Color.LightGray;
            this.purchase_button.BackgroundColor = System.Drawing.Color.LightGray;
            this.purchase_button.BorderColor = System.Drawing.Color.Black;
            this.purchase_button.BorderRadius = 20;
            this.purchase_button.BorderSize = 0;
            this.purchase_button.FlatAppearance.BorderSize = 0;
            this.purchase_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchase_button.ForeColor = System.Drawing.Color.Black;
            this.purchase_button.Location = new System.Drawing.Point(754, 489);
            this.purchase_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.purchase_button.Name = "purchase_button";
            this.purchase_button.Size = new System.Drawing.Size(200, 49);
            this.purchase_button.TabIndex = 4;
            this.purchase_button.Text = "Purchase";
            this.purchase_button.TextColor = System.Drawing.Color.Black;
            this.purchase_button.UseVisualStyleBackColor = false;
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.price_label.Location = new System.Drawing.Point(19, 369);
            this.price_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(350, 27);
            this.price_label.TabIndex = 3;
            this.price_label.Text = "Price";
            // 
            // description_label
            // 
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.Location = new System.Drawing.Point(381, 79);
            this.description_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(522, 286);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "Description";
            // 
            // title_Label
            // 
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.Location = new System.Drawing.Point(377, 15);
            this.title_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(526, 62);
            this.title_Label.TabIndex = 1;
            this.title_Label.Text = "Title";
            this.title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_PictureBox
            // 
            this.product_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.product_PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.product_PictureBox.Location = new System.Drawing.Point(19, 15);
            this.product_PictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.product_PictureBox.Name = "product_PictureBox";
            this.product_PictureBox.Size = new System.Drawing.Size(350, 350);
            this.product_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PictureBox.TabIndex = 0;
            this.product_PictureBox.TabStop = false;
            // 
            // Product_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.product_Panel);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Product_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Product_Form";
            this.product_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.product_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label back_Button;
        private System.Windows.Forms.Label exitButton;
        private Components.A_Panel product_Panel;
        private Components.A_Button purchase_button;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.PictureBox product_PictureBox;
        private Components.A_Button editProduct_Button;
    }
}