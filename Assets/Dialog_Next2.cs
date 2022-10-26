using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog_Next2 : MonoBehaviour
{
	public GameObject Text1;
	public GameObject Text2;
	public GameObject Name;
	public GameObject Press1;
	public GameObject Press2;
	private bool isText1 = true;
	public NPC_Task1 npc_tallkScript;

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
			npc_tallkScript.EndDialog = true;
			isText1 = true;
			Text1.SetActive(true);
			Text2.SetActive(false);

			Press1.SetActive(true);
			Press2.SetActive(true);
			Name.SetActive(true);
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
}