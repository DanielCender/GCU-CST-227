using System;

namespace CarShopGUI
{
    public class Car
    { 
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public bool IsNew { get; set; }
        public int BodyCondition { get; set; }

        public Car(string make, string model, decimal price, bool isNew, int bodyCondition)
        {
            Make = make;
            Model = model;
            Price = price;
            IsNew = isNew;
            BodyCondition = bodyCondition;
        }

        public Car()
        {
            Make = "No Make";
            Model = "No Model";
            Price = 0;
            IsNew = false;
            BodyCondition = 0;
        }
        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2} {3} {4}", Make, Model, Price, IsNew, BodyCondition);
            }
        }
    }
}
