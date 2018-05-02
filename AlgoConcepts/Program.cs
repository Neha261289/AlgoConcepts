﻿using AlgoConcepts.Sorting;
using AlgoConcepts.TreeConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDS ds = new PrintDS();
            SelectionSort ss = new SelectionSort();
            int[] intarr = new int[] { 5,3,4,2,8,9,1};
            string[] strarr = new string[] {"paper", "flower","floppy","true","soap"};

            //ss.sortIntArray(intarr);
            //ss.sortStrArray(strarr);

            //ds.printIntegerArray(intarr);
            //ds.printStringArray(strarr);

            //BubbleSort bs = new BubbleSort();
            //bs.recursiveBubbleSort(intarr,intarr.Length);
            //ds.printIntegerArray(intarr);

            //SingleLinkedList sList = new SingleLinkedList();
            //sList.CreateList(intarr);

            //BubbleSort bs = new BubbleSort();
            //bs.bubbleSortSingleLList(sList);

            //InsertionSort isrt = new InsertionSort();
            //isrt.sortIntArray(intarr);

            //isrt.recursiveSortIntArray(intarr,intarr.Length);

            
            int[] input = new int[] { 12, 11, 13, 5, 6, 7 };
            //ms.mergesortIntArray(input,0,input.Length-1);
            //MergeSort ms = new MergeSort();
            //SingleLinkedList sLL = new SingleLinkedList();
            //sLL.CreateList(input);

            //ms.MergeSortLList(sLL.start)

            QuickSort qs = new QuickSort();
            //qs.quickSortIntArray(input,0,input.Length-1);
            //qs.QuickSortLinkedList(sLL.start, sLL.start.getLastNode());

            //DoublyLinkedList dll = new DoublyLinkedList();
            //dll.createListFromArray(input);
            //qs.QuickSortDLL(dll.Head,dll.Tail);

            //BinaryTree bt = new BinaryTree();
            //bt.root = new TreeNode(1);
            //bt.root.left = new TreeNode(2);
            //bt.root.right = new TreeNode(3);
            //bt.root.left.left = new TreeNode(4);
            //bt.root.left.right = new TreeNode(5);

            //bt.printInOrder(bt.root);

            //bt.printPreOrder(bt.root);

            //bt.printPostOrder(bt.root);

            int[] inorder = new int[] {4,2,5,1,3,6 };
            int[] preorder = new int[] { 1,2,4,5,3,6};

            BinaryTree output = new BinaryTree();
            output.root = output.createTreeFromPreInOrderTraversal(inorder, preorder, 0, inorder.Length);


        }
    }
}
