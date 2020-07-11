using DsAlgo_Course2_CSharp.BinarySearchTree;
using System;

namespace DsAlgo_Course2_CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			#region Tree

			Tree tree = new Tree();
			tree.Insert(7);
			tree.Insert(4);
			tree.Insert(9);
			tree.Insert(1);
			tree.Insert(6);
			tree.Insert(8);
			tree.Insert(10);

			Console.WriteLine("");

			#endregion Tree
		}
	}
}