namespace Calculadora
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
            somar = new Button();
            primeiroNumero = new TextBox();
            segundoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            resultado = new Label();
            SuspendLayout();
            // 
            // somar
            // 
            somar.Location = new Point(197, 219);
            somar.Name = "somar";
            somar.Size = new Size(75, 23);
            somar.TabIndex = 0;
            somar.Text = "Somar";
            somar.UseVisualStyleBackColor = true;
            somar.Click += somar_Click;
            // 
            // primeiroNumero
            // 
            primeiroNumero.Location = new Point(197, 125);
            primeiroNumero.Name = "primeiroNumero";
            primeiroNumero.Size = new Size(100, 23);
            primeiroNumero.TabIndex = 1;
            // 
            // segundoNumero
            // 
            segundoNumero.Location = new Point(197, 169);
            segundoNumero.Name = "segundoNumero";
            segundoNumero.Size = new Size(100, 23);
            segundoNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 128);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Primeiro Número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 172);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Segundo Número";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(333, 152);
            resultado.Name = "resultado";
            resultado.Size = new Size(13, 15);
            resultado.TabIndex = 5;
            resultado.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(segundoNumero);
            Controls.Add(primeiroNumero);
            Controls.Add(somar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button somar;
        private TextBox primeiroNumero;
        private TextBox segundoNumero;
        private Label label1;
        private Label label2;
        private Label resultado;
    }
}