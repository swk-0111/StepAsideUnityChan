using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour {

    //Unityちゃんオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    //test 障害物を消すブロックのオブジェクト
    private GameObject deleteBlock;

    //test 障害物を消すブロックとカメラの位置
    private float blockDifference;


    // Use this for initialization
    void Start () {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find ("unitychan");
        //Unityちゃんとカメラの位置(z座標)の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //test 障害物を消すブロックのオブジェクトを取得
        this.deleteBlock = GameObject.Find("DeleteBlock");
        //障害物を消すブロックの位置はカメラと同じ
        this.blockDifference = this.transform.position.z;

    }

    // Update is called once per frame
    void Update () {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, 
                                              this.transform.position.y,
                                              this.unitychan.transform.position.z - difference);

        //Debug.Log(this.transform.position);
    }
}
