using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelTextScript : MonoBehaviour
{
    public Text MyText;
    // Start is called before the first frame update
    void Start()
    {	
		MyText = gameObject.GetComponent<Text>();
        MyText.text = "Level 1";
    }

    // Update is called once per frame
    void Update()
    {
		
       
    }
	
	public void LevelUpdate(int level){
		
		 MyText.text = "Level " + level;
	}
}
