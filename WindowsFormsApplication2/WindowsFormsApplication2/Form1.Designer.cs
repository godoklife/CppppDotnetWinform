namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.listBoard = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("굴림", 25F);
            this.lblTitle.Location = new System.Drawing.Point(49, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(83, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "제목";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(138, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(273, 60);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "";
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(480, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 158);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(138, 130);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(273, 60);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("굴림", 25F);
            this.lblContent.Location = new System.Drawing.Point(49, 130);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(83, 34);
            this.lblContent.TabIndex = 3;
            this.lblContent.Text = "내용";
            // 
            // listBoard
            // 
            this.listBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colContent});
            this.listBoard.HideSelection = false;
            this.listBoard.Location = new System.Drawing.Point(12, 229);
            this.listBoard.Name = "listBoard";
            this.listBoard.Size = new System.Drawing.Size(705, 255);
            this.listBoard.TabIndex = 5;
            this.listBoard.UseCompatibleStateImageBehavior = false;
            this.listBoard.View = System.Windows.Forms.View.Details;
            this.listBoard.SelectedIndexChanged += new System.EventHandler(this.listBoard_SelectedIndexChanged);
            // 
            // colTitle
            // 
            this.colTitle.Text = "제목";
            this.colTitle.Width = 230;
            // 
            // colContent
            // 
            this.colContent.Text = "내용";
            this.colContent.Width = 470;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(693, 106);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(23, 57);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "button1";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 496);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.listBoard);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox txtTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ListView listBoard;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colContent;
        private System.Windows.Forms.Button btnTest;
    }
}

