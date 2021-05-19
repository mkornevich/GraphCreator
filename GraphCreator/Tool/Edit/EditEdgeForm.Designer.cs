namespace GraphCreator.Tool.Edit
{
    partial class EditEdgeForm
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
            this.hasWeightFld = new System.Windows.Forms.CheckBox();
            this.weightFld = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.hasDirectionFld = new System.Windows.Forms.CheckBox();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lineColorBtn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textColorBtn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lineWidthLbl = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.weightFld)).BeginInit();
            this.SuspendLayout();
            // 
            // hasWeightFld
            // 
            this.hasWeightFld.AutoSize = true;
            this.hasWeightFld.Location = new System.Drawing.Point(9, 10);
            this.hasWeightFld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasWeightFld.Name = "hasWeightFld";
            this.hasWeightFld.Size = new System.Drawing.Size(80, 17);
            this.hasWeightFld.TabIndex = 1;
            this.hasWeightFld.Text = "Имеет вес";
            this.hasWeightFld.UseVisualStyleBackColor = true;
            this.hasWeightFld.Click += new System.EventHandler(this.hasWeightFld_Click);
            // 
            // weightFld
            // 
            this.weightFld.Location = new System.Drawing.Point(85, 10);
            this.weightFld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.weightFld.Name = "weightFld";
            this.weightFld.Size = new System.Drawing.Size(87, 20);
            this.weightFld.TabIndex = 3;
            this.weightFld.ValueChanged += new System.EventHandler(this.weightFld_ValueChanged);
            // 
            // hasDirectionFld
            // 
            this.hasDirectionFld.AutoSize = true;
            this.hasDirectionFld.Location = new System.Drawing.Point(9, 37);
            this.hasDirectionFld.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hasDirectionFld.Name = "hasDirectionFld";
            this.hasDirectionFld.Size = new System.Drawing.Size(154, 17);
            this.hasDirectionFld.TabIndex = 4;
            this.hasDirectionFld.Text = "Является направленным";
            this.hasDirectionFld.UseVisualStyleBackColor = true;
            this.hasDirectionFld.Click += new System.EventHandler(this.hasDirectionFld_Click);
            // 
            // reverseBtn
            // 
            this.reverseBtn.Location = new System.Drawing.Point(9, 58);
            this.reverseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(163, 22);
            this.reverseBtn.TabIndex = 5;
            this.reverseBtn.Text = "Инвертировать направление";
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стиль ребра";
            // 
            // lineColorBtn
            // 
            this.lineColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineColorBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineColorBtn.ForeColor = System.Drawing.Color.Lime;
            this.lineColorBtn.Location = new System.Drawing.Point(157, 115);
            this.lineColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineColorBtn.Name = "lineColorBtn";
            this.lineColorBtn.Size = new System.Drawing.Size(16, 17);
            this.lineColorBtn.TabIndex = 7;
            this.lineColorBtn.Click += new System.EventHandler(this.lineColorBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Цвет ребра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цвет индекса вершины";
            // 
            // textColorBtn
            // 
            this.textColorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textColorBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textColorBtn.ForeColor = System.Drawing.Color.Lime;
            this.textColorBtn.Location = new System.Drawing.Point(157, 136);
            this.textColorBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textColorBtn.Name = "textColorBtn";
            this.textColorBtn.Size = new System.Drawing.Size(16, 17);
            this.textColorBtn.TabIndex = 9;
            this.textColorBtn.Click += new System.EventHandler(this.textColorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Толщина ребра";
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
            this.lineWidthLbl.Location = new System.Drawing.Point(115, 157);
            this.lineWidthLbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lineWidthLbl.Name = "lineWidthLbl";
            this.lineWidthLbl.Size = new System.Drawing.Size(58, 21);
            this.lineWidthLbl.TabIndex = 13;
            this.lineWidthLbl.Tag = "";
            this.lineWidthLbl.SelectedIndexChanged += new System.EventHandler(this.lineWidthLbl_SelectedIndexChanged);
            // 
            // EditEdgeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 188);
            this.Controls.Add(this.lineWidthLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textColorBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lineColorBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.hasDirectionFld);
            this.Controls.Add(this.weightFld);
            this.Controls.Add(this.hasWeightFld);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEdgeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ребро (1 --> 5)";
            ((System.ComponentModel.ISupportInitialize)(this.weightFld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox hasWeightFld;
        private System.Windows.Forms.NumericUpDown weightFld;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.CheckBox hasDirectionFld;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel lineColorBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel textColorBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lineWidthLbl;
    }
}