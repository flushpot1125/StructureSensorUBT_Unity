using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace StructureAR
{

public class AutoScanController : MonoBehaviour {

		[SerializeField] Button button;
		private float timeOut=4.0f;
		private float timeElapsed;

		void Update(){
			timeElapsed += Time.deltaTime;

			if(timeElapsed >= timeOut) {
				generateFrameAndDisappear ();

				timeElapsed = 0.0f;
			}
		}

		private void generateFrameAndDisappear(){
			button.onClick.Invoke ();
		}

}
}
