using System;

namespace TodoNotes.WinFormsUI
{
    partial class Form1
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
            this.dgvTodos = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkCompleted = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeleteNotes = new System.Windows.Forms.Button();
            this.btnUpdateNotes = new System.Windows.Forms.Button();
            this.btnAddNotes = new System.Windows.Forms.Button();
            this.txtContext = new System.Windows.Forms.TextBox();
            this.txtTitleNotes = new System.Windows.Forms.TextBox();
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodos
            // 
            this.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodos.Location = new System.Drawing.Point(6, 28);
            this.dgvTodos.Name = "dgvTodos";
            this.dgvTodos.Size = new System.Drawing.Size(577, 295);
            this.dgvTodos.TabIndex = 0;
            this.dgvTodos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodos_CellClick);
            this.dgvTodos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodos_CellContentClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(599, 49);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(144, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(599, 75);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(144, 87);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(599, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(599, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 452);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTodos);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.txtTitle);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.chkCompleted);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "To-Do";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCompleted
            // 
            this.chkCompleted.AutoSize = true;
            this.chkCompleted.Location = new System.Drawing.Point(599, 168);
            this.chkCompleted.Name = "chkCompleted";
            this.chkCompleted.Size = new System.Drawing.Size(76, 17);
            this.chkCompleted.TabIndex = 3;
            this.chkCompleted.Text = "Completed";
            this.chkCompleted.UseVisualStyleBackColor = true;
            this.chkCompleted.CheckedChanged += new System.EventHandler(this.chkCompleted_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteNotes);
            this.tabPage2.Controls.Add(this.btnUpdateNotes);
            this.tabPage2.Controls.Add(this.btnAddNotes);
            this.tabPage2.Controls.Add(this.txtContext);
            this.tabPage2.Controls.Add(this.txtTitleNotes);
            this.tabPage2.Controls.Add(this.dgvNotes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDeleteNotes
            // 
            this.btnDeleteNotes.Location = new System.Drawing.Point(392, 320);
            this.btnDeleteNotes.Name = "btnDeleteNotes";
            this.btnDeleteNotes.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteNotes.TabIndex = 5;
            this.btnDeleteNotes.Text = "Delete";
            this.btnDeleteNotes.UseVisualStyleBackColor = true;
            this.btnDeleteNotes.Click += new System.EventHandler(this.btnDeleteNotes_Click);
            // 
            // btnUpdateNotes
            // 
            this.btnUpdateNotes.Location = new System.Drawing.Point(392, 290);
            this.btnUpdateNotes.Name = "btnUpdateNotes";
            this.btnUpdateNotes.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateNotes.TabIndex = 4;
            this.btnUpdateNotes.Text = "Update";
            this.btnUpdateNotes.UseVisualStyleBackColor = true;
            this.btnUpdateNotes.Click += new System.EventHandler(this.btnUpdateNotes_Click);
            // 
            // btnAddNotes
            // 
            this.btnAddNotes.Location = new System.Drawing.Point(392, 260);
            this.btnAddNotes.Name = "btnAddNotes";
            this.btnAddNotes.Size = new System.Drawing.Size(75, 23);
            this.btnAddNotes.TabIndex = 3;
            this.btnAddNotes.Text = "Add";
            this.btnAddNotes.UseVisualStyleBackColor = true;
            this.btnAddNotes.Click += new System.EventHandler(this.btnNoteAdd_Click);
            // 
            // txtContext
            // 
            this.txtContext.Location = new System.Drawing.Point(7, 290);
            this.txtContext.Multiline = true;
            this.txtContext.Name = "txtContext";
            this.txtContext.Size = new System.Drawing.Size(356, 130);
            this.txtContext.TabIndex = 2;
            // 
            // txtTitleNotes
            // 
            this.txtTitleNotes.Location = new System.Drawing.Point(7, 263);
            this.txtTitleNotes.Name = "txtTitleNotes";
            this.txtTitleNotes.Size = new System.Drawing.Size(356, 20);
            this.txtTitleNotes.TabIndex = 1;
            // 
            // dgvNotes
            // 
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Location = new System.Drawing.Point(6, 6);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.Size = new System.Drawing.Size(748, 250);
            this.dgvNotes.TabIndex = 0;
            this.dgvNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotes_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 476);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "To-Do Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodos;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.Button btnDeleteNotes;
        private System.Windows.Forms.Button btnUpdateNotes;
        private System.Windows.Forms.Button btnAddNotes;
        private System.Windows.Forms.TextBox txtContext;
        private System.Windows.Forms.TextBox txtTitleNotes;
        private System.Windows.Forms.CheckBox chkCompleted;
    }
}

