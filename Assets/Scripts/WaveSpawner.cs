using UnityEngine;
using System.Collections;

namespace WaveSimulator {
	public class WaveSpawner : MonoBehaviour {

		public GameObject AnimatedCube;

		public int MaxRows = 50;
		public int MaxCols = 50;
		public float WaveHeight = 0.7f;
		public float WaveLength = 10f;
        public float Speed = 0.5f;

		void Start() {
			for (float row = 0; row < MaxRows; row++) {
				for (int col = 0; col < MaxCols; col++) {
					GameObject go = (GameObject)Instantiate(AnimatedCube, new Vector3(row, 1, col), Quaternion.identity);
					float customStart = (row / WaveLength) - (col / WaveLength);
					SimpleAnimation script = go.GetComponent<SimpleAnimation>();
					script.Config(customStart, WaveHeight);
					script.X = SimpleAnimation.Anim.None;
					script.Y = SimpleAnimation.Anim.Sin;
					script.Z = SimpleAnimation.Anim.None;
                    script.Speed = Speed;
					go.transform.parent = this.transform;
				}
			}
		}
	}
}
