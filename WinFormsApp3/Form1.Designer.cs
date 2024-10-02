namespace WinFormsApp3
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
            components = new System.ComponentModel.Container();
            txtNombre = new TextBox();
            label1 = new Label();
            btnValidar = new Button();
            lbUsuario = new Label();
            errorUsuario = new ErrorProvider(components);
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)errorUsuario).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(228, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(111, 34);
            label1.Name = "label1";
            label1.Size = new Size(111, 35);
            label1.TabIndex = 1;
            label1.Text = "Usuario:";
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnValidar.Location = new Point(111, 96);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(94, 29);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.Location = new Point(117, 154);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(50, 20);
            lbUsuario.TabIndex = 3;
            lbUsuario.Text = "label2";
            lbUsuario.Visible = false;
            // 
            // errorUsuario
            // 
            errorUsuario.ContainerControl = this;
            // 
            // listView1
            // 
            listView1.Location = new Point(228, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(206, 171);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.MouseEnter += listView1_MouseEnter;
            listView1.MouseLeave += listView1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(525, 296);
            Controls.Add(listView1);
            Controls.Add(lbUsuario);
            Controls.Add(btnValidar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Button btnValidar;
        private Label lbUsuario;
        private ErrorProvider errorUsuario;
        private ListView listView1;
    }
}
