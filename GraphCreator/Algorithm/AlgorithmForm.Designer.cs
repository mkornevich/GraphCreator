namespace GraphCreator.Algorithm
{
    partial class AlgorithmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgorithmForm));
            this.consoleView = new System.Windows.Forms.TextBox();
            this.inputFld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consoleView
            // 
            this.consoleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consoleView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleView.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.consoleView.Location = new System.Drawing.Point(0, 0);
            this.consoleView.Multiline = true;
            this.consoleView.Name = "consoleView";
            this.consoleView.ReadOnly = true;
            this.consoleView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.consoleView.Size = new System.Drawing.Size(631, 379);
            this.consoleView.TabIndex = 0;
            this.consoleView.TabStop = false;
            this.consoleView.WordWrap = false;
            // 
            // inputFld
            // 
            this.inputFld.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFld.Location = new System.Drawing.Point(0, 385);
            this.inputFld.Name = "inputFld";
            this.inputFld.Size = new System.Drawing.Size(631, 22);
            this.inputFld.TabIndex = 0;
            this.inputFld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputFld_KeyDown);
            // 
            // AlgorithmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 408);
            this.Controls.Add(this.inputFld);
            this.Controls.Add(this.consoleView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlgorithmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Алгоритм";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlgorithmForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox consoleView;
        private System.Windows.Forms.TextBox inputFld;
    }
}