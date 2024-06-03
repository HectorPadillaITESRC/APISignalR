namespace PruebaSignalR
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
            txtNombre = new TextBox();
            btnAgregar = new Button();
            lstNombre = new ListBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(351, 11);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Nombre";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstNombre
            // 
            lstNombre.FormattingEnabled = true;
            lstNombre.Location = new Point(33, 54);
            lstNombre.Name = "lstNombre";
            lstNombre.Size = new Size(509, 364);
            lstNombre.TabIndex = 2;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(448, 12);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(btnBorrar);
            Controls.Add(lstNombre);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Button btnAgregar;
        private ListBox lstNombre;
        private Button btnBorrar;
    }
}
