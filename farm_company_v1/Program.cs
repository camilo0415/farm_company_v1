using System;
using farm_company_v1.Clases;
using farm_company_v1.Codigo;

namespace farm_company_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListasFarmersAndCrops listasFarmersAndCrops = new ListasFarmersAndCrops();

            Farmer f1 = new Farmer();
            f1.Name = "Juan";
            f1.Stratum = 2;
            f1.Gender = 0;
            listasFarmersAndCrops.AddFarmers(f1);

            Farmer f2 = new Farmer();
            f2.Name = "Pablo";
            f2.Stratum = 2;
            f2.Gender = 0;
            listasFarmersAndCrops.AddFarmers(f2);

            Farmer f3 = new Farmer();
            f3.Name = "Maria";
            f3.Stratum = 2;
            f3.Gender = 1;
            listasFarmersAndCrops.AddFarmers(f3);

            Farmer f4 = new Farmer();
            f4.Name = "Pedro";
            f4.Stratum = 2;
            f4.Gender = 0;
            listasFarmersAndCrops.AddFarmers(f4);

            Farmer f5 = new Farmer();
            f5.Name = "Stella";
            f5.Stratum = 2;
            f5.Gender = 1;
            listasFarmersAndCrops.AddFarmers(f5);



            Product p1 = new Product();
            p1.Name = "Cebolla";
            p1.UnitPrice = 15;
            p1.UnitPerKilometer = 45;
            p1.CropExtensionKms = 10;
            p1.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p1);

            Product p2 = new Product();
            p2.Name = "Tomate";
            p2.UnitPrice = 16;
            p2.UnitPerKilometer = 46;
            p2.CropExtensionKms = 11;
            p2.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p2);

            Product p3 = new Product();
            p3.Name = "Sandia";
            p3.UnitPrice = 8;
            p3.UnitPerKilometer = 40;
            p3.CropExtensionKms = 7;
            p3.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p3);

            Product p4 = new Product();
            p4.Name = "Naranja";
            p4.UnitPrice = 17;
            p4.UnitPerKilometer = 39;
            p4.CropExtensionKms = 5;
            p4.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p4);

            Product p5 = new Product();
            p5.Name = "Banano";
            p5.UnitPrice = 20;
            p5.UnitPerKilometer = 50;
            p5.CropExtensionKms = 15;
            p5.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p5);

            Product p6 = new Product();
            p6.Name = "Lechuga";
            p6.UnitPrice = 18;
            p6.UnitPerKilometer = 30;
            p6.CropExtensionKms = 6;
            p6.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p6);

            Product p7 = new Product();
            p7.Name = "Zanahoria";
            p7.UnitPrice = 12;
            p7.UnitPerKilometer = 49;
            p7.CropExtensionKms = 10;
            p7.TaxPerUnitPercentage = 10;
            listasFarmersAndCrops.AddProdut(p7);



        }
    }
}
