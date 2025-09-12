using UnityEngine;
using TMPro;  // Use this if you’re using TextMeshPro

public class scoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    public GameObject ball;
    int score =0;
    // Start is called before the first frame update
    public void addScore(int input)
    {   if (input == 1){
            score=score+input;
            scoreText.text = score.ToString()+"Points";
            if (score == 1)
            {
                winText.text = "You Win!";
                ball.SetActive(false);
                
                }
        }
        else if (input == 0){
            winText.text = "Game Over!";
        }
    
    }

   
}
