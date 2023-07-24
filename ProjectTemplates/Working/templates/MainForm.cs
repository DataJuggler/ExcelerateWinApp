

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.Excelerate;
using DataJuggler.UltimateHelper;
using ExcelerateWinApp.Objects;
using DataJuggler.Excelerate.Delegates;
using DataJuggler.Excelerate.Interfaces;

#endregion

namespace ExcelerateWinApp
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this app.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // wire up the listener
            FileSelector.OnTextChangedListener = this;
        }
        #endregion

        #region Events

        #region OnTextChanged(Control sender, string text)
        /// <summary>
        /// event is fired when On Text Changed
        /// </summary>
        public void OnTextChanged(Control sender, string text)
        {
            // enable the control if it exists
            UpdateButton.Enabled = TextHelper.Exists(text);
        }
        #endregion

        #region UpdateButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'UpdateButton' is clicked.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // load your object(s)
            string workbookPath = FileSelector.Text;

            // Example WorksheetInfo object             
            WorksheetInfo info = new WorksheetInfo();
            info.LoadColumnOptions = LoadColumnOptionsEnum.LoadAllColumnsExceptExcluded;
            info.Path = workbookPath;

            // Change to your SheetName
            info.SheetName = "";

            // Example load Worksheet
            Worksheet worksheet = ExcelDataLoader.LoadWorksheet(workbookPath, info);

            // If the worksheet object exist
            if (NullHelper.Exists(worksheet))
            {
                // load your objects (example)
                // List<Address> addresses = Address.Load(worksheet);

                // perform your updates 

                // to save back to Excel
                // you must convert the list before we can pass it in
                // List<IExcelerateObject> excelerateObjectList = addresses.Cast<IExcelerateObject>().ToList();

                // Save Worksheet Example
                // ExcelHelper.SaveWorksheet(excelerateObjectList, worksheet, info, SaveWorksheetCallback, 500);

                // show finished
                StatusLabel.Text = "Done.";
                Graph.Visible = false;
            }
        }
        #endregion

        #endregion

        #region Methods

        #region SaveWorksheetCallback(SaveWorksheetResponse resonse)
        /// <summary>
        /// Save Worksheet Callback
        /// </summary>
        public void SaveWorksheetCallback(SaveWorksheetResponse response)
        {
            // If the response object exists
            if (NullHelper.Exists(response))
            {
                // Update the graph
                Graph.Value = response.RowsSaved;
                StatusLabel.Text = "Saved " + response.CurrentRowNumber + " of " + response.TotalRows;

                // update the UI
                Refresh();
                Application.DoEvents();
            }
        }
        #endregion

        #region SetupGraph()
        /// <summary>
        /// Setup Graph
        /// </summary>
        public void SetupGraph(string statusText, int graphMaxium, bool showGraph)
        {
            // Show or hide
            StatusLabel.Text = statusText;
            StatusLabel.Visible = showGraph;
            Graph.Maximum = graphMaxium;
            Graph.Visible = showGraph;
            Graph.Value = 0;
        }
        #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
