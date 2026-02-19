namespace StudentsManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            specificStudentToolStripMenuItem = new ToolStripMenuItem();
            allStudentsToolStripMenuItem = new ToolStripMenuItem();
            pnl_studentsFields = new Panel();
            btn_func = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_studentSurname = new TextBox();
            txt_studentName = new TextBox();
            msk_studentClass = new MaskedTextBox();
            msk_studentCode = new MaskedTextBox();
            pnl_title = new Panel();
            lbl_title = new Label();
            dgv_studentsViewer = new DataGridView();
            menuStrip1.SuspendLayout();
            pnl_studentsFields.SuspendLayout();
            pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_studentsViewer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Font = new Font("Ubuntu Mono", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, modifyToolStripMenuItem, deleteToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1232, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(57, 28);
            addStudentToolStripMenuItem.Text = "Add";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(90, 28);
            modifyToolStripMenuItem.Text = "Modify";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(90, 28);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { specificStudentToolStripMenuItem, allStudentsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(68, 28);
            viewToolStripMenuItem.Text = "View";
            // 
            // specificStudentToolStripMenuItem
            // 
            specificStudentToolStripMenuItem.Name = "specificStudentToolStripMenuItem";
            specificStudentToolStripMenuItem.Size = new Size(281, 28);
            specificStudentToolStripMenuItem.Text = "Specific student";
            // 
            // allStudentsToolStripMenuItem
            // 
            allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            allStudentsToolStripMenuItem.Size = new Size(281, 28);
            allStudentsToolStripMenuItem.Text = "All students";
            // 
            // pnl_studentsFields
            // 
            pnl_studentsFields.Controls.Add(btn_func);
            pnl_studentsFields.Controls.Add(label4);
            pnl_studentsFields.Controls.Add(label3);
            pnl_studentsFields.Controls.Add(label2);
            pnl_studentsFields.Controls.Add(label1);
            pnl_studentsFields.Controls.Add(txt_studentSurname);
            pnl_studentsFields.Controls.Add(txt_studentName);
            pnl_studentsFields.Controls.Add(msk_studentClass);
            pnl_studentsFields.Controls.Add(msk_studentCode);
            pnl_studentsFields.Location = new Point(787, 135);
            pnl_studentsFields.Name = "pnl_studentsFields";
            pnl_studentsFields.Size = new Size(442, 564);
            pnl_studentsFields.TabIndex = 1;
            // 
            // btn_func
            // 
            btn_func.Location = new Point(104, 438);
            btn_func.Name = "btn_func";
            btn_func.Size = new Size(250, 61);
            btn_func.TabIndex = 8;
            btn_func.Text = "Add";
            btn_func.UseVisualStyleBackColor = true;
            btn_func.Click += btn_func_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 317);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 7;
            label4.Text = "Class:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 222);
            label3.Name = "label3";
            label3.Size = new Size(60, 22);
            label3.TabIndex = 6;
            label3.Text = "Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 131);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 5;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            // 
            // txt_studentSurname
            // 
            txt_studentSurname.Location = new Point(104, 156);
            txt_studentSurname.Name = "txt_studentSurname";
            txt_studentSurname.Size = new Size(250, 33);
            txt_studentSurname.TabIndex = 3;
            // 
            // txt_studentName
            // 
            txt_studentName.Location = new Point(104, 68);
            txt_studentName.Name = "txt_studentName";
            txt_studentName.Size = new Size(250, 33);
            txt_studentName.TabIndex = 2;
            // 
            // msk_studentClass
            // 
            msk_studentClass.AsciiOnly = true;
            msk_studentClass.HidePromptOnLeave = true;
            msk_studentClass.Location = new Point(104, 342);
            msk_studentClass.Mask = ">0°LL";
            msk_studentClass.Name = "msk_studentClass";
            msk_studentClass.Size = new Size(250, 33);
            msk_studentClass.TabIndex = 1;
            msk_studentClass.TextAlign = HorizontalAlignment.Center;
            // 
            // msk_studentCode
            // 
            msk_studentCode.AsciiOnly = true;
            msk_studentCode.HidePromptOnLeave = true;
            msk_studentCode.Location = new Point(104, 247);
            msk_studentCode.Mask = ">LL-00000";
            msk_studentCode.Name = "msk_studentCode";
            msk_studentCode.Size = new Size(250, 33);
            msk_studentCode.TabIndex = 0;
            msk_studentCode.TextAlign = HorizontalAlignment.Center;
            // 
            // pnl_title
            // 
            pnl_title.BackColor = SystemColors.ControlLight;
            pnl_title.Controls.Add(lbl_title);
            pnl_title.Dock = DockStyle.Top;
            pnl_title.Location = new Point(0, 32);
            pnl_title.Name = "pnl_title";
            pnl_title.Size = new Size(1232, 100);
            pnl_title.TabIndex = 2;
            // 
            // lbl_title
            // 
            lbl_title.Dock = DockStyle.Fill;
            lbl_title.Font = new Font("Ubuntu Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(0, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(1232, 100);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Students Manager";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_studentsViewer
            // 
            dgv_studentsViewer.AllowUserToAddRows = false;
            dgv_studentsViewer.AllowUserToDeleteRows = false;
            dgv_studentsViewer.BackgroundColor = SystemColors.Control;
            dgv_studentsViewer.BorderStyle = BorderStyle.None;
            dgv_studentsViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentsViewer.Location = new Point(0, 135);
            dgv_studentsViewer.Name = "dgv_studentsViewer";
            dgv_studentsViewer.ReadOnly = true;
            dgv_studentsViewer.RowHeadersWidth = 51;
            dgv_studentsViewer.Size = new Size(781, 564);
            dgv_studentsViewer.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(dgv_studentsViewer);
            Controls.Add(pnl_title);
            Controls.Add(pnl_studentsFields);
            Controls.Add(menuStrip1);
            Font = new Font("Ubuntu Mono Medium", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Students Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnl_studentsFields.ResumeLayout(false);
            pnl_studentsFields.PerformLayout();
            pnl_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_studentsViewer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem modifyToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem specificStudentToolStripMenuItem;
        private ToolStripMenuItem allStudentsToolStripMenuItem;
        private Panel pnl_studentsFields;
        private MaskedTextBox msk_studentCode;
        private Panel pnl_title;
        private Label lbl_title;
        private Label label1;
        private TextBox txt_studentSurname;
        private TextBox txt_studentName;
        private MaskedTextBox msk_studentClass;
        private Button btn_func;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgv_studentsViewer;
    }
}
