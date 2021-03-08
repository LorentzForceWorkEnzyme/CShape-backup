namespace 实训ATM机
{
    partial class UserForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepos = new System.Windows.Forms.Button();
            this.btnTranfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnChangePassw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(103, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "请选择您需要的服务";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(150, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "目前您的账户余额为：";
            // 
            // btnDepos
            // 
            this.btnDepos.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDepos.Location = new System.Drawing.Point(0, 239);
            this.btnDepos.Name = "btnDepos";
            this.btnDepos.Size = new System.Drawing.Size(113, 46);
            this.btnDepos.TabIndex = 3;
            this.btnDepos.Text = "存款";
            this.btnDepos.UseVisualStyleBackColor = true;
            this.btnDepos.Click += new System.EventHandler(this.btnDepos_Click);
            // 
            // btnTranfer
            // 
            this.btnTranfer.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTranfer.Location = new System.Drawing.Point(686, 235);
            this.btnTranfer.Name = "btnTranfer";
            this.btnTranfer.Size = new System.Drawing.Size(113, 46);
            this.btnTranfer.TabIndex = 5;
            this.btnTranfer.Text = "转账";
            this.btnTranfer.UseVisualStyleBackColor = true;
            this.btnTranfer.Click += new System.EventHandler(this.btnTranfer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(686, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWithdraw.Location = new System.Drawing.Point(0, 401);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(113, 46);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "取款";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnChangePassw
            // 
            this.btnChangePassw.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePassw.Location = new System.Drawing.Point(686, 401);
            this.btnChangePassw.Name = "btnChangePassw";
            this.btnChangePassw.Size = new System.Drawing.Size(113, 46);
            this.btnChangePassw.TabIndex = 8;
            this.btnChangePassw.Text = "修改密码";
            this.btnChangePassw.UseVisualStyleBackColor = true;
            this.btnChangePassw.Click += new System.EventHandler(this.btnChangePassw_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnChangePassw);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTranfer);
            this.Controls.Add(this.btnDepos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepos;
        private System.Windows.Forms.Button btnTranfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnChangePassw;
    }
}