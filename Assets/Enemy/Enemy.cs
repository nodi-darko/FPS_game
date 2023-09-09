using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float lives = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            Die();
        }
        
    }

    public void Die(){
        Destroy(gameObject);
    }
    public void OnColissionEnter(Collision collision){
        Debug.Log(collision.gameObject.name);
    }
}
