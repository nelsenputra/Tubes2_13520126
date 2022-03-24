using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler
{
    internal class FileGraph
    {
        private Microsoft.Msagl.Drawing.Graph graph;
        public Microsoft.Msagl.Drawing.Node R;

        // Constructor
        public FileGraph(string rootDirectory)
        {
            setRoot(rootDirectory);
        }

        // Set Root
        public void setRoot(string rootDirectory)
        {
            graph = new Microsoft.Msagl.Drawing.Graph();
            R = new Microsoft.Msagl.Drawing.Node(graph.NodeCount.ToString());
            R.LabelText = rootDirectory;
            graph.AddNode(R);
        }


        // COLOR NODE
        // turn node A to color red
        public static void ColorNodeRed(Microsoft.Msagl.Drawing.Node A)
        {
            A.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
        }

        // turn node A to color black
        public static void ColorNodeBlack(Microsoft.Msagl.Drawing.Node A)
        {
            A.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
        }

        // turn node A to color blue
        public static void ColorNodeBlue(Microsoft.Msagl.Drawing.Node A)
        {
            A.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
        }



        // EDGES
        // add new node B and add egde(A,B) with red color
        public Microsoft.Msagl.Drawing.Node AddEdgeRed(Microsoft.Msagl.Drawing.Node A, String B)
        {
            Microsoft.Msagl.Drawing.Node N = new Microsoft.Msagl.Drawing.Node(graph.NodeCount.ToString());
            N.LabelText = B;
            graph.AddNode(N);
            graph.AddEdge(A.Id, N.Id).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            return N;
        }


        // Turn edge(A,B) to color blue, A and B must be conected
        public Microsoft.Msagl.Drawing.Node ColorEdgeBlue(Microsoft.Msagl.Drawing.Node A, String B)
        {
            Microsoft.Msagl.Drawing.Node N = null;
            var el = A.OutEdges.ToArray();
            foreach (var e in el)
            {
                if (e.TargetNode.LabelText.Equals(B))
                {
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    N = e.TargetNode;
                }
            }
            return N;
        }

        // Turn edge(A,B) to color red, A and B must be conected
        public Microsoft.Msagl.Drawing.Node ColorEdgeRed(Microsoft.Msagl.Drawing.Node A, String B)
        {
            Microsoft.Msagl.Drawing.Node N = null;
            var el = A.OutEdges.ToArray();
            foreach (var e in el)
            {
                if (e.TargetNode.LabelText.Equals(B) && e.Attr.Color != Microsoft.Msagl.Drawing.Color.Blue)
                {
                    e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    N = e.TargetNode;
                }
            }
            return N;
        }

        // add new node B and add egde(A,B) with black color
        public Microsoft.Msagl.Drawing.Node AddEdgeBlack(Microsoft.Msagl.Drawing.Node A, String B)
        {
            Microsoft.Msagl.Drawing.Node N = new Microsoft.Msagl.Drawing.Node(graph.NodeCount.ToString());
            N.LabelText = B;
            graph.AddNode(N);
            graph.AddEdge(A.Id, N.Id).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            return N;
        }

        // Turn all node root to node goal to color blue. Following the directory path in an array of string (node label)
        public void TurnBlue(List<string> L)
        {
            ColorNodeBlue(R);
            Microsoft.Msagl.Drawing.Node N = R;
            foreach (String name in L)
            {
                N = ColorEdgeBlue(N, name);
                ColorNodeBlue(N);
            }
        }

        public List<string> dirToList(string directory)
        {
            List<string> list = new List<string>();
            while(directory != this.R.Label.Text)
            {
                list.Insert(0, System.IO.Path.GetFileName(directory));
                directory = System.IO.Directory.GetParent(directory).FullName;
            }
            return list;
        }

        // SHOW GRAPH

        public void showGraph(Microsoft.Msagl.GraphViewerGdi.GViewer viewer, int delay)
        {
            //bind the graph to the viewer 
            viewer.Graph = graph;
            System.Windows.Forms.Application.DoEvents();
            System.Threading.Thread.Sleep(delay);
        }

    }
}
