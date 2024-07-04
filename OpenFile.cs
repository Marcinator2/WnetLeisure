using System;
using System.Windows.Forms;

public class OpenFile
{
    public string ShowOpenFileDialog()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            return openFileDialog.FileName;
        }

        return null; // Return null if user cancels the dialog
    }
    public string ShowOpenCsvFileDialog()
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "CSV files (*.csv)|*.csv";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            return openFileDialog.FileName;
        }

        return null; // Return null if user cancels the dialog
    }

}