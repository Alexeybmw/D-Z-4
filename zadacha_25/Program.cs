int Exp (int A,int B)
{
      int result = 1;
      for (int i=1;i<=B;i++)
      {
            result = result * A;
      }
      
      return result;
}
Console.Write("Введите число A; ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B; ");
int numB = Convert.ToInt32(Console.ReadLine());

int exp = Exp(numA,numB);
Console.WriteLine("->" + exp);
