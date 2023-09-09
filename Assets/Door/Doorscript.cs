using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Doorscript : MonoBehaviour
{
    public GameObject[] enemies;
    public bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemies[0].IsDestroyed() && opened == false)
        {
            OpenDoor();
        }
    }
    void OpenDoor(){
        Debug.Log("Door is opened");
        opened = true;
        gameObject.SetActive(false);
        
    }
}
