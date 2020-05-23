namespace SmartCityProject
{
    partial class ControlTemprature
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
            this.ApplyTempratureButton = new System.Windows.Forms.Button();
            this.BedroomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BathroomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.KitchenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LivingroomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BathroomLabel = new System.Windows.Forms.Label();
            this.BedroomLabel = new System.Windows.Forms.Label();
            this.KithenLabel = new System.Windows.Forms.Label();
            this.LivingroomLabel = new System.Windows.Forms.Label();
            this.ControlTempratureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivingroomNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyTempratureButton
            // 
            this.ApplyTempratureButton.BackColor = System.Drawing.Color.Blue;
            this.ApplyTempratureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyTempratureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ApplyTempratureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ApplyTempratureButton.Location = new System.Drawing.Point(432, 128);
            this.ApplyTempratureButton.Name = "ApplyTempratureButton";
            this.ApplyTempratureButton.Size = new System.Drawing.Size(121, 67);
            this.ApplyTempratureButton.TabIndex = 19;
            this.ApplyTempratureButton.Text = "Apply Temprature";
            this.ApplyTempratureButton.UseVisualStyleBackColor = false;
            this.ApplyTempratureButton.Click += new System.EventHandler(this.ApplyTempratureButton_Click);
            // 
            // BedroomNumericUpDown
            // 
            this.BedroomNumericUpDown.Location = new System.Drawing.Point(228, 175);
            this.BedroomNumericUpDown.Name = "BedroomNumericUpDown";
            this.BedroomNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BedroomNumericUpDown.TabIndex = 18;
            this.BedroomNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BathroomNumericUpDown
            // 
            this.BathroomNumericUpDown.Location = new System.Drawing.Point(228, 221);
            this.BathroomNumericUpDown.Name = "BathroomNumericUpDown";
            this.BathroomNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BathroomNumericUpDown.TabIndex = 17;
            this.BathroomNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // KitchenNumericUpDown
            // 
            this.KitchenNumericUpDown.Location = new System.Drawing.Point(228, 132);
            this.KitchenNumericUpDown.Name = "KitchenNumericUpDown";
            this.KitchenNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.KitchenNumericUpDown.TabIndex = 16;
            this.KitchenNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LivingroomNumericUpDown
            // 
            this.LivingroomNumericUpDown.Location = new System.Drawing.Point(228, 90);
            this.LivingroomNumericUpDown.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.LivingroomNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.LivingroomNumericUpDown.Name = "LivingroomNumericUpDown";
            this.LivingroomNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LivingroomNumericUpDown.TabIndex = 15;
            this.LivingroomNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // BathroomLabel
            // 
            this.BathroomLabel.AutoSize = true;
            this.BathroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BathroomLabel.Location = new System.Drawing.Point(45, 221);
            this.BathroomLabel.Name = "BathroomLabel";
            this.BathroomLabel.Size = new System.Drawing.Size(79, 20);
            this.BathroomLabel.TabIndex = 14;
            this.BathroomLabel.Text = "Bathroom";
            // 
            // BedroomLabel
            // 
            this.BedroomLabel.AutoSize = true;
            this.BedroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.BedroomLabel.Location = new System.Drawing.Point(45, 175);
            this.BedroomLabel.Name = "BedroomLabel";
            this.BedroomLabel.Size = new System.Drawing.Size(74, 20);
            this.BedroomLabel.TabIndex = 13;
            this.BedroomLabel.Text = "Bedroom";
            // 
            // KithenLabel
            // 
            this.KithenLabel.AutoSize = true;
            this.KithenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.KithenLabel.Location = new System.Drawing.Point(45, 132);
            this.KithenLabel.Name = "KithenLabel";
            this.KithenLabel.Size = new System.Drawing.Size(62, 20);
            this.KithenLabel.TabIndex = 12;
            this.KithenLabel.Text = "Kitchen";
            // 
            // LivingroomLabel
            // 
            this.LivingroomLabel.AutoSize = true;
            this.LivingroomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LivingroomLabel.Location = new System.Drawing.Point(45, 90);
            this.LivingroomLabel.Name = "LivingroomLabel";
            this.LivingroomLabel.Size = new System.Drawing.Size(85, 20);
            this.LivingroomLabel.TabIndex = 11;
            this.LivingroomLabel.Text = "Livingroom";
            // 
            // ControlTempratureLabel
            // 
            this.ControlTempratureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ControlTempratureLabel.ForeColor = System.Drawing.Color.Blue;
            this.ControlTempratureLabel.Location = new System.Drawing.Point(90, 18);
            this.ControlTempratureLabel.Name = "ControlTempratureLabel";
            this.ControlTempratureLabel.Size = new System.Drawing.Size(419, 38);
            this.ControlTempratureLabel.TabIndex = 10;
            this.ControlTempratureLabel.Text = "Control Home\'s Temprature";
            // 
            // ControlTemprature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 274);
            this.Controls.Add(this.ApplyTempratureButton);
            this.Controls.Add(this.BedroomNumericUpDown);
            this.Controls.Add(this.BathroomNumericUpDown);
            this.Controls.Add(this.KitchenNumericUpDown);
            this.Controls.Add(this.LivingroomNumericUpDown);
            this.Controls.Add(this.BathroomLabel);
            this.Controls.Add(this.BedroomLabel);
            this.Controls.Add(this.KithenLabel);
            this.Controls.Add(this.LivingroomLabel);
            this.Controls.Add(this.ControlTempratureLabel);
            this.Name = "ControlTemprature";
            this.Text = "ControlTemprature";
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KitchenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LivingroomNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyTempratureButton;
        private System.Windows.Forms.NumericUpDown BedroomNumericUpDown;
        private System.Windows.Forms.NumericUpDown BathroomNumericUpDown;
        private System.Windows.Forms.NumericUpDown KitchenNumericUpDown;
        private System.Windows.Forms.NumericUpDown LivingroomNumericUpDown;
        private System.Windows.Forms.Label BathroomLabel;
        private System.Windows.Forms.Label BedroomLabel;
        private System.Windows.Forms.Label KithenLabel;
        private System.Windows.Forms.Label LivingroomLabel;
        private System.Windows.Forms.Label ControlTempratureLabel;

    }
}