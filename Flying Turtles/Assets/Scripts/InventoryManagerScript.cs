using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagerScript : MonoBehaviour
{
	
	public GameObject[] i = new GameObject[4];
	public GameObject[] Ui = new GameObject[4];
	public Sprite[] s = new Sprite[4];
	int totalItems = 0;
	keyObject key;
	Color clear;
	
	
	
    // Start is called before the first frame update
    void Start()
    {
		
		Ui[0] = GameObject.Find("UIItem1");
		Ui[1] = GameObject.Find("UIItem2");
		Ui[2] = GameObject.Find("UIItem3");
		Ui[3] = GameObject.Find("UIItem4");
		clear = new Color(255, 255, 255, 0);
		key = GameObject.Find("moveable").GetComponent<keyObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public bool addItem(GameObject item){
		if(totalItems < 4){
			if(i[0] == null){
				i[0] = item;
				s[0] = i[0].GetComponent<SpriteRenderer>().sprite;
				Ui[0].GetComponent<Image>().sprite = s[0];
				Ui[0].GetComponent<Image>().color = i[0].GetComponent<SpriteRenderer>().color;
				totalItems++;
				
			}
			else if(i[1] == null){
				i[1] = item;
				s[1] = i[1].GetComponent<SpriteRenderer>().sprite;
				Ui[1].GetComponent<Image>().sprite = s[1];
				Ui[1].GetComponent<Image>().color = i[1].GetComponent<SpriteRenderer>().color;
				totalItems++;
			}
			else if(i[2] == null){
				i[2] = item;
				s[2] = i[2].GetComponent<SpriteRenderer>().sprite;
				Ui[2].GetComponent<Image>().sprite = s[2];
				Ui[2].GetComponent<Image>().color = i[2].GetComponent<SpriteRenderer>().color;
				totalItems++;
				
			}
			else {
				i[3] = item;
				s[3] = i[3].GetComponent<SpriteRenderer>().sprite;
				Ui[3].GetComponent<Image>().sprite = s[3];
				Ui[3].GetComponent<Image>().color = i[3].GetComponent<SpriteRenderer>().color;
				totalItems++;
				
			}
			
			key.reach += item.GetComponent<ItemScript>().reach;
			key.sharp += item.GetComponent<ItemScript>().sharp;
			key.flame += item.GetComponent<ItemScript>().flame;
			key.wood += item.GetComponent<ItemScript>().wood;
			key.power += item.GetComponent<ItemScript>().power;
			
			
			
		}
		else{
			return false;
		}
		return true;
	}
	
	public bool removeItem(int j){
		
		if(s[j] != null){
			s[j] = null;
			Ui[j].GetComponent<Image>().sprite = null;
			Ui[j].GetComponent<Image>().color = clear;
			i[j].GetComponent<ItemScript>().Return();
			
			key.reach -= i[j].GetComponent<ItemScript>().reach;
			key.sharp -= i[j].GetComponent<ItemScript>().sharp;
			key.flame -= i[j].GetComponent<ItemScript>().flame;
			key.wood -= i[j].GetComponent<ItemScript>().wood;
			key.power -= i[j].GetComponent<ItemScript>().power;
			
			
			i[j] = null;
			totalItems--;
			
			
			
			
			return true;
			}
		return false;
	}
	
}
