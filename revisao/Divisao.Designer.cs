namespace revisao
{
    partial class Divisao
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
            this.tx_divisao = new System.Windows.Forms.TextBox();
            this.tx_divisao2 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_divisao
            // 
            this.tx_divisao.Location = new System.Drawing.Point(376, 97);
            this.tx_divisao.Name = "tx_divisao";
            this.tx_divisao.Size = new System.Drawing.Size(100, 20);
            this.tx_divisao.TabIndex = 0;
            // 
            // tx_divisao2
            // 
            this.tx_divisao2.Location = new System.Drawing.Point(351, 194);
            this.tx_divisao2.Name = "tx_divisao2";
            this.tx_divisao2.Size = new System.Drawing.Size(100, 20);
            this.tx_divisao2.TabIndex = 1;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(376, 282);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(75, 23);
            this.bt_calcular.TabIndex = 2;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_divisao_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(332, 372);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 13);
            this.lb_resultado.TabIndex = 3;
            // 
            // Divisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tx_divisao2);
            this.Controls.Add(this.tx_divisao);
            this.Name = "Divisao";
            this.Text = "Divisao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_divisao;
        private System.Windows.Forms.TextBox tx_divisao2;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label lb_resultado;
    }
}