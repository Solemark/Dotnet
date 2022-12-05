namespace Reverse_Array {
    internal class Reverse_Array {
        internal static int[] Reverse(int[] arr) {
            output(arr);
            int a = 0;
            int b = 0;
            int c = arr.Length - 1;
            for (int i = 0; i <= c; i++) {
                a = arr[i];
                b = arr[c];
                arr[c] = a;
                arr[i] = b;
                c--;
            }
            output(arr);
            return arr;
        }

        internal static void output(int[] arr){
            Console.WriteLine();
            foreach(var number in arr){
                Console.Write(number + " ");
            }
        }
    }
}