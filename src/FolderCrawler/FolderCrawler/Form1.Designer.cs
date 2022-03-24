namespace FolderCrawler
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PathFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.gViewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.msLabel = new System.Windows.Forms.Label();
            this.StepDelayTextbox = new System.Windows.Forms.TextBox();
            this.stepDelayLabel = new System.Windows.Forms.Label();
            this.AllOccCheckbox = new System.Windows.Forms.CheckBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BFSButton = new System.Windows.Forms.Button();
            this.DFSButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.StartDirLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StartDirButton = new System.Windows.Forms.Button();
            this.SearchMethodLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StartDirLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel.Controls.Add(this.PathFlowPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.gViewer, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.ConfigPanel, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(1348, 721);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // PathFlowPanel
            // 
            this.PathFlowPanel.AutoScroll = true;
            this.PathFlowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PathFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PathFlowPanel.Location = new System.Drawing.Point(443, 579);
            this.PathFlowPanel.Name = "PathFlowPanel";
            this.PathFlowPanel.Size = new System.Drawing.Size(902, 139);
            this.PathFlowPanel.TabIndex = 0;
            this.PathFlowPanel.WrapContents = false;
            // 
            // gViewer
            // 
            this.gViewer.ArrowheadLength = 10D;
            this.gViewer.AsyncLayout = false;
            this.gViewer.AutoScroll = true;
            this.gViewer.BackwardEnabled = false;
            this.gViewer.BuildHitTree = true;
            this.gViewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.gViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gViewer.EdgeInsertButtonVisible = true;
            this.gViewer.FileName = "";
            this.gViewer.ForwardEnabled = false;
            this.gViewer.Graph = null;
            this.gViewer.InsertingEdge = false;
            this.gViewer.LayoutAlgorithmSettingsButtonVisible = true;
            this.gViewer.LayoutEditingEnabled = true;
            this.gViewer.Location = new System.Drawing.Point(443, 3);
            this.gViewer.LooseOffsetForRouting = 0.25D;
            this.gViewer.MouseHitDistance = 0.05D;
            this.gViewer.Name = "gViewer";
            this.gViewer.NavigationVisible = true;
            this.gViewer.NeedToCalculateLayout = true;
            this.gViewer.OffsetForRelaxingInRouting = 0.6D;
            this.gViewer.PaddingForEdgeRouting = 8D;
            this.gViewer.PanButtonPressed = false;
            this.gViewer.SaveAsImageEnabled = true;
            this.gViewer.SaveAsMsaglEnabled = true;
            this.gViewer.SaveButtonVisible = true;
            this.gViewer.SaveGraphButtonVisible = true;
            this.gViewer.SaveInVectorFormatEnabled = true;
            this.gViewer.Size = new System.Drawing.Size(902, 570);
            this.gViewer.TabIndex = 1;
            this.gViewer.TightOffsetForRouting = 0.125D;
            this.gViewer.ToolBarIsVisible = true;
            this.gViewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("gViewer.Transform")));
            this.gViewer.UndoRedoButtonsVisible = true;
            this.gViewer.WindowZoomButtonPressed = false;
            this.gViewer.ZoomF = 1D;
            this.gViewer.ZoomWindowThreshold = 0.05D;
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.AutoScroll = true;
            this.ConfigPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ConfigPanel.Controls.Add(this.msLabel);
            this.ConfigPanel.Controls.Add(this.StepDelayTextbox);
            this.ConfigPanel.Controls.Add(this.stepDelayLabel);
            this.ConfigPanel.Controls.Add(this.AllOccCheckbox);
            this.ConfigPanel.Controls.Add(this.SearchButton);
            this.ConfigPanel.Controls.Add(this.BFSButton);
            this.ConfigPanel.Controls.Add(this.DFSButton);
            this.ConfigPanel.Controls.Add(this.FileNameTextBox);
            this.ConfigPanel.Controls.Add(this.StartDirLinkLabel);
            this.ConfigPanel.Controls.Add(this.StartDirButton);
            this.ConfigPanel.Controls.Add(this.SearchMethodLabel);
            this.ConfigPanel.Controls.Add(this.FileNameLabel);
            this.ConfigPanel.Controls.Add(this.StartDirLabel);
            this.ConfigPanel.Controls.Add(this.TitleLabel);
            this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigPanel.Location = new System.Drawing.Point(3, 3);
            this.ConfigPanel.Name = "ConfigPanel";
            this.TableLayoutPanel.SetRowSpan(this.ConfigPanel, 2);
            this.ConfigPanel.Size = new System.Drawing.Size(434, 715);
            this.ConfigPanel.TabIndex = 2;
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.msLabel.Location = new System.Drawing.Point(316, 369);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(40, 25);
            this.msLabel.TabIndex = 13;
            this.msLabel.Text = "ms";
            // 
            // StepDelayTextbox
            // 
            this.StepDelayTextbox.Location = new System.Drawing.Point(160, 366);
            this.StepDelayTextbox.Name = "StepDelayTextbox";
            this.StepDelayTextbox.Size = new System.Drawing.Size(150, 33);
            this.StepDelayTextbox.TabIndex = 12;
            // 
            // stepDelayLabel
            // 
            this.stepDelayLabel.AutoSize = true;
            this.stepDelayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stepDelayLabel.Location = new System.Drawing.Point(39, 369);
            this.stepDelayLabel.Name = "stepDelayLabel";
            this.stepDelayLabel.Size = new System.Drawing.Size(111, 25);
            this.stepDelayLabel.TabIndex = 11;
            this.stepDelayLabel.Text = "Step Delay";
            // 
            // AllOccCheckbox
            // 
            this.AllOccCheckbox.AutoSize = true;
            this.AllOccCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AllOccCheckbox.Location = new System.Drawing.Point(50, 322);
            this.AllOccCheckbox.Name = "AllOccCheckbox";
            this.AllOccCheckbox.Size = new System.Drawing.Size(208, 29);
            this.AllOccCheckbox.TabIndex = 10;
            this.AllOccCheckbox.Text = "Find All Occurance";
            this.AllOccCheckbox.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(44, 557);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 50);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // BFSButton
            // 
            this.BFSButton.BackColor = System.Drawing.Color.Transparent;
            this.BFSButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BFSButton.FlatAppearance.BorderSize = 5;
            this.BFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFSButton.ForeColor = System.Drawing.Color.DimGray;
            this.BFSButton.Location = new System.Drawing.Point(220, 457);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(170, 60);
            this.BFSButton.TabIndex = 8;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseVisualStyleBackColor = false;
            this.BFSButton.Click += new System.EventHandler(this.BFSButton_Click);
            this.BFSButton.MouseEnter += new System.EventHandler(this.BFSButton_MouseEnter);
            this.BFSButton.MouseLeave += new System.EventHandler(this.BFSButton_MouseLeave);
            // 
            // DFSButton
            // 
            this.DFSButton.BackColor = System.Drawing.Color.Transparent;
            this.DFSButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DFSButton.FlatAppearance.BorderSize = 5;
            this.DFSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DFSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DFSButton.Location = new System.Drawing.Point(50, 457);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(170, 60);
            this.DFSButton.TabIndex = 7;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = false;
            this.DFSButton.Click += new System.EventHandler(this.DFSButton_Click);
            this.DFSButton.MouseEnter += new System.EventHandler(this.DFSButton_MouseEnter);
            this.DFSButton.MouseLeave += new System.EventHandler(this.DFSButton_MouseLeave);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Location = new System.Drawing.Point(49, 273);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(350, 33);
            this.FileNameTextBox.TabIndex = 6;
            // 
            // StartDirLinkLabel
            // 
            this.StartDirLinkLabel.AutoEllipsis = true;
            this.StartDirLinkLabel.LinkColor = System.Drawing.Color.Cyan;
            this.StartDirLinkLabel.Location = new System.Drawing.Point(44, 187);
            this.StartDirLinkLabel.Name = "StartDirLinkLabel";
            this.StartDirLinkLabel.Size = new System.Drawing.Size(350, 25);
            this.StartDirLinkLabel.TabIndex = 5;
            this.StartDirLinkLabel.TabStop = true;
            this.StartDirLinkLabel.Text = "C:\\";
            this.StartDirLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StartDirLinkLabel_LinkClicked);
            // 
            // StartDirButton
            // 
            this.StartDirButton.Location = new System.Drawing.Point(49, 134);
            this.StartDirButton.Name = "StartDirButton";
            this.StartDirButton.Size = new System.Drawing.Size(170, 40);
            this.StartDirButton.TabIndex = 4;
            this.StartDirButton.Text = "Select Directory";
            this.StartDirButton.UseVisualStyleBackColor = true;
            this.StartDirButton.Click += new System.EventHandler(this.StartDirButton_Click);
            // 
            // SearchMethodLabel
            // 
            this.SearchMethodLabel.AutoSize = true;
            this.SearchMethodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchMethodLabel.Location = new System.Drawing.Point(39, 414);
            this.SearchMethodLabel.Name = "SearchMethodLabel";
            this.SearchMethodLabel.Size = new System.Drawing.Size(154, 25);
            this.SearchMethodLabel.TabIndex = 3;
            this.SearchMethodLabel.Text = "Search Method";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FileNameLabel.Location = new System.Drawing.Point(39, 231);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File Name";
            // 
            // StartDirLabel
            // 
            this.StartDirLabel.AutoSize = true;
            this.StartDirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartDirLabel.Location = new System.Drawing.Point(34, 93);
            this.StartDirLabel.Name = "StartDirLabel";
            this.StartDirLabel.Size = new System.Drawing.Size(175, 25);
            this.StartDirLabel.TabIndex = 1;
            this.StartDirLabel.Text = "Starting Directory";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleLabel.Location = new System.Drawing.Point(110, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(200, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Folder Crawler";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.TableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Folder Crawler";
            this.TableLayoutPanel.ResumeLayout(false);
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel PathFlowPanel;
        private Microsoft.Msagl.GraphViewerGdi.GViewer gViewer;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BFSButton;
        private System.Windows.Forms.Button DFSButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.LinkLabel StartDirLinkLabel;
        private System.Windows.Forms.Button StartDirButton;
        private System.Windows.Forms.Label SearchMethodLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label StartDirLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckBox AllOccCheckbox;
        private System.Windows.Forms.TextBox StepDelayTextbox;
        private System.Windows.Forms.Label stepDelayLabel;
        private System.Windows.Forms.Label msLabel;
    }
}

