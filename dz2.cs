// See https://aka.ms/new-console-template for more information

static int z5(List<int> list)
{
    if (list.Count == 0)
    {
        return 0;
    }
    List<int> leftMax = new List<int>(); // максимальное слева значение
    List<int> rightMax= new List<int>();
    var totalLeftMax = -1;
    for (int i = 0; i < list.Count; i++)
    {
        totalLeftMax = Math.Max(totalLeftMax, list[i]);
        leftMax.Add(totalLeftMax);
    }
    var totalRightMax = -1;
    for (int i = 0; i < list.Count; i++)
    {
        totalRightMax = Math.Max(totalRightMax, list[i]);
        rightMax.Add(totalRightMax);
    }

    var sum = 0;
    for (int i = 0; i < list.Count; i++)
    {
        sum += Math.Min(leftMax[i], rightMax[i]) - list[i];
    }
    return sum;
}

int z4(int k, int n)
{
    int [,] memoryArray = new int[k+1,n+1];
    memoryArray[0, 0] = 1;

    int z4_dp(int k0, int n0)
    {
        if ((n0<k0)||(k0<0))
        {return 0;}

        if (memoryArray[k0, n0] != 0)
        {
            return memoryArray[k0, n0];
        }

        var sum = 0;
        for (int i = 1; i < 7; i++)
        {
            sum += z4_dp(k0 - 1, n0 - i);
        }
        memoryArray[k0, n0] = sum;
        return sum;
    }

    return z4_dp(k,n);
}


    

List<int> test1 = new List<int>(); //[4, 2, 0, 3, 2, 5]
    test1.Add(4);
    test1.Add(2);
    test1.Add(0);
    test1.Add(3);
    test1.Add(2);
    test1.Add(5);
    var a = z5(test1);
    System.Console.WriteLine(a);

System.Console.WriteLine(z4(6,20));

