using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class Example : MonoBehaviour {

	public delegate void myCallbackDelegate(int x);

	[DllImport ("example")]
	private static extern float FooPluginFunction();

	[DllImport ("example")]
	private static extern void FooCallbackFunction(myCallbackDelegate fp);



	// Use this for initialization
	void Start () {
		#if UNITY_ANDROID

		Debug.Log("Result from native - " + FooPluginFunction());
		FooCallbackFunction(new myCallbackDelegate( this.myCallback ));

		#endif
	}
	
	void myCallback( int x )
	{
		Debug.Log("Callback value - " + x);
	}
}
