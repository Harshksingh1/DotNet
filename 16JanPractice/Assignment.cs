// // using System;
// // class Program
// // {
// class Membership
// {
//     public string Tier{set;get;}
//     public int DurationinMonth{set;get;}
//     public double BasePricePerMonth{set;get;}

//     public bool ValidateEnrollment()
//     {
//         if(Tier!="Basic" || Tier!="Premium" || Tier != "Elite")
//         {
//             throw new InvalidTierException("Tier not recognized");
//         }
//         if (DurationinMonth <= 0)
//         {
//             throw new Exception("Duration must be at least one month.");
//         }
//         return true;
//     }
//     public double CalculateTotalBill()
//     {
//         double total=(DurationinMonth*BasePricePerMonth);
//         double discountRate = 0;
//         if (Tier== "Basic")
//         {
//             discountRate = 0.02;
//         }
//         else if (Tier == "Premium")
//         {
//             discountRate = 0.07;
//         }
//         else if (Tier == "Elite")
//         {
//             discountRate = 0.12;
//         }
//         double finaltotal=total-(total*discountRate);
//         return finaltotal;
//     }
//     public static void Main(string[] args)
//     {
//         Membership mi=new Membership();
//         Console.Write("Enter the Tier: ");
//         mi.Tier=Console.ReadLine();
//         Console.Write("Enter the duration: ");
//         mi.DurationinMonth=int.Parse(Console.ReadLine());
//         Console.Write("Enter the base Price Per month: ");
//         mi.BasePricePerMonth=double.Parse(Console.ReadLine());
//         try
//         {
//             if (mi.ValidateEnrollment())
//             {
//                 double bill=mi.CalculateTotalBill();
//                 Console.WriteLine("Final bill is: "+bill);
//             }
//         }catch(InvalidTierException ex)
//         {
//             Console.WriteLine("Erroor: "+ex.Message);
//         }
//         catch(Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }

// using System;
// class Shipment
// {
//     public string ShipmentCode { get; set; }
//     public string TransportMode { get; set; }
//     public double Weight { get; set; }
//     public int StorageDays { get; set; }

//     public Shipment(string shipmentCode, string transportMode, double weight, int storageDays)
//     {
//         ShipmentCode = shipmentCode;
//         TransportMode = transportMode;
//         Weight = weight;
//         StorageDays = storageDays;
//     }
// }

// class ShipmentDetails : Shipment
// {
//     public ShipmentDetails(string shipmentCode) 
//         : base(shipmentCode, "", 0, 0)
//     {
//     }

//     public bool ValidateShipmentCode()
//     {
//         if (string.IsNullOrEmpty(ShipmentCode) || ShipmentCode.Length != 7)
//             return false;

//         if (!ShipmentCode.StartsWith("GC#"))
//             return false;

//         string digits = ShipmentCode.Substring(3);
//         return int.TryParse(digits, out _);
//     }
//     public double CalculateTotalCost()
//     {
//         double ratePerKg = 0;

//         switch (TransportMode)
//         {
//             case "Sea": ratePerKg = 15.0; break;
//             case "Air": ratePerKg = 50.0; break;
//             case "Land": ratePerKg = 25.0; break;
//             default: return 0.0;
//         }

//         double totalCost = (Weight * ratePerKg) + Math.Sqrt(StorageDays);
//         return Math.Round(totalCost, 2);
//     }
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Enter the Shipment Code: ");
//         string code = Console.ReadLine();

//         ShipmentDetails sh = new ShipmentDetails(code);

//         if (sh.ValidateShipmentCode())
//         {
//             Console.Write("Enter the Transport Mode (Sea/Air/Land): ");
//             sh.TransportMode = Console.ReadLine();

//             Console.Write("Enter the Weight: ");
//             sh.Weight = double.Parse(Console.ReadLine());

//             Console.Write("Enter the Storage Days: ");
//             sh.StorageDays = int.Parse(Console.ReadLine());

//             double result = sh.CalculateTotalCost();
//             Console.WriteLine("The total cost is: " + result);
//         }
//         else
//         {
//             Console.WriteLine("Invalid shipment code");
//         }
//     }
// }


// class Chocolate
// {
//     public string Flavour{get;set;}
//     public int Quantity{get;set;}
//     public int PricePerUnit{get;set;}
//     public double TotalPrice{get;set;}
//     public double DiscountPrice{set;get;}
//     public bool ValidateChocolateFlavour()
//     {
//         if(Flavour=="Dark" || Flavour=="Milk"|| Flavour=="White") return true;
//         return false;
//     }
// }
// class Program
// {
//     public Chocolate CalculateDiscountedPrice(Chocolate chocolate)
//     {
//         double discount=0;
//         if(chocolate.Flavour=="Dark") discount=18;
//         else if(chocolate.Flavour=="Milk") discount=12;
//         else discount=6;

