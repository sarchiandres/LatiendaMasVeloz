namespace Principal
{
    partial class VentanaPrincipal
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(65, 135);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 1;
            button2.Text = "Registrar Empleado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(65, 190);
            button3.Name = "button3";
            button3.Size = new Size(150, 23);
            button3.TabIndex = 2;
            button3.Text = "Seleccionar Productos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(65, 244);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 3;
            button4.Text = "Registrar Cliente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "VentanaPrincipal";
            Text = "VentanaPrincipal";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
    }
}