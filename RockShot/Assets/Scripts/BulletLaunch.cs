using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaunch : MonoBehaviour
{
    public float bulletForce;
    public GameObject bulletPreFab;
    public Transform firePos;

    [SerializeField]
    private Vector3 shotHalfSize;

    [SerializeField]
    private float maxDistance;

    private Ray ray;

    // Update is called once per frame
    void Update()
    {

        // Casts ray from camera to a point correlated with mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Destroys rock if ray connects with it
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity) && hit.collider.gameObject.CompareTag("Rock"))
            {
                hit.collider.GetComponent<Rock>().Shot();
            }
        }
    }

}
