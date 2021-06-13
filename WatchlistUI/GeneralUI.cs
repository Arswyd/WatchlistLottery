using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchlistLibrary;

namespace WatchlistUI
{
    public partial class GeneralUI : Form
    {
        List<SettingsModel> settings = new List<SettingsModel>();
        List<ItemModel> items = new List<ItemModel>();
        List<ItemModel> sortedList = new List<ItemModel>();
        private string sortingType;
        private bool isSortingAscending;
        private bool isCompleted;
        private string _firstListName;        
        private string _secondListName;        
        private string _thirdListName;
        private string _firstListCategory;
        private string _secondListCategory;
        private string _thirdListCategory;
        private string _currentList;

        public GeneralUI()
        {
            InitializeComponent();
            GetSettings();
            WireUpForm();
        }

        public void WireUpForm()
        {
            LoadItemList(_currentList);
            SetUpDatagridDesign();
            WireUpComboboxes();
        }

        private void GetSettings()
        {
            settings = SqliteDataAccess.LoadSettings();

            _currentList = settings[6].SettingData;
            _firstListName = settings[0].SettingData;
            _firstListCategory = settings[1].SettingData;
            _secondListName = settings[2].SettingData;
            _secondListCategory = settings[3].SettingData;
            _thirdListName = settings[4].SettingData;
            _thirdListCategory = settings[5].SettingData;
        }

        private void SetUpDatagridDesign()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 45;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 45;
        }

        private void WireUpComboboxes()
        {
            cmbCurrentList.Items.Clear();
            cmbCategoryFilter.Items.Clear();

            string[] categories;

            cmbCurrentList.Items.Add(_firstListName);
            cmbCurrentList.Items.Add(_secondListName);
            cmbCurrentList.Items.Add(_thirdListName);

            if (_currentList == "FirstList")
            {
                cmbCurrentList.Text = _firstListName;
                categories = _firstListCategory.Split(',');
            }
            else if(_currentList == "SecondList")
            {
                cmbCurrentList.Text = _secondListName;
                categories = _secondListCategory.Split(',');
            }
            else if (_currentList == "ThirdList")
            {
                cmbCurrentList.Text = _thirdListName;
                categories = _thirdListCategory.Split(',');
            }
            else
            {
                categories = new string[] { };
            }

            cmbCategoryFilter.Items.Add("");
            foreach (var category in categories)
            {
                cmbCategoryFilter.Items.Add(category);
            }
        }

        public void LoadItemList(string currentList)
        {
            items = SqliteDataAccess.LoadItems(currentList);
            var filteredList = GetFilteredList(items);
            sortedList = GetSortedList(filteredList);
            WireUpList(sortedList);
        }

        private List<ItemModel> GetFilteredList(List<ItemModel> items)
        {
                if (txtTitleFilter.Text != "")
                {
                    items = items.Where(x => x.Title.ToLower().Contains(txtTitleFilter.Text)).ToList();
                }
                if (txtScoreFilterMin.Text != "")
                {
                    items = items.Where(x => x.Score >= Convert.ToDouble(txtScoreFilterMin.Text)).ToList();
                }
                if (txtScoreFilterMax.Text != "")
                {
                    items = items.Where(x => x.Score <= Convert.ToDouble(txtScoreFilterMax.Text)).ToList();
                }
                if (txtDateFilterMin.Text != "")
                {
                    items = items.Where(x => x.Date >= Convert.ToInt32(txtDateFilterMin.Text)).ToList();
                }
                if (txtDateFilterMax.Text != "")
                {
                    items = items.Where(x => x.Date <= Convert.ToInt32(txtDateFilterMax.Text)).ToList();
                }
                if (cmbCategoryFilter.Text != "")
                {
                    items = items.Where(x => x.Category == cmbCategoryFilter.Text).ToList();
                }

                return items;
        }

