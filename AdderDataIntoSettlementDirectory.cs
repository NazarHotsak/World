using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World
{
    public partial class AdderDataIntoSettlementDirectory : AdderData
    {
        public AdderDataIntoSettlementDirectory(SqlParameters parameters, AddDataIntoDirectoryHandler addDataIntoDirectory) 
            : base(parameters, addDataIntoDirectory)
        {
            InitializeComponent();

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

        protected override void AddDataIntoDirectory()
        {
            if (string.IsNullOrEmpty(dataName.Text) == false)
            {
                _sqlParameters.DataName = dataName.Text;
                _sqlParameters.TypeSettlement = Convert.ToInt32(selectTypeSettlement.SelectedValue);
                _addDataIntoDirectory?.Invoke(parameters: _sqlParameters);
            }
            ((Form)this.Owner).Enabled = true;
            this.Close();
        }
    }
}
