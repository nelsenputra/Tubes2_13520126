namespace FolderCrawler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartDirLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.SearchMethodLabel = new System.Windows.Forms.Label();
            this.FindAllOccCheckbox = new System.Windows.Forms.CheckBox();
            this.DFSButton = new System.Windows.Forms.Button();
            this.BFSButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectDirButton = new System.Windows.Forms.Button();
            this.gViewer1 = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.StartDirLinkLabel = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ConfigPanel.Controls.Add(this.StartDirLinkLabel);
            this.ConfigPanel.Controls.Add(this.SelectDirButton);
            this.ConfigPanel.Controls.Add(this.SearchButton);
            this.ConfigPanel.Controls.Add(this.FileNameTextBox);
            this.ConfigPanel.Controls.Add(this.BFSButton);
            this.ConfigPanel.Controls.Add(this.DFSButton);
            this.ConfigPanel.Controls.Add(this.FindAllOccCheckbox);
            this.ConfigPanel.Controls.Add(this.SearchMethodLabel);
            this.ConfigPanel.Controls.Add(this.FileNameLabel);
            this.ConfigPanel.Controls.Add(this.StartDirLabel);
            this.ConfigPanel.Controls.Add(this.TitleLabel);
            this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ConfigPanel.Location = new System.Drawing.Point(0, 0);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(440, 601);
            this.ConfigPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(85, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(260, 42);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "FolderCrawler";
            this.TitleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // StartDirLabel
            // 
            this.StartDirLabel.AutoSize = true;
            this.StartDirLabel.Location = new System.Drawing.Point(31, 85);
            this.StartDirLabel.Name = "StartDirLabel";
            this.StartDirLabel.Size = new System.Drawing.Size(175, 25);
            this.StartDirLabel.TabIndex = 3;
            this.StartDirLabel.Text = "Starting Directory";
            this.StartDirLabel.Click += new System.EventHandler(this.StartDirLabel_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(31, 210);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FileNameLabel.TabIndex = 4;
            this.FileNameLabel.Text = "File Name";
            // 
            // SearchMethodLabel
            // 
            this.SearchMethodLabel.AutoSize = true;
            this.SearchMethodLabel.Location = new System.Drawing.Point(31, 355);
            this.SearchMethodLabel.Name = "SearchMethodLabel";
            this.SearchMethodLabel.Size = new System.Drawing.Size(184, 25);
            this.SearchMethodLabel.TabIndex = 5;
            this.SearchMethodLabel.Text = "Searching Method";
            // 
            // FindAllOccCheckbox
            // 
            this.FindAllOccCheckbox.AutoSize = true;
            this.FindAllOccCheckbox.Location = new System.Drawing.Point(40, 301);
            this.FindAllOccCheckbox.Name = "FindAllOccCheckbox";
            this.FindAllOccCheckbox.Size = new System.Drawing.Size(202, 29);
            this.FindAllOccCheckbox.TabIndex = 6;
            this.FindAllOccCheckbox.Text = "Find all occurance";
            this.FindAllOccCheckbox.UseVisualStyleBackColor = true;
            this.FindAllOccCheckbox.CheckedChanged += new System.EventHandler(this.FindAllOccCheckbox_CheckedChanged);
            // 
            // DFSButton
            // 
            this.DFSButton.Location = new System.Drawing.Point(40, 392);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(180, 60);
            this.DFSButton.TabIndex = 7;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = true;
            // 
            // BFSButton
            // 
            this.BFSButton.Location = new System.Drawing.Point(220, 392);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(180, 60);
            this.BFSButton.TabIndex = 8;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseVisualStyleBackColor = true;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(40, 249);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(360, 33);
            this.FileNameTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(40, 505);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(180, 60);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SelectDirButton
            // 
            this.SelectDirButton.Location = new System.Drawing.Point(40, 122);
            this.SelectDirButton.Name = "SelectDirButton";
            this.SelectDirButton.Size = new System.Drawing.Size(170, 37);
            this.SelectDirButton.TabIndex = 2;
            this.SelectDirButton.Text = "Select Directory";
            this.SelectDirButton.UseVisualStyleBackColor = true;
            this.SelectDirButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gViewer1
            // 
            this.gViewer1.ArrowheadLength = 10D;
            this.gViewer1.AsyncLayout = false;
            this.gViewer1.AutoScroll = true;
            this.gViewer1.BackwardEnabled = false;
            this.gViewer1.BuildHitTree = true;
            this.gViewer1.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer1.EdgeInsertButtonVisible = true;
            this.gViewer1.FileName = "";
            this.gViewer1.ForwardEnabled = false;
            this.gViewer1.Graph = null;
            this.gViewer1.InsertingEdge = false;
            this.gViewer1.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer1.LayoutEditingEnabled = true;
            this.gViewer1.Location = new System.Drawing.Point(440, 0);
            this.gViewer1.LooseOffsetForRouting = 0.25D;
            this.gViewer1.MouseHitDistance = 0.05D;
            this.gViewer1.Name = "gViewer1";
            this.gViewer1.NavigationVisible = true;
            this.gViewer1.NeedToCalculateLayout = true;
            this.gViewer1.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer1.PaddingForEdgeRouting = 8D;
            this.gViewer1.PanButtonPressed = false;
            this.gViewer1.SaveAsImageEnabled = true;
            this.gViewer1.SaveAsMsaglEnabled = true;
            this.gViewer1.SaveButtonVisible = true;
            this.gViewer1.SaveGraphButtonVisible = true;
            this.gViewer1.SaveInVectorFormatEnabled = true;
            this.gViewer1.Size = new System.Drawing.Size(694, 452);
            this.gViewer1.TabIndex = 2;
            this.gViewer1.TightOffsetForRouting = 0.125D;
            this.gViewer1.ToolBarIsVisible = true;
            this.gViewer1.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer1.Transform")));
            this.gViewer1.UndoRedoButtonsVisible = true;
            this.gViewer1.WindowZoomButtonPressed = false;
            this.gViewer1.ZoomF = 1D;
            this.gViewer1.ZoomWindowThreshold = 0.05D;
            // 
            // StartDirLinkLabel
            // 
            this.StartDirLinkLabel.AutoSize = true;
            this.StartDirLinkLabel.LinkColor = System.Drawing.Color.MediumAquamarine;
            this.StartDirLinkLabel.Location = new System.Drawing.Point(40, 177);
            this.StartDirLinkLabel.Name = "StartDirLinkLabel";
            this.StartDirLinkLabel.Size = new System.Drawing.Size(38, 25);
            this.StartDirLinkLabel.TabIndex = 11;
            this.StartDirLinkLabel.TabStop = true;
            this.StartDirLinkLabel.Text = "C:/";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(440, 453);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 148);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 601);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gViewer1);
            this.Controls.Add(this.ConfigPanel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button BFSButton;
        private System.Windows.Forms.Button DFSButton;
        private System.Windows.Forms.CheckBox FindAllOccCheckbox;
        private System.Windows.Forms.Label SearchMethodLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label StartDirLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button SelectDirButton;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer1;
        private System.Windows.Forms.LinkLabel StartDirLinkLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

