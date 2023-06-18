﻿namespace IS201_N22_HTCL.UserControls
{
    partial class ShopItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopItem));
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbGenre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbDisc = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(8, 245);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 32);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbGenre
            // 
            this.lbGenre.BackColor = System.Drawing.Color.Transparent;
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbGenre.Location = new System.Drawing.Point(8, 279);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(40, 21);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Genre";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.Image")));
            this.btnAddToCart.Location = new System.Drawing.Point(185, 296);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddToCart.Size = new System.Drawing.Size(33, 32);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddToCart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(8, 306);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(45, 27);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lbPrice);
            this.guna2Panel1.Controls.Add(this.lbName);
            this.guna2Panel1.Controls.Add(this.lbGenre);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(240, 350);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pbDisc
            // 
            this.pbDisc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDisc.BorderRadius = 5;
            this.pbDisc.ImageRotate = 0F;
            this.pbDisc.Location = new System.Drawing.Point(35, 16);
            this.pbDisc.Name = "pbDisc";
            this.pbDisc.Size = new System.Drawing.Size(170, 222);
            this.pbDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisc.TabIndex = 0;
            this.pbDisc.TabStop = false;
            // 
            // ShopItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.pbDisc);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ShopItem";
            this.Size = new System.Drawing.Size(240, 350);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbDisc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbGenre;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddToCart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
