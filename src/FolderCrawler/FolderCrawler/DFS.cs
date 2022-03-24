using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace FolderCrawler
{
    public class DFS
    {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        private List<string> solutionPath = new List<String>();

        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private FileGraph fileGraph;

        public DFS()
        {
            this.solutionPath = new List<string>();
        }

        public DFS(string rootDirectory, Microsoft.Msagl.GraphViewerGdi.GViewer viewer)
        {
            this.solutionPath = new List<string>();
            this.fileGraph = new FileGraph(rootDirectory);
            this.viewer = viewer;
        }

        public List<string> getSolutionPath()
        {
            return this.solutionPath;
        }


        public void addSolution(string Path)
        {
            this.solutionPath.Add(Path);
        }

        public void searchFilePathDFS(string start, string search, Microsoft.Msagl.Drawing.Node startingNode, int stepDelay, bool findAll)
        {
            // Mengecek apakah file sudah ketemu atau belum
            if (solutionPath.Count > 0 && !findAll)
            {
                return;
            }

            // Inisialisasi
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(start);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            if (startingNode == null)
            {
                startingNode = fileGraph.R;
            }

            try
            {
                files = root.GetFiles("*.*");
            }
            // Handle dir yang tidak bisa akses
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }
            // Handle dir yang not found
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                // Ubah node menjadi warna merah jika warna awalnya bukan

                if (startingNode.Attr.Color != Microsoft.Msagl.Drawing.Color.Blue)
                {
                    startingNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }

                // Tambahkan node semua folder start directory 
                subDirs = root.GetDirectories();
                // Dilakukan Reverse agar pembentukan pohon rapih
                Array.Reverse(subDirs);

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    Microsoft.Msagl.Drawing.Node subdirectory = fileGraph.AddEdgeBlack(startingNode, dirInfo.Name);
                }

                Array.Reverse(subDirs);

                // Tambahkan node semua file start directory
                Array.Reverse(files);
                foreach (System.IO.FileInfo file in files)
                {
                    Microsoft.Msagl.Drawing.Node subdirectory = fileGraph.AddEdgeBlack(startingNode, file.Name);
                }
                Array.Reverse(files);

                // Tampilkan pohon
                fileGraph.showGraph(viewer, stepDelay);


                foreach (System.IO.FileInfo fi in files)
                {
                    // Mengecek apakah file merupakan yang dicari
                    if (search.Equals(fi.Name))
                    {
                        this.addSolution(fi.FullName);
                        fileGraph.TurnBlue(fileGraph.dirToList(fi.FullName));

                        // Tampilkan pohon
                        fileGraph.showGraph(viewer, stepDelay);

                        if (!findAll)
                        {
                            break;
                        }  
                    }
                    else
                    {
                        Microsoft.Msagl.Drawing.Node N = fileGraph.ColorEdgeRed(startingNode, fi.Name);
                        FileGraph.ColorNodeRed(N);

                        // Tampilkan pohon
                        fileGraph.showGraph(viewer, stepDelay);
                    }
                }

                // Melanjutkan DFS
                if (findAll || this.solutionPath.Count == 0)
                {
                    foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                    {
                        Microsoft.Msagl.Drawing.Node nextNode = fileGraph.ColorEdgeRed(startingNode, dirInfo.Name);
                        searchFilePathDFS(dirInfo.FullName, search, nextNode, stepDelay, findAll);
                    }
                }
            }
        }
    }
}