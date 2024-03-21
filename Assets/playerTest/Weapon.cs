using System;

[Serializable]
public class Weapon
{
    public string name;
    public int power;

    public Weapon(string name, int power)
    {
        this.name = name;
        this.power = power;
    }
}