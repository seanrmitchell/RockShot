using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour
{
    public float bulletForce;
    public GameObject bulletPreFab;
    public Transform firePos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
    }

    void Fire()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity) && hit.collider.gameObject.CompareTag("Rock"))
        {
            Destroy(hit.collider.gameObject);
        }
        
        /*GameObject clone = Instantiate(bulletPreFab, firePos.position, firePos.rotation);
        Rigidbody rb = clone.GetComponent<Rigidbody>();
        rb.AddForce(firePos.forward * bulletForce, ForceMode.Impulse);*/
    }
}
