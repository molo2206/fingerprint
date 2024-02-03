namespace test.Views.Indentification
{
    partial class FrmListUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            tableuser = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableuser).BeginInit();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 20;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(70, 183, 201);
            guna2Button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(873, 48);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(117, 44);
            guna2Button1.TabIndex = 6;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // tableuser
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(225, 205, 233);
            tableuser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tableuser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableuser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(155, 89, 182);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            tableuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            tableuser.ColumnHeadersHeight = 4;
            tableuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(235, 221, 240);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(188, 144, 206);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tableuser.DefaultCellStyle = dataGridViewCellStyle3;
            tableuser.GridColor = Color.FromArgb(222, 201, 231);
            tableuser.ImeMode = ImeMode.On;
            tableuser.Location = new Point(12, 110);
            tableuser.Name = "tableuser";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tableuser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tableuser.RowHeadersVisible = false;
            tableuser.RowHeadersWidth = 200;
            tableuser.RowTemplate.Height = 100;
            tableuser.RowTemplate.Resizable = DataGridViewTriState.True;
            tableuser.ScrollBars = ScrollBars.Vertical;
            tableuser.Size = new Size(986, 391);
            tableuser.TabIndex = 0;
            tableuser.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Amethyst;
            tableuser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(225, 205, 233);
            tableuser.ThemeStyle.AlternatingRowsStyle.Font = null;
            tableuser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            tableuser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            tableuser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            tableuser.ThemeStyle.BackColor = Color.White;
            tableuser.ThemeStyle.GridColor = Color.FromArgb(222, 201, 231);
            tableuser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(155, 89, 182);
            tableuser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            tableuser.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableuser.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            tableuser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            tableuser.ThemeStyle.HeaderStyle.Height = 4;
            tableuser.ThemeStyle.ReadOnly = false;
            tableuser.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(235, 221, 240);
            tableuser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableuser.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableuser.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            tableuser.ThemeStyle.RowsStyle.Height = 100;
            tableuser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(188, 144, 206);
            tableuser.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // FrmListUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 513);
            Controls.Add(guna2Button1);
            Controls.Add(tableuser);
            Name = "FrmListUser";
            Text = "FrmAddUser";
            Load += FrmListUser_Load;
            ((System.ComponentModel.ISupportInitialize)tableuser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView tableuser;
    }
}