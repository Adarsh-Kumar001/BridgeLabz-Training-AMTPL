using System;



class TryCatchFinally
{
    static float Dividee(int x, int y)
    {
        float res = x / y;
        return res;
    }
    static void Main(string[] args)
	{
		int n = Convert.ToInt32(Console.ReadLine());
		int m = Convert.ToInt32(Console.ReadLine());

		float ans = 0;

		try
		{
			ans = Dividee(n, m);
		}
		catch (Exception e) 
		{
			ans = -1;
			Console.WriteLine(e.Message);	
		}
		finally
		{
			Console.WriteLine(ans);
		}
		
	}
}