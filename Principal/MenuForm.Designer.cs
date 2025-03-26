namespace Principal
{
    partial class MenuForm
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
            btCrearUsuario = new Button();
            btMostrar = new Button();
            SuspendLayout();
            // 
            // btCrearUsuario
            // 
            btCrearUsuario.Location = new Point(91, 90);
            btCrearUsuario.Name = "btCrearUsuario";
            btCrearUsuario.Size = new Size(130, 88);
            btCrearUsuario.TabIndex = 0;
            btCrearUsuario.Text = "Crear";
            btCrearUsuario.UseVisualStyleBackColor = true;
            btCrearUsuario.Click += btCrearUsuario_Click;
            // 
            // btMostrar
            // 
            btMostrar.Location = new Point(326, 90);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(130, 88);
            btMostrar.TabIndex = 1;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMostrar);
            Controls.Add(btCrearUsuario);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btCrearUsuario;
        private Button btMostrar;
    }
}