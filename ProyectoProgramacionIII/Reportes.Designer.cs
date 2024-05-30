namespace ProyectoProgra
{
    partial class Reportes
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
            this.dgvAbasPrepago = new System.Windows.Forms.DataGridView();
            this.dgvAbasTanque = new System.Windows.Forms.DataGridView();
            this.dgvCierracaja = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasPrepago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasTanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierracaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbasPrepago
            // 
            this.dgvAbasPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbasPrepago.Location = new System.Drawing.Point(582, 47);
            this.dgvAbasPrepago.Name = "dgvAbasPrepago";
            this.dgvAbasPrepago.RowHeadersWidth = 62;
            this.dgvAbasPrepago.RowTemplate.Height = 28;
            this.dgvAbasPrepago.Size = new System.Drawing.Size(386, 245);
            this.dgvAbasPrepago.TabIndex = 0;
            // 
            // dgvAbasTanque
            // 
            this.dgvAbasTanque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbasTanque.Location = new System.Drawing.Point(582, 390);
            this.dgvAbasTanque.Name = "dgvAbasTanque";
            this.dgvAbasTanque.RowHeadersWidth = 62;
            this.dgvAbasTanque.RowTemplate.Height = 28;
            this.dgvAbasTanque.Size = new System.Drawing.Size(386, 228);
            this.dgvAbasTanque.TabIndex = 1;
            // 
            // dgvCierracaja
            // 
            this.dgvCierracaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierracaja.Location = new System.Drawing.Point(42, 47);
            this.dgvCierracaja.Name = "dgvCierracaja";
            this.dgvCierracaja.RowHeadersWidth = 62;
            this.dgvCierracaja.RowTemplate.Height = 28;
            this.dgvCierracaja.Size = new System.Drawing.Size(373, 256);
            this.dgvCierracaja.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(405, 634);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(176, 75);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reporte de Servicios de tipo \"Pre-pago\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reporte de Servicios de tipo \"Tanque Lleno\"";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvCierracaja);
            this.Controls.Add(this.dgvAbasTanque);
            this.Controls.Add(this.dgvAbasPrepago);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasPrepago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasTanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierracaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbasPrepago;
        private System.Windows.Forms.DataGridView dgvAbasTanque;
        private System.Windows.Forms.DataGridView dgvCierracaja;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}