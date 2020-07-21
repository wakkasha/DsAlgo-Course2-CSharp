﻿namespace DsAlgo_Course2_CSharp.BinarySearchTree
{
	public class Tree
	{
		private class Node
		{
			public int value;
			public Node leftChild;
			public Node rightChild;

			public Node(int value) => this.value = value;

			public override string ToString() => $"Node={value}";
		}

		private Node root;

		public void Insert(int value)
		{
			var node = new Node(value);
			if (root is null)
			{
				root = node;
				return;
			}

			var current = root;
			while (true)
			{
				if (value < current.value)
				{
					if (current.leftChild is null)
					{
						current.leftChild = node;
						break;
					}
					current = current.leftChild;
				}
				else
				{
					if (current.rightChild is null)
					{
						current.rightChild = node;
						break;
					}
					current = current.rightChild;
				}
			}
		}

		public bool Find(int value)
		{
			var current = root;
			while (current != null)
			{
				if (value < current.value)
					current = current.leftChild;
				else if (value > current.value)
					current = current.rightChild;
				else
					return true;
			}
			return false;
		}
	}
}