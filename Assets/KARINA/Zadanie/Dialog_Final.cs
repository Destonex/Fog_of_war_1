using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Dialog_Final : MonoBehaviour
{

	public GameObject Text1;
	public GameObject Name;
	public GameObject Press1;

	private bool isText1 = true;
	public NPC_Task npc_tallkScript;


	// Start is called before the first frame update
	void Start()
    {
		Text1.SetActive(true);
		Press1.SetActive(true);
		Name.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey("r"))
		{
			isText1 = false;

			Text1.SetActive(true);
			Press1.SetActive(true);
			Name.SetActive(true);
			npc_tallkScript.EndDialog = true;
			npc_tallkScript.Dialog2.SetActive(false);
			//npc_tallkScript.move.GetComponent<FirstPersonController>().enabled = true;
			//npc_tallkScript.move.GetComponent<Rigidbody>().useGravity = true;
			npc_tallkScript.gameObject.GetComponent<Animator>().SetBool("Talking", false);
		}

		//if (isText1 == true)
		//{
		//	Text1.SetActive(true);
		//	Press1.SetActive(true);
		//	Name.SetActive(true);
		//}
		//else
		//{
		//	Text1.SetActive(false);
		//	Press1.SetActive(false);
		//	Name.SetActive(false);
		//}
	}
}
