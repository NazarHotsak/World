using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class AdderData : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CAPTION = 0x2;
        protected SqlParameters _sqlParameters;
        protected AddDataIntoDirectoryHandler _addDataIntoDirectory;
        protected TextBox dataName;

        public AdderData(SqlParameters parameters, AddDataIntoDirectoryHandler addDataIntoDirectory)
        {
            _addDataIntoDirectory = addDataIntoDirectory;
            _sqlParameters = parameters;
            Init();
        }

        private void Init()
        {
            dataName = new TextBox();

            // dataName
            this.dataName.Location = new System.Drawing.Point(15, 50);
            this.dataName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.dataName.Name = "dataName";
            this.dataName.Size = new System.Drawing.Size(268, 27);
            this.dataName.TabIndex = 1;
            this.dataName.KeyDown += new System.Windows.Forms.KeyEventHandler(AddDataIntoDirectory_KeyDown);
        }

        protected void CloseApplication_Click(object sender, EventArgs e)
        {
            ((Form)this.Owner).Enabled = true;
            this.Close();
        }

        protected void Cross_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox сross)
            {
                сross.BackColor = Color.Red;
            }
        }

        protected void Cross_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox сross)
            {
                сross.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(212)))));
            }
        }

        /// <summary>
        /// Occurs when the add buttom is clicked
        /// </summary>
        protected void AddDataIntoDirectory_Click(object sender, EventArgs e)
        {
            AddDataIntoDirectory();
        }

        /// <summary>
        /// Occurs when the dataName is down
        /// </summary>
        protected void AddDataIntoDirectory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AddDataIntoDirectory();
            }
        }

        protected virtual void AddDataIntoDirectory()
        {
            if (string.IsNullOrEmpty(dataName.Text) == false)
            {
                _sqlParameters.DataName = dataName.Text;
                _addDataIntoDirectory?.Invoke(parameters: _sqlParameters);
            }
            ((Form)this.Owner).Enabled = true;
            this.Close();
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
    }
}
