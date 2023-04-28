namespace SistemaGestionDeClientes
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
            btn_gestionClientes = new Button();
            SuspendLayout();
            // 
            // btn_gestionClientes
            // 
            btn_gestionClientes.Location = new Point(441, 45);
            btn_gestionClientes.Name = "btn_gestionClientes";
            btn_gestionClientes.Size = new Size(75, 47);
            btn_gestionClientes.TabIndex = 0;
            btn_gestionClientes.Text = "Gestionar clientes";
            btn_gestionClientes.UseVisualStyleBackColor = true;
            btn_gestionClientes.Click += btn_gestionClientes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 323);
            Controls.Add(btn_gestionClientes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_gestionClientes;
    }
}