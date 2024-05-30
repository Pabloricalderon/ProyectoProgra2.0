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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasPrepago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasTanque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbasPrepago
            // 
            this.dgvAbasPrepago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbasPrepago.Location = new System.Drawing.Point(13, 76);
            this.dgvAbasPrepago.Name = "dgvAbasPrepago";
            this.dgvAbasPrepago.RowHeadersWidth = 62;
            this.dgvAbasPrepago.RowTemplate.Height = 28;
            this.dgvAbasPrepago.Size = new System.Drawing.Size(348, 227);
            this.dgvAbasPrepago.TabIndex = 0;
            // 
            // dgvAbasTanque
            // 
            this.dgvAbasTanque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbasTanque.Location = new System.Drawing.Point(13, 364);
            this.dgvAbasTanque.Name = "dgvAbasTanque";
            this.dgvAbasTanque.RowHeadersWidth = 62;
            this.dgvAbasTanque.RowTemplate.Height = 28;
            this.dgvAbasTanque.Size = new System.Drawing.Size(348, 203);
            this.dgvAbasTanque.TabIndex = 1;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 721);
            this.Controls.Add(this.dgvAbasTanque);
            this.Controls.Add(this.dgvAbasPrepago);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasPrepago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbasTanque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbasPrepago;
        private System.Windows.Forms.DataGridView dgvAbasTanque;
    }
}