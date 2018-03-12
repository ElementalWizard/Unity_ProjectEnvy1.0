using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour {

	public AudioMixer au;
	private Resolution[] resolutions;
	public Dropdown resDD;

	void Start(){
	
	
		resolutions = Screen.resolutions;

		resDD.ClearOptions ();

		List<string> options = new List<string> ();

		int currentResolutionIndex = 0;
		for (int i = 0; i < resolutions.Length; i++) {
			string option = resolutions [i].width + " x " + resolutions [i].height;
			options.Add (option);
			if (resolutions [i].width == Screen.currentResolution.width && resolutions [i].height == Screen.currentResolution.height) {
				currentResolutionIndex = i;
			}

		}

		resDD.AddOptions (options);
		resDD.value = currentResolutionIndex;
		resDD.RefreshShownValue ();

	}

	public void setResolutions(int resolutionIndex){
		Resolution resolution = resolutions [resolutionIndex];

		Screen.SetResolution (resolution.width,resolution.height,Screen.fullScreen);

	}

	public void setVolume(float volume){
	
		au.SetFloat("volume",volume);
	
	}

	public void setQuality(int qualityIndex){
		QualitySettings.SetQualityLevel (qualityIndex);
	
	}

	public void setFullscreen(bool isFullscreen){
	
		Screen.fullScreen = (isFullscreen);

	
	}
		




}
