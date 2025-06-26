namespace Calculadora
{
    partial class frmRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepeticao));
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.ltbCategorias = new System.Windows.Forms.ListBox();
            this.lblListarCategorias = new System.Windows.Forms.Label();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(186, 63);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbbCategorias.TabIndex = 0;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorias.Location = new System.Drawing.Point(183, 29);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(86, 20);
            this.lblCategorias.TabIndex = 2;
            this.lblCategorias.Text = "Categorias";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(186, 190);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(121, 33);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // ltbCategorias
            // 
            this.ltbCategorias.FormattingEnabled = true;
            this.ltbCategorias.Location = new System.Drawing.Point(417, 63);
            this.ltbCategorias.Name = "ltbCategorias";
            this.ltbCategorias.Size = new System.Drawing.Size(171, 108);
            this.ltbCategorias.TabIndex = 4;
            // 
            // lblListarCategorias
            // 
            this.lblListarCategorias.AutoSize = true;
            this.lblListarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarCategorias.Location = new System.Drawing.Point(413, 29);
            this.lblListarCategorias.Name = "lblListarCategorias";
            this.lblListarCategorias.Size = new System.Drawing.Size(116, 20);
            this.lblListarCategorias.TabIndex = 5;
            this.lblListarCategorias.Text = "Lista Categoria";
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(417, 190);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(120, 35);
            this.btnListarCategorias.TabIndex = 6;
            this.btnListarCategorias.Text = "Listar Categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.lblListarCategorias);
            this.Controls.Add(this.ltbCategorias);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbbCategorias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.ListBox ltbCategorias;
        private System.Windows.Forms.Label lblListarCategorias;
        private System.Windows.Forms.Button btnListarCategorias;
    }
}