        private List<ItemModel> GetSortedList(List<ItemModel> items)
        {
            if(sortingType == "byTitle" && isSortingAscending)
            {
                return items.OrderBy(x => x.Title).ToList();
            }
            else if(sortingType == "byTitle" && !isSortingAscending)
            {
                return items.OrderByDescending(x => x.Title).ToList();
            }
            else if (sortingType == "byScore" && isSortingAscending)
            {
                return items.OrderBy(x => x.Score).ToList();
            }
            else if (sortingType == "byScore" && !isSortingAscending)
            {
                return items.OrderByDescending(x => x.Score).ToList();
            }
            else if (sortingType == "byDate" && isSortingAscending)
            {
                return items.OrderBy(x => x.Date).ToList();
            }
            else if (sortingType == "byDate" && !isSortingAscending)
            {
                return items.OrderByDescending(x => x.Date).ToList();
            }
            else
            {
                return items;
            }
        }

        private void WireUpList(List<ItemModel> temp)
        {
            dataGridView1.DataSource = temp;
        }

        public string GetSwitchList(string currentList)
        {
            string result = null;

            switch (currentList)
            {
                case "FirstList":
                    result = "FirstListCompleted";
                    break;
                case "FirstListCompleted":
                    result = "FirstList";
                    break;
                case "SecondList":
                    result = "SecondListCompleted";
                    break;
                case "SecondListCompleted":
                    result = "SecondList";
                    break;
                case "ThirdList":
                    result = "ThirdListCompleted";
                    break;
                case "ThirdListCompleted":
                    result = "ThirdList";
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            LotteryUI lotteryUI = new LotteryUI(sortedList, _currentList, this);
            lotteryUI.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
            SqliteDataAccess.TransferWatchOrCompleted(item, _currentList, GetSwitchList(_currentList));
            LoadItemList(_currentList);
        }

        private void btnOnWatch_Click(object sender, EventArgs e)
        {
            if (isCompleted)
            {
                isCompleted = false;
                btnOnWatch.Text = "Switch to Completed";
                btnTransfer.Text = "Transfer to Completed";
                _currentList = GetSwitchList(_currentList);
                LoadItemList(_currentList);
            }
            else
            {
                isCompleted = true;
                btnOnWatch.Text = "Switch to On Watch";
                btnTransfer.Text = "Transfer to On Watch";
                _currentList = GetSwitchList(_currentList);
                LoadItemList(_currentList);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsUI settingsUI = new SettingsUI(this, settings);
            settingsUI.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditUI editUI = new EditUI(_currentList, this, false);
            editUI.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
            EditUI editUI = new EditUI(item, _currentList, this, true);
            editUI.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
                SqliteDataAccess.DeleteFromList(item, _currentList);
                LoadItemList(_currentList);
            }
        }

        private void btnSortTitle_Click(object sender, EventArgs e)
        {
            if (sortingType != "byTitle")
            {
                sortingType = "byTitle";
                isSortingAscending = true;
            }
            else
            {
                isSortingAscending = !isSortingAscending;
            }
            LoadItemList(_currentList);
        }

        private void btnSortScore_Click(object sender, EventArgs e)
        {
            if (sortingType != "byScore")
            {
                sortingType = "byScore";
                isSortingAscending = false;
            }
            else
            {
                isSortingAscending = !isSortingAscending;
            }
            LoadItemList(_currentList);
        }

        private void btnSortDate_Click(object sender, EventArgs e)
        {
            if (sortingType != "byDate")
            {
                sortingType = "byDate";
                isSortingAscending = false;
            }
            else
            {
                isSortingAscending = !isSortingAscending;
            }
            LoadItemList(_currentList);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (InputValidation.ValidateFilters(txtTitleFilter.Text, txtScoreFilterMin.Text, txtScoreFilterMax.Text, txtDateFilterMin.Text, txtDateFilterMax.Text))
            {
                LoadItemList(_currentList);
            }
            else
            {
                MessageBox.Show("Imput not valid!");
            }
        }

        private void cmbCurrentList_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cmbCurrentList.SelectedItem.ToString() == _firstListName)
            {
                _currentList = "FirstList";
            }
            else if (cmbCurrentList.SelectedItem.ToString() == _secondListName)
            {
                _currentList = "SecondList";
            }
            else if (cmbCurrentList.SelectedItem.ToString() == _thirdListName)
            {
                _currentList = "ThirdList";
            }

            WireUpForm();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtTitleFilter.Text = "";
            txtScoreFilterMin.Text = "";
            txtScoreFilterMax.Text = "";
            txtDateFilterMin.Text = "";
            txtDateFilterMax.Text = "";
            cmbCategoryFilter.Text = "";

            LoadItemList(_currentList);
        }
    }
}
