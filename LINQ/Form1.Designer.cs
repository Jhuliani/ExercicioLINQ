namespace LINQ
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 15;
            this.Lista.Location = new System.Drawing.Point(5, 10);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(386, 334);
            this.Lista.TabIndex = 0;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(397, 12);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(214, 23);
            this.txtConsulta.TabIndex = 1;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(397, 41);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(75, 23);
            this.btn_executar.TabIndex = 2;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 365);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Lista;
        private TextBox txtConsulta;
        private Button btn_executar;
    }
}