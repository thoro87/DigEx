using UnityEngine;
using System.Collections;

namespace WaveSimulator {
	public class SimpleAnimation : MonoBehaviour {

		public enum Anim {
			None,
			Sin,
			Cos
		}

		public float Distance = 0.1f;
		public float Speed = 1f;
		public bool IndividualStartTime = true;

		[Space(10)]
		public Anim X = Anim.Sin;
		public Anim Y = Anim.None;
		public Anim Z = Anim.Cos;

		private Vector3 StartPosition;
		private float SpawnTime;

		void Awake() {
			StartPosition = transform.position;
			SpawnTime = Time.time;
		}

		void Update() {
			transform.position = StartPosition + new Vector3(GetCoordinate(X), GetCoordinate(Y), GetCoordinate(Z));
		}

		private float GetCoordinate(Anim anim) {
			float time = IndividualStartTime ? Time.time - SpawnTime : Time.time;
			switch (anim) {
				case Anim.Sin: return Mathf.Sin(time * Speed) * Distance;
				case Anim.Cos: return Mathf.Cos(time * Speed) * Distance;
				default: return 0f;
			}
		}

		public void Config(float newSpawnTime, float distance) {
			SpawnTime = newSpawnTime;
			Distance = distance;
		}
	}
}