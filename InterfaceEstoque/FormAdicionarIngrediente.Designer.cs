﻿namespace InterfaceEstoque
{
    partial class FormAdicionarIngrediente
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelNameIngrediente = new System.Windows.Forms.Label();
            this.numericUpDownIngrediente = new System.Windows.Forms.NumericUpDown();
            this.labelQuantMax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionar.Location = new System.Drawing.Point(181, 274);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 0;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click_1);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(378, 30);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "VOLTAR";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(157, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(143, 13);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "ADICIONAR INGREDIENTE";
            // 
            // labelNameIngrediente
            // 
            this.labelNameIngrediente.AutoSize = true;
            this.labelNameIngrediente.Location = new System.Drawing.Point(178, 89);
            this.labelNameIngrediente.Name = "labelNameIngrediente";
            this.labelNameIngrediente.Size = new System.Drawing.Size(91, 13);
            this.labelNameIngrediente.TabIndex = 3;
            this.labelNameIngrediente.Text = "name_ingrediente";
            // 
            // numericUpDownIngrediente
            // 
            this.numericUpDownIngrediente.Location = new System.Drawing.Point(149, 181);
            this.numericUpDownIngrediente.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownIngrediente.Name = "numericUpDownIngrediente";
            this.numericUpDownIngrediente.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIngrediente.TabIndex = 4;
            // 
            // labelQuantMax
            // 
            this.labelQuantMax.AutoSize = true;
            this.labelQuantMax.Location = new System.Drawing.Point(260, 126);
            this.labelQuantMax.Name = "labelQuantMax";
            this.labelQuantMax.Size = new System.Drawing.Size(59, 13);
            this.labelQuantMax.TabIndex = 5;
            this.labelQuantMax.Text = "quant_max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade máxima: ";
            // 
            // FormAdicionarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQuantMax);
            this.Controls.Add(this.numericUpDownIngrediente);
            this.Controls.Add(this.labelNameIngrediente);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonAdicionar);
            this.Name = "FormAdicionarIngrediente";
            this.Text = "FormAdicionarIngrediente";
            this.Load += new System.EventHandler(this.FormAdicionarIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelNameIngrediente;
        private System.Windows.Forms.NumericUpDown numericUpDownIngrediente;
        private System.Windows.Forms.Label labelQuantMax;
        private System.Windows.Forms.Label label1;
    }
}