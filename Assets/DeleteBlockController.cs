using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBlockController : MonoBehaviour {

    //透明な壁を移動させるコンポーネントを入れる
   // private Rigidbody myRigidbody;
    //前進するための力
   // private float forwardForce = 800.0f;


    // Use this for initialization
    void Start () {

        //Rigidbodyコンポーネントを取得
        // this.myRigidbody = GetComponent<Rigidbody>();

        //Debug.Log("スタート");
    }
	
	// Update is called once per frame
	void Update () {
        //透明な壁に前方向の力を加える
       // this.myRigidbody.AddForce(this.transform.forward * forwardForce);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("衝突した");
        //Debug.Log("アザー" + other.gameObject.tag);


        //障害物に衝突した場合
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag" || other.gameObject.tag == "CoinTag")
        {
           // Debug.Log("デリート前");
            Destroy(other.gameObject);
           // Debug.Log("デリート後");
        }

        // Debug.Log("if文抜けた");

    }
}
