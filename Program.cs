
string[] InArray = new string[9] { "2012", "1984", "c#", "Star", "Wars", "Andor", ":-p", "GB", "GPB" };
string[] OutArray = new string[InArray.Length];
int count = 0;
    for (int i = 0; i < InArray.Length; i++)
       
    {
        
        if (InArray[i].Length <= 3)
        {
            OutArray[count] = InArray[i];
            count++;
            
        }
       
    }
    
    Console.Write(String.Join(" ", OutArray)); 
