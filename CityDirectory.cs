using System.Data;

namespace World
{
    public partial class CityDirectory : Form
    {

        private CityDirectorySqlData _cityDirectoryData;
        private DirectoryCommit _commit;
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        private readonly Color LightGreen = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(192)))), ((int)(((byte)(49)))));
        private readonly Color LightBlue = Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(206)))), ((int)(((byte)(252)))));

        //private struct 

        public CityDirectory()
        {
            InitializeComponent();
            _cityDirectoryData = new CityDirectorySqlData(databaseName: "CityDirectory");
            _commit = new DirectoryCommit();

            var items = new[]
            {
                new{ Text = "М.", Value = $"{(int)TypeSettlement.City}" },
                new{ Text = "с.", Value = $"{(int)TypeSettlement.Village}" },
                new{ Text = "обл.", Value = $"{(int)TypeSettlement.RegionalCenter}" },
                new{ Text = "рег.", Value = $"{(int)TypeSettlement.DistrictCenter}" },
            };

            selectTypeSettlement.DisplayMember = "Text";
            selectTypeSettlement.ValueMember = "Value";
            selectTypeSettlement.DataSource = items;
        }


        private void World_Load(object sender, EventArgs e)
        {
            OutputDataFromAllDirectories();
        }

        public void OutputDataFromAllDirectories()
        {
            int firstId = OutputDataFromCountriesDirectory();

            firstId = OutputDataFromRegionDirectory(contryId: firstId);

            firstId = OutputDataFromDistrictDirectory(regionId: firstId);

            OutputDataFromSettlementDirectory(districtId: firstId);
        }

        public void OutputDataFromAllDirectories(DirectoryCommit commit)
        {
            OutputDataFromCountriesDirectory();
            OutputDataFromRegionDirectory(contryId: commit.ForeignCountryId);
            OutputDataFromDistrictDirectory(regionId: commit.ForeignRegionId);
            OutputDataFromSettlementDirectory(districtId: commit.ForeignDistrictId);

            if (dataCountriesDirectory.Rows.Count != 0 && commit.CountryIndex != null)
            {
                if (dataCountriesDirectory.Rows.Count <= commit.CountryIndex.Value)
                {
                    commit.CountryIndex--;
                }
                dataCountriesDirectory.CurrentCell = dataCountriesDirectory.Rows[commit.CountryIndex.Value].Cells["Name"];
            }
            if (dataRegionsDirectory.Rows.Count != 0 && commit.RegionIndex != null)
            {
                if (dataRegionsDirectory.Rows.Count <= commit.RegionIndex.Value)
                {
                    commit.RegionIndex--;
                }
                dataRegionsDirectory.CurrentCell = dataRegionsDirectory.Rows[commit.RegionIndex.Value].Cells["Name"];
            }
            if (dataDistrictsDirectory.Rows.Count != 0 && commit.DistrictIndex != null)
            {
                if (dataDistrictsDirectory.Rows.Count <= commit.DistrictIndex.Value)
                {
                    commit.DistrictIndex--;
                }
                dataDistrictsDirectory.CurrentCell = dataDistrictsDirectory.Rows[commit.DistrictIndex.Value].Cells["Name"];
            }
        }

        /// <returns>First Id in the country directoty</returns>
        private int OutputDataFromCountriesDirectory()
        {
            return OutputDataDirectory(dataGridView: dataCountriesDirectory,
                dataTable: _cityDirectoryData.GetDirectoryData(directoryName: "Countries"));
        }

        /// <returns>First Id in the region directoty</returns>
        private int OutputDataFromRegionDirectory(int contryId)
        {
            return OutputDataDirectory(dataGridView: dataRegionsDirectory,
                dataTable: _cityDirectoryData.GetDirectoryData(directoryName: "Regions", foreignIdName: "CountryId", foreignId: contryId));
        }

        /// <returns>First Id in the district directoty</returns>
        private int OutputDataFromDistrictDirectory(int regionId)
        {
            return OutputDataDirectory(dataGridView: dataDistrictsDirectory,
                dataTable: _cityDirectoryData.GetDirectoryData(directoryName: "Districts", foreignIdName: "RegionId", foreignId: regionId));
        }

        private void OutputDataFromSettlementDirectory(int districtId)
        {
            OutputDataFromSettlementDirectory(dataGridView: dataSettlementsDirectory,
                dataTable: _cityDirectoryData.GetSettlementsDirectoryData(directoryName: "Settlements", foreignIdName: "DistrictId", foreignId: districtId));

            dataSettlementsDirectory.Select();
        }

        private void OutputDataFromSettlementDirectory(DataGridView dataGridView, DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                dataGridView.DataSource = null;
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i].SetField<string>("Name",
                    $"{TypeSettlementExtension.GetNameOfTypeSettlement(Convert.ToInt32(dataTable.Rows[i]["TypeSettlement"]))}." +
                    $" {dataTable.Rows[i]["Name"]}");
            }

            OutputDataDirectory(dataGridView, dataTable);

            SetColortypeSettlement(dataGridView);

            dataGridView.Columns["TypeSettlement"].Visible = false;
        }

        /// <summary>
        /// Specific item first then to sort the rest of the items.
        /// Then output data from settlement directory. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedTypeSettlement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataDistrictsDirectory.CurrentRow == null)
            {
                return;
            }

            SqlParameters sqlParameters = new SqlParameters()
            {
                DirectoryName = "Settlements",
                ForeignIdName = "DistrictId",
                ForeignId = Convert.ToInt32(dataDistrictsDirectory.CurrentRow.Cells["Id"].Value),
                TypeSettlement = Convert.ToInt32(selectTypeSettlement.SelectedValue)
            };

            OutputDataFromSettlementDirectory(dataGridView: dataSettlementsDirectory,
                dataTable: _cityDirectoryData.GetSettlementsDirectoryDataWithPrioritySort(sqlParameters));
        }

        private void SetColortypeSettlement(DataGridView dataGridView)
        {
            int typeSettlement;
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                typeSettlement = Convert.ToInt32(dataGridView.Rows[i].Cells["TypeSettlement"].Value);

                if (typeSettlement == (int)TypeSettlement.DistrictCenter)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = LightBlue;
                }
                if (typeSettlement == (int)TypeSettlement.RegionalCenter)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = LightGreen;
                }
            }
        }

        /// <returns>First Id in the directoty</returns>
        private int OutputDataDirectory(DataGridView dataGridView, DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                dataGridView.DataSource = null;
                return 0;
            }

            dataGridView.DataSource = dataTable;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Select();

            return Convert.ToInt32(dataGridView.Rows[0].Cells["Id"].Value);
        }

        /// <summary>
        /// Occurs when the cell of dataCountriesDirectory is clicked.
        /// Output data of country such as regions, districts, settlements. 
        /// </summary>
        /// <param name="sender">dataCountriesDirectory</param>
        private void NewCountryHasBeenChosen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OutputCascadeDataFromCountryDirectory();
        }

        private void OutputCascadeDataFromCountryDirectory()
        {
            if (dataCountriesDirectory.CurrentRow == null)
            {
                dataCountriesDirectory.DataSource = null;
                dataRegionsDirectory.DataSource = null;
                dataDistrictsDirectory.DataSource = null;
                dataSettlementsDirectory.DataSource = null;
                return;
            }

            int selectedCountryId = Convert.ToInt32(dataCountriesDirectory.CurrentRow.Cells["Id"].Value);
            int firstId = OutputDataFromRegionDirectory(contryId: selectedCountryId);
            firstId = OutputDataFromDistrictDirectory(regionId: firstId);
            OutputDataFromSettlementDirectory(districtId: firstId);
        }

        /// <summary>
        /// Occurs when the cell of dataRegionsDirectory is clicked.
        /// Output data of region of country such as districts, settlements. 
        /// </summary>
        /// <param name="sender">dataRegionsDirectory</param>
        private void NewRegionHasBeenChosen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OutputCascadeDataFromRegionDirectory();
        }

        private void OutputCascadeDataFromRegionDirectory()
        {
            if (dataRegionsDirectory.CurrentRow == null)
            {
                dataRegionsDirectory.DataSource = null;
                dataDistrictsDirectory.DataSource = null;
                dataSettlementsDirectory.DataSource = null;
                return;
            }

            int selectedRegionId = Convert.ToInt32(dataRegionsDirectory.CurrentRow?.Cells["Id"].Value);
            int firstId = OutputDataFromDistrictDirectory(regionId: selectedRegionId);
            OutputDataFromSettlementDirectory(districtId: firstId);
        }

        /// <summary>
        /// Occurs when the cell of dataDistrictDirectory is clicked.
        /// Output data of district of region of country such as settlements. 
        /// </summary>
        /// <param name="sender">dataDistrictDirectory</param>
        private void NewDistrictsHasBeenChosen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OutputCascadeDataFromDistrictDirectory();
        }

        private void OutputCascadeDataFromDistrictDirectory()
        {
            if (dataDistrictsDirectory.CurrentRow == null)
            {
                dataDistrictsDirectory.DataSource = null;
                dataSettlementsDirectory.DataSource = null;
                return;
            }

            int selectedDistrictId = Convert.ToInt32(dataDistrictsDirectory.CurrentRow?.Cells["Id"].Value);
            OutputDataFromSettlementDirectory(districtId: selectedDistrictId);
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cross_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox сross)
            {
                сross.BackColor = Color.Red;
            }
        }

        private void Cross_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox сross)
            {
                сross.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(212)))));
            }
        }

        private void AddCountryIntoDirectory_Click(object sender, EventArgs e)
        {
            CreateAdderData(parameters: new SqlParameters()
            {
                DirectoryName = "Countries",
            },
            addDataIntoDirectory: _cityDirectoryData.AddDataIntoDirectory,
            labelText: "Додати населений пункт в довідник");
        }

        private void AddRegionIntoDirectory_Click(object sender, EventArgs e)
        {
            if (dataCountriesDirectory.CurrentRow == null)
            {
                return;
            }

            CreateAdderData(parameters: new SqlParameters()
            {
                DirectoryName = "Regions",
                ForeignId = Convert.ToInt32(dataCountriesDirectory.CurrentRow.Cells["Id"].Value),
                ForeignIdName = "CountryId",
            },
            addDataIntoDirectory: _cityDirectoryData.AddDataIntoDirectoryWithForeignId,
            labelText: "Додати область в довідник");
        }

        private void AddDistrictIntoDirectory_Click(object sender, EventArgs e)
        {
            if (dataRegionsDirectory.CurrentRow == null)
            {
                return;
            }

            CreateAdderData(parameters: new SqlParameters()
            {
                DirectoryName = "Districts",
                ForeignId = Convert.ToInt32(dataRegionsDirectory.CurrentRow.Cells["Id"].Value),
                ForeignIdName = "RegionId",
            },
            addDataIntoDirectory: _cityDirectoryData.AddDataIntoDirectoryWithForeignId,
            labelText: "Додати регіон в довідник");
        }

        private void AddSettlementIntoDirectory_Click(object sender, EventArgs e)
        {
            if (dataDistrictsDirectory.CurrentRow == null)
            {
                return;
            }

            CreateSettlementAdderData(parameters: new SqlParameters()
            {
                DirectoryName = "Settlements",
                ForeignId = Convert.ToInt32(dataDistrictsDirectory.CurrentRow.Cells["Id"].Value),
                ForeignIdName = "DistrictId",
            },
            addDataIntoDirectory: _cityDirectoryData.AddDataIntoSettlementDirectory);
        }

        private void CreateSettlementAdderData(SqlParameters parameters, AddDataIntoDirectoryHandler addDataIntoDirectory)
        {
            AdderDataIntoSettlementDirectory addData = new(parameters, addDataIntoDirectory);
            addData.Owner = this;
            this.Enabled = false;
            addData.latelText.Text = "Додати населений пункт в довідник";
            addData.Show();
        }

        private void CreateAdderData(SqlParameters parameters, AddDataIntoDirectoryHandler addDataIntoDirectory, string labelText)
        {
            AdderDataIntoDirectory addData = new(parameters, addDataIntoDirectory);
            addData.Owner = this;
            this.Enabled = false;
            addData.latelText.Text = labelText;
            addData.Show();
        }

        private void RemoveCountry_Click(object sender, EventArgs e)
        {
            RemoveItemFromDirectory(dataGridView: dataCountriesDirectory, directoryName: "Countries");
        }

        private void RemoveRegion_Click(object sender, EventArgs e)
        {
            RemoveItemFromDirectory(dataGridView: dataRegionsDirectory, directoryName: "Regions");
        }

        private void RemoveDistrict_Click(object sender, EventArgs e)
        {
            RemoveItemFromDirectory(dataGridView: dataDistrictsDirectory, directoryName: "Districts");
        }

        private void RemoveSettlement_Click(object sender, EventArgs e)
        {
            RemoveItemFromDirectory(dataGridView: dataSettlementsDirectory, directoryName: "Settlements");
        }

        private DialogResult MessageForRemove(string nameOfItemToBeDeleted)
        {
            return MessageBox.Show(text: $"Ви впевнені в тому що хочете видалити \"{nameOfItemToBeDeleted}\"?",
                caption: "Видалення елемента", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Asterisk,
                defaultButton: MessageBoxDefaultButton.Button2);
        }

        private void RemoveItemFromDirectory(DataGridView dataGridView, string directoryName)
        {
            Commit();

            if (dataGridView.CurrentRow == null)
            {
                return;
            }

            if (DialogResult.No == MessageForRemove(Convert.ToString(value: dataGridView.CurrentRow.Cells["Name"].Value) ?? ""))
            {
                return;
            }

            _cityDirectoryData.DeleteItemFromDirectory(new SqlParameters()
            {
                DirectoryName = directoryName,
                Id = Convert.ToInt32(value: dataGridView.CurrentRow.Cells["Id"].Value)
            });

            OutputDataFromAllDirectories(_commit);
        }

        private void UpdateDirectory_EnabledChanged(object sender, EventArgs e)
        {
            if ((sender is not Form) || ((Form)sender).Enabled == false)
            {
                Commit();
                return;
            }

            OutputDataFromAllDirectories(_commit);
        }

        private void Commit()
        {
            _commit.ForeignCountryId = Convert.ToInt32(dataCountriesDirectory.CurrentRow?.Cells["Id"].Value);
            _commit.ForeignDistrictId = Convert.ToInt32(dataDistrictsDirectory.CurrentRow?.Cells["Id"].Value);
            _commit.ForeignRegionId = Convert.ToInt32(dataRegionsDirectory.CurrentRow?.Cells["Id"].Value);
            _commit.CountryIndex = dataCountriesDirectory.CurrentRow?.Index;
            _commit.RegionIndex = dataRegionsDirectory.CurrentRow?.Index;
            _commit.DistrictIndex = dataDistrictsDirectory.CurrentRow?.Index;
        }

        /// <summary>
        /// Moves the form
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = (IntPtr)(HT_CAPTION);
            }
        }

        private void SearchCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
            {
                return;
            }

            string text = ((TextBox)sender).Text;

            if (string.IsNullOrEmpty(text))
            {
                OutputDataFromAllDirectories();
                return;
            }

            dataCountriesDirectory.DataSource = _cityDirectoryData.GetDirectoryDataSearchByName(new SqlParameters()
            {
                DirectoryName = "Countries",
                NameSearch = ((TextBox)sender).Text
            });

            dataCountriesDirectory.Select();

            OutputCascadeDataFromCountryDirectory();
        }

        private void SearchRegion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter || dataCountriesDirectory.CurrentRow == null)
            {
                return;
            }

            string text = ((TextBox)sender).Text;

            if (string.IsNullOrEmpty(text))
            {
                OutputCascadeDataFromCountryDirectory();
                return;
            }

            dataRegionsDirectory.DataSource = _cityDirectoryData.GetDirectoryDataSearchByNameWithForignId(new SqlParameters()
            {
                DirectoryName = "Regions",
                NameSearch = ((TextBox)sender).Text,
                ForeignIdName = "CountryId",
                ForeignId = Convert.ToInt32(dataCountriesDirectory.CurrentRow.Cells["Id"].Value)
            });

            dataRegionsDirectory.Select();

            OutputCascadeDataFromRegionDirectory();
        }

        private void SearchDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter || dataRegionsDirectory.CurrentRow == null)
            {
                return;
            }

            string text = ((TextBox)sender).Text;

            if (string.IsNullOrEmpty(text))
            {
                OutputCascadeDataFromRegionDirectory();
                return;
            }

            dataDistrictsDirectory.DataSource = _cityDirectoryData.GetDirectoryDataSearchByNameWithForignId(new SqlParameters()
            {
                DirectoryName = "Districts",
                NameSearch = ((TextBox)sender).Text,
                ForeignIdName = "RegionId",
                ForeignId = Convert.ToInt32(dataRegionsDirectory.CurrentRow.Cells["Id"].Value)
            });

            dataDistrictsDirectory.Select();

            OutputCascadeDataFromDistrictDirectory();
        }

        private void SearchSettlement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter || dataDistrictsDirectory.CurrentRow == null)
            {
                return;
            }

            string text = ((TextBox)sender).Text;

            if (string.IsNullOrEmpty(text))
            {
                OutputDataFromSettlementDirectory(districtId: Convert.ToInt32(dataDistrictsDirectory.CurrentRow.Cells["Id"].Value));
                return;
            }

            DataTable dataTable = _cityDirectoryData.GetSettlementsDirectoryDataSearchByNameWithForignId(new SqlParameters()
            {
                DirectoryName = "Settlements",
                NameSearch = ((TextBox)sender).Text,
                ForeignIdName = "DistrictId",
                ForeignId = Convert.ToInt32(dataDistrictsDirectory.CurrentRow.Cells["Id"].Value)
            });

            OutputDataFromSettlementDirectory(dataGridView: dataSettlementsDirectory, dataTable);

            dataSettlementsDirectory.Select();
        }
    }
}


