using System;

namespace Interface
{public interface PrinterWindows
    {
    void Show();
    void Print();
    }
    public class Epson : PrinterWindows
    {
    public void Show()
        {Console.WriteLine("Epson display dimension : 10*11");}
    public void Print()
        {Console.WriteLine("Epson printer printing. . .");}
    }public class Canon : PrinterWindows{
    public void Show()
        {Console.WriteLine("Canon display dimension : 9.5*12");}
    public void Print()
        {Console.WriteLine("Canon printer printing. . .");}
    }public class LaserJet : PrinterWindows{
    public void Show()
        {Console.WriteLine("LaserJet display dimension : 12*12");}
    public void Print()
        {Console.WriteLine("LaserJet printer printing. . .");}
    }class Program{
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih Printer :");
            Console.WriteLine("1.Epson");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LaserJet\n");
            Console.Write("Nomor Printer [1...3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();
            printer.Show();
            printer.Print();
            Console.ReadKey();}}}