using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PowerUpDollar : MonoBehaviour
{

    public float cashAmmount = 100.0f;

    public AudioClip clip = null;

    private AudioSource sfx = null;

    // Use this for initialization
    void Start()
    {
        GameObject SoundsObject = GameObject.FindGameObjectWithTag("sounds");
        if (SoundsObject == null) return;
        sfx = SoundsObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("player")) return;
        if (sfx) { sfx.PlayOneShot(clip, 1.0f); }
        gameObject.SetActive(false);
        PlayerController pc = other.gameObject.GetComponent<PlayerController>();
        //if (pc != null) pc.cash += cashAmmount;
        GameManager.Notifications.PostNotification(this, "PowerupCollected");
    }
}
