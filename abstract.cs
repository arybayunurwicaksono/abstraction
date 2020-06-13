using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       
       Console.WriteLine("Transportation");
       
       Console.WriteLine();
       
       ACTransportation tp;
       
       tp = new Mobil();
       tp.perusahaan();
       tp.merk();
       tp.jenis();
       
       Console.WriteLine();
       
       tp = new Motor();
       tp.perusahaan();
       tp.merk();
       tp.jenis();
       
       Console.WriteLine();
       
       Console.WriteLine("Cellphone");
       
       Console.WriteLine();
       
       ICellphone cellphone;
       
       cellphone = new Ios();
       cellphone.info();
       cellphone.kelebihan();
       cellphone.Pembuat();
       
       Console.WriteLine();
       
       cellphone = new Android();
       cellphone.info();
       cellphone.kelebihan();
       cellphone.Pembuat();
     }
   }

   public abstract class ACTransportation {
     public abstract void perusahaan();
     public abstract void merk();
     public abstract void jenis();
   }
   
   public class Mobil : ACTransportation{
     public override void perusahaan() {
       Console.WriteLine("Pembuat : Toyota ");
     }
     
     public override void merk() {
       Console.WriteLine("Merk : M3 ");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis : Mobil Bensin ");
     }
   }
   
   public class Motor : ACTransportation{
     public override void perusahaan() {
       Console.WriteLine("Pembuat : Honda");
     }
     
     public override void merk() {
       Console.WriteLine("Merk : Vario");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis : Motor Bensin ");
     }
   }
   
   public interface ICellphone{
     void info();
     void kelebihan();
     void pembuat();
   }
   
  public class Ios : ICellphone {
     public void info() {
       Console.WriteLine("Informasi: ");
     }
   
     public void kelebihan() {
       Console.WriteLine("- Mengunggulkan performa dan kualitas");
     }
     public void Pembuat() {
       Console.WriteLine("- Dari Apple ");
     }
     
   } 
   
   
   public class Android : ICellphone {
     public void info() {
       Console.WriteLine("Informasi: ");
     }
     public void suara() {
       Console.WriteLine("- Penggunanya lebih banyak / mendunia");
     }
     public void jenis() {
       Console.WriteLine("- Dari Samsung, Vivo, Dll");
     }
     
   } 
   
 }