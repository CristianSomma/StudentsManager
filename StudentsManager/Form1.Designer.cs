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
            lbl_studentPicker = new Label();
            cmb_studentPicker = new ComboBox();
            btn_func = new Button();
            lbl_studentClass = new Label();
            lbl_studentCode = new Label();
            lbl_studentSurname = new Label();
            lbl_studentName = new Label();
            txt_studentSurname = new TextBox();
            txt_studentName = new TextBox();
            msk_studentClass = new MaskedTextBox();
            msk_studentCode = new MaskedTextBox();
            pnl_title = new Panel();
            lbl_title = new Label();
            dgv_studentsViewer = new DataGridView();
            btn_sortAscending = new Button();
            btn_sortDescending = new Button();
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
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(90, 28);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
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
            specificStudentToolStripMenuItem.Click += specificStudentToolStripMenuItem_Click;
            // 
            // allStudentsToolStripMenuItem
            // 
            allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            allStudentsToolStripMenuItem.Size = new Size(281, 28);
            allStudentsToolStripMenuItem.Text = "All students";
            allStudentsToolStripMenuItem.Click += allStudentsToolStripMenuItem_Click;
            // 
            // pnl_studentsFields
            // 
            pnl_studentsFields.Controls.Add(lbl_studentPicker);
            pnl_studentsFields.Controls.Add(cmb_studentPicker);
            pnl_studentsFields.Controls.Add(btn_func);
            pnl_studentsFields.Controls.Add(lbl_studentClass);
            pnl_studentsFields.Controls.Add(lbl_studentCode);
            pnl_studentsFields.Controls.Add(lbl_studentSurname);
            pnl_studentsFields.Controls.Add(lbl_studentName);
            pnl_studentsFields.Controls.Add(txt_studentSurname);
            pnl_studentsFields.Controls.Add(txt_studentName);
            pnl_studentsFields.Controls.Add(msk_studentClass);
            pnl_studentsFields.Controls.Add(msk_studentCode);
            pnl_studentsFields.Location = new Point(787, 135);
            pnl_studentsFields.Name = "pnl_studentsFields";
            pnl_studentsFields.Size = new Size(442, 564);
            pnl_studentsFields.TabIndex = 1;
            // 
            // lbl_studentPicker
            // 
            lbl_studentPicker.AutoSize = true;
            lbl_studentPicker.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_studentPicker.Location = new Point(104, 26);
            lbl_studentPicker.Name = "lbl_studentPicker";
            lbl_studentPicker.Size = new Size(160, 22);
            lbl_studentPicker.TabIndex = 10;
            lbl_studentPicker.Text = "Choose student:";
            lbl_studentPicker.Visible = false;
            // 
            // cmb_studentPicker
            // 
            cmb_studentPicker.FormattingEnabled = true;
            cmb_studentPicker.Location = new Point(104, 51);
            cmb_studentPicker.Name = "cmb_studentPicker";
            cmb_studentPicker.Size = new Size(250, 36);
            cmb_studentPicker.TabIndex = 9;
            cmb_studentPicker.Visible = false;
            cmb_studentPicker.SelectedValueChanged += cmb_studentPicker_SelectedValueChanged;
            // 
            // btn_func
            // 
            btn_func.Location = new Point(104, 478);
            btn_func.Name = "btn_func";
            btn_func.Size = new Size(250, 61);
            btn_func.TabIndex = 8;
            btn_func.Text = "Add";
            btn_func.UseVisualStyleBackColor = true;
            btn_func.Click += btn_func_Click;
            // 
            // lbl_studentClass
            // 
            lbl_studentClass.AutoSize = true;
            lbl_studentClass.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_studentClass.Location = new Point(104, 391);
            lbl_studentClass.Name = "lbl_studentClass";
            lbl_studentClass.Size = new Size(70, 22);
            lbl_studentClass.TabIndex = 7;
            lbl_studentClass.Text = "Class:";
            // 
            // lbl_studentCode
            // 
            lbl_studentCode.AutoSize = true;
            lbl_studentCode.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_studentCode.Location = new Point(104, 296);
            lbl_studentCode.Name = "lbl_studentCode";
            lbl_studentCode.Size = new Size(60, 22);
            lbl_studentCode.TabIndex = 6;
            lbl_studentCode.Text = "Code:";
            // 
            // lbl_studentSurname
            // 
            lbl_studentSurname.AutoSize = true;
            lbl_studentSurname.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_studentSurname.Location = new Point(104, 205);
            lbl_studentSurname.Name = "lbl_studentSurname";
            lbl_studentSurname.Size = new Size(90, 22);
            lbl_studentSurname.TabIndex = 5;
            lbl_studentSurname.Text = "Surname:";
            // 
            // lbl_studentName
            // 
            lbl_studentName.AutoSize = true;
            lbl_studentName.Font = new Font("Ubuntu Mono", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_studentName.Location = new Point(104, 111);
            lbl_studentName.Name = "lbl_studentName";
            lbl_studentName.Size = new Size(60, 22);
            lbl_studentName.TabIndex = 4;
            lbl_studentName.Text = "Name:";
            // 
            // txt_studentSurname
            // 
            txt_studentSurname.Location = new Point(104, 230);
            txt_studentSurname.Name = "txt_studentSurname";
            txt_studentSurname.Size = new Size(250, 33);
            txt_studentSurname.TabIndex = 3;
            // 
            // txt_studentName
            // 
            txt_studentName.Location = new Point(104, 142);
            txt_studentName.Name = "txt_studentName";
            txt_studentName.Size = new Size(250, 33);
            txt_studentName.TabIndex = 2;
            // 
            // msk_studentClass
            // 
            msk_studentClass.AsciiOnly = true;
            msk_studentClass.HidePromptOnLeave = true;
            msk_studentClass.Location = new Point(104, 416);
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
            msk_studentCode.Location = new Point(104, 321);
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
            dgv_studentsViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_studentsViewer.BackgroundColor = SystemColors.Control;
            dgv_studentsViewer.BorderStyle = BorderStyle.None;
            dgv_studentsViewer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_studentsViewer.Location = new Point(0, 170);
            dgv_studentsViewer.Name = "dgv_studentsViewer";
            dgv_studentsViewer.ReadOnly = true;
            dgv_studentsViewer.RowHeadersWidth = 51;
            dgv_studentsViewer.Size = new Size(781, 529);
            dgv_studentsViewer.TabIndex = 3;
            // 
            // btn_sortAscending
            // 
            btn_sortAscending.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sortAscending.Location = new Point(12, 135);
            btn_sortAscending.Name = "btn_sortAscending";
            btn_sortAscending.Size = new Size(375, 29);
            btn_sortAscending.TabIndex = 4;
            btn_sortAscending.Text = "Sort in ascending order";
            btn_sortAscending.UseVisualStyleBackColor = true;
            btn_sortAscending.Click += btn_sortAscending_Click;
            // 
            // btn_sortDescending
            // 
            btn_sortDescending.Font = new Font("Ubuntu Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_sortDescending.Location = new Point(406, 135);
            btn_sortDescending.Name = "btn_sortDescending";
            btn_sortDescending.Size = new Size(375, 29);
            btn_sortDescending.TabIndex = 5;
            btn_sortDescending.Text = "Sort in descending order";
            btn_sortDescending.UseVisualStyleBackColor = true;
            btn_sortDescending.Click += btn_sortDescending_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(btn_sortDescending);
            Controls.Add(btn_sortAscending);
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
        private Label lbl_studentName;
        private TextBox txt_studentSurname;
        private TextBox txt_studentName;
        private MaskedTextBox msk_studentClass;
        private Button btn_func;
        private Label lbl_studentClass;
        private Label lbl_studentCode;
        private Label lbl_studentSurname;
        private DataGridView dgv_studentsViewer;
        private Label lbl_studentPicker;
        private ComboBox cmb_studentPicker;
        private Button btn_sortAscending;
        private Button btn_sortDescending;
    }
}
