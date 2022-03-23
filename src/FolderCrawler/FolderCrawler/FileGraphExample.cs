﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler
{
    internal static class FileGraphExample
    {
        public static void mFileGraph()
        {
            // warnai root merag
            FileGraph.ColorNodeRed(FileGraph.R);

            // add node "Folder A", add edge("root", "Folder A") color=red
            Microsoft.Msagl.Drawing.Node N = FileGraph.AddEdgeRed(FileGraph.R, "Folder A");

            // warnai node "Folder A" merah
            FileGraph.ColorNodeRed(N);

            // add node "File 1", add edge("Folder A", "File 1") color=red
            N = FileGraph.AddEdgeRed(N, "File 1");

            // warnai node "File 1" merah
            FileGraph.ColorNodeRed(N);

            // add node "Folder A", add edge("root", "Folder B") color=red
            N = FileGraph.AddEdgeRed(FileGraph.R, "Folder B");

            // warnai node "Folder B" merah
            FileGraph.ColorNodeRed(N);

            // add node "File 2", add edge("Folder B", "File 2") color=red
            N = FileGraph.AddEdgeRed(N, "File 2");

            // warnai node "File 2" merah
            FileGraph.ColorNodeRed(N);

            // warnai root sampai file 2 menjadi biru
            String[] S = new String[2];
            S[0] = ("Folder B");
            S[1] = ("File 2");

            FileGraph.TurnBlue(S);

            // add node "File 3", add edge("root", "File 3") color=black
            N = FileGraph.AddEdgeBlack(FileGraph.R, "File 3");

            // warnai node "File 3" hitam
            FileGraph.ColorNodeBlack(N);

            // show graph
            FileGraph.showGraph();
        }
    }
}
