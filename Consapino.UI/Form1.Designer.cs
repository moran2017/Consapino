namespace Consapino.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvJson = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJson
            // 
            this.dgvJson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJson.Location = new System.Drawing.Point(32, 100);
            this.dgvJson.Name = "dgvJson";
            this.dgvJson.RowTemplate.Height = 24;
            this.dgvJson.Size = new System.Drawing.Size(823, 292);
            this.dgvJson.TabIndex = 0;
            this.dgvJson.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJson_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 445);
            this.Controls.Add(this.dgvJson);
            this.Name = "Form1";
            this.Text = "Servicios API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJson;
    }
}

