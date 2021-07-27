using System;
using System.Collections.Generic;
using System.Text;

namespace prjfirstapplication
{
    class Asign2
    {
        internal int Salesno;
        int Productno;
        double Price;
        DateTime dateofsale;
        int Qty;
        double TotalAmount;

        Asign2(int Salesno, int Productno, double Price, DateTime dateofsale, int Qty)
        {
            this.Salesno = Salesno;
            this.Productno = Productno;
            this.Price = Price;
            this.dateofsale = dateofsale;
            this.Qty = Qty;
        }
        void Sales(int qty, double price)
        {
            double TotalAmount = qty * price;
            Console.WriteLine("Total Amount : {0}", TotalAmount);
        }

        static void display(Asign2 saledetails)
        {
            Console.WriteLine("Sale no: " + saledetails.Salesno + " Product no: " + saledetails.Productno +
                " Price: " + saledetails.Price + " Date of Sale: " + (saledetails.dateofsale).ToString("dd/MM/yyyy") +
                " Quantity: " + saledetails.Qty);
        }

        public static void Main(String[] args)
        {
            Asign2 a2 = new Asign2(1, 100, 110.2, Convert.ToDateTime("25/12/1999"), 10);

            display(a2);
            a2.Sales(10, 110.2);
        }

    }
}
