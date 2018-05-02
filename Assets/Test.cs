using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss{
	private int hp = 100;  //体力
	private int power = 25; //攻撃力
	private int mp = 53; //MP


	//攻撃用の関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	//防御用の関数
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		//残りHPを減らす
		this.hp -= damage;
	}

	//魔法用の関数
	public void Magic(){
		this.mp -= 5;
		if (this.mp >= 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		}
			else{
				Debug.Log("MPが足りないため魔法が使えない。");
			}
	}

}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] array = {10,20,30,40,50};
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

		for (int a = 4; a >= 0; a--) {
			Debug.Log (array [a]);
		}



			//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();



		for (int b = 0; b <= 10; b++) {
			//魔法用の関数を呼び出す
			lastboss.Magic ();
		}


			//攻撃用の関数を呼び出す
			/*lastboss.Attack ();

			//防御用の関数を呼び出す
			lastboss.Defence (3);*/


		/*int[] points = { 30, 20, 50, 60, 80, 10, 100 };
		for (int i = 0; i < points.Length; i++) {
			if (points [i] >= 50) {
				Debug.Log (points [i]);
			}
		}*/

		/*int[] points = new int[5];
		points [0] = 20;
		points [1] = 30;
		points [2] = 60;
		points [3] = 80;
		points [4] = 10;

		for (int i = 0; i < 5; i++) {
			Debug.Log (points [i]);
		}*/

		/*int sum = 0;
		for (int i = 1; i <= 10; i++) {
			sum += i;
		}
		Debug.Log (sum);*/

		/*int num = 2;
		int val = (num == 1) ? -100 : 100;
		Debug.Log (val);*/

		/*int money = 200;
		if (money >= 100) {
			Debug.Log ("ポーションを買う");
		}*/

		/*int a = 3;
		int b = 4;
		int c = a + b;
		Debug.Log (c);*/

		//int score;
		//score = 150;
		//Debug.Log (score);

		//Debug.Log ("Hello, World");
	}
	
	// Update is called once per frame


	void Update () {
		
	}
}
