using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int hp = 1;

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealthScript player = collision.gameObject.GetComponent<PlayerHealthScript>();
        EnemyMoveScript1 enemy1 = collision.gameObject.GetComponent<EnemyMoveScript1>();
        EnemyMoveScript2 enemy2 = collision.gameObject.GetComponent<EnemyMoveScript2>();
        BlastScript blast = collision.gameObject.GetComponent<BlastScript>();
        Debug.Log("Kaboom!!!");

        

        if ((enemy1 != null || enemy2 != null))
        {
            hp -= 1;

            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        var gameOver = FindObjectOfType<GameOverScript>();
        gameOver.ShowButtons();
    }
}
