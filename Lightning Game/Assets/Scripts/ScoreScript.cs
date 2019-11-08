using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
	
	public Text MyText;
    // Start is called before the first frame update
    void Start()
    {	
		MyText = gameObject.GetComponent<Text>();
        MyText.text = "SCORE: 000000";
    }

    // Update is called once per frame
    void Update()
    {
		
       
    }
	
	public void ScoreUpdate(int score){
		
		 if(score < 100){
			MyText.text = "SCORE: " + score.ToString().PadLeft(6, '0');
			Debug.Log(score.ToString().PadLeft(4, '0'));
		 }
		else if(score < 1000){
			MyText.text = "SCORE: " + score.ToString().PadLeft(6, '0');
			Debug.Log("1000");
		}
		else if(score < 10000){
			 MyText.text = "SCORE: " + score.ToString().PadLeft(6, '0');
			 Debug.Log("10000");
		}
		else if(score < 100000){
			 MyText.text = "SCORE: " + score.ToString().PadLeft(6, '0');
			 Debug.Log("100000");
		}
		else {
			 MyText.text = "SCORE: " + score;
			 Debug.Log("1000000");
		}
	}
}
