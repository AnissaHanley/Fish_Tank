using UnityEngine;
using System.Collections;
using System.Collections.Generic; //add this line to use "Lists"

public class GoldFish : MonoBehaviour {
	
	public Transform fishBlueprint; // assign in inspector
	List<fish> fishlist = new List<fish>();
	
	// Use this for initialization
	void Start () {
				int counter = 0;
		
				while (counter < 100) {
			fish newfish = Instantiate (fishBlueprint, Random.insideUnitSphere * 10f, Random.rotation) as fish;
			fishlist.Add (newfish);
						counter++; // "increment" bascially means "+=1"
				
				}
		}
		// Update is called once per frame
		void Update () {
				if (Input.GetKey (KeyCode.Space)) {
						foreach (fish kevin in fishlist) {
								kevin.destination = Vector3.zero;
						}
				}
		}
	}