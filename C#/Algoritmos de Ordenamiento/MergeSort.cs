using System;

class MergeSort {

    static void merge(int[] a, int l, int m, int r){
        
        int a1 = m - l + 1;
        int a2 = r - m;

        int[] L = new int[a1];
        int[] R = new int[a2];
        int i, j;

        for (i = 0; i < a1; ++i)
            L[i] = a[l + i];
        for (j = 0; j < a2; ++j)
            R[j] = a[m + 1 + j];

        i = 0;
        j = 0;

        int k = l;
        
        while (i < a1 && j < a2) {
            if (L[i] <= R[j]) {
                a[k] = L[i];
                i++;
            }
            else {
                a[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < a1) {
            a[k] = L[i];
            i++;
            k++;
        }

        while (j < a2) {
            a[k] = R[j];
            j++;
            k++;
        }
    }

    static void mergeSort(int[] a, int l, int r){
        
        if (l < r) {
            
            int m = l + (r - l) / 2;

            mergeSort(a, l, m);
            mergeSort(a, m + 1, r);

            merge(a, l, m, r);
        }
    }

    
    public static void Main(String[] args){
        
        int[] a = {39, 28, 44, 11};
        int n = a.Length;
        Console.Write(" Antes de ordenar el arreglo:");
          for (int i = 0; i < n; ++i)
            Console.Write(a[i] + " ");
        Console.WriteLine();
        
        mergeSort(a, 0, a.Length - 1);
        
    Console.Write(" Antes de ordenar el arreglo:");
        for (int i = 0; i < n; ++i)
            Console.Write(a[i] + " ");
        Console.WriteLine();
    }
}