// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace FolderCrawler {
    public class BFS {
        private List<string> searchPath;
        private List<string> solutionPath;
        private float executionTime;

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

        public BFS() {
            this.searchPath = new List<string>();
            this.solutionPath = new List<string>();
            this.executionTime = 0;
        }

        public float getExecutionTime() {
            return this.executionTime;
        }

        public void setExecutionTime(float t) {
            this.executionTime = t;
        }

        public List<string> getSearchPaths() {
            return this.searchPath;
        }

        public List<string> getSolutionPath() {
            return this.solutionPath;
        }

        public void addPath(string Path) {
            this.searchPath.Add(Path);
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
        public bool isDirectoryValid(string dirName, string fileName, string Path) {
            string[] directories = Directory.GetDirectories(Path, "*");
            var file = Directory.GetFiles(Path, "*");
            bool directoryEmpty = directories.Length == 0;
            bool fileExist = file.Length > 0;
            return !directoryEmpty | fileExist;
        }

        // Parameter: path ke rootnya dan nama file yang dicari
        public void searchFilePathBFS(string filename, string rootDir, bool FindAll) {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<string> res = new List<string>();
            Queue<string> q = new Queue<string>();
            string dir = rootDir;
            // Add node di awal untuk root
            q.Enqueue(rootDir);
            // Implementasi
            if (FindAll) {
                while (q.Count > 0) {
                    Console.WriteLine("Dequeing.....");
                    dir = q.Dequeue();
                    string[] directories = Directory.GetDirectories(dir, "*");
                    if (directories.Length == 0) {
                        Console.WriteLine("Visiting: " + Path.GetFileName(dir));
                    }
                    foreach (string directory in directories) {
                        string dirName = Path.GetFileName(directory);
                        // Hanya untuk debugging, kalau sudah fix, boleh dihapus
                        Console.WriteLine("Visiting: " + dirName);
                        // Valid artinya directory ada isinya
                        if (isDirectoryValid(dirName, filename, directory)) {
                            //Console.WriteLine(dirName + " is Valid");
                            q.Enqueue(directory);
                        }
                        this.addPath(directory);
                        // Cek apakah punya file atau tidak
                    }
                    if (isExistFileInDirectory(dir)) {
                        var files = Directory.GetFiles(dir);
                        //Console.Write(dirName + " files: ");
                        foreach (string file in files) {
                            this.addPath(file);
                            if (Path.GetFileName(file) == filename) {
                                this.setSolution(file);
                            }
                        }
                    }
                }
                if (this.getSolutionPath().Count == 0) {
                    this.setSolution("File not found");
                }
            } else {
                while ((!isFileFound(dir, filename)) & q.Count > 0) {
                    Console.WriteLine("Dequeing.....");
                    dir = q.Dequeue();
                    string[] directories = Directory.GetDirectories(dir, "*");
                    if (directories.Length == 0) {
                        Console.WriteLine("Visiting: " + Path.GetFileName(dir));
                    }
                    foreach (string directory in directories) {
                        string dirName = Path.GetFileName(directory);
                        // Hanya untuk debugging, kalau sudah fix, boleh dihapus
                        Console.WriteLine("Visiting: " + dirName);
                        // Valid artinya directory ada isinya
                        if (isDirectoryValid(dirName, filename, directory)) {
                            //Console.WriteLine(dirName + " is Valid");
                            q.Enqueue(directory);
                        }
                        this.addPath(directory);
                        // Cek apakah punya file atau tidak
                    }
                    if (isExistFileInDirectory(dir)) {
                        var files = Directory.GetFiles(dir);
                        //Console.Write(dirName + " files: ");
                        foreach (string file in files) {
                            this.addPath(file);
                        }
                    }
                }
                string[] solution = Directory.GetFiles(dir, filename);
                if (solution.Length > 0) {
                    this.setSolution(solution[0]);
                } else {
                    this.setSolution("File not found");
                }
            }

            stopwatch.Stop();
            this.setExecutionTime(stopwatch.ElapsedMilliseconds);
        }
    }
}