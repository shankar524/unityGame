using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataBaseManager : MonoBehaviour {
	public string DomainName,urlServer;
	public Text username, email;
	// Use this for initialization
	void Start () {
		urlServer = DomainName + "/unitybootcamp/login.php";
		//DomainName="192.168.1.24";
	}
	public void UserPush(){
		StartCoroutine ("Connect");
	}

	//for asynchronous function
	IEnumerator Connect()
	{
		WWWForm form = new WWWForm ();
		form.AddField ("username", username.text.ToString ());
		form.AddField ("email", email.text.ToString ());
		WWW w = new WWW (urlServer, form);
		//for animation we can use yoels new WaitfroSeconds
		yield return w;//it prevents from futher code proceed for slow answer receive
		if (!string.IsNullOrEmpty (w.error)) {
			Debug.Log (w.text.ToString());
		} else {
			Debug.Log (w.text.ToString());
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
