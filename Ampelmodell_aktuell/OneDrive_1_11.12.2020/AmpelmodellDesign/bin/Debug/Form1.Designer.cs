
namespace AmpelmodellDesign
{
    partial class Form1
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
            this.lblPress = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.colorDialog3 = new System.Windows.Forms.ColorDialog();
            this.redLamp = new System.Windows.Forms.TextBox();
            this.yellowLamp = new System.Windows.Forms.TextBox();
            this.gruenLamp = new System.Windows.Forms.TextBox();
            this.rotFußgaenger = new System.Windows.Forms.TextBox();
            this.gruenFussgaenger = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.programmStarten = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPress
            // 
            this.lblPress.Location = new System.Drawing.Point(414, 380);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(100, 28);
            this.lblPress.TabIndex = 0;
            this.lblPress.Text = "Press";
            this.lblPress.UseVisualStyleBackColor = true;
            this.lblPress.Click += new System.EventHandler(this.lblPress_Click);
            // 
            // redLamp
            // 
            this.redLamp.Location = new System.Drawing.Point(452, 208);
            this.redLamp.Name = "redLamp";
            this.redLamp.Size = new System.Drawing.Size(25, 22);
            this.redLamp.TabIndex = 1;
            this.redLamp.TextChanged += new System.EventHandler(this.redLamp_TextChanged);
            // 
            // yellowLamp
            // 
            this.yellowLamp.Location = new System.Drawing.Point(452, 255);
            this.yellowLamp.Name = "yellowLamp";
            this.yellowLamp.Size = new System.Drawing.Size(25, 22);
            this.yellowLamp.TabIndex = 2;
            this.yellowLamp.TextChanged += new System.EventHandler(this.yellowLamp_TextChanged);
            // 
            // gruenLamp
            // 
            this.gruenLamp.Location = new System.Drawing.Point(452, 309);
            this.gruenLamp.Name = "gruenLamp";
            this.gruenLamp.Size = new System.Drawing.Size(25, 22);
            this.gruenLamp.TabIndex = 3;
            this.gruenLamp.TextChanged += new System.EventHandler(this.gruenLamp_TextChanged);
            // 
            // rotFußgaenger
            // 
            this.rotFußgaenger.Location = new System.Drawing.Point(647, 208);
            this.rotFußgaenger.Name = "rotFußgaenger";
            this.rotFußgaenger.Size = new System.Drawing.Size(25, 22);
            this.rotFußgaenger.TabIndex = 4;
            // 
            // gruenFussgaenger
            // 
            this.gruenFussgaenger.Location = new System.Drawing.Point(646, 255);
            this.gruenFussgaenger.Name = "gruenFussgaenger";
            this.gruenFussgaenger.Size = new System.Drawing.Size(26, 22);
            this.gruenFussgaenger.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Autoampel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fußgaenger";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // programmStarten
            // 
            this.programmStarten.Location = new System.Drawing.Point(104, 225);
            this.programmStarten.Name = "programmStarten";
            this.programmStarten.Size = new System.Drawing.Size(161, 23);
            this.programmStarten.TabIndex = 8;
            this.programmStarten.Text = "Amepl starten";
            this.programmStarten.UseVisualStyleBackColor = true;
            this.programmStarten.Click += new System.EventHandler(this.programmStarten_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.programmStarten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gruenFussgaenger);
            this.Controls.Add(this.rotFußgaenger);
            this.Controls.Add(this.gruenLamp);
            this.Controls.Add(this.yellowLamp);
            this.Controls.Add(this.redLamp);
            this.Controls.Add(this.lblPress);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblPress;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog3;
        private System.Windows.Forms.TextBox redLamp;
        private System.Windows.Forms.TextBox yellowLamp;
        private System.Windows.Forms.TextBox gruenLamp;
        private System.Windows.Forms.TextBox rotFußgaenger;
        private System.Windows.Forms.TextBox gruenFussgaenger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button programmStarten;
        private System.Windows.Forms.Button button1;
    }
}

