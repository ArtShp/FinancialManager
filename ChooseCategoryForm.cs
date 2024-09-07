﻿namespace FinancialManager
{
    public partial class ChooseCategoryForm : Form
    {
        private long selectedId = -1;
        public long SelectedId => selectedId;

        public ChooseCategoryForm()
        {
            InitializeComponent();

            LoadAll();
        }

        #region Loaders

        private void LoadAll()
        {
            LoadList();
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

        #region Buttons Click Handlers

        private void chooseButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(treeView.SelectedNode.Tag);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
