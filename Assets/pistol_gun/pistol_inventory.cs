using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class pistol_inventory : MonoBehaviour
{
    public bool pistolInInventory = false;
    public KeyCode zoomKey = KeyCode.Mouse1;
    public KeyCode reloadKey = KeyCode.R;
    public GameObject crosshair;
    public Camera cam;
    public float muniInGun = 0;
    public float allMuni = 0;
    public TMP_Text muniText;
    public TMP_Text allMuniText;
    public float maxMuniInGun = 6;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        muniText.text = muniInGun.ToString();
        allMuniText.text = allMuni.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PistolZoom();
        if (muniInGun <= 0 && allMuni > 0)
        {
            Reload();
        }
    }

    public void SetGunActive(){
        gameObject.SetActive(true);
        crosshair.GetComponent<Crosshairs>().ChangeToNormal();
    }

    public void PistolZoom(){
        if (Input.GetKey(zoomKey))
        {
            crosshair.GetComponent<Crosshairs>().ChangeToSniper();
            cam.fieldOfView = 20;
        }else
        {
            cam.fieldOfView = 60;
            crosshair.GetComponent<Crosshairs>().ChangeToNormal();
        }
        if (Input.GetKeyDown(reloadKey))
        {
            Reload();
        }
    }
    public void Reload(){
        if (allMuni + muniInGun >= maxMuniInGun)
        {
            allMuni = allMuni - maxMuniInGun + muniInGun;
            muniInGun = maxMuniInGun;
        }else
        {
            muniInGun = muniInGun +allMuni;
            allMuni = 0;
        }
        muniText.text = muniInGun.ToString();
        allMuniText.text = allMuni.ToString();
    }

}
