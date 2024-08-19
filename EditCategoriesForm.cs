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
    }
}
