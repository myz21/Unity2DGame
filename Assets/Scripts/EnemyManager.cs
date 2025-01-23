using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    public Slider slider;
    public float health;    
    public float damage;
    bool colliderBusy = false;
    // Start is called before the first frame update
    
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            collision.GetComponent<PlayerManager>().GetDamage(damage);

        }
        else if(collision.tag == "Bullet")
        {
            GetDamage(collision.GetComponent<BulletManager>().bulletDamage);
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player") 
        {
            colliderBusy = false;
        }
    }
 public void GetDamage(float damage)
    {
        if(health - damage >= 0) 
        {
            health-=damage;
        }
        else
        {
            health=0;
        }
        slider.value = health;
        AmIDead();
    }
 void AmIDead()
    {
        if(health<=0)
        {
            global::System.Object value = DataManager.Instance.EnemyKilled++;
            Destroy(gameObject);
        }
    }
}
