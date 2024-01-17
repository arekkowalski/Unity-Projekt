using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemCollector : MonoBehaviour
{

    private int strawberries = 0;

    [SerializeField] private Text Points;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            Destroy(collision.gameObject);
            strawberries++;
            Points.text = "Points: " + strawberries;
        }
        else if (collision.gameObject.CompareTag("Coin"))
        {  
            Destroy(collision.gameObject);
            strawberries = strawberries + 5;
            Points.text = "Points: " + strawberries;
        }
    }
}
