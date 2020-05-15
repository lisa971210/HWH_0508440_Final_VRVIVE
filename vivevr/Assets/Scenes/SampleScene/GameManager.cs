using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;
public class GameManager : MonoBehaviour
{
    [Header("標靶數量")]
    public Text ballcounttext;
    private int ballcount = 10;
    public Text scoretext;
    [Header("音效")]
    public AudioClip music;
    private AudioSource aut;

    private void Start()
    {
        aut = GetComponent<AudioSource>();
    }
    public void Useball(GameObject ball) {
        Destroy(ball.GetComponent<Throwable>());
        Destroy(ball.GetComponent<Interactable>());
        ballcount--;
        ballcounttext.text = "飛鏢數量" + ballcount + "/10";
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
    private void Update()
    {
        scoretext.text = "" + Threepoint.score;
    }
    
}
