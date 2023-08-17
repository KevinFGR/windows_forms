namespace WinFormsApp1
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
            textbox_Name = new TextBox();
            label_name = new Label();
            txt_box_email = new TextBox();
            label_email = new Label();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // textbox_Name
            // 
            textbox_Name.AccessibleName = "";
            textbox_Name.Location = new Point(28, 46);
            textbox_Name.Name = "textbox_Name";
            textbox_Name.Size = new Size(173, 23);
            textbox_Name.TabIndex = 0;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(28, 28);
            label_name.Name = "label_name";
            label_name.Size = new Size(88, 15);
            label_name.TabIndex = 1;
            label_name.Text = "Set your Name:";
            // 
            // txt_box_email
            // 
            txt_box_email.Location = new Point(28, 114);
            txt_box_email.Name = "txt_box_email";
            txt_box_email.Size = new Size(173, 23);
            txt_box_email.TabIndex = 2;
            txt_box_email.TextChanged += textBox1_TextChanged;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(28, 96);
            label_email.Name = "label_email";
            label_email.Size = new Size(68, 15);
            label_email.TabIndex = 3;
            label_email.Text = "Your e-mail";
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.DodgerBlue;
            btn_submit.Location = new Point(57, 178);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(97, 36);
            btn_submit.TabIndex = 4;
            btn_submit.Tag = "";
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_submit);
            Controls.Add(label_email);
            Controls.Add(txt_box_email);
            Controls.Add(label_name);
            Controls.Add(textbox_Name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_Name;
        private Label label_name;
        private TextBox txt_box_email;
        private Label label_email;
        private Button btn_submit;
    }
}