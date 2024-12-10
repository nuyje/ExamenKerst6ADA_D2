
namespace exKerst6ADA_EK2024
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
            lstWedstrijden = new ListBox();
            label1 = new Label();
            lblSpeelfase = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblDatum = new Label();
            lblPloeg1 = new Label();
            lblPloeg2 = new Label();
            txtUitslag = new TextBox();
            btnUpdateUitslag = new Button();
            label20 = new Label();
            lstGroep = new ListBox();
            label7 = new Label();
            txtWW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lstWedstrijden
            // 
            lstWedstrijden.FormattingEnabled = true;
            lstWedstrijden.ItemHeight = 15;
            lstWedstrijden.Location = new Point(274, 93);
            lstWedstrijden.Margin = new Padding(4, 3, 4, 3);
            lstWedstrijden.Name = "lstWedstrijden";
            lstWedstrijden.Size = new Size(325, 454);
            lstWedstrijden.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "Wedstrijden";
            // 
            // lblSpeelfase
            // 
            lblSpeelfase.AutoSize = true;
            lblSpeelfase.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblSpeelfase.Location = new Point(638, 93);
            lblSpeelfase.Margin = new Padding(4, 0, 4, 0);
            lblSpeelfase.Name = "lblSpeelfase";
            lblSpeelfase.Size = new Size(137, 24);
            lblSpeelfase.TabIndex = 2;
            lblSpeelfase.Text = "Wedstrijd info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(639, 137);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Tijdstip";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Ploeg 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(639, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Ploeg 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 231);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Uitslag";
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Location = new Point(738, 137);
            lblDatum.Margin = new Padding(4, 0, 4, 0);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(0, 15);
            lblDatum.TabIndex = 7;
            // 
            // lblPloeg1
            // 
            lblPloeg1.AutoSize = true;
            lblPloeg1.Location = new Point(738, 167);
            lblPloeg1.Margin = new Padding(4, 0, 4, 0);
            lblPloeg1.Name = "lblPloeg1";
            lblPloeg1.Size = new Size(0, 15);
            lblPloeg1.TabIndex = 8;
            // 
            // lblPloeg2
            // 
            lblPloeg2.AutoSize = true;
            lblPloeg2.Location = new Point(738, 199);
            lblPloeg2.Margin = new Padding(4, 0, 4, 0);
            lblPloeg2.Name = "lblPloeg2";
            lblPloeg2.Size = new Size(0, 15);
            lblPloeg2.TabIndex = 9;
            // 
            // txtUitslag
            // 
            txtUitslag.Location = new Point(739, 223);
            txtUitslag.Margin = new Padding(4, 3, 4, 3);
            txtUitslag.Name = "txtUitslag";
            txtUitslag.Size = new Size(61, 23);
            txtUitslag.TabIndex = 10;
            // 
            // btnUpdateUitslag
            // 
            btnUpdateUitslag.Location = new Point(643, 255);
            btnUpdateUitslag.Margin = new Padding(4, 3, 4, 3);
            btnUpdateUitslag.Name = "btnUpdateUitslag";
            btnUpdateUitslag.Size = new Size(163, 27);
            btnUpdateUitslag.TabIndex = 11;
            btnUpdateUitslag.Text = "Werk uitslag bij";
            btnUpdateUitslag.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(33, 71);
            label20.Name = "label20";
            label20.Size = new Size(39, 15);
            label20.TabIndex = 24;
            label20.Text = "Groep";
            // 
            // lstGroep
            // 
            lstGroep.FormattingEnabled = true;
            lstGroep.ItemHeight = 15;
            lstGroep.Location = new Point(33, 93);
            lstGroep.Name = "lstGroep";
            lstGroep.Size = new Size(217, 184);
            lstGroep.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 25);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 26;
            label7.Text = "ww: ";
            // 
            // txtWW
            // 
            txtWW.Location = new Point(77, 22);
            txtWW.Name = "txtWW";
            txtWW.PasswordChar = '*';
            txtWW.Size = new Size(100, 23);
            txtWW.TabIndex = 27;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(205, 22);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 28;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 583);
            Controls.Add(btnLogin);
            Controls.Add(txtWW);
            Controls.Add(label7);
            Controls.Add(lstGroep);
            Controls.Add(label20);
            Controls.Add(btnUpdateUitslag);
            Controls.Add(txtUitslag);
            Controls.Add(lblPloeg2);
            Controls.Add(lblPloeg1);
            Controls.Add(lblDatum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSpeelfase);
            Controls.Add(label1);
            Controls.Add(lstWedstrijden);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstWedstrijden;
        private Label label1;
        private Label lblSpeelfase;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblDatum;
        private Label lblPloeg1;
        private Label lblPloeg2;
        private TextBox txtUitslag;
        private Button btnUpdateUitslag;
        private Label label20;
        private ListBox lstGroep;
        private Label label7;
        private TextBox txtWW;
        private Button btnLogin;
    }
}

