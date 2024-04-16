using ProductProject;

var prodgen = new ProductGeneral();

string nameb = "batchdfsdf";
double priceb = 33;
DateTime expdateb = new DateTime(2024, 5, 1, 8, 30, 52);
DateTime prodtimeb = new DateTime(2008, 5, 1, 8, 30, 52);
int amountb = 13567;

string names = "setsetset";
double prices = 453543;

string name1 = "hjkhvjkhjkfyjk";
double price1 = 2;
DateTime expdate1 = new DateTime(2024, 12, 12, 9, 28, 50);
DateTime prodtime1 = new DateTime(2018, 4, 2, 5, 8, 52);


string name2 = "fghfgsdfasdf346356";
double price2 = 3;
DateTime expdate2 = new DateTime(2024, 2, 3, 10, 29, 51);
DateTime prodtime2 = new DateTime(2019, 4, 2, 5, 8, 52);


string name3 = "lkdlkd00";
double price3 = 4;
DateTime expdate3 = new DateTime(2024, 12, 5, 10, 29, 51);
DateTime prodtime3 = new DateTime(2020, 4, 3, 6, 8, 54);


var product1 = new Product(name1, price1, prodtime1, expdate1);
var product2 = new Product(name2, price2, prodtime2, expdate2);
var product3 = new Product(name3, price3, prodtime3, expdate3);
var batch = new Batch(nameb, priceb, amountb, prodtimeb, expdateb);

Product[] prodArray = { product1, product2, product3};
var set = new Set(names, prices, prodArray);


    product1.ProductInfo(product1);
    batch.ProductInfo(batch);
    set.ProductInfo(set);



