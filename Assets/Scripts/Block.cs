using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Element myElement;
    [SerializeField] private int Health;

    // Start is called before the first frame update
    void Start()
    {
        Health = myElement.Health;
    }

    void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0) OnMine();
    }

    void OnMine()
    {
        for (int i = 0; i < myElement.NumberOfItemsToDrop; i++)
        {
            Instantiate(myElement.ItemToDrop, transform.position + Random.onUnitSphere, 
                transform.rotation);
        }
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        TakeDamage(1);
    }
}

