using System;
using System.Collections.Generic;
using System.Text;
using farm_company_v1.Clases;

namespace farm_company_v1.Codigo
{
    public class ListasFarmersAndCrops
    {
        Farmer[] Farmers = new Farmer[10];
        int farmCount = 0;

        Product[] Productos = new Product[10];
        int productCount = 0;

        List<double> Extension = new List<double> { 5, 10, 15, 20, 25, 30, 35 };


        public void AñadirFarmers(Farmer farmer)
        {
            Farmers[farmCount] = farmer;
            farmCount++;
        }

        public void AñadirProdut(Product product)
        {
            Productos[productCount] = product;
            productCount++;
        }



    }
}
