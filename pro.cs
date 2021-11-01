using System;

namespace methods
{
    class pro
    {

        public void Prod()
        {
            string id;
            string name;
            string price;

            string[] pross = new string[3];
            Console.WriteLine("product id");
            id = Console.ReadLine();
            pross[0] = id;

            Console.WriteLine("product name");
            name = Console.ReadLine();
            pross[1] = name;

            Console.WriteLine("product price");
            price = Console.ReadLine();
            pross[2] = price;
            foreach (string det in pross)
            {
                Console.WriteLine(det);
            }
        }
        string Postid;
        string Posttittle;
        string Postcataegtory;

       
        public string Postid1 { get => Postid; set => Postid = value; }
        public string Posttittle1 { get => Posttittle; set => Posttittle = value; }
        public string Postcataegtory2 { get => Postcataegtory; set => Postcataegtory = value; }


        public pro()
        {
            Postid1 = "mi";
            Posttittle1 = "12324";
            Postcataegtory2 = "2000";
        }

        public override string ToString()
        {
            return string.Format("product{0}    \nid{1}    \nprice{2} ",Postid, Posttittle, Postcataegtory);
          
        }
    }
        
    
}
