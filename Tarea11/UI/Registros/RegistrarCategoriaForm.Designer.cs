namespace Tarea11
{
    partial class CategoriasForm
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
            this.components = new System.ComponentModel.Container();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AgregarLabel = new System.Windows.Forms.Label();
            this.GuardarLabel = new System.Windows.Forms.Label();
            this.EliminarLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(65, 85);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(88, 31);
            this.IdTextBox.TabIndex = 0;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(65, 139);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(152, 31);
            this.DescripcionTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(278, 31);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Registrar categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
            // 
            // AgregarLabel
            // 
            this.AgregarLabel.AutoSize = true;
            this.AgregarLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarLabel.Location = new System.Drawing.Point(69, 189);
            this.AgregarLabel.Name = "AgregarLabel";
            this.AgregarLabel.Size = new System.Drawing.Size(40, 16);
            this.AgregarLabel.TabIndex = 8;
            this.AgregarLabel.Text = "Nuevo";
            // 
            // GuardarLabel
            // 
            this.GuardarLabel.AutoSize = true;
            this.GuardarLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarLabel.Location = new System.Drawing.Point(115, 189);
            this.GuardarLabel.Name = "GuardarLabel";
            this.GuardarLabel.Size = new System.Drawing.Size(49, 16);
            this.GuardarLabel.TabIndex = 9;
            this.GuardarLabel.Text = "Guardar";
            // 
            // EliminarLabel
            // 
            this.EliminarLabel.AutoSize = true;
            this.EliminarLabel.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarLabel.Location = new System.Drawing.Point(167, 189);
            this.EliminarLabel.Name = "EliminarLabel";
            this.EliminarLabel.Size = new System.Drawing.Size(49, 16);
            this.EliminarLabel.TabIndex = 10;
            this.EliminarLabel.Text = "Eliminar";
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::Tarea11.Properties.Resources.ic_search_black_48dp_2x;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButton.Location = new System.Drawing.Point(154, 85);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(32, 32);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImage = global::Tarea11.Properties.Resources.ic_delete_black_48dp_2x;
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EliminarButton.Location = new System.Drawing.Point(168, 205);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(46, 49);
            this.EliminarButton.TabIndex = 4;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackgroundImage = global::Tarea11.Properties.Resources.ic_save_black_48dp_2x;
            this.AgregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AgregarButton.Location = new System.Drawing.Point(116, 205);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(46, 49);
            this.AgregarButton.TabIndex = 3;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImage = global::Tarea11.Properties.Resources.ic_add_circle_outline_black_48dp_2x;
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NuevoButton.Location = new System.Drawing.Point(65, 205);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(46, 49);
            this.NuevoButton.TabIndex = 2;
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CategoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.EliminarLabel);
            this.Controls.Add(this.GuardarLabel);
            this.Controls.Add(this.AgregarLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Name = "CategoriasForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AgregarLabel;
        private System.Windows.Forms.Label GuardarLabel;
        private System.Windows.Forms.Label EliminarLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

