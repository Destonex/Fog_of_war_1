using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Dialog_Next : MonoBehaviour
{
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Name;
	public GameObject Press1;
	public GameObject Press2;
	private bool isText1 = true;
	public NPC_Task npc_tallkScript;
	public bool end_Finish;
	public GameObject Obgect_Quest;

	public bool active;
	void Start()
	{

	}

	void Update()
	{
		if (Input.GetKey("f"))
		{
			isText1 = false;
		}
		else if (Input.GetKey("r"))
		{
			if (isText1 == false)
				active = false;
			else
				active = true;

			if (end_Finish == false)
			{
				npc_tallkScript.EndDialog = true;
				isText1 = true;
				
				Obgect_Quest.SetActive(true);

				Text1.SetActive(true);
				Text2.SetActive(false);
				Press1.SetActive(true);
				Press2.SetActive(true);
				Name.SetActive(true);
				npc_tallkScript.move.GetComponent<FirstPersonController>().enabled = true;
				//npc_tallkScript.move.GetComponent<Rigidbody>().;
				npc_tallkScript.gameObject.GetComponent<Animator>().SetBool("Talking", false);
			}
			else
            {
				isText1 = true;
				npc_tallkScript.end_Finish = true;
			}
		}

		if (isText1 == true)
		{
			Text1.SetActive(true);
			Text2.SetActive(false);

			Press1.SetActive(true);
			Press2.SetActive(true);
			Name.SetActive(true);
		}
		else
		{
			Text1.SetActive(false);
			Text2.SetActive(true);

			Press1.SetActive(false);
			Press2.SetActive(true);
			Name.SetActive(true);
		}
	}

	//void Update()
	//{

	//	if (Input.GetKey("f"))
	//	{
	//		isText1 = false;
	//	}
	//	else if (Input.GetKey("r"))
	//	{
	//		npc_tallkScript.EndDialog = true;
	//		isText1 = true;
	//		Text1.SetActive(true);
	//		Text2.SetActive(false);

	//		Press1.SetActive(true);
	//		Press2.SetActive(true);
	//		Name.SetActive(true);
	//	}

	//	if (isText1 == true)
	//	{
	//		Text1.SetActive(true);
	//		Text2.SetActive(false);

	//		Press1.SetActive(true);
	//		Press2.SetActive(true);
	//		Name.SetActive(true);
	//	}
	//	else
	//	{
	//		Text1.SetActive(false);
	//		Text2.SetActive(true);

	//		Press1.SetActive(false);
	//		Press2.SetActive(true);
	//		Name.SetActive(true);
	//	}
	//}
}
