using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerManager : MonoBehaviour
{
    public int maxHP = 10;
    public int HP;
    public int score = 0;
    private int scoreToAdd;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }

    private void OnTriggerEnter2D(Collider2D contact)
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
                GameObject.Destroy(contact.gameObject);
            }
        }
        
        if (contact.gameObject.CompareTag("Heal"))
        {
            if (HP < maxHP)
            {
            HP += 1;
            GameObject.Destroy(contact.gameObject);
            }


        }

        if (contact.gameObject.CompareTag("Score"))
        {
            scoreToAdd = contact.gameObject.GetComponent<ScoreID>().scoreAwarded;
            score = score + scoreToAdd;
            GameObject.Destroy(contact.gameObject);
        }
    }
}
