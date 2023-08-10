namespace Abstract_Class;
//furniture = mobilya ,fabric=kumaş,material=malzeme,feature=özelik,sofa=kanepe
abstract class furniture
{
   public string color;
   public string fabric;
   public string material;
    abstract public void feature();
}

class Table : furniture
{
    public override void feature()
    {
        Console.WriteLine("Masanın özelikleri ");
        Console.WriteLine("Renk:" + color);
        Console.WriteLine("Malzeme:" + material);
        
    }
}
class Sofa : furniture
{
    public override void feature()
    {
        Console.WriteLine("Kanepenin özelikleri ");
        Console.WriteLine("Renk: " + color);
        Console.WriteLine("Kumaş: " + fabric);

    }
}


class Program
{
    static void Main(string[] args)
    {
        //Abstract_Class
        //Bu sınıftan new anahtar kelimesi kullanılarak bir nesne oluşturulamaz.
        // Sadece soyut sınıflar içerisinde kullanılabilirler.

        Table table = new Table();
        table.color = "Siyah";
        table.material = "Dut ağacı";

        Sofa sofa = new Sofa();
        sofa.color = "Kahverengi";
        sofa.fabric = "Keten";

        table.feature();
        sofa.feature();
        Console.Read();

    }
}




