namespace Principal
{
    partial class RegistrarEmpleado
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
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(340, 284);
            button4.Name = "button4";
            button4.Size = new Size(97, 23);
            button4.TabIndex = 3;
            button4.Text = "Agregar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 144);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(340, 82);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(110, 23);
            tbDescription.TabIndex = 6;
            tbDescription.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(340, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(340, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "TipoEmpleado";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(340, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 9;
            textBox3.Text = "Nombre";
            // 
            // RegistrarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(tbDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Name = "RegistrarEmpleado";
            Text = "RegistrarEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Label label1;
        private Label label2;
        private TextBox tbDescription;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}