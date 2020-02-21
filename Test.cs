using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int hp = 100;     //体力
    private int power = 300;   //攻撃力
    private int magic = 11;//魔法
    private int m = 53;//mp

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りのhpを減らす
        this.hp -= damage;
    }
    //魔法用の関数
    public void Magic()
    {
        Debug.Log(magic+"のダメージを与えた");
        int m = 53;
        if (m >= 5)
        { 
            //残りのmpを減らす
             m -= 5;

            //mpが５以上だった場合の処理
            Debug.Log("魔法攻撃をした。残りmpは"+m);
          
        }else {
        
            Debug.Log("MPが足りないため魔法が使えない");
        }


        


    }
}

public class Test : MonoBehaviour {
        

    void Start(){
        //要素数5の配列を初期化する
        int[] array = new int[5];

            //配列の各要素に値を代入する
        array[0] = 40;
        array[1] = 70;
        array[2] = 10;
        array[3] = 60;
        array[4] = 30;

        //配列の要素を順番に表示する
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

       
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を呼び出す
        lastboss.Magic();

        //10回処理を繰り返す
        for (int m = 53; m >= 5; m -= 5)
        {
            Debug.Log(m);
        }
       
            }
      
        //update is called once per frame
	void Update () {
		
	}
}

