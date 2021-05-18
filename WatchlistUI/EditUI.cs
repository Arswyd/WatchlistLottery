using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchlistLibrary;

namespace WatchlistUI
{
    public partial class EditUI : Form
    {
        private ItemModel _item = new ItemModel();
        private GeneralUI _generalUI;
        private string _currentList;
        private bool _isExisting;
        public EditUI(string currentList, GeneralUI generalUI, bool isExisting)
        {
            InitializeComponent();
            _generalUI = generalUI;
            _currentList = currentList;
            _isExisting = isExisting;
        }

        public EditUI(ItemModel item, string currentList, GeneralUI generalUI, bool isExisting)
        {
            InitializeComponent();

            _item = item;
            _generalUI = generalUI;
            _currentList = currentList;
            _isExisting = isExisting;

            txtTitle.Text = _item.Title;
            txtScore.Text = _item.Score.ToString();
            txtDate.Text = _item.Date.ToString();
            cmbCategory.Text = _item.Category;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _item.Title = txtTitle.Text;
            _item.Score = Convert.ToDouble(txtScore.Text);
            _item.Date = Convert.ToInt32(txtDate.Text);
            _item.Category = cmbCategory.Text;

            if (_isExisting)
            {
                SqliteDataAccess.EditListItem(_item, _currentList);
                _generalUI.LoadItemList(_currentList);
            }
            else
            {
                SqliteDataAccess.AddItemToList(_item, _currentList);
                _generalUI.LoadItemList(_currentList);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
