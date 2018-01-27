using UnityEngine;

public class FireLightScript : MonoBehaviour
{
	public float minIntensity = 0.25f;
	public float maxIntensity = 0.5f;

	public Light fireLight;

	float random;

	ParticleSystem[] childrenParticleSystems;
	bool disabledRelevantPSEmissions = false;

	void Awake() {
		childrenParticleSystems = gameObject.GetComponentsInChildren<ParticleSystem> ();

		if (!disabledRelevantPSEmissions) {
			foreach (ParticleSystem childPS in childrenParticleSystems) {
				ParticleSystem.EmissionModule childPSEmissionModule = childPS.emission;
				childPSEmissionModule.enabled = false;
				fireLight.enabled = false;
			}
		}
	}

	void Update()
	{
		random = Random.Range(0.0f, 150.0f);
		float noise = Mathf.PerlinNoise(random, Time.time);
		fireLight.GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			if (!disabledRelevantPSEmissions) {
				foreach (ParticleSystem childPS in childrenParticleSystems) {
					ParticleSystem.EmissionModule childPSEmissionModule = childPS.emission;
					childPSEmissionModule.enabled = true;
					fireLight.enabled = true;
				}
			}
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.CompareTag ("Player")) {
			if (!disabledRelevantPSEmissions) {
				foreach (ParticleSystem childPS in childrenParticleSystems) {
					ParticleSystem.EmissionModule childPSEmissionModule = childPS.emission;
					childPSEmissionModule.enabled = false;
					fireLight.enabled = false;
				}
			}
		}
	}
}