//         chocolate.TotalPrice=chocolate.Quantity*chocolate.PricePerUnit;
//         chocolate.DiscountPrice=chocolate.TotalPrice-(chocolate.TotalPrice*discount/100);
//         return chocolate;
//     }
//     public static void Main(string[] args)
//     {
//         Chocolate ch=new Chocolate();
//         Console.Write("Enter flavour: ");
//         ch.Flavour=Console.ReadLine();
//         Console.Write("Enter quantity: ");
//         ch.Quantity=int.Parse(Console.ReadLine());
//         Console.Write("Enter price per unit: ");
//         ch.PricePerUnit=int.Parse(Console.ReadLine());
//         if (ch.ValidateChocolateFlavour())
//         {
//             Program p=new Program();
//             Chocolate chocolate=p.CalculateDiscountedPrice(ch);
//             Console.Write("Falvour: "+ch.Flavour);
//             Console.Write("Quantity: "+ch.Quantity);
//             Console.Write("Price per unit: "+ch.PricePerUnit);
//             Console.Write("Total Price: "+ch.TotalPrice);
//             Console.Write("Discounted Price: "+ch.DiscountPrice);
//         }
//         else
//         {
//             Console.WriteLine("Invalid input");
//         }
//     }
// }

// using System;

// public class Computer
// {
//     public string Processor { get; set; }
//     public int RamSize { get; set; }
//     public int HardDiskSize { get; set; }
//     public int GraphicCard { get; set; }
// }

// public class Desktop : Computer
// {
//     public int MonitorSize { get; set; }
//     public int PowerSupplyVolt { get; set; }

//     public double DesktopPriceCalculation()
//     {
//         double processorCost = 0;

//         if (Processor == "i3")
//             processorCost = 1500;
//         else if (Processor == "i5")
//             processorCost = 3000;
//         else if (Processor == "i7")
//             processorCost = 4500;

//         double price =
//             processorCost +
//             (RamSize * 200) +
//             (HardDiskSize * 1500) +
//             (GraphicCard * 2500) +
//             (MonitorSize * 250) +
//             (PowerSupplyVolt * 20);

//         return price;
//     }
// }

// public class Laptop : Computer
// {
//     public int DisplaySize { get; set; }
//     public int BatteryVolt { get; set; }

//     public double LaptopPriceCalculation()
//     {
//         double processorCost = 0;

//         if (Processor == "i3")
//             processorCost = 2500;
//         else if (Processor == "i5")
//             processorCost = 5000;
//         else if (Processor == "i7")
//             processorCost = 6500;

//         double price =
//             processorCost +
//             (RamSize * 200) +
//             (HardDiskSize * 1500) +
//             (GraphicCard * 2500) +
//             (DisplaySize * 250) +
//             (BatteryVolt * 20);

//         return price;
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("1.Desktop");
//         Console.WriteLine("2.Laptop");
//         Console.WriteLine("Choose the option");

//         int option = int.Parse(Console.ReadLine());

//         switch (option)
//         {
//             case 1:
//                 Desktop d = new Desktop();

//                 Console.WriteLine("Enter the processor");
//                 d.Processor = Console.ReadLine();

//                 Console.WriteLine("Enter the ram size");
//                 d.RamSize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the hard disk size");
//                 d.HardDiskSize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the graphic card size");
//                 d.GraphicCard = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the monitor size");
//                 d.MonitorSize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the power supply volt");
//                 d.PowerSupplyVolt = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Desktop price is " + d.DesktopPriceCalculation());
//                 break;

//             case 2:
//                 Laptop l = new Laptop();

//                 Console.WriteLine("Enter the processor");
//                 l.Processor = Console.ReadLine();

//                 Console.WriteLine("Enter the ram size");
//                 l.RamSize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the hard disk size");
//                 l.HardDiskSize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the graphic card size");
//                 l.GraphicCard = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the display size");
//                 l.DisplaySize = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Enter the battery volt");
//                 l.BatteryVolt = int.Parse(Console.ReadLine());

//                 Console.WriteLine("Laptop price is " + l.LaptopPriceCalculation());
//                 break;

//             default:
//                 Console.WriteLine("Invalid option");
//                 break;
//         }
//     }
// }