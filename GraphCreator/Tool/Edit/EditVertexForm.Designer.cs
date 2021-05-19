namespace GraphCreator.Tool.Edit
{
    partial class EditVertexForm
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
            this.lineWidthLbl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textColorBtn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lineColorBtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.indexFld = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.indexFld)).BeginInit();
            this.SuspendLayout();
            // 
            // lineWidthLbl
            // 
            this.lineWidthLbl.FormattingEnabled = true;
            this.lineWidthLbl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.lineWidthLbl.Location = new System.Drawing.Point(115, 106);
            this.lineWidthLbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineWidthLbl.Name = "lineWidthLbl";
            this.lineWidthLbl.Size = new System.Drawing.Size(58, 21);
            this.lineWidthLbl.TabIndex = 24;
            this.lineWidthLbl.Tag = "";
            this.lineWidthLbl.SelectedIndexChanged += new System.EventHandler(this.lineWidthLbl_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Толщина обводки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Цвет индекса вершины";
            // 
            // textColorBtn
            // 
            this.textColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textColorBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textColorBtn.ForeColor = System.Drawing.Color.Lime;
            this.textColorBtn.Location = new System.Drawing.Point(157, 84);
            this.textColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textColorBtn.Name = "textColorBtn";
            this.textColorBtn.Size = new System.Drawing.Size(16, 17);
            this.textColorBtn.TabIndex = 21;
            this.textColorBtn.Click += new System.EventHandler(this.textColorBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Цвет обводки";
            // 
            // lineColorBtn
            // 
            this.lineColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineColorBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineColorBtn.ForeColor = System.Drawing.Color.Lime;
            this.lineColorBtn.Location = new System.Drawing.Point(157, 63);
            this.lineColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineColorBtn.Name = "lineColorBtn";
            this.lineColorBtn.Size = new System.Drawing.Size(16, 17);
            this.lineColorBtn.TabIndex = 19;
            this.lineColorBtn.Click += new System.EventHandler(this.lineColorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Стиль вершины";
            // 
            // indexFld
            // 
            this.indexFld.Location = new System.Drawing.Point(101, 10);
            this.indexFld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.indexFld.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.indexFld.Name = "indexFld";
            this.indexFld.Size = new System.Drawing.Size(70, 20);
            this.indexFld.TabIndex = 15;
            this.indexFld.ValueChanged += new System.EventHandler(this.indexFld_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Индекс вершины";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(8, 29);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(164, 9);
            this.errorLbl.TabIndex = 26;
            this.errorLbl.Text = "Вершина с таким индексом уже существует";
            // 
            // EditVertexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 133);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineWidthLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textColorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexFld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditVertexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вершина";
            ((System.ComponentModel.ISupportInitialize)(this.indexFld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lineWidthLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel textColorBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel lineColorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown indexFld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}