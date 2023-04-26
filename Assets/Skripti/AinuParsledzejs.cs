using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	//Metode ļauj pārslēgties no UI ainas uz Sākuma ainu
	public void UzSakumu()
	{
		SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
	}

	//Metode, kura aizver programmu, ja tā ir izveidota kā .exe
	public void Apturet()
	{
		Application.Quit();
	}

	//Pašiem jāuztaisa metode, kas pārslēdz no sākuma uz UI ainu

	
}
