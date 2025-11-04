using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa.DataSet
{

public class DeliveryPopOrder
    {
        public int Id { get; set; }
        public int User_Company_Id { get; set; }
        public int Company_Id { get; set; }
        public int User_Client_Id { get; set; }
        public string User_Client_Phone_Number { get; set; }
        public string Code { get; set; }

        public OrderData Order_Data { get; set; } // Agora é objeto

        public int Delivery_Type { get; set; }
        public List<DeliveryAddress> Delivery_Address { get; set; } // Agora é lista de objetos

        public string Delivery_Table { get; set; }
        public string Price_Order { get; set; }
        public string Price_Delivery { get; set; }
        public string Price_Total { get; set; }
        public string Price_Cost { get; set; }
        public int Payment_Method { get; set; }
        public int Online_Method { get; set; }
        public int Exchanged { get; set; }
        public string Price_Exchanged { get; set; }
        public string Date_Created { get; set; }
        public string Date_Updated { get; set; }
        public int Is_Schedule_Order { get; set; }
        public string Datetime_Schedule_Order { get; set; }
        public int Status { get; set; }
        public int Paid { get; set; }

        public string Mp_Link { get; set; }
        public string Mp_Preference_Id { get; set; }
        public string Pix_Payload { get; set; }
        public string Pix_Txid { get; set; }
        public string Pix_Mp { get; set; }
        public string Pix_Multihub { get; set; }
        public string Pix_Asaas { get; set; }
        public string Pagseguro_Link { get; set; }
        public string Stripe_Link { get; set; }
        public string Multihub_Link { get; set; }
        public string Asaas_Link { get; set; }

        public int Is_Split_Payment { get; set; }
        public string Ifood_Event_Id { get; set; }
        public string Ifood_Order_Id { get; set; }

        public string Log { get; set; }
        public string Rate { get; set; }
        public string Reason_Cancel { get; set; }
        public int Source_Type { get; set; }
        public int Printed { get; set; }
        public int Warned { get; set; }
        public object Imprimir { get; set; }
    }

    public class OrderData
    {
        public List<CartItem> Cart { get; set; }
        public string Card_Name { get; set; }
        public string Card_Rate { get; set; }
        public string Note { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone_Number { get; set; }
        public string Hash_Token_Fcm { get; set; }
    }

    public class CartItem
    {
        public List<ProductItem> Item { get; set; }
        public List<AdditionalItem> Additionals { get; set; }
        public List<string> AdditionalsAmount { get; set; }
        public string Additionals_Details_List_View { get; set; }
        public string Note { get; set; }
        public int Amount { get; set; }
        public string Price { get; set; }
        public string Unit_Price { get; set; }
        public string CartItemCode { get; set; }
    }

    public class ProductItem
    {
        public int Id { get; set; }
        public int User_Company_Id { get; set; }
        public int Company_Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public string Price { get; set; }
        public string Price_Cost { get; set; }
        public string Price_Offer { get; set; }
        public int Price_Type { get; set; }
        public int Item_Type { get; set; }
        public int Flavor_Amount_Min { get; set; }
        public int Flavor_Amount { get; set; }
        public string Days_Week { get; set; }
        public string Hours { get; set; }
        public int Amount { get; set; }
        public int Free_Shipping { get; set; }
        public int Preparation_Time { get; set; }
        public int Serve_People_Amount { get; set; }
        public string External_Code { get; set; }
        public int Is_Unavailable_Delivery { get; set; }
        public int Unit_Measure_Type { get; set; }
        public string Cashback { get; set; }
        public int Switch_Up_Selling { get; set; }
        public string Up_Selling { get; set; }
        public string Ncm_Code { get; set; }
        public int Hidden { get; set; }
        public int Position { get; set; }
    }

    public class AdditionalItem
    {
        public int Id { get; set; }
        public int User_Company_Id { get; set; }
        public int Company_Id { get; set; }
        public int Additional_Category_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int Max { get; set; }
        public int Hide_Free_Name { get; set; }
        public int Amount { get; set; }
        public string External_Code { get; set; }
        public int Hidden { get; set; }
        public int Position { get; set; }
    }

    public class DeliveryAddress
    {
        public string City { get; set; }
        public string City_Id { get; set; }
        public string District { get; set; }
        public int District_Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Zip_Code { get; set; }
        public string Reference { get; set; }
        public string Complement { get; set; }
    }
}

