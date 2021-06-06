using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchlistLibrary;

namespace WatchlistUI
{
    public partial class SettingsUI : Form
    {
        List<SettingsModel> _settings = new List<SettingsModel>();
        private GeneralUI _generalUI;
        public SettingsUI(GeneralUI generalUI, List<SettingsModel> settings)
        {
            InitializeComponent();
            _settings = settings;
            _generalUI = generalUI;
            WireUpSettingUI();
        }

        private void WireUpSettingUI()
        {
            txtName1.Text = _settings[0].SettingData;
            txtCategory1.Text = _settings[1].SettingData;
            txtName2.Text = _settings[2].SettingData;
            txtCategory2.Text = _settings[3].SettingData;
            txtName3.Text = _settings[4].SettingData;
            txtCategory3.Text = _settings[5].SettingData;

            cmbDefault.Items.Add(_settings[0].SettingData);
            cmbDefault.Items.Add(_settings[2].SettingData);
            cmbDefault.Items.Add(_settings[4].SettingData);

            if (_settings[6].SettingData == "FirstList")
            {
                cmbDefault.Text = _settings[0].SettingData;
            }
            else if (_settings[6].SettingData == "SecondList")
            {
                cmbDefault.Text = _settings[2].SettingData;
            }
            else if (_settings[6].SettingData == "ThirdList")
            {
                cmbDefault.Text = _settings[4].SettingData;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _settings[0].SettingData = txtName1.Text;
            _settings[1].SettingData = txtCategory1.Text;
            _settings[2].SettingData = txtName2.Text;
            _settings[3].SettingData = txtCategory2.Text;
            _settings[4].SettingData = txtName3.Text;
            _settings[5].SettingData = txtCategory3.Text;

            if (cmbDefault.Text == _settings[0].SettingData)
            {
                _settings[6].SettingData = "FirstList";
            }
            else if (cmbDefault.Text == _settings[2].SettingData)
            {
                _settings[6].SettingData = "SecondList";
            }
            else if (cmbDefault.Text == _settings[4].SettingData)
            {
                _settings[6].SettingData = "ThirdList";
            }

            SqliteDataAccess.SaveSettings(_settings);
            _generalUI.WireUpForm();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Import List

        private void btnImport1_Click(object sender, EventArgs e)
        {
            Import();
        }

        private void btnImport2_Click(object sender, EventArgs e)
        {

        }

        private void btnImport3_Click(object sender, EventArgs e)
        {

        }

        void Import()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }

            if (!String.IsNullOrEmpty(filePath))
            {
                LoadFile(filePath);
            }
        }

        void LoadFile(string filePath)
        {
            File.ReadAllLines(filePath).ToList();
        }

        List<ItemModel> ConvertToItemModel(List<string> lines)
        {
            List<ItemModel> output = new List<ItemModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(';');

                ItemModel item = new ItemModel();

                item.Title = cols[0];

                output.Add(item);
            }

            return output;
        }

        // Export List

        private void btnExport1_Click(object sender, EventArgs e)
        {
            List<ItemModel> items = SqliteDataAccess.LoadItems("FirstList");
            List<ItemModel> completedItems = SqliteDataAccess.LoadItems("FirstListCompleted");
            string BackupPath = "../../../WatchlistLibrary/ListBackup/FirstListBackup_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            SaveToFile(items, completedItems, BackupPath);
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            List<ItemModel> items = SqliteDataAccess.LoadItems("SecondList");
            List<ItemModel> completedItems = SqliteDataAccess.LoadItems("SecondListCompleted");
            string BackupPath = "../../../WatchlistLibrary/ListBackup/FirstListBackup_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            SaveToFile(items, completedItems, BackupPath);
        }

        private void btnExport3_Click(object sender, EventArgs e)
        {
            List<ItemModel> items = SqliteDataAccess.LoadItems("ThirdList");
            List<ItemModel> completedItems = SqliteDataAccess.LoadItems("ThirdListCompleted");
            string BackupPath = "../../../WatchlistLibrary/ListBackup/FirstListBackup_" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            SaveToFile(items, completedItems, BackupPath);
        }

        void SaveToFile(List<ItemModel> items, List<ItemModel> completedItems, string BackupPath)
        {
            List<string> lines = new List<string>();

            foreach (ItemModel i in items)
            {
                lines.Add($"{i.Title}; {i.Date}; {i.Category}; {i.Score}; Onwatch");
            }
            foreach (ItemModel c in completedItems)
            {
                lines.Add($"{c.Title}; {c.Date}; {c.Category}; {c.Score}; Completed");
            }

            File.WriteAllLines(BackupPath, lines);
            MessageBox.Show("Backup complete!");
        }

        // Delete All

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            DeleteAll("FirstList", "FirstListCompleted");
        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
            DeleteAll("SecondList", "SecondListCompleted");
        }

        private void btnDelete3_Click(object sender, EventArgs e)
        {
            DeleteAll("ThirdList", "ThirdListCompleted");
        }

        private void DeleteAll(string listname, string completedlistname)
        {
            SqliteDataAccess.DeleteAllFromList(listname);
            SqliteDataAccess.DeleteAllFromList(completedlistname);
            _generalUI.WireUpForm();
            this.Close();
        }
    }
}
