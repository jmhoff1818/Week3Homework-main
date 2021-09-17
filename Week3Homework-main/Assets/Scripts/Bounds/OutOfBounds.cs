using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    public GameManager booltime;

    public GameManager wowee;

    private void Start()
    {
        GameObject g = GameObject.Find("GameManager");
        booltime = g.GetComponent<GameManager>();

        GameObject m = GameObject.Find("GameManager");
        wowee = m.GetComponent<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle

        
        if (collision.CompareTag("Ball"))
        {
            Destroy(collision.gameObject);
            booltime.isBallThereYet = false;
            wowee.schnastyWithIt = true;


        }
    }
}
