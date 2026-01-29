using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using TodoNotes.Business.Abstract;
using TodoNotes.Entities.Concrete;
using System.Linq;
using System.Linq.Expressions;


namespace TodoNotes.WinFormsUI
{
    public partial class Form1 : Form
    {
        private readonly ITodoItemService _todoService;
        private int _selectedTodoId;

        private readonly INoteService _noteService;
        private int _selectedNoteId;


        public Form1(ITodoItemService todoService, INoteService noteService)
        {
            InitializeComponent();
            _todoService = todoService;
            _noteService = noteService;
        }
        private void LoadNotes()
        {
            dgvNotes.DataSource = _noteService.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTodos();
            LoadNotes();
        }
        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNotes.Rows[e.RowIndex];
            _selectedNoteId = Convert.ToInt32(row.Cells["Id"].Value);

            txtTitleNotes.Text = row.Cells["Title"].Value.ToString();
            txtContext.Text = row.Cells["Content"].Value.ToString();
        }
        private void btnNoteAdd_Click(object sender, EventArgs e)
        {
            var note = new Note
            {
                Title = txtTitleNotes.Text,
                Content = txtContext.Text,
                CreatedAt = DateTime.Now
            };
            try
            {
                _noteService.Add(note);
                LoadNotes();
                ClearNoteForm();
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "FluentValidation.ValidationException")
                    MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearNoteForm()
        {
            txtTitleNotes.Clear();
            txtContext.Clear();
            _selectedNoteId = 0;
        }


        private void LoadTodos()
        {
            dgvTodos.DataSource = _todoService.GetAll();
        }


        private void dgvTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvTodos.Rows[e.RowIndex];

            _selectedTodoId = Convert.ToInt32(row.Cells["Id"].Value);
            txtTitle.Text = row.Cells["Title"].Value.ToString();
            txtDescription.Text = row.Cells["Description"].Value.ToString();
            chkCompleted.Checked = Convert.ToBoolean(row.Cells["IsCompleted"].Value);
        }


        private void chkCompleted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedTodoId == 0)
            {
                MessageBox.Show("Select a todo first.");
                return;
            }
            try
            {
                var todo = _todoService.GetById(_selectedTodoId);
                if (todo == null)
                {
                    MessageBox.Show("The selected todo could not be found.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Are you sure?",
                    "Delete",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    _todoService.Delete(todo);
                    LoadTodos();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "FluentValidation.ValidationException")
                    MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newTodo = new TodoItem
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                IsCompleted = chkCompleted.Checked
            };

            _todoService.Add(newTodo);
            LoadTodos();
            ClearForm();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedTodoId == 0)
            {
                MessageBox.Show("Select a todo first.");
                return;
            }

            try
            {
                var todo = _todoService.GetById(_selectedTodoId);
                if (todo == null)
                {
                    MessageBox.Show("The selected todo could not be found.");
                    return;
                }

                todo.Title = txtTitle.Text;
                todo.Description = txtDescription.Text;
                todo.IsCompleted = chkCompleted.Checked;

                _todoService.Update(todo);
                LoadTodos();
                ClearForm();
            }
            catch (Exception ex)
            {
                if (ex.GetType().FullName == "FluentValidation.ValidationException")
                    MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void HandleException(Exception ex)
        {
            errorProvider1.Clear();

            // Validation errors coming from Business
            var validationException = ex as Exception;

            if (ex is System.Exception && ex.Message.Contains("Validation"))
            {
                MessageBox.Show("Validation error occurred.");
                return;
            }

            MessageBox.Show(ex.Message);
        }
        */

        private void ClearForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            chkCompleted.Checked = false;
            _selectedTodoId = 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateNotes_Click(object sender, EventArgs e)
        {
            var note = _noteService.GetById(_selectedNoteId);
            note.Title = txtTitleNotes.Text;
            note.Content = txtContext.Text;

            _noteService.Update(note);
            LoadNotes();
            ClearNoteForm();
        }
        private void btnDeleteNotes_Click(object sender, EventArgs e)
        {
            if (_selectedNoteId == 0)
            {
                MessageBox.Show("Select a note first.");
                return;
            }

            var confirm = MessageBox.Show("Delete this note?", "Confirm",
                MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var note = _noteService.GetById(_selectedNoteId);
                _noteService.Delete(note);
                LoadNotes();
                ClearNoteForm();
            }
        }
    }
}

