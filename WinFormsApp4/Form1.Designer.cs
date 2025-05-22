namespace WinFormsApp4
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            txtResIMC = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(480, 378);
            button1.Name = "button1";
            button1.Size = new Size(89, 44);
            button1.TabIndex = 0;
            button1.Text = "Limpar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(222, 378);
            button2.Name = "button2";
            button2.Size = new Size(89, 45);
            button2.TabIndex = 1;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.CornflowerBlue;
            button3.Location = new Point(350, 378);
            button3.Name = "button3";
            button3.Size = new Size(89, 45);
            button3.TabIndex = 2;
            button3.Text = "Verificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(313, 75);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 3;
            label1.Text = "Qual é o seu IMC?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(222, 155);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 4;
            label2.Text = "Digite o seu peso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(222, 222);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 5;
            label3.Text = "Digite a sua altura:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(248, 308);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 6;
            label4.Text = "Seu IMC é:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(364, 152);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(191, 23);
            txtPeso.TabIndex = 7;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(364, 223);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(191, 23);
            txtAltura.TabIndex = 8;
            // 
            // txtResIMC
            // 
            txtResIMC.Location = new Point(339, 305);
            txtResIMC.Name = "txtResIMC";
            txtResIMC.Size = new Size(191, 23);
            txtResIMC.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private TextBox txtResIMC;
    }
}
