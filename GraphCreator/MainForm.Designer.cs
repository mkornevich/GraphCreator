namespace GraphCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drawPanel = new System.Windows.Forms.Panel();
            this.algorithmsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToolsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolTab = new System.Windows.Forms.TabPage();
            this.algorithmTab = new System.Windows.Forms.TabPage();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.toolTab.SuspendLayout();
            this.algorithmTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(219, 30);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(889, 619);
            this.drawPanel.TabIndex = 0;
            // 
            // algorithmsListBox
            // 
            this.algorithmsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.algorithmsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.algorithmsListBox.FormattingEnabled = true;
            this.algorithmsListBox.Location = new System.Drawing.Point(2, 2);
            this.algorithmsListBox.Name = "algorithmsListBox";
            this.algorithmsListBox.Size = new System.Drawing.Size(192, 345);
            this.algorithmsListBox.TabIndex = 1;
            this.algorithmsListBox.SelectedValueChanged += new System.EventHandler(this.algorithmsListBox_SelectedValueChanged);
            this.algorithmsListBox.DoubleClick += new System.EventHandler(this.algorithmsListBox_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Граф";
            // 
            // ToolsListBox
            // 
            this.ToolsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToolsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsListBox.FormattingEnabled = true;
            this.ToolsListBox.Items.AddRange(new object[] {
            "Переместить",
            "Редактировать",
            "Удалить",
            "Добавить вершину",
            "Добавить ребро"});
            this.ToolsListBox.Location = new System.Drawing.Point(2, 2);
            this.ToolsListBox.Name = "ToolsListBox";
            this.ToolsListBox.Size = new System.Drawing.Size(192, 345);
            this.ToolsListBox.TabIndex = 3;
            this.ToolsListBox.SelectedIndexChanged += new System.EventHandler(this.ToolsListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionTextBox.Location = new System.Drawing.Point(9, 405);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(202, 244);
            this.descriptionTextBox.TabIndex = 6;
            this.descriptionTextBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.toolTab);
            this.tabControl1.Controls.Add(this.algorithmTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(204, 375);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // toolTab
            // 
            this.toolTab.Controls.Add(this.ToolsListBox);
            this.toolTab.Location = new System.Drawing.Point(4, 22);
            this.toolTab.Margin = new System.Windows.Forms.Padding(2);
            this.toolTab.Name = "toolTab";
            this.toolTab.Padding = new System.Windows.Forms.Padding(2);
            this.toolTab.Size = new System.Drawing.Size(196, 349);
            this.toolTab.TabIndex = 0;
            this.toolTab.Text = "Инструменты";
            this.toolTab.UseVisualStyleBackColor = true;
            // 
            // algorithmTab
            // 
            this.algorithmTab.Controls.Add(this.algorithmsListBox);
            this.algorithmTab.Location = new System.Drawing.Point(4, 22);
            this.algorithmTab.Margin = new System.Windows.Forms.Padding(2);
            this.algorithmTab.Name = "algorithmTab";
            this.algorithmTab.Padding = new System.Windows.Forms.Padding(2);
            this.algorithmTab.Size = new System.Drawing.Size(196, 349);
            this.algorithmTab.TabIndex = 1;
            this.algorithmTab.Text = "Алгоритмы";
            this.algorithmTab.UseVisualStyleBackColor = true;
            // 
            // aboutBtn
            // 
            this.aboutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutBtn.Location = new System.Drawing.Point(1024, 5);
            this.aboutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(85, 22);
            this.aboutBtn.TabIndex = 8;
            this.aboutBtn.Text = "О программе";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(941, 5);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(78, 22);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 658);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drawPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1135, 703);
            this.Name = "MainForm";
            this.Text = "GraphCreator";
            this.tabControl1.ResumeLayout(false);
            this.toolTab.ResumeLayout(false);
            this.algorithmTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ListBox algorithmsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ToolsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage toolTab;
        private System.Windows.Forms.TabPage algorithmTab;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

