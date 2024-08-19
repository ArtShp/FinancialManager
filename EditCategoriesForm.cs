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
                Name = categoryTextBox.Text,
                Id_Parent = Convert.ToInt64(parentCategoryId)
            };

            SqliteDataAccess.AddCategory(category);

            clearDataView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadMainCategories();
        }

        private void clearDataView()
        {
            nameTextBox.Clear();
            categoryTextBox.Clear();
            parentCategoryId = 0;
        }
    }
}
