using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rigid2D;
    float jumpforce=1200.0f;
    float walkSpped=0.005f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D=GetComponent<Rigidbody2D>();    
        this.rigid2D.gravityScale=2.0f;
        this.rigid2D.transform.position=new Vector3(-1.5f,0f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<=-4.5){
            SceneManager.LoadScene("GameOver");
        }

        if(Input.GetKey(KeyCode.Space)){
            this.rigid2D.velocity=new Vector2(rigid2D.velocity.x,this.jumpforce*Time.deltaTime);
        }

        transform.Translate(walkSpped,0,0);

    }

    void OnTriggerEnter2D(Collider2D other){
        SceneManager.LoadScene("GameOver");
    }
}
