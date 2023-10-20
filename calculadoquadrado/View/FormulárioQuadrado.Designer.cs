namespace calculadoquadrado.View
{
    partial class FormulárioQuadrado
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
            label1 = new Label();
            label2 = new Label();
            tb_Valor = new TextBox();
            lbl_Resultado = new Label();
            btn_Calcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 25);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Cálculo Quadrado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(77, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 1;
            label2.Text = "Digite o Valor:";
            // 
            // tb_Valor
            // 
            tb_Valor.Location = new Point(199, 85);
            tb_Valor.Name = "tb_Valor";
            tb_Valor.Size = new Size(149, 23);
            tb_Valor.TabIndex = 2;
            // 
            // lbl_Resultado
            // 
            lbl_Resultado.BackColor = Color.FromArgb(192, 0, 192);
            lbl_Resultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Resultado.Location = new Point(77, 202);
            lbl_Resultado.Name = "lbl_Resultado";
            lbl_Resultado.Size = new Size(333, 221);
            lbl_Resultado.TabIndex = 3;
            lbl_Resultado.Text = "label3";
            lbl_Resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Calcular
            // 
            btn_Calcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Calcular.Location = new Point(77, 163);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(333, 23);
            btn_Calcular.TabIndex = 4;
            btn_Calcular.Text = "Calcular";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // FormulárioQuadrado
            // 
            AcceptButton = btn_Calcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(btn_Calcular);
            Controls.Add(lbl_Resultado);
            Controls.Add(tb_Valor);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "FormulárioQuadrado";
            ShowIcon = false;
            Text = "FormulárioQuadrado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_Valor;
        private Label lbl_Resultado;
        private Button btn_Calcular;
    }
}