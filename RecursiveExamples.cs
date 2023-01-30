internal class RecursiveExamples
{
    private static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        int uY = 6;
        int hC = 10;
        int max = 10;
        bool turnOfGlass = false;

        Methods methods = new();


        Console.WriteLine(" Staircase: \n");
        methods.Staircase(x,y);
        Console.WriteLine("\n Upsidedown Staircase: \n");
        methods.UpsideDownStairs(x, uY);
        Console.WriteLine("\n Hourglass: \n");
        methods.HourGlass(x, hC, max, turnOfGlass);
    }

    class Methods
    {
        public void Staircase(int i, int y){
            y+=1;
            var c = new String('#', y);

            if(y < 6)
            {
                Console.WriteLine(c);
                Staircase(i,y); 
            }           
        }

        public void UpsideDownStairs(int i, int y)
        {
            y-=1;
            var c = new String('#', y);

            if(y > 0)
            {
                Console.WriteLine(c);
                UpsideDownStairs(i,y);
            }
        }

        public void HourGlass(int spaceCount, int hashCount, int max, bool turnOfGlass)
        {
            var hash = new String('#', hashCount);
            var space = new String(' ', spaceCount);

            if(hashCount <= max)
            {
                if(!turnOfGlass)
                {   
                    if(hashCount <= 4)
                        turnOfGlass = true;

                    Console.WriteLine(space + hash + space);
                    HourGlass(spaceCount + 1, hashCount -= 2, max, turnOfGlass);
                }
                else
                {                 
                    if(spaceCount > 0)
                        spaceCount--;
                    
                    Console.WriteLine(space + hash + space);
                    HourGlass(spaceCount, hashCount + 2, max, turnOfGlass);
                }
            }
        }
    }
     
}