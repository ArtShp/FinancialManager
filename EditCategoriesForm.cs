using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManager
{
    public partial class EditCategoriesForm : Form
    {
        private long selectedId = -1;
        private long parentCategoryId = 0;
        private Size originalFormSize;
        private Size originalTreeViewSize;

        public EditCategoriesForm()
        {
            InitializeComponent();

            LoadAll();

            originalFormSize = new Size(Size.Width, Size.Height);
            originalTreeViewSize = new Size(treeView.Width, treeView.Height);
        }

        #region Loaders

        private void LoadAll()
        {
            try
            {
                LoadList();
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadList()
        {
            LoadMainCategories();
            LoadMainSubCategories();
        }

        private void LoadMainCategories()
        {
            var data = SqliteDataAccess.LoadCategoriesByParentId();

            treeView.BeginUpdate();
            treeView.Nodes.Clear();

            foreach (var category in data)
            {
                treeView.Nodes.Add(
                    new TreeNode(category.Name)
                    {
                        Tag = category.Id
                    });
            }

            treeView.EndUpdate();
        }

        private void LoadMainSubCategories()
        {
            treeView.BeginUpdate();

            foreach (var parent in treeView.Nodes)
            {
                var parentNode = (TreeNode)parent;
                var categories = SqliteDataAccess.LoadCategoriesByParentId(Convert.ToInt64(parentNode.Tag));

                foreach (var category in categories)
                {
                    parentNode.Nodes.Add(
                        new TreeNode(category.Name)
                        {
                            Tag = category.Id
                        });
                }
            }

            treeView.EndUpdate();
        }

        #endregion

        #region View Controls

        private void SetDataView(CategoryModel category)
        {
            nameTextBox.Text = category.Name;

            parentCategoryId = category.Id_Parent;
            if (parentCategoryId == 0)
                categoryTextBox.Clear();
            else
                categoryTextBox.Text = SqliteDataAccess.GetCategoryById(parentCategoryId).Name;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
            categoryTextBox.Clear();
            parentCategoryId = 0;
        }

        #endregion

        #region Buttons Click Handlers

        private void loadButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null)
                return;

            parentCategoryId = Convert.ToInt64(treeView.SelectedNode.Tag);
            var category = SqliteDataAccess.GetCategoryById(parentCategoryId);
            categoryTextBox.Text = category.Name;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            categoryTextBox.Clear();
            parentCategoryId = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null)
                return;

            selectedId = Convert.ToInt64(treeView.SelectedNode.Tag);
            var category = SqliteDataAccess.GetCategoryById(selectedId);
            SetDataView(category);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the category!", "Edit category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoryModel category = new CategoryModel
            {
                Id = selectedId,
                Name = nameTextBox.Text.Trim(),
                Id_Parent = parentCategoryId
            };

            SqliteDataAccess.UpdateCategory(category);

            selectedId = -1;
            ClearDataView();

            LoadList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            ClearDataView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new category", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the category!", "Add category", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CategoryModel category = new CategoryModel
            {
                Name = nameTextBox.Text.Trim(),
                Id_Parent = Convert.ToInt64(parentCategoryId)
            };

            SqliteDataAccess.AddCategory(category);

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null)
                return;

            selectedId = Convert.ToInt64(treeView.SelectedNode.Tag);

            var result = MessageBox.Show($"Are you sure you want to delete category \"{treeView.SelectedNode.Text}\" with all subcategories (if exist)?", "Delete Category", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqliteDataAccess.DeleteCategoryById(selectedId);
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY constraint failed"))
                    {
                        MessageBox.Show("You can't delete a category that is used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            selectedId = -1;
            ClearDataView();

            LoadList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        #endregion

        #region Resize Handlers

        private void EditCategoriesForm_Resize(object sender, EventArgs e)
        {
            ResizeTreeView();
        }

        private void ResizeTreeView()
        {
            // Resize treeView to fit the form
            treeView.Size = new Size(originalTreeViewSize.Width + (Width - originalFormSize.Width),
                                     originalTreeViewSize.Height + (Height - originalFormSize.Height));
        }

        #endregion

        #region Other Controls Handlers

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.BeginUpdate();

            foreach (var parent in e.Node.Nodes)
            {
                var parentNode = (TreeNode)parent;
                var categories = SqliteDataAccess.LoadCategoriesByParentId(Convert.ToInt64(parentNode.Tag));

                foreach (var category in categories)
                {
                    parentNode.Nodes.Add(
                        new TreeNode(category.Name)
                        {
                            Tag = category.Id
                        });
                }
            }

            treeView.EndUpdate();
        }

        private void treeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treeView.BeginUpdate();

            foreach (var node in e.Node.Nodes)
            {
                var treeNode = (TreeNode)node;
                treeNode.Collapse();
                treeNode.Nodes.Clear();
            }

            treeView.EndUpdate();
        }

        #endregion
    }
}
