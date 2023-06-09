// программа получает на вход 4 числа и находит наименьшее и наибольшее из них
       
       
       
        Console.Clear();
        System.Console.WriteLine("Enter 4 numbers");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int num1 = Convert.ToInt32(splitString[0]);
        int num2 = Convert.ToInt32(splitString[1]);
        int num3 = Convert.ToInt32(splitString[2]);
        int num4 = Convert.ToInt32(splitString[3]);

        int maxValue = num1;
        int minValue = num2;
        
        if (num2 > maxValue )
        {
            maxValue = num2;
            minValue = num1;
            if (num3 > maxValue)
            {
                maxValue = num3;            
                if (num4 > maxValue)
                {
                    maxValue = num4;
                    
                }
                else if (num4 < minValue)
                {
                    minValue = num4;
                }
            }
            else if (num4 > maxValue)
            {
                    maxValue = num4;
                    if (num3 < minValue)
                    {
                        minValue = num3;
                        if (num4 < minValue)
                        {
                            minValue = num4;
                        }
                    }
            }
            else 
            {
                if (num3 < minValue)
                    {
                        minValue = num3;
                        if (num4 < minValue)
                        {
                            minValue = num4;
                        }
                    }
                if (num4 < minValue) 
                {
                    minValue = num4;
                }   
            }   
        } 
        else if (num3 > maxValue)
            {
                maxValue = num3;            
                if (num4 > maxValue)
                {
                    maxValue = num4;
                }
                else if (num4 < minValue)
                {
                    minValue = num4;
                }
                
            }
            
        else if (num4 > maxValue)
        {
            maxValue = num4;
            
                if (num3 < minValue)
                {
                    minValue = num3;
                }
        }
        else
        {
            if (num3 < minValue)
            {
                minValue = num3;
            }
            if (num4 < minValue) 
            {
                minValue = num4;
            }
        }
        Console.WriteLine($"Maximum number - {maxValue}");
        Console.WriteLine($"Minimum number - {minValue}");

