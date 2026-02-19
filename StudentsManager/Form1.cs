using StudentsManager.Models;

namespace StudentsManager
{
    public partial class MainForm : Form
    {
        private DoublyLinkedList<Student> _students;
        private Status _status;

        public MainForm()
        {
            InitializeComponent();
            _students = new DoublyLinkedList<Student>();
            cmb_studentPicker.DisplayMember = "FullName";
            SetStatus(Status.Idle);
        }

        private void SetStatus(Status status)
        {
            _status = status;

            pnl_studentsFields.Visible = false;
            dgv_studentsViewer.Visible = false;
            lbl_studentPicker.Visible = false;
            cmb_studentPicker.Visible = false;
            btn_func.Visible = false;
            SetFieldsEnabled(true);
            SetFieldsVisible(true);
            ClearFields();

            switch (status)
            {
                case Status.Add:
                    pnl_studentsFields.Visible = true;
                    btn_func.Visible = true;
                    btn_func.Text = "Add";
                    break;

                case Status.Modify:
                    pnl_studentsFields.Visible = true;
                    lbl_studentPicker.Visible = true;
                    cmb_studentPicker.Visible = true;
                    btn_func.Visible = true;
                    btn_func.Text = "Modify";
                    RefreshComboBox();
                    break;

                case Status.Delete:
                    pnl_studentsFields.Visible = true;
                    lbl_studentPicker.Visible = true;
                    cmb_studentPicker.Visible = true;
                    btn_func.Visible = true;
                    btn_func.Text = "Delete";
                    SetFieldsEnabled(false);
                    RefreshComboBox();
                    break;

                case Status.ViewOne:
                    pnl_studentsFields.Visible = true;
                    lbl_studentPicker.Visible = true;
                    cmb_studentPicker.Visible = true;
                    SetFieldsVisible(false);
                    RefreshComboBox();
                    break;

                case Status.ViewAll:
                    dgv_studentsViewer.Visible = true;
                    RefreshDataGrid();
                    break;
            }
        }

        private void RefreshComboBox()
        {
            cmb_studentPicker.DataSource = null;
            cmb_studentPicker.DataSource = _students.ToList();
            cmb_studentPicker.DisplayMember = "FullName";
        }

        private void RefreshDataGrid()
        {
            dgv_studentsViewer.DataSource = _students.ToList();
            dgv_studentsViewer.Columns["FullName"]?.Visible = false;
        }

        private void SetFieldsEnabled(bool enabled)
        {
            txt_studentName.Enabled = enabled;
            txt_studentSurname.Enabled = enabled;
            msk_studentCode.Enabled = enabled;
            msk_studentClass.Enabled = enabled;
        }

        private void SetFieldsVisible(bool visible)
        {
            lbl_studentName.Visible = visible;
            lbl_studentSurname.Visible = visible;
            lbl_studentCode.Visible = visible;
            lbl_studentClass.Visible = visible;
            txt_studentName.Visible = visible;
            txt_studentSurname.Visible = visible;
            msk_studentCode.Visible = visible;
            msk_studentClass.Visible = visible;
        }

        private void ClearFields()
        {
            txt_studentName.Text = "";
            txt_studentSurname.Text = "";
            msk_studentCode.Text = "";
            msk_studentClass.Text = "";
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e) => SetStatus(Status.Add);
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e) => SetStatus(Status.Modify);
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) => SetStatus(Status.Delete);
        private void specificStudentToolStripMenuItem_Click(object sender, EventArgs e) => SetStatus(Status.ViewOne);
        private void allStudentsToolStripMenuItem_Click(object sender, EventArgs e) => SetStatus(Status.ViewAll);

        private void btn_func_Click(object sender, EventArgs e)
        {
            switch (_status)
            {
                case Status.Add: AddClient(); break;
                case Status.Modify: ModifyClient(); break;
                case Status.Delete: DeleteClient(); break;
            }
        }

        private void AddClient()
        {
            Student? newStudent = null;
            try
            {
                newStudent = new Student()
                {
                    Name = txt_studentName.Text,
                    Surname = txt_studentSurname.Text,
                    Code = msk_studentCode.Text,
                    Class = msk_studentClass.Text
                };
            }
            catch
            {
                MessageBox.Show("The fields aren't filled properly.", "ERROR");
                return;
            }

            _students.InsertLast(newStudent);
            SetStatus(Status.Idle);
        }

        private void ModifyClient()
        {
            Student? selected = cmb_studentPicker.SelectedItem as Student;
            if (selected is null) { MessageBox.Show("No student selected.", "ERROR"); return; }

            int index = _students.FindIndex(selected);
            if (index == -1) { MessageBox.Show("Student not found.", "ERROR"); return; }

            try
            {
                _students.SetAt(index, new Student()
                {
                    Name = txt_studentName.Text,
                    Surname = txt_studentSurname.Text,
                    Code = msk_studentCode.Text,
                    Class = msk_studentClass.Text
                });
            }
            catch
            {
                MessageBox.Show("The fields aren't filled properly.", "ERROR");
                return;
            }

            SetStatus(Status.Idle);
        }

        private void DeleteClient()
        {
            Student? selected = cmb_studentPicker.SelectedItem as Student;
            
            if (selected is null) 
            { 
                MessageBox.Show("No student selected.", "ERROR"); 
                return; 
            }

            int index = _students.FindIndex(selected);
            if (index == -1) 
            { 
                MessageBox.Show("Student not found.", "ERROR"); 
                return; 
            }

            try 
            { 
                _students.DeleteAt(index); 
            }
            catch 
            { 
                MessageBox.Show("An error occurred during deletion.", "OPS!"); 
                return; 
            }

            SetStatus(Status.Idle);
        }

        private void cmb_studentPicker_SelectedValueChanged(object sender, EventArgs e)
        {
            Student? selected = cmb_studentPicker.SelectedItem as Student;
            if (selected is null) return;

            if (_status == Status.ViewOne)
            {
                dgv_studentsViewer.Visible = true;
                dgv_studentsViewer.DataSource = new Student[] { selected };
                dgv_studentsViewer.Columns["FullName"]?.Visible = false;
                return;
            }

            txt_studentName.Text = selected.Name;
            txt_studentSurname.Text = selected.Surname;
            msk_studentCode.Text = selected.Code;
            msk_studentClass.Text = selected.Class;
        }
    }

    public enum Status
    {
        Idle,
        Add,
        Modify,
        Delete,
        ViewOne,
        ViewAll
    }
}