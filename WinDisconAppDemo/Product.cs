using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconAppDemo
{
    public class Product
    {
     #region Fields
        int prodID;
        string prodName;
        int price;
        string desc;
        #endregion

        #region Properties
        //CLR Properties
        public int ProdId
        {
            get { return prodID; }
            set
            {
                if(value <=0 || value >= 999)
                {
                    throw new MyCustomException("Product Id is not Valid!!");
                }
                else
                {
                    prodID = value;
                }
            }
        }
        public string Name { get; set; }
        public int Price { get; set; }
        public string CatName {  get; set; }
        public string Description { get; set; }
        #endregion

    }
}
