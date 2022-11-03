
namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Square = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Rhomb = new System.Windows.Forms.Button();
            this.textSquare = new System.Windows.Forms.TextBox();
            this.textCircle = new System.Windows.Forms.TextBox();
            this.textRhomb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(37, 74);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(125, 29);
            this.Square.TabIndex = 1;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(37, 173);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(125, 29);
            this.Circle.TabIndex = 2;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rhomb
            // 
            this.Rhomb.Location = new System.Drawing.Point(37, 273);
            this.Rhomb.Name = "Rhomb";
            this.Rhomb.Size = new System.Drawing.Size(125, 29);
            this.Rhomb.TabIndex = 3;
            this.Rhomb.Text = "Rhomb";
            this.Rhomb.UseVisualStyleBackColor = true;
            this.Rhomb.Click += new System.EventHandler(this.Rhomb_Click);
            // 
            // textSquare
            // 
            this.textSquare.Location = new System.Drawing.Point(37, 41);
            this.textSquare.Name = "textSquare";
            this.textSquare.Size = new System.Drawing.Size(125, 27);
            this.textSquare.TabIndex = 4;
            // 
            // textCircle
            // 
            this.textCircle.Location = new System.Drawing.Point(37, 140);
            this.textCircle.Name = "textCircle";
            this.textCircle.Size = new System.Drawing.Size(125, 27);
            this.textCircle.TabIndex = 5;
            // 
            // textRhomb
            // 
            this.textRhomb.Location = new System.Drawing.Point(37, 240);
            this.textRhomb.Name = "textRhomb";
            this.textRhomb.Size = new System.Drawing.Size(125, 27);
            this.textRhomb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "x / y / radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "x / y / radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "x / y / dh / dv";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(26, 487);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1079, 56);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 555);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRhomb);
            this.Controls.Add(this.textCircle);
            this.Controls.Add(this.textSquare);
            this.Controls.Add(this.Rhomb);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Square);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rhomb;
        private System.Windows.Forms.TextBox textSquare;
        private System.Windows.Forms.TextBox textCircle;
        private System.Windows.Forms.TextBox textRhomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

