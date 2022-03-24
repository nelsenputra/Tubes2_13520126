using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FolderCrawler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartDirButton_Click(object sender, EventArgs e)
        {
            // Membuka menu pemilihan folder dan set link label sesuai dengan pilihan folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                StartDirLinkLabel.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void StartDirLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Membuka folder sesuai dengan directory pada link label
            string directory = StartDirLinkLabel.Text;
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "explorer.exe";
                startInfo.Arguments = directory;
                Process.Start(startInfo);
            }
            catch 
            {
                MessageBox.Show(string.Format("Error in opening directory {0}", directory));
            }
        }

        private void DFSButton_Click(object sender, EventArgs e)
        {
            // Mengubah pilihan metode pencarian menjadi DFS
            Program.searchMethod = "DFS";

            DFSButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            DFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DFSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

            BFSButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            BFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BFSButton.ForeColor = System.Drawing.Color.DimGray;

        }

        private void BFSButton_Click(object sender, EventArgs e)
        {
            // Mengubah pilihan metode pencarian menjadi BFS
            Program.searchMethod = "BFS";

            BFSButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            BFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BFSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));

            DFSButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            DFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DFSButton.ForeColor = System.Drawing.Color.DimGray;
        }

        private void DFSButton_MouseEnter(object sender, EventArgs e)
        {
            if (Program.searchMethod == "DFS")
            {
                DFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
            else
            {
                DFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            }
        }

        private void DFSButton_MouseLeave(object sender, EventArgs e)
        {
            DFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }

        private void BFSButton_MouseEnter(object sender, EventArgs e)
        {
            if (Program.searchMethod == "BFS")
            {
                BFSButton.BackColor = DFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
            else
            {
                BFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            }
        }

        private void BFSButton_MouseLeave(object sender, EventArgs e)
        {
            BFSButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchButton.Enabled = false;
            bool isNumeric = int.TryParse(StepDelayTextbox.Text, out _);
            if (FileNameTextBox.Text == "")
            {
                MessageBox.Show("File name must be filled out!");
            }
            else if (!isNumeric)
            {
                MessageBox.Show("Step delay must be integer!");
            }
            else
            {
                string startingDirectory = StartDirLinkLabel.Text;
                string searchMethod = Program.searchMethod;
                string filename = FileNameTextBox.Text;
                bool findAllOccurance = AllOccCheckbox.Checked;
                int.TryParse(StepDelayTextbox.Text, out int stepDelay);

                PathFlowPanel.Controls.Clear();
                gViewer.Graph = null;

                // Label metode pencarian yang digunakan
                Label methodLabel = new Label();
                methodLabel.Text = string.Format("{0} method is used in searching process.", searchMethod);
                methodLabel.AutoSize = true;
                methodLabel.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                PathFlowPanel.Controls.Add(methodLabel);

                Stopwatch stopwatch = Stopwatch.StartNew();

                DFS dfs = null;
                BFS bfs = null;
                if (searchMethod == "DFS")
                {
                    // Lakukan pencarian dengan metode DFS
                    dfs = new DFS(startingDirectory, gViewer);
                    dfs.searchFilePathDFS(startingDirectory, filename, null, stepDelay, findAllOccurance);
                    stopwatch.Stop();
                }
                else if (searchMethod == "BFS")
                {
                    // Lakukan pencarian dengan metode BFS
                    bfs = new BFS(startingDirectory, gViewer);
                    bfs.searchFilePathBFS(startingDirectory, filename, stepDelay, findAllOccurance);
                    stopwatch.Stop();
                }

                // Label waktu pencarian
                Label searchTimeLabel = new Label();
                searchTimeLabel.Text = String.Format("Search time: {0} s", (float)stopwatch.ElapsedMilliseconds / 1000);
                searchTimeLabel.AutoSize = true;
                searchTimeLabel.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                PathFlowPanel.Controls.Add(searchTimeLabel);

                // Path hasil pencarian
                Label spacing = new Label();
                spacing.Text = "-----------------------------------";
                spacing.AutoSize = true;
                spacing.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                PathFlowPanel.Controls.Add(spacing);


                Label pathsLabel = new Label();
                pathsLabel.Text = "File Path(s): ";
                pathsLabel.AutoSize = true;
                pathsLabel.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                PathFlowPanel.Controls.Add(pathsLabel);

                if (searchMethod == "DFS")
                {
                    if (dfs.getSolutionPath().Count > 0)
                    {
                        foreach (String dir in dfs.getSolutionPath())
                        {
                            Console.WriteLine(dir);
                            addDirectoryLinkLabel(dir, PathFlowPanel);
                        }
                    }
                    else
                    {
                        addNotFoundLabel(PathFlowPanel);
                    }
                }
                else if (searchMethod == "BFS")
                {
                    if (bfs.getSolutionPath().Count > 0)
                    {
                        foreach (String dir in bfs.getSolutionPath())
                        {
                            Console.WriteLine(dir);
                            addDirectoryLinkLabel(dir, PathFlowPanel);
                        }
                    }
                    else
                    {
                        addNotFoundLabel(PathFlowPanel);
                    }
                }
            }
            SearchButton.Enabled = true;
        }

        public void PathLinkLabel_Clicked(object sender, EventArgs e)
        {
            // Event Handler untuk path link label yang dihasilkan dari pencarian
            LinkLabel linkLabel = sender as LinkLabel;
            string directory = System.IO.Directory.GetParent(linkLabel.Text).FullName;

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "explorer.exe";
                startInfo.Arguments = directory;
                Process.Start(startInfo);
            }
            catch
            {
                MessageBox.Show(string.Format("Error in opening directory {0}", directory));
            }
        }

        public void addDirectoryLinkLabel(String directory, FlowLayoutPanel flp)
        {
            LinkLabel pathLinkLabel = new LinkLabel();
            pathLinkLabel.Text = directory;
            pathLinkLabel.AutoSize = true;
            pathLinkLabel.LinkColor = Color.Cyan;
            pathLinkLabel.Click += new EventHandler(PathLinkLabel_Clicked);
            flp.Controls.Add(pathLinkLabel);
        }

        public void addNotFoundLabel(FlowLayoutPanel flp)
        {
            Label notFoundLabel = new Label();
            notFoundLabel.Text = "No matching file found";
            notFoundLabel.AutoSize = true;
            notFoundLabel.ForeColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            flp.Controls.Add(notFoundLabel);
        }

    }
}
