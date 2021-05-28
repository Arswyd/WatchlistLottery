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
    public partial class SettingsUI : Form
    {
        List<SettingsModel> _settings = new List<SettingsModel>();
        public SettingsUI(GeneralUI generalUI, List<SettingsModel> settings)
        {
            InitializeComponent();
            _settings = settings;
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

            cmbDefault.Items.Add(_settings[0].SettingData);
            cmbDefault.Items.Add(_settings[2].SettingData);
            cmbDefault.Items.Add(_settings[4].SettingData);
        }
    }
}
