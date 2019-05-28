namespace test2._43
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbtnType1 = new System.Windows.Forms.RadioButton();
            this.rbtnType2 = new System.Windows.Forms.RadioButton();
            this.rbtnType3 = new System.Windows.Forms.RadioButton();
            this.cbxAutoNext = new System.Windows.Forms.CheckBox();
            this.btnFast = new System.Windows.Forms.Button();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbxAutoShow = new System.Windows.Forms.CheckBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblEq = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbtnType3);
            this.gbxType.Controls.Add(this.rbtnType2);
            this.gbxType.Controls.Add(this.rbtnType1);
            this.gbxType.Location = new System.Drawing.Point(35, 12);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(462, 77);
            this.gbxType.TabIndex = 0;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "题目类型";
            // 
            // rbtnType1
            // 
            this.rbtnType1.AutoSize = true;
            this.rbtnType1.Location = new System.Drawing.Point(19, 38);
            this.rbtnType1.Name = "rbtnType1";
            this.rbtnType1.Size = new System.Drawing.Size(141, 22);
            this.rbtnType1.TabIndex = 0;
            this.rbtnType1.TabStop = true;
            this.rbtnType1.Text = "10以内加减法";
            this.rbtnType1.UseVisualStyleBackColor = true;
            // 
            // rbtnType2
            // 
            this.rbtnType2.AutoSize = true;
            this.rbtnType2.Location = new System.Drawing.Point(166, 38);
            this.rbtnType2.Name = "rbtnType2";
            this.rbtnType2.Size = new System.Drawing.Size(141, 22);
            this.rbtnType2.TabIndex = 1;
            this.rbtnType2.TabStop = true;
            this.rbtnType2.Text = "20以内加减法";
            this.rbtnType2.UseVisualStyleBackColor = true;
            // 
            // rbtnType3
            // 
            this.rbtnType3.AutoSize = true;
            this.rbtnType3.Location = new System.Drawing.Point(313, 38);
            this.rbtnType3.Name = "rbtnType3";
            this.rbtnType3.Size = new System.Drawing.Size(69, 22);
            this.rbtnType3.TabIndex = 2;
            this.rbtnType3.TabStop = true;
            this.rbtnType3.Text = "乘法";
            this.rbtnType3.UseVisualStyleBackColor = true;
            // 
            // cbxAutoNext
            // 
            this.cbxAutoNext.AutoSize = true;
            this.cbxAutoNext.Location = new System.Drawing.Point(544, 50);
            this.cbxAutoNext.Name = "cbxAutoNext";
            this.cbxAutoNext.Size = new System.Drawing.Size(124, 22);
            this.cbxAutoNext.TabIndex = 1;
            this.cbxAutoNext.Text = "自动下一题";
            this.cbxAutoNext.UseVisualStyleBackColor = true;
            this.cbxAutoNext.CheckedChanged += new System.EventHandler(this.CbxAutoNext_CheckedChanged);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(686, 40);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(91, 42);
            this.btnFast.TabIndex = 2;
            this.btnFast.Text = "快一些";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.BtnFast_Click);
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(783, 40);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(91, 42);
            this.btnSlow.TabIndex = 3;
            this.btnSlow.Text = "慢一些";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.BtnSlow_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(579, 107);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 44);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // cbxAutoShow
            // 
            this.cbxAutoShow.AutoSize = true;
            this.cbxAutoShow.Location = new System.Drawing.Point(728, 119);
            this.cbxAutoShow.Name = "cbxAutoShow";
            this.cbxAutoShow.Size = new System.Drawing.Size(142, 22);
            this.cbxAutoShow.TabIndex = 5;
            this.cbxAutoShow.Text = "自动显示答案";
            this.cbxAutoShow.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblA.Location = new System.Drawing.Point(109, 221);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(77, 84);
            this.lblA.TabIndex = 6;
            this.lblA.Text = "a";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOp.Location = new System.Drawing.Point(248, 221);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(119, 84);
            this.lblOp.TabIndex = 7;
            this.lblOp.Text = "op";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblB.Location = new System.Drawing.Point(397, 221);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(77, 84);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "b";
            // 
            // lblEq
            // 
            this.lblEq.AutoSize = true;
            this.lblEq.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEq.Location = new System.Drawing.Point(504, 221);
            this.lblEq.Name = "lblEq";
            this.lblEq.Size = new System.Drawing.Size(77, 84);
            this.lblEq.TabIndex = 9;
            this.lblEq.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(620, 218);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(200, 103);
            this.txtResult.TabIndex = 10;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtResult_KeyDown);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(173, 439);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(152, 44);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "总得分";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPoint.Location = new System.Drawing.Point(365, 439);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(42, 44);
            this.lblPoint.TabIndex = 12;
            this.lblPoint.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(665, 341);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 40);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 527);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblEq);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cbxAutoShow);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSlow);
            this.Controls.Add(this.btnFast);
            this.Controls.Add(this.cbxAutoNext);
            this.Controls.Add(this.gbxType);
            this.Name = "Form1";
            this.Text = "题目练习";
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.RadioButton rbtnType3;
        private System.Windows.Forms.RadioButton rbtnType2;
        private System.Windows.Forms.RadioButton rbtnType1;
        private System.Windows.Forms.CheckBox cbxAutoNext;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbxAutoShow;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblEq;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConfirm;
    }
}

