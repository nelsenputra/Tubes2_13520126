// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace FolderCrawler {
    public class BFS {
        private List<string> solutionPath;

        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private FileGraph fileGraph;

        /*
        public static void Main(string[] args) {
            // Mengambil path dari GUI
            string rootPath = @"/Users/";
            string[] rootDirs = Directory.GetFiles(rootPath, "*");

            BFS bfs = new BFS();
            bfs.searchFilePathBFS("test.pdf", rootPath, true);
            foreach (string res in bfs.getSearchPaths()) {
                Console.WriteLine(res);
            }

            // Mengambil nama file di akhir path
            Console.WriteLine(Path.GetFileName(bfs.getSolutionPath()[1]));
            // Mengambil nama directory sebelum akhir path
            Console.WriteLine(Path.GetFileName(Path.GetDirectoryName(bfs.getSolutionPath()[1])));

            // Akses otomatis dilakukan berdasarkan abjad
        }
        */

        public BFS() {
            this.solutionPath = new List<string>();
        }

        public BFS(string rootDirectory, Microsoft.Msagl.GraphViewerGdi.GViewer viewer)
        {
            this.solutionPath = new List<string>();
            this.fileGraph = new FileGraph(rootDirectory);
            this.viewer = viewer;
        }

        public List<string> getSolutionPath() {
            return this.solutionPath;
        }

        public void setSolution(string Path) {
            this.solutionPath.Add(Path);
        }

        // Fungsi untuk basis, mengecek apakah filenya ada di directory atau tidak
        public bool isFileFound(string rootDir, string filename) {
            var file = Directory.GetFiles(rootDir, filename);
            return file.Length > 0;
        }

        // Mengecek apakah dalam suatu directory ada file atau tidak
        public bool isExistFileInDirectory(string Path) {
            var file = Directory.GetFiles(Path, "*");
            return file.Length > 0;
        }

        // Mengecek apakah directory bisa ditelusuri (valid atau tidak)
        // Valid apabila directorynya tidak kosong (ada directory lain/file di dalamnya)
        public bool isDirectoryValid(string directory) {
            string[] directories = Directory.GetDirectories(directory, "*");
            var file = Directory.GetFiles(directory, "*");
            bool directoryEmpty = directories.Length == 0;
            bool fileExist = file.Length > 0;
            return !directoryEmpty | fileExist;
        }

        // Parameter: path ke rootnya dan nama file yang dicari
        public void searchFilePathBFS(string rootDir, string filename, int stepDelay, bool FindAll) {

            List<string> res = new List<string>();
            Queue<string> q = new Queue<string>();
            Queue<Microsoft.Msagl.Drawing.Node> parentNodeQueue = new Queue<Microsoft.Msagl.Drawing.Node>();
            string dir = rootDir;
            // Add node di awal untuk root
            q.Enqueue(rootDir);
            parentNodeQueue.Enqueue(fileGraph.R);

            Microsoft.Msagl.Drawing.Node ParentNode = fileGraph.R;
            ParentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

            // Implementasi
            while (q.Count > 0 && (FindAll || this.solutionPath.Count == 0))
            {
                // Warnai node yang sedang dicek menjadi merah
                dir = q.Dequeue();
                ParentNode = parentNodeQueue.Dequeue();

                Microsoft.Msagl.Drawing.Node currentParentNode = fileGraph.R;

                if (dir != rootDir)
                {
                    currentParentNode = fileGraph.ColorEdgeRed(ParentNode, Path.GetFileName(dir));
                    currentParentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                
                fileGraph.showGraph(this.viewer, stepDelay);

                string[] directories = Directory.GetDirectories(dir, "*");

                // Tambahkan node semua folder directory
                Array.Reverse(directories);

                foreach (string directory in directories)
                {
                    Microsoft.Msagl.Drawing.Node N = fileGraph.AddEdgeBlack(currentParentNode, Path.GetFileName(directory));
                }

                Array.Reverse(directories);

                // Tambahkan node semua file directory
                string[] files = Directory.GetFiles(dir);

                Array.Reverse(files);

                foreach (string file in files)
                {
                    Microsoft.Msagl.Drawing.Node N = fileGraph.AddEdgeBlack(currentParentNode, Path.GetFileName(file));
                }

                Array.Reverse(files);

                // Tampilkan pohon
                fileGraph.showGraph(this.viewer, stepDelay);

                // Search file
                foreach (string file in files)
                {
                    if (Path.GetFileName(file).Equals(filename))
                    {
                        this.setSolution(file);
                        fileGraph.TurnBlue(fileGraph.dirToList(file));
                        fileGraph.showGraph(this.viewer, stepDelay);
                        if (!FindAll)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Microsoft.Msagl.Drawing.Node N = fileGraph.ColorEdgeRed(currentParentNode, Path.GetFileName(file));
                        FileGraph.ColorNodeRed(N);
                        fileGraph.showGraph(this.viewer, stepDelay);
                    }
                }

                // Search directory
                if (FindAll || this.solutionPath.Count == 0)
                {
                    foreach (string directory in directories)
                    {
                        string dirName = Path.GetFileName(directory);

                        q.Enqueue(directory);
                        parentNodeQueue.Enqueue(currentParentNode);
                    }
                }
            }
        }
    }
}