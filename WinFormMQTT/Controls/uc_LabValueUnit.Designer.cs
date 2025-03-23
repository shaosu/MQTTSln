namespace WinFormMQTT.Controls
{
    partial class uc_LabValueUnit
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            txt_Value = new TextBox();
            lab_Unit = new Label();
            lab_Title = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(txt_Value, 1, 0);
            tableLayoutPanel1.Controls.Add(lab_Unit, 2, 0);
            tableLayoutPanel1.Controls.Add(lab_Title, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(131, 30);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txt_Value
            // 
            txt_Value.Dock = DockStyle.Fill;
            txt_Value.Location = new Point(41, 3);
            txt_Value.Name = "txt_Value";
            txt_Value.Size = new Size(50, 23);
            txt_Value.TabIndex = 1;
            txt_Value.Text = "Value";
            // 
            // lab_Unit
            // 
            lab_Unit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lab_Unit.AutoSize = true;
            lab_Unit.Location = new Point(97, 0);
            lab_Unit.Name = "lab_Unit";
            lab_Unit.Size = new Size(31, 30);
            lab_Unit.TabIndex = 2;
            lab_Unit.Text = "Unit";
            lab_Unit.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lab_Title
            // 
            lab_Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lab_Title.AutoSize = true;
            lab_Title.Location = new Point(3, 0);
            lab_Title.Name = "lab_Title";
            lab_Title.Size = new Size(32, 30);
            lab_Title.TabIndex = 0;
            lab_Title.Text = "Title";
            lab_Title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uc_LabValueUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel1);
            Name = "uc_LabValueUnit";
            Size = new Size(131, 30);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txt_Value;
        private Label lab_Unit;
        private Label lab_Title;
    }
}
