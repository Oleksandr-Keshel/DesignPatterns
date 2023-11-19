// Дано клас Товар (назва, ціна) та Замовлення - клас що містить список пар товар - кількість. 
// Розробити систему продаж. Система повинна вміти продавати 1 товар, а також замовлення. 
// Система повинна вміти приймати оплату кредитною карткою (вивід в консоль повідомлення про суму оплати) та 
// оплату в кредит (вивід в консоль графіку щомісячних оплат) % 
// та термін кредиту вказується додатково. 
// Передбачити можливість розширення функціоналу системи в майбутньому, наприклад, акційне замовлення: 
// список товарів із вказаною знижкою у % та новий способів оплати, наприклад, оплата частинами без %.

/*Для даної задачі доцільно використовувати шаблон проектування Фасад. Він дає змогу спростити інтерфейс
користування системою для користувача, бо Фасад приховує цю складну систему від нього.*/
class Program
{
    public static void Main(string[]agrs){

        Product pr1 = new Product("LG Laptop", 900);
        Product pr2 = new Product("MacBook Air", 1300);
        Product pr3 = new Product("Iphone 15", 1100);
        Product pr4 = new Product("Chair", 30);
        Product pr5 = new Product("Table", 100);


        Inventory inventory = new Inventory();
        inventory.AddProduct(pr1,10);
        inventory.AddProduct(pr2,20);
        inventory.AddProduct(pr3,50);
        inventory.AddProduct(pr4,100);
        inventory.AddProduct(pr5,70);


        Order myOrder = new Order();
        myOrder.addProduct(pr2,2);
        myOrder.addProduct(pr4,10);
        myOrder.addProduct(pr5,2);

        PurchaseFacade purchaseFacade = new PurchaseFacade(inventory);
        purchaseFacade.Purchase(myOrder,"Credit card");
        System.Console.WriteLine("------------------------");
        purchaseFacade.Purchase(pr5,"Credit");
        

        




    }


    




}


