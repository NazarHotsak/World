namespace World
{
    partial class AdderDataIntoDirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdderDataIntoDirectory));
            this.workspace = new System.Windows.Forms.Panel();
            this.add = new System.Windows.Forms.Button();
            //this.dataName = new System.Windows.Forms.TextBox();
            this.latelText = new System.Windows.Forms.Label();
            this.cross = new System.Windows.Forms.PictureBox();
            this.workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).BeginInit();
            this.SuspendLayout();
            // 
            // workspace
            // 
            this.workspace.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.workspace.Controls.Add(this.add);
            this.workspace.Controls.Add(this.dataName);
            this.workspace.Controls.Add(this.latelText);
            this.workspace.Location = new System.Drawing.Point(1, 25);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(298, 127);
            this.workspace.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(203, 87);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(80, 30);
            this.add.TabIndex = 2;
            this.add.Text = "Додати";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddDataIntoDirectory_Click);
            // 
            // dataName
            //// 
            //this.dataName.Location = new System.Drawing.Point(15, 50);
            //this.dataName.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            //this.dataName.Name = "dataName";
            //this.dataName.Size = new System.Drawing.Size(268, 27);
            //this.dataName.TabIndex = 1;
            //this.dataName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDataIntoDirectory_KeyDown);
            // 
            // latelText
            // 
            this.latelText.AutoSize = true;
            this.latelText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latelText.Location = new System.Drawing.Point(15, 15);
            this.latelText.Name = "latelText";
            this.latelText.Size = new System.Drawing.Size(0, 20);
            this.latelText.TabIndex = 0;
            // 
            // cross
            // 
            this.cross.Image = ((System.Drawing.Image)(resources.GetObject("cross.Image")));
            this.cross.Location = new System.Drawing.Point(275, 0);
            this.cross.Margin = new System.Windows.Forms.Padding(3, 6, 6, 3);
            this.cross.Name = "cross";
            this.cross.Padding = new System.Windows.Forms.Padding(6, 6, 2, 2);
            this.cross.Size = new System.Drawing.Size(25, 25);
            this.cross.TabIndex = 1;
            this.cross.TabStop = false;
            this.cross.Click += new System.EventHandler(this.CloseApplication_Click);
            this.cross.MouseLeave += new System.EventHandler(this.Cross_MouseLeave);
            this.cross.MouseHover += new System.EventHandler(this.Cross_MouseHover);
            // 
            // AdderDataIntoDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(300, 153);
            this.Controls.Add(this.cross);
            this.Controls.Add(this.workspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdderDataIntoDirectory";
            this.workspace.ResumeLayout(false);
            this.workspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cross)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel workspace;
        private PictureBox cross;
        private Button add;
        //
        //private TextBox dataName;
        public Label latelText;
    }
}