namespace TIC_TAC_TOE
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            lblmessage = new Label();
            btnFinishGame = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(273, 132);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 71);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += clickGame;
            // 
            // btn2
            // 
            btn2.Location = new Point(364, 132);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 71);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += clickGame;
            // 
            // btn3
            // 
            btn3.Location = new Point(455, 132);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 71);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += clickGame;
            // 
            // btn4
            // 
            btn4.Location = new Point(273, 209);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 71);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += clickGame;
            // 
            // btn5
            // 
            btn5.Location = new Point(364, 209);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 71);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += clickGame;
            // 
            // btn6
            // 
            btn6.Location = new Point(455, 209);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 71);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += clickGame;
            // 
            // btn7
            // 
            btn7.Location = new Point(273, 286);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 71);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += clickGame;
            // 
            // btn8
            // 
            btn8.Location = new Point(364, 286);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 71);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += clickGame;
            // 
            // btn9
            // 
            btn9.Location = new Point(455, 286);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 71);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += clickGame;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 18);
            label1.Name = "label1";
            label1.Size = new Size(240, 45);
            label1.TabIndex = 9;
            label1.Text = "TIC TAC TOE";
            // 
            // lblmessage
            // 
            lblmessage.AutoSize = true;
            lblmessage.Location = new Point(184, 82);
            lblmessage.Name = "lblmessage";
            lblmessage.Size = new Size(78, 32);
            lblmessage.TabIndex = 10;
            lblmessage.Text = "label2";
            toolTip1.SetToolTip(lblmessage, "You will see all game outcomes in this info section");
            // 
            // btnFinishGame
            // 
            btnFinishGame.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinishGame.Location = new Point(295, 390);
            btnFinishGame.Name = "btnFinishGame";
            btnFinishGame.Size = new Size(220, 46);
            btnFinishGame.TabIndex = 11;
            btnFinishGame.Text = "Finish Game";
            btnFinishGame.UseVisualStyleBackColor = true;
            btnFinishGame.Click += FinishGame;
            // 
            // toolTip1
            // 
            toolTip1.ForeColor = SystemColors.InactiveCaptionText;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(825, 478);
            Controls.Add(btnFinishGame);
            Controls.Add(lblmessage);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TIC TAC TOE ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label lblmessage;
        private Button btnFinishGame;
        private ToolTip toolTip1;
    }
}
