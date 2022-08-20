class Program
{

      static void Main (string[] args)
      {
            string number = Console.ReadLine();
            string[]array = number.Split( ',');
            Console.Write("[ ");
            for(int i = 0;i < array.Length-1;i++)
            {
                  Console.Write(array[i]+ ", ");
            }
            Console.Write(array[array.Length-1]+ " ]");
      }












}