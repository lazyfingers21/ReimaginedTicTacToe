namespace tictactoe
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(104, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Player 1 Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(103, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Player 2 Name:";
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlayer1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer1.Location = new System.Drawing.Point(63, 53);
            this.textBoxPlayer1.MaxLength = 15;
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(273, 33);
            this.textBoxPlayer1.TabIndex = 0;
            this.textBoxPlayer1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlayer2.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayer2.Location = new System.Drawing.Point(63, 138);
            this.textBoxPlayer2.MaxLength = 15;
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(273, 33);
            this.textBoxPlayer2.TabIndex = 1;
            this.textBoxPlayer2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Sienna;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfirm.Location = new System.Drawing.Point(120, 195);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnConfirm.Size = new System.Drawing.Size(159, 43);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(400, 300);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Sienna;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.Location = new System.Drawing.Point(117, 193);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(165, 46);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.Button btnConfirm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}