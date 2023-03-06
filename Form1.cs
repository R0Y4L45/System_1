using System.Diagnostics;

namespace SystemProgramming_HW1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        FillProcess();
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
    }

    private void FillProcess()
    {
        foreach (Process process in Process.GetProcesses())
        {
            listBox1.Items.Add(process.Id);
            listBox2.Items.Add(process.ProcessName);
        }
        listBox3.Items.Add(@"Access is denied.
Admin access required.");
    }

    private void StartBtn_Click(object sender, EventArgs e)
    {
        Process.Start(textBox1.Text);
    }

    private void EndBtn_Click(object sender, EventArgs e)
    {
        try
        {
            string SelectedItem = listBox2?.SelectedItem?.ToString()!;
            var SelectedProcess = Process.GetProcessesByName(SelectedItem).ToList();
            foreach (var item in SelectedProcess)
            {
                item.Kill();
                SelectedProcess.Remove(item);
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message);
        }

    }

    private void RefReshBtn_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        listBox2.Items.Clear();
        listBox3.Items.Clear();
        FillProcess();
    }
}