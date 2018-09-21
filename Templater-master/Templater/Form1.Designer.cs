namespace Templater
{
    partial class Form1
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
            this.tb_templ_path = new System.Windows.Forms.TextBox();
            this.b_optempl = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.b_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.p_fields = new System.Windows.Forms.Panel();
            this.b_sel_excel = new System.Windows.Forms.Button();
            this.tb_excel_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл шаблона:";
            // 
            // tb_templ_path
            // 
            this.tb_templ_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_templ_path.Location = new System.Drawing.Point(105, 10);
            this.tb_templ_path.Name = "tb_templ_path";
            this.tb_templ_path.Size = new System.Drawing.Size(336, 20);
            this.tb_templ_path.TabIndex = 2;
            this.tb_templ_path.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_templ_path_KeyDown);
            // 
            // b_optempl
            // 
            this.b_optempl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_optempl.Location = new System.Drawing.Point(447, 8);
            this.b_optempl.Name = "b_optempl";
            this.b_optempl.Size = new System.Drawing.Size(75, 23);
            this.b_optempl.TabIndex = 3;
            this.b_optempl.Text = "Выбрать";
            this.b_optempl.UseVisualStyleBackColor = true;
            this.b_optempl.Click += new System.EventHandler(this.b_optempl_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Controls.Add(this.b_save);
            this.mainpanel.Controls.Add(this.groupBox1);
            this.mainpanel.Enabled = false;
            this.mainpanel.Location = new System.Drawing.Point(16, 68);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(506, 377);
            this.mainpanel.TabIndex = 5;
            // 
            // b_save
            // 
            this.b_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_save.Location = new System.Drawing.Point(215, 351);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Выгрузить";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.p_fields);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Соответствие полей";
            // 
            // p_fields
            // 
            this.p_fields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_fields.AutoScroll = true;
            this.p_fields.Location = new System.Drawing.Point(6, 19);
            this.p_fields.Name = "p_fields";
            this.p_fields.Size = new System.Drawing.Size(487, 317);
            this.p_fields.TabIndex = 0;
            // 
            // b_sel_excel
            // 
            this.b_sel_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_sel_excel.Enabled = false;
            this.b_sel_excel.Location = new System.Drawing.Point(447, 35);
            this.b_sel_excel.Name = "b_sel_excel";
            this.b_sel_excel.Size = new System.Drawing.Size(75, 23);
            this.b_sel_excel.TabIndex = 8;
            this.b_sel_excel.Text = "Выбрать";
            this.b_sel_excel.UseVisualStyleBackColor = true;
            this.b_sel_excel.Click += new System.EventHandler(this.b_sel_excel_Click);
            // 
            // tb_excel_path
            // 
            this.tb_excel_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_excel_path.Enabled = false;
            this.tb_excel_path.Location = new System.Drawing.Point(121, 37);
            this.tb_excel_path.Name = "tb_excel_path";
            this.tb_excel_path.Size = new System.Drawing.Size(320, 20);
            this.tb_excel_path.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Файл наполнения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 457);
            this.Controls.Add(this.b_sel_excel);
            this.Controls.Add(this.tb_excel_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.b_optempl);
            this.Controls.Add(this.tb_templ_path);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "Form1";
            this.Text = "Templater";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_templ_path;
        private System.Windows.Forms.Button b_optempl;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel p_fields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_sel_excel;
        private System.Windows.Forms.TextBox tb_excel_path;
        private System.Windows.Forms.Label label2;
    }
}

