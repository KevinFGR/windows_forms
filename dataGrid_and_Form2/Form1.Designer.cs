namespace aula_01_09
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
            dataGridView1 = new DataGridView();
            txtBox_name = new TextBox();
            label1 = new Label();
            btn_submit = new Button();
            label2 = new Label();
            txtBox_bornDate = new MaskedTextBox();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            registerToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            clientToolStripMenuItem = new ToolStripMenuItem();
            numeric_petsQuantity = new NumericUpDown();
            Column_name = new DataGridViewTextBoxColumn();
            Column_bornDate = new DataGridViewTextBoxColumn();
            Column_petsQuantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_petsQuantity).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_name, Column_bornDate, Column_petsQuantity });
            dataGridView1.Location = new Point(135, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(424, 150);
            dataGridView1.TabIndex = 0;
            // 
            // txtBox_name
            // 
            txtBox_name.Location = new Point(226, 192);
            txtBox_name.Name = "txtBox_name";
            txtBox_name.Size = new Size(100, 23);
            txtBox_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 195);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(226, 352);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(115, 49);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 245);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 5;
            label2.Text = "Born Date";
            // 
            // txtBox_bornDate
            // 
            txtBox_bornDate.Location = new Point(226, 242);
            txtBox_bornDate.Mask = "00/00/0000";
            txtBox_bornDate.Name = "txtBox_bornDate";
            txtBox_bornDate.Size = new Size(100, 23);
            txtBox_bornDate.TabIndex = 6;
            txtBox_bornDate.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 292);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 7;
            label3.Text = "Pets quantity";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, toolsToolStripMenuItem, registerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userToolStripMenuItem, clientToolStripMenuItem });
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new Size(61, 20);
            registerToolStripMenuItem.Text = "Register";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(105, 22);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // clientToolStripMenuItem
            // 
            clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            clientToolStripMenuItem.Size = new Size(105, 22);
            clientToolStripMenuItem.Text = "Client";
            // 
            // numeric_petsQuantity
            // 
            numeric_petsQuantity.Location = new Point(226, 290);
            numeric_petsQuantity.Name = "numeric_petsQuantity";
            numeric_petsQuantity.Size = new Size(120, 23);
            numeric_petsQuantity.TabIndex = 9;
            // 
            // Column_name
            // 
            Column_name.HeaderText = "Name";
            Column_name.Name = "Column_name";
            // 
            // Column_bornDate
            // 
            Column_bornDate.HeaderText = "Born Date";
            Column_bornDate.Name = "Column_bornDate";
            // 
            // Column_petsQuantity
            // 
            Column_petsQuantity.HeaderText = "Pets Quantity";
            Column_petsQuantity.Name = "Column_petsQuantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(numeric_petsQuantity);
            Controls.Add(label3);
            Controls.Add(txtBox_bornDate);
            Controls.Add(label2);
            Controls.Add(btn_submit);
            Controls.Add(label1);
            Controls.Add(txtBox_name);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_petsQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtBox_name;
        private Label label1;
        private Button btn_submit;
        private Label label2;
        private MaskedTextBox txtBox_bornDate;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem registerToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem clientToolStripMenuItem;
        private NumericUpDown numeric_petsQuantity;
        private DataGridViewTextBoxColumn Column_name;
        private DataGridViewTextBoxColumn Column_bornDate;
        private DataGridViewTextBoxColumn Column_petsQuantity;
    }
}