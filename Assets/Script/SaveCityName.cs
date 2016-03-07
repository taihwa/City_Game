using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class SaveCityName : MonoBehaviour {

	public GameObject NameInput;

	void GetCityName() {

		InputField inputField = NameInput.GetComponent<InputField> ();

		FsmString globalName = FsmVariables.GlobalVariables.FindFsmString("CityName");
		globalName.Value = inputField.text;

	}
}
