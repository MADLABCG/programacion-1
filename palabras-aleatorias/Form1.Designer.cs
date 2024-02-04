namespace Ejercicio1
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
            cuadroTexto = new TextBox();
            btnEscoger = new Button();
            lblEscogido = new Label();
            SuspendLayout();
            // 
            // cuadroTexto
            // 
            cuadroTexto.Location = new Point(29, 40);
            cuadroTexto.Multiline = true;
            cuadroTexto.Name = "cuadroTexto";
            cuadroTexto.Size = new Size(406, 388);
            cuadroTexto.TabIndex = 0;
            // 
            // btnEscoger
            // 
            btnEscoger.Location = new Point(441, 40);
            btnEscoger.Name = "btnEscoger";
            btnEscoger.Size = new Size(126, 54);
            btnEscoger.TabIndex = 1;
            btnEscoger.Text = "Escoger";
            btnEscoger.UseVisualStyleBackColor = true;
            btnEscoger.Click += btnEscoger_Click;
            // 
            // lblEscogido
            // 
            lblEscogido.AutoSize = true;
            lblEscogido.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEscogido.Location = new Point(441, 106);
            lblEscogido.Name = "lblEscogido";
            lblEscogido.Size = new Size(207, 32);
            lblEscogido.TabIndex = 2;
            lblEscogido.Text = "Palabra escogida";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEscogido);
            Controls.Add(btnEscoger);
            Controls.Add(cuadroTexto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cuadroTexto;
        private Button btnEscoger;
        private Label lblEscogido;
    }
}