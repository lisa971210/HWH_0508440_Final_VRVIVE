using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;
public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text ballcounttext;
    private int ballcount = 5;
    [Header("分數")]
    public Text scoretext;
    private int score;

    public void Useball(GameObject ball) {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());
        ballcount--;
        ballcounttext.text="籃球數量:"+ballcount+"/5";
    }
    private void OnTriggerEnter(Collider other)
    {
        score += 2;
        scoretext.text = "分數" + score;
    }
}
