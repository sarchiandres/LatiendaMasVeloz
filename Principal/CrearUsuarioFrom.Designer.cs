namespace Principal
{
    partial class CrearUsuarioFrom
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
            tbNombre = new TextBox();
            tbDescription = new TextBox();
            btGuardar = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(245, 70);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(280, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(245, 109);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(280, 23);
            tbDescription.TabIndex = 1;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(297, 183);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(159, 77);
            btGuardar.TabIndex = 2;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(297, 298);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "label1";
            // 
            // CrearUsuarioFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btGuardar);
            Controls.Add(tbDescription);
            Controls.Add(tbNombre);
            Name = "CrearUsuarioFrom";
            Text = "CrearUsuarioFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbDescription;
        private Button btGuardar;
        private Label lbResultado;
    }
}