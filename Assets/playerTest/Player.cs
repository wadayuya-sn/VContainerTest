using UnityEngine;
using VContainer.Unity;

public class Player : IStartable
{
    int hp; // ITickableはMonobehaviourではないので[SerializeField]を除去
    Weapon w; // ITickableはMonobehaviourではないので[SerializeField]を除去
    Shield s; // 追加

    public Player(int hp, Weapon w, Shield s)　// コンストラクタを追加
    {
        this.hp = hp;
        this.w = w;
        this.s = s; 
        s.Guard();
    }
    
    void IStartable.Start()// void Updateを置き換え
    {
        CheckWeapon();
        ShowCurrentHp(); // 追加
    }

    public void CheckWeapon()
    {
        Debug.Log(w.name);
        Debug.Log( w.power);
    }
    
    public void ShowCurrentHp() // 追加
    {
        Debug.Log( hp );
    }
}