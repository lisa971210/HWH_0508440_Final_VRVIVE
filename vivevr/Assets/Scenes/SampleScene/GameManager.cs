using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;
public class GameManager : MonoBehaviour
{
    [Header("籃球數量")]
    public Text ballcounttext;
    private int ballcount = 5;
    [Header("分數")]
    public Text scoretext;
    private int score;
    private Threepoint threepoint;
    [Header("音效")]
    public AudioClip music;
    private AudioSource aut;
    private void Start()
    {
        aut = GetComponent<AudioSource>();
        threepoint = FindObjectOfType<Threepoint>();
    }
    public void Useball(GameObject ball) {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());
        ballcount--;
        ballcounttext.text="籃球數量:"+ballcount+"/5";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (threepoint.inthreepoint)
        {
            score += 3;
        }
        else
        {
            score += 2;
        }
        scoretext.text = "分數" + score;
    }
    public void Replay()
    {
        Destroy(FindObjectOfType<Player>().gameObject);
        SceneManager.LoadScene("viver");
    }
    public void Quit()
    {
        Application.Quit();
        
    }
}
