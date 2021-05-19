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
    public partial class GeneralUI : Form
    {
        List<SettingsModel> settings = new List<SettingsModel>();
        List<ItemModel> items = new List<ItemModel>();
        List<ItemModel> filteredItems = new List<ItemModel>();
        private string sortingType;
        private bool isSortingAscending;
        private bool isCompleted = false;
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
            settings = SqliteDataAccess.LoadSettings();
            GetSettings();
            LoadItemList(_currentList);
            SetUpDatagridDesign();
        }

        private void GetSettings()
        {
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
            //dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 40;
        }

        public void LoadItemList(string currentList)
        {
            items = SqliteDataAccess.LoadItems(currentList);
            var temp = GetTempList(items);
            WireUpList(temp);
        }

        private List<ItemModel> GetTempList(List<ItemModel> items)
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
            LotteryUI lotteryUI = new LotteryUI(filteredItems, _currentList, this);
            lotteryUI.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
            SqliteDataAccess.TransferWatchOrCompleted(item, _currentList, GetSwitchList(_currentList));
            LoadItemList(_currentList);
        }

        private void btnOnWatch_Click(object sender, EventArgs e)
        {
            isCompleted = false;
            btnTransfer.Text = "Transfer to Completed";
            _currentList = GetSwitchList(_currentList);
            LoadItemList(_currentList);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            isCompleted = true;
            btnTransfer.Text = "Transfer to On watch";
            _currentList = GetSwitchList(_currentList);
            LoadItemList(_currentList);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditUI editUI = new EditUI(_currentList, this, false);
            editUI.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
            EditUI editUI = new EditUI(item, _currentList, this, true);
            editUI.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemModel item = (ItemModel)dataGridView1.SelectedRows[0].DataBoundItem;
            SqliteDataAccess.DeleteFromList(item, _currentList);
            LoadItemList(_currentList);
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

        }
    }
}
