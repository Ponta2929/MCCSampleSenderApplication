
namespace MCCSampleSenderApplication
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Send = new System.Windows.Forms.Button();
            this.TextBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_Comment = new System.Windows.Forms.TextBox();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前：";
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(518, 27);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(75, 23);
            this.Button_Send.TabIndex = 1;
            this.Button_Send.Text = "送信";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // TextBox_Name
            // 
            this.TextBox_Name.Location = new System.Drawing.Point(12, 29);
            this.TextBox_Name.Name = "TextBox_Name";
            this.TextBox_Name.Size = new System.Drawing.Size(100, 19);
            this.TextBox_Name.TabIndex = 2;
            this.TextBox_Name.Text = "名無しのごん兵衛";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "コメント：";
            // 
            // TextBox_Comment
            // 
            this.TextBox_Comment.Location = new System.Drawing.Point(118, 29);
            this.TextBox_Comment.Name = "TextBox_Comment";
            this.TextBox_Comment.Size = new System.Drawing.Size(394, 19);
            this.TextBox_Comment.TabIndex = 4;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBox_Log.Location = new System.Drawing.Point(12, 59);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.ReadOnly = true;
            this.RichTextBox_Log.Size = new System.Drawing.Size(581, 298);
            this.RichTextBox_Log.TabIndex = 5;
            this.RichTextBox_Log.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 369);
            this.Controls.Add(this.RichTextBox_Log);
            this.Controls.Add(this.TextBox_Comment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_Name);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "サンプル送信プログラム";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.TextBox TextBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox_Comment;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
    }
}

