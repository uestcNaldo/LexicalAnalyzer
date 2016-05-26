using System;

namespace LexicalAnalyzer {
    partial class LA_UI {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.DataView = new System.Windows.Forms.DataGridView();
            this.FileOpenButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Location = new System.Drawing.Point(14, 58);
            this.DataView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataView.Name = "DataView";
            this.DataView.RowTemplate.Height = 23;
            this.DataView.Size = new System.Drawing.Size(339, 490);
            this.DataView.TabIndex = 0;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FileOpenButton
            // 
            this.FileOpenButton.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileOpenButton.Location = new System.Drawing.Point(14, 13);
            this.FileOpenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileOpenButton.Name = "FileOpenButton";
            this.FileOpenButton.Size = new System.Drawing.Size(339, 37);
            this.FileOpenButton.TabIndex = 1;
            this.FileOpenButton.Text = "OpenFile";
            this.FileOpenButton.UseVisualStyleBackColor = true;
            this.FileOpenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox.Location = new System.Drawing.Point(359, 13);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(513, 535);
            this.TextBox.TabIndex = 2;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // LA_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.FileOpenButton);
            this.Controls.Add(this.DataView);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LA_UI";
            this.Text = "Lexical Analyzer - Pascal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button FileOpenButton;
        protected System.Windows.Forms.RichTextBox TextBox;
    }
}

