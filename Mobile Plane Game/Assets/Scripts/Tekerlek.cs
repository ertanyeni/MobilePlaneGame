using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tekerlek : MonoBehaviour
{
    public float RampaForceX = 1000;
    public float RampaForceY = 100;
    public float RampaForceCikisX = 1000;
    public float RampaForceCikisY = 500;
    public Rigidbody2D tekerlek;
    public Rigidbody2D PlaneBody;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rampa")
        {
            Vector2 rampaForce = new Vector2(RampaForceX, RampaForceY);
            tekerlek.AddForce(rampaForce);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rampa")
        {
            Vector2 rampaForce = new Vector2(RampaForceCikisX, RampaForceCikisY);
            PlaneBody.gravityScale = 0.3f;
            tekerlek.AddForce(rampaForce);
        }
    }

}
