int [] numbers = new int[8];
int max1, max2, i;
max1 = 0;
max2 = 0;
i = 0;
for (i = 0; i < numbers.Length;)
{        
    numbers [i] = new Random().Next(0, 100);        
    Console.Write($"{numbers [i]} ");
        if (numbers [i]>max1)  
        {
            max2=max1;
            max1=numbers [i];
        }
        if (numbers [i]>max2 && numbers [i]<max1)
        {
            max2=numbers [i];
        } 
    i++;
 }
 Console.Write ($"Second maximum:{max2}");                                             
 

