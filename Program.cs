using PV.ObjectPooling;

var bulletPool = new Pool<Bullet>(20);

var counter = 0;
while (true)
{
    var bullet = bulletPool.Get();
    bullet.Penetration = 10;
    bullet.Strength = counter++;
    Console.WriteLine($"Shooting bullet. Strength: {bullet.Strength} Penetration: {bullet.Penetration}");
    bulletPool.Return(bullet);
}


class Bullet
{
    public int Penetration { get; set; }
    public int Strength { get; set; }
}