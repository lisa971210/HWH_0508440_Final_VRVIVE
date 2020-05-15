using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Threepoint : MonoBehaviour
{
    [Header("分數")]
    public Text scoretext;
  static public int score;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "標靶")
        {
            score += 1;
        Destroy(this);
        }
        if (other.name == "2")
        {
            score += 2;
          Destroy(this);
        }
        if (other.name == "5")
        {
            score += 5;
         Destroy(this);
        }
        if (other.name == "10")
        {
            score += 10;
          Destroy(this);
        }
        //scoretext.text = "" + score;
    }


}
