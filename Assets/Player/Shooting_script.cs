using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting_script : MonoBehaviour
{
    public Transform pistol_gun;
    public GameObject pistol_gun_inventory;
    bool usablePistol = false;
    public GameObject crosshair;
    public Camera cam;
    public KeyCode shootKey = KeyCode.Mouse0;
    public float maxDistance = 100;
    public LayerMask layersToHit;
    // Start is called before the first frame update
    void Start()
    {
        crosshair.SetActive(false);
        //GetComponent<pistol_inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pistol_gun != null)
        {
            PickingUpGun();
        }
        if (Input.GetKeyDown(shootKey) && usablePistol == true && pistol_gun_inventory.GetComponent<pistol_inventory>().muniInGun > 0)
        {
            Shoot();    
        }
    }

    private void PickingUpGun(){
        Vector3 distance = transform.position - pistol_gun.transform.position;
        /*if (transform.position.x + 1 > pistol_gun.transform.position.x && transform.position.x - 1 < pistol_gun.transform.position.x &&
            transform.position.z + 1 > pistol_gun.transform.position.z && transform.position.z - 1 < pistol_gun.transform.position.z)*/
        //Debug.Log(distance.ToString());
        if (distance.magnitude < 2 )
        {
            pistol_gun.GetComponent<pistol_ground>().Destroy_pistol();
            usablePistol = true;
            pistol_gun_inventory.GetComponent<pistol_inventory>().SetGunActive();
            crosshair.SetActive(true);
        }
    }
    private void Shoot(){
        pistol_gun_inventory.GetComponent<pistol_inventory>().muniInGun --;
        pistol_gun_inventory.GetComponent<pistol_inventory>().muniText.text = pistol_gun_inventory.GetComponent<pistol_inventory>().muniInGun.ToString();

        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, layersToHit))
        {
            hit.collider.gameObject.GetComponent<Enemy>().lives -= 10;
        }
    }

}
