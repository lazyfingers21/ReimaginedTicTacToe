namespace tictactoe
{
    partial class GIF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIF));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(550, 450);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BorderColor = System.Drawing.Color.Lime;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.CornerRadius = 7;
            this.rectangleShape2.FillColor = System.Drawing.Color.Lime;
            this.rectangleShape2.FillGradientColor = System.Drawing.Color.ForestGreen;
            this.rectangleShape2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(54, 339);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(440, 15);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkGreen;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 11;
            this.rectangleShape1.Location = new System.Drawing.Point(49, 334);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(449, 25);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.Black;
            this.lblLoading.Location = new System.Drawing.Point(203, 363);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(185, 33);
            this.lblLoading.TabIndex = 34;
            this.lblLoading.Text = "Loading...";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 475;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // GIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GIF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF";
            this.Load += new System.EventHandler(this.GIF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timer2;
    }
}