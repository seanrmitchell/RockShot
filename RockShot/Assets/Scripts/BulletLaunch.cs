using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class BulletLaunch : MonoBehaviour
{
    public float bulletForce;
    public GameObject bulletPreFab;
    public Transform firePos;
    public AudioSource aud;
    public ScoreDisplay sc;

    [SerializeField]
    private Vector3 shotHalfSize;

    // Update is called once per frame
    void Update()
    {
        // Casts ray from camera to a point correlated with mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.timeScale > 0)
        {
            aud.Play();
            // Destroys rock if ray connects with it
            if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity) && hit.collider.gameObject.CompareTag("Rock"))
            {
                sc.scoreCount += hit.collider.GetComponent<Rock>().scoreValue;
                hit.collider.GetComponent<Rock>().Shot();
            }
        }
    }

}
