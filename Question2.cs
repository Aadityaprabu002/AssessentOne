namespace AssessentOne {
    internal class Question2 {
        static public void Run() {
            Console.WriteLine("Question 2");
            int[][] array = new int[3][];
            for(int i = 0;i < 3; i++) {
                array[i] = new int[3+i];
            }
            for(int i = 0; i < 3; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
