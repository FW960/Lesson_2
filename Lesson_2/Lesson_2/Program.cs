using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Информация о организации и номер чека

            int receiptNum = 1111;
            string organisationName = "ООО Ромашка";
            long individualTaxpayerNum = 123456789100;

            //Информация о месте и времени покупки

            int zipCode = 770000;
            string adressCity = "Москва";
            string adressStreet = "ул. Воронцовская";
            int houseNum = 35;

            DateTime dateTime = new DateTime(2022, 01, 25, 10, 00, 00);

            //Информация о кассире

            string cashierName = "Иванов Иван Иванович";

            //Информация по продуктам

            string productmilk = "Молоко"; int milkAmount = 1; float milkPrice = 50.00f; float valueAddedFaxForMilk = 5.00f;  int percentageAddedFaxForMilk = 10; float allMilkPrice = milkAmount * milkPrice;

            string productLipton = "Lipton"; int liptonAmount = 2; float liptonPrice = 150.00f; float valueAddedFaxForLipton = 54.00f;  ;  int percentageAddedFaxForLipton = 18; float allLiptonPrice = liptonAmount * liptonPrice;

            float allProductsPrice = 350.00f;

            //Сумма и сдача

            float cash = 500.00f;
            float change = 150.00f;

            //Информация о чеке

            string taxationSystem = "ОСНО";
            int fiscalReceiptNum = 12345;
            int KKTcode = 479949;
            int fiscalAccumulator = 88890;
            string fiscalDataOperatorName = "Первый ОФД";

            Console.WriteLine($"               Кассовый чек №:{receiptNum}");
            Console.WriteLine($"                  {organisationName}");
            Console.WriteLine($"                ИНН {individualTaxpayerNum}");
            Console.WriteLine($"    Адрес: {zipCode}, {adressCity}, {adressStreet}, {houseNum}Б");
            Console.WriteLine($"              {dateTime}");
            Console.WriteLine($"           Кассир: {cashierName}");
            Console.WriteLine("****************************************************");
            Console.WriteLine("Приход");
            Console.WriteLine("Продажа");
            Console.WriteLine("****************************************************");
            Console.WriteLine("Товар  Цена  Кол-во Стоимость");
            Console.WriteLine($"{productmilk}  {milkPrice}p.     {milkAmount}      {allMilkPrice}p.");
            Console.WriteLine($"НДС {percentageAddedFaxForMilk}%");
            Console.WriteLine($"{productLipton}  {liptonPrice}p.    {liptonAmount}      {allLiptonPrice}p.");
            Console.WriteLine($"НДС {percentageAddedFaxForLipton}%");
            Console.WriteLine($"Итого                   {allProductsPrice}p.");
            Console.WriteLine($"{percentageAddedFaxForMilk}%                     {valueAddedFaxForMilk}p.");
            Console.WriteLine($"{percentageAddedFaxForLipton}%                     {valueAddedFaxForLipton}p.");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"Наличными        {cash}p.");
            Console.WriteLine($"Сдача            {change}p.");
            Console.WriteLine("****************************************************");
            Console.WriteLine($"          Система налогообложения {taxationSystem}");
            Console.WriteLine($"              Фискальный чек {fiscalReceiptNum}");
            Console.WriteLine($"                 Код ККТ {KKTcode}");
            Console.WriteLine($"                   ФН {fiscalAccumulator}");
            Console.WriteLine($"                ОФД {fiscalDataOperatorName}");
        }

    }
}
