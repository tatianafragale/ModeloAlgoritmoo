public static class FlywaightPointer
{
    public static readonly Flywaight NormalBullet = new Flywaight()
    {
        speed = 50,
        damage = 10
    };


    public static readonly Flywaight MegaBullet = new Flywaight()
    {
        speed = 30,
        damage = 10
    };
}
