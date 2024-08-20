using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class EditCategoriesForm : Form
    {
        private List<CategoryModel> data = new List<CategoryModel>();
        private long selectedId = -1;
        private long parentCategoryId = 0;

        public EditCategoriesForm()
        {
            InitializeComponent();

            LoadMainCategories();
            LoadMainSubCategories();
        }

        private void LoadMainCategories()
        {
            data = SqliteDataAccess.LoadCategoriesByParentId();

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

        private void loadButton_Click(object sender, EventArgs e)
        {
            parentCategoryId = Convert.ToInt64(treeView.SelectedNode.Tag);
            var category = SqliteDataAccess.GetCategoryById(parentCategoryId);
            categoryTextBox.Text = category.Name;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            categoryTextBox.Clear();
            parentCategoryId = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CategoryModel category = new CategoryModel
            {
                Name = nameTextBox.Text,
                Id_Parent = Convert.ToInt64(parentCategoryId)
            };

            SqliteDataAccess.AddCategory(category);

            clearDataView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadMainCategories();
            LoadMainSubCategories();
        }

        private void setDataView(CategoryModel category)
        {
            nameTextBox.Text = category.Name;

            if (category.Id_Parent == 0)
                categoryTextBox.Clear();
            else
                categoryTextBox.Text = SqliteDataAccess.GetCategoryById(category.Id_Parent).Name;
        }

        private void clearDataView()
        {
            nameTextBox.Clear();
            categoryTextBox.Clear();
            parentCategoryId = 0;
        }

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(treeView.SelectedNode.Tag);

            var result = MessageBox.Show($"Are you sure you want to delete category \"{treeView.SelectedNode.Text}\"?", "Delete Category", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteCategoryById(selectedId);

            selectedId = -1;
            clearDataView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(treeView.SelectedNode.Tag);
            var category = SqliteDataAccess.GetCategoryById(selectedId);
            setDataView(category);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            clearDataView();
        }
    }
}
