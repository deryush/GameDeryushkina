using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    public int Health;
    public GameObject Finish;
    public Text LifesCount;

    public PlayerMove PlayerMove;

    private void Start()
    {
        LifesCount.text ="Lifes: " + Health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyFoot"))
        {
            TakeDamagePlayer();
        }
    }
    private void Update()
    {
        LifesCount.text = "Lifes: " + Health.ToString();
    }
    public void TakeDamagePlayer()
    {
        Health -= 1;
        if (Health <= 0)
        {
            PlayerMove.enabled = false;
            Finish.SetActive(true);
        }
    }
}
