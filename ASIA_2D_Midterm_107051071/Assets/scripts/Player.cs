using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "傳送門")

        {
            final.SetActive(true);

        }

        if (collision.tag=="南瓜")

        {
            Destroy(collision.gameObject);

            count++;
            textcount.text = "南瓜:" + count;
        }
    }






}
