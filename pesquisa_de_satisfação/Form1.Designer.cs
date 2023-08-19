namespace pesquisa_de_satisfação
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
            lb_pergunta = new Label();
            btn_sim = new Button();
            btn_nao = new Button();
            lb_sim = new Label();
            lb_nao = new Label();
            lb_contN = new Label();
            lb_contS = new Label();
            SuspendLayout();
            // 
            // lb_pergunta
            // 
            lb_pergunta.AutoSize = true;
            lb_pergunta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pergunta.Location = new Point(135, 73);
            lb_pergunta.Name = "lb_pergunta";
            lb_pergunta.Size = new Size(445, 25);
            lb_pergunta.TabIndex = 0;
            lb_pergunta.Text = "Você ficou satisfeito com o atendmento da nossa loja?";
            // 
            // btn_sim
            // 
            btn_sim.BackColor = Color.Lime;
            btn_sim.ForeColor = SystemColors.ControlText;
            btn_sim.Location = new Point(319, 194);
            btn_sim.Name = "btn_sim";
            btn_sim.Size = new Size(80, 40);
            btn_sim.TabIndex = 1;
            btn_sim.Text = "Sim";
            btn_sim.UseVisualStyleBackColor = false;
            btn_sim.Click += btn_sim_Click;
            // 
            // btn_nao
            // 
            btn_nao.BackColor = Color.Red;
            btn_nao.ForeColor = SystemColors.ButtonHighlight;
            btn_nao.Location = new Point(458, 194);
            btn_nao.Name = "btn_nao";
            btn_nao.Size = new Size(80, 40);
            btn_nao.TabIndex = 2;
            btn_nao.Text = "Não";
            btn_nao.UseVisualStyleBackColor = false;
            btn_nao.Click += btn_nao_Click;
            // 
            // lb_sim
            // 
            lb_sim.AutoSize = true;
            lb_sim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sim.ForeColor = Color.IndianRed;
            lb_sim.Location = new Point(58, 198);
            lb_sim.Name = "lb_sim";
            lb_sim.Size = new Size(34, 19);
            lb_sim.TabIndex = 3;
            lb_sim.Text = "Sim:";
            // 
            // lb_nao
            // 
            lb_nao.AutoSize = true;
            lb_nao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nao.ForeColor = Color.IndianRed;
            lb_nao.Location = new Point(58, 238);
            lb_nao.Name = "lb_nao";
            lb_nao.Size = new Size(37, 19);
            lb_nao.TabIndex = 4;
            lb_nao.Text = "Não:";
            // 
            // lb_contN
            // 
            lb_contN.AutoSize = true;
            lb_contN.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_contN.Location = new Point(110, 238);
            lb_contN.Name = "lb_contN";
            lb_contN.Size = new Size(17, 19);
            lb_contN.TabIndex = 5;
            lb_contN.Text = "0";
            // 
            // lb_contS
            // 
            lb_contS.AutoSize = true;
            lb_contS.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_contS.Location = new Point(110, 198);
            lb_contS.Name = "lb_contS";
            lb_contS.Size = new Size(17, 19);
            lb_contS.TabIndex = 6;
            lb_contS.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 391);
            Controls.Add(lb_contS);
            Controls.Add(lb_contN);
            Controls.Add(lb_nao);
            Controls.Add(lb_sim);
            Controls.Add(btn_nao);
            Controls.Add(btn_sim);
            Controls.Add(lb_pergunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_pergunta;
        private Button btn_sim;
        private Button btn_nao;
        private Label lb_sim;
        private Label lb_nao;
        private Label lb_contN;
        private Label lb_contS;
    }
}