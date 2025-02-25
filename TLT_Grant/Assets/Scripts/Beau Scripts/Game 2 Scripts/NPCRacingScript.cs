using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRacingScript : MonoBehaviour
{
    public int x = 10; // The upper bound for the random number
    public float minMoveTime = 0.5f; // Minimum time to move left
    public float maxMoveTime = 2f; // Maximum time to move left
    public float moveAmount = 0.01f; // Amount to move left each frame
    public float goal = 30f;//goal to win the game
    public GameScript gm;
    private bool gameover = false;

    void Start()
    {
        StartCoroutine(RandomizeAndMove());
    }

    private void Update()
    {
        if(transform.position.x >= goal && gameover == false)
        {
            gm.YouLose();
            gameover = true;
        }
    }

    IEnumerator RandomizeAndMove()
    {
        while (true)
        {
            // Randomize a number between 1 and x
            int randomNumber = Random.Range(1, x + 1);

            // If the number is less than 3, move the object left
            if (randomNumber < 3)
            {
                // Randomize the movement duration between minMoveTime and maxMoveTime
                float moveTime = Random.Range(minMoveTime, maxMoveTime);
                float elapsedTime = 0f;

                // Move the object left for the duration of moveTime
                while (elapsedTime < moveTime)
                {
                    transform.position += Vector3.right * moveAmount;
                    elapsedTime += Time.deltaTime;
                    yield return null; // Wait until the next frame
                }
            }

            // Wait for a short duration before the next randomization
            yield return new WaitForSeconds(.5f);
        }
    }
}