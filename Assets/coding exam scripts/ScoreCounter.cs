using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text scoreText;
    public int score = 0;
    public string[] ScoreMessages = new string[5];

    public void Start()
    {
        // Old Code that I did not end up using, but didnt delete before the end of class
        //scoreText = GetComponent<Text>();  
       
    }
    // Initially designed to take in a single integer i, and then increase the score by that ammount. However if we want to use the score as a method to index an array, it seemed more practical to simply increase it by one. 
    public void IncreaseScore(int i)
    {
        score += 1;
        scoreText.text = "Score: " + score + "\n" + ScoreMessages[score-1];
      
    }

    // Coroutine that I was going to use to wipe the text board clean after a set ammount of time has passed. in this case 3 seconds, 
    IEnumerator RemoveScoreText()
    {
        yield return new WaitForSeconds(3);
        scoreText.text = "";
    }
}
