using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int maxHP = 10;
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }
    
    private void OnTriggerEnter(Collider contact)
    {
        if (contact.gameObject.CompareTag("Damage"))
        {
            if (HP > 0)
            {
                HP -= 1;
                if (HP == 0)
                {
                    GameObject.Destroy(gameObject);
                }
            }

            if (contact.gameObject.CompareTag("Heal"))
            {
                if (HP < maxHP)
                {   
                    HP += 1;
                }
            }
        }
    }
}
