﻿namespace CRUDSHARP1
{
    partial class listado
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century751 No2 BT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(358, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTADOS DE CLIENTES LM";
            // 
            // dataGridViewclientes
            // 
            this.dataGridViewclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewclientes.Location = new System.Drawing.Point(18, 163);
            this.dataGridViewclientes.Name = "dataGridViewclientes";
            this.dataGridViewclientes.RowHeadersWidth = 62;
            this.dataGridViewclientes.RowTemplate.Height = 28;
            this.dataGridViewclientes.Size = new System.Drawing.Size(1224, 463);
            this.dataGridViewclientes.TabIndex = 2;
            // 
            // listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1266, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewclientes);
            this.Name = "listado";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewclientes;
    }
}