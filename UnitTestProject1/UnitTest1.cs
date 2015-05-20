using System;
using System.CodeDom;
using System.Collections.Generic;
using GraphDataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AdjacencyListGraph graph = new AdjacencyListGraph();
            Node n1 = new Node()
            {
                Id=1,Value = 10
            };
            Node n2 = new Node()
            {
                Id = 2,Value = 15
            };
            var list = new Dictionary<int, List<Node>>();
            List<Node> n1List = new List<Node>();
            n1List.Add(n2);
            List<Node> n2List = new List<Node>();
            n2List.Add(n1);
            list.Add(n1.Id,n1List);
            list.Add(n2.Id,n2List);
            graph.AdjacencyList = list;
            Assert.AreEqual(graph.GetDegree(1),1);
        }
    }
}
