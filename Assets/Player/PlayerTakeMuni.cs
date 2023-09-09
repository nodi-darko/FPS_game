using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTakeMuni : MonoBehaviour
{
    public muniBox MuniboxScript;
    public KeyCode takeMuniKey = KeyCode.E;
    public float muniCounter = 3;
    public pistol_inventory pistolGunInventory;
    // Start is called before the first frame update
    void Start()
    {
        pistolGunInventory = pistolGunInventory.GetComponent<pistol_inventory>();
        MuniboxScript = MuniboxScript.GetComponent<muniBox>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, MuniboxScript.transform.position);
        if (Input.GetKey(takeMuniKey) && dist <= 2)
        {
            muniCounter -= Time.deltaTime;
            if (muniCounter <= 0)
            {
                muniCounter = 3;
                TakeMuni();
                pistolGunInventory.allMuniText.text = pistolGunInventory.allMuni.ToString();
            }
        }else
        {
            muniCounter = 3;
        }
    }
    void TakeMuni(){
        pistolGunInventory.allMuni += 20;
        //MuniboxScript.Destroy();
    }
}
