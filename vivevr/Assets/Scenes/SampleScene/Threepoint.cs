using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Threepoint : MonoBehaviour
{
    [Header("分數")]
    public Text scoretext;
  static public int score;
    [Header("音效")]
    public AudioClip shot;
    public AudioClip drop;
    private AudioSource aut;
    private void Start()
    {

        aut = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "標靶")
        {
            score += 1;
            aut.PlayOneShot(shot, 1);
            Destroy(this);
        }
        if (other.name == "2")
        {
            score += 2;
            aut.PlayOneShot(shot, 1);
            Destroy(this);
        }
        if (other.name == "5")
        {
            score += 5;
            aut.PlayOneShot(shot, 1);
            Destroy(this);
        }
        if (other.name == "10")
        {
            score += 10;
            aut.PlayOneShot(shot, 1);
            Destroy(this);
        }
        //scoretext.text = "" + score;
    }
  private  void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Untagged")
        {
            aut.PlayOneShot(drop, 0.5f);
            Destroy(this);
        }
    }
}
