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
    public partial class LotteryUI : Form
    {
        private GeneralUI _generalUI;
        List<ItemModel> temp = new List<ItemModel>();
        Random random = new Random();
        private int tempNo;
        private string _currentList;

        public LotteryUI(List<ItemModel> items, string currentList, GeneralUI generalUI)
        {
            _generalUI = generalUI;
            _currentList = currentList;
            temp = items;
            InitializeComponent();
            StartLottery();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            btnReroll.Enabled = true;
            btnAccept.Enabled = true;
            timer1.Stop();
            lblTitle.Text = temp[tempNo].Title;
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            StartLottery();
        }

        private void StartLottery()
        {
            tempNo = random.Next(temp.Count());
            pictureBox1.Enabled = true;
            btnReroll.Enabled = false;
            btnAccept.Enabled = false;
            timer1.Start();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //TODO - Try with separate class for "GetSwitchList" to parameterize!!
            if (_currentList == "FirstList")
            {
                SqliteDataAccess.TransferWatchOrCompleted(temp[tempNo], _currentList, "FirstListCompleted");
                _generalUI.LoadItemList(_currentList);
            }
            else if (_currentList != "SecondList")
            {
                SqliteDataAccess.TransferWatchOrCompleted(temp[tempNo], _currentList, "SecondListCompleted");
                _generalUI.LoadItemList(_currentList);
            }
            else if (_currentList != "ThirdList")
            {
                SqliteDataAccess.TransferWatchOrCompleted(temp[tempNo], _currentList, "ThirdListCompleted");
                _generalUI.LoadItemList(_currentList);
            }
            else
            {
                 
            }
            this.Close();
        }
    }
}
