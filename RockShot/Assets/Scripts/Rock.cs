using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Rock : MonoBehaviour
{

    public AudioSource aud;
    public int scoreValue;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        
    }

    public void Shot()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(SoundWait());
    }

    IEnumerator SoundWait()
    {
        aud.Play();
        yield return new WaitUntil(() => !aud.isPlaying);
        Destroy(gameObject);
    }
}
