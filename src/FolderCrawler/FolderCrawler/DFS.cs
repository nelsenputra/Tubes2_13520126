using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace FolderCrawler {
    public class DFS {
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
        static bool check = false;

        private float executionTime;
        private List<string> searchPath;
        private string solutionPath;
        private List<string> solutionPathAll;

        // Driver
        // public void Main() {
        //     Console.WriteLine("Enter file name: ");
        //     string query = Console.ReadLine();

        //     // Menyimpan jumlah nama drive dalam komputer (full computer search), nanti ambil dari GUI aja
        //     string[] drives = System.Environment.GetLogicalDrives();

        //     foreach (string dr in drives) {
        //         System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

        //         if (!di.IsReady) {
        //             Console.WriteLine("The drive {0} could not be read", di.Name);
        //             continue;
        //         }
        //         System.IO.DirectoryInfo rootDir = di.RootDirectory;
        //         if (this.findAll) {
        //             searchAllFilePathDFS(rootDir.FullName, query);
        //         } else {
        //             searchFilePathDFS(rootDir.FullName, query);
        //         }
        //     }

        //     // Menuliskan jalur crawling DFS
        //     Console.WriteLine("Directory crawled:");
        //     foreach (string dr in this.searchPath) {
        //         Console.WriteLine(dr);
        //     }

        //     // Menuliskan path solusi
        //     if (this.findAll) {
        //         Console.WriteLine("Solution Path:");
        //         foreach (string dr in this.solutionPathAll) {
        //             Console.WriteLine(dr);
        //         }
        //     } else {
        //         Console.WriteLine("Solution Path:");
        //         Console.WriteLine(this.solutionPath);            
        //     }

        //     // Menuliskan directory restricted apa saja yang dilalui
        //     Console.WriteLine("Files with restricted access:");
        //     foreach (string s in log) {
        //         Console.WriteLine(s);
        //     }

        //     Console.WriteLine("Press any key");
        //     Console.ReadKey();
        // }

        public List<string> getSearchPaths() {
            return this.searchPath;
        }

        public string getSolutionPath() {
            return this.solutionPath;
        }

        public List<string> getSolutionPathAll() {
            return this.solutionPathAll;
        }

        public float getExecutionTime() {
            return this.executionTime;
        }

        public void setExecutionTime(float t) {
            this.executionTime = t;
        }

        public void addPath(string Path) {
            this.searchPath.Add(Path);
        }

        public void setSolution(string Path) {
            this.solutionPath = Path;
        }

        public DFS() {
            this.searchPath = new List<string>();
            this.solutionPath = "File not found";
            this.solutionPathAll = new List<string>();
        }

        public void searchFilePathDFS(string start, string search) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Mengecek apakah file sudah ketemu atau belum
            if (check) {
                return;
            }

            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(start);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            try {
                files = root.GetFiles("*.*");
            }
            // Handle dir yang tidak bisa akses
            catch (UnauthorizedAccessException e) {
                log.Add(e.Message);
            }
            // Handle dir yang not found
            catch (System.IO.DirectoryNotFoundException e) {
                Console.WriteLine(e.Message);
            }

            if (files != null) {
                foreach (System.IO.FileInfo fi in files) {
                    this.searchPath.Add(fi.FullName);
                    // Mengecek apakah file merupakan yang dicari
                    if (search.Equals(fi.Name)) {
                        check = true;
                        this.solutionPath = fi.FullName;
                        break;
                    }
                }

                subDirs = root.GetDirectories();

                // Melanjutkan DFS
                foreach (System.IO.DirectoryInfo dirInfo in subDirs) {
                    searchFilePathDFS(dirInfo.FullName, search);
                }
            }

            stopwatch.Stop();
            this.setExecutionTime(stopwatch.ElapsedMilliseconds);
        }

        public void searchAllFilePathDFS(string start, string search){
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(start);
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            try {
                files = root.GetFiles("*.*");
            }
            // Handle dir yang tidak bisa akses
            catch (UnauthorizedAccessException e) {
                log.Add(e.Message);
            }
            // Handle dir yang not found
            catch (System.IO.DirectoryNotFoundException e) {
                Console.WriteLine(e.Message);
            }

            if (files != null) {
                foreach (System.IO.FileInfo fi in files) {
                    this.searchPath.Add(fi.FullName);
                    // Mengecek apakah file merupakan yang dicari
                    if (search.Equals(fi.Name)) {
                        this.solutionPathAll.Add(fi.FullName);
                    }
                }

                subDirs = root.GetDirectories();

                // Melanjutkan DFS
                foreach (System.IO.DirectoryInfo dirInfo in subDirs) {
                    searchFilePathDFS(dirInfo.FullName, search);
                }
            }

            stopwatch.Stop();
            this.setExecutionTime(stopwatch.ElapsedMilliseconds);
        }

    }
}