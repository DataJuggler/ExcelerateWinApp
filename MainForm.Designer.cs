namespace ExcelerateWinApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FileSelector = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            UpdateButton = new DataJuggler.Win.Controls.Button();
            Graph = new ProgressBar();
            StatusLabel = new Label();
            ExtensionLabel = new Label();
            SuspendLayout();
            // 
            // FileSelector
            // 
            FileSelector.BackColor = Color.Transparent;
            FileSelector.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            FileSelector.ButtonColor = Color.LemonChiffon;
            FileSelector.ButtonImage = (Image)resources.GetObject("FileSelector.ButtonImage");
            FileSelector.ButtonWidth = 48;
            FileSelector.DarkMode = false;
            FileSelector.DisabledLabelColor = Color.Empty;
            FileSelector.Editable = true;
            FileSelector.EnabledLabelColor = Color.Empty;
            FileSelector.Filter = "Excel Files|*.xlsx;";
            FileSelector.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelector.HideBrowseButton = false;
            FileSelector.LabelBottomMargin = 0;
            FileSelector.LabelColor = Color.LemonChiffon;
            FileSelector.LabelFont = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FileSelector.LabelText = "Excel File:";
            FileSelector.LabelTopMargin = 0;
            FileSelector.LabelWidth = 120;
            FileSelector.Location = new Point(36, 38);
            FileSelector.Name = "FileSelector";
            FileSelector.OnTextChangedListener = null;
            FileSelector.OpenCallback = null;
            FileSelector.ScrollBars = ScrollBars.None;
            FileSelector.SelectedPath = null;
            FileSelector.Size = new Size(1016, 32);
            FileSelector.StartPath = null;
            FileSelector.TabIndex = 0;
            FileSelector.TextBoxBottomMargin = 0;
            FileSelector.TextBoxDisabledColor = Color.Empty;
            FileSelector.TextBoxEditableColor = Color.Empty;
            FileSelector.TextBoxFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileSelector.TextBoxTopMargin = 0;
            FileSelector.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.Transparent;
            UpdateButton.ButtonText = "Update";
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateButton.ForeColor = Color.LemonChiffon;
            UpdateButton.Location = new Point(897, 118);
            UpdateButton.Margin = new Padding(6, 4, 6, 4);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(155, 46);
            UpdateButton.TabIndex = 1;
            UpdateButton.TextAlign = ContentAlignment.MiddleCenter;
            UpdateButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Graph
            // 
            Graph.Location = new Point(36, 292);
            Graph.Name = "Graph";
            Graph.Size = new Size(1016, 23);
            Graph.TabIndex = 2;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = Color.Transparent;
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(37, 259);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(1015, 29);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            StatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            StatusLabel.Visible = false;
            // 
            // ExtensionLabel
            // 
            ExtensionLabel.BackColor = Color.Transparent;
            ExtensionLabel.ForeColor = Color.LemonChiffon;
            ExtensionLabel.Location = new Point(312, 73);
            ExtensionLabel.Name = "ExtensionLabel";
            ExtensionLabel.Size = new Size(465, 29);
            ExtensionLabel.TabIndex = 4;
            ExtensionLabel.Text = "Excel file must be saved with extension .xlsx";
            ExtensionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.BlackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1103, 335);
            Controls.Add(ExtensionLabel);
            Controls.Add(StatusLabel);
            Controls.Add(Graph);
            Controls.Add(UpdateButton);
            Controls.Add(FileSelector);
            DoubleBuffered = true;
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excelerate Win App";
            ResumeLayout(false);
        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl FileSelector;
        private DataJuggler.Win.Controls.Button UpdateButton;
        private ProgressBar Graph;
        private Label StatusLabel;
        private Label ExtensionLabel;
    }
}