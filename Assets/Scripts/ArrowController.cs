using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    Transform player;
    public GameDirector director;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-0.1f,0);

        if(transform.position.y < -5.0f){
            //Debug.Break();
            Destroy(gameObject);            
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.position;
        Vector2 dir = p1-p2;
        float d= dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;
        
        if(d < r1 + r2){
            director.DecreaseHp();
            Destroy(gameObject);
        }
    }

    public void setPlayer(Transform player){
        this.player=player;
    }
}
