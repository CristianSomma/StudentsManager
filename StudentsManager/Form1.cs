using DoubleLinkedList_Test;

namespace StudentsManager
{
    public partial class MainForm : Form
    {
        private DoublyLinkedList

        public MainForm()
        {
            InitializeComponent();
            dgv_studentsViewer.Visible = false;
            pnl_studentsFields.Visible = false;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_studentsFields.Visible = true;
            btn_func.Text = "Add";
        }

        private void btn_func_Click(object sender, EventArgs e)
        {

        }
    }

    public enum WindowStatus
    {
        Add,
        Modify,
        Delete,
        ViewOne,
        ViewAll
    }
}
