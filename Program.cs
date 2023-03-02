class homwork{
    static void Main(){
        
        bool check1 = false,check2 = false, check3 = false, check4 = false;
        
        Console.Write("Input FBI/CIA/NSA : ");
        string  agency = Console.ReadLine();
        
       
        Console.Write("Input password = ");
        int x = int.Parse(Console.ReadLine());
        bool y = (x>=100000)&&(x<=999999);
        
        int sixth = x % 10;
        int fifth = (x/10) % 10;
        int fourth = (x/100)%10;
        int third = (x/1000) % 10;
        int second = (x/10000)%10;
        int first = (x/100000)%10;
      
    switch(agency){
        
        case "CIA":
               if (y == true)
                {
                    check1 = true;
                }
                if(sixth%3 == 0) 
                {
                    check2 = true; 
                }
                if(fifth != 1 && fifth != 3 && fifth != 5)
                {
                    check3 = true;
                }
                if(third >=6 && third!=8)
                {
                    check4 = true;
                }
                if(check1 && check2 && check3 && check4)
                {
                    Console.WriteLine("True");
                }
                else
                {
                Console.WriteLine("False");
                }
            break;



        case "FBI":
            if (y == true)
            {
                check1 = true;
            }
            if(	first>=4 && first <=7)
            {
                check2=true;
            }
            if(fourth%2==0 && fourth!=6)
            {
                check3=true;
            }
            if(second % 2 != 0){
                check4=true;
            }
             if(check1 && check2 && check3 && check4)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            break;
        
        
        case "NSA":
            if (y == true)
            {
                check1 = true;
            }
            if (sixth == 1 || sixth == 2 || sixth == 3 || sixth == 5 || sixth == 6)
            {
                check2=true;
            }
            if(fourth % 3 == 0 && fourth % 2!= 0)
            {
                check3=true;
            }
            if(sixth == 7 || fifth == 7 || fourth == 7 || third == 7 || second == 7 || 	first == 7)
            {
                check4=true;
            }
            if(check1 && check2 && check3 && check4)
            {
                    Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            break;
        }

    }
}
