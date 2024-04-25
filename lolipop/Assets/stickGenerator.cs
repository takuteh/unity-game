using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickGenerator : MonoBehaviour
{
        public GameObject lolipopPrefab;
    float span=1.0f;
    float delta=0;
    float new_prefabPos_x;
    float old_prefabPos_x;
    GameObject player;
void Start(){
    this.player=GameObject.Find("player");
    create_prefab();
}
    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos=this.player.transform.position;
        this.delta+=Time.deltaTime;

        if(playerPos.x>=old_prefabPos_x+1){
           create_prefab();
        }

    }

    void create_prefab(){
            float py=Random.Range(0,5);
            Vector3 topRight; 

            //画面の端の座標を取得
            topRight= Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
            new_prefabPos_x=topRight.x;
            
            //prefabの座標を設定
            Vector3 prefabPos_top=new Vector3(new_prefabPos_x,py+1,0.0f);
            Vector3 prefabPos_under=new Vector3(new_prefabPos_x,py-4,0.0f);
            
            //prefabを生成
            Instantiate(lolipopPrefab, prefabPos_top, Quaternion.identity);
            Instantiate(lolipopPrefab, prefabPos_under, Quaternion.identity);
            old_prefabPos_x=new_prefabPos_x;
    }
}
