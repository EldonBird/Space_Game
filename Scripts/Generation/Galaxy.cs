namespace SpaceGame.Scripts.Generation;
using System.Numerics;
public class Galaxy {

	public Galaxy(float sizeX, float sizeY, int planetNum) {

		for (var i = 0; i < planetNum; i++) {

			float x = (HaltonSequence.Sequence(2, i) - 0.5f) * sizeX;
			float y = (HaltonSequence.Sequence(3, i) - 0.5f) * sizeY;
			
			Vector2 position = new(x, y);

			Planet p = new Planet(position, i);

		}

	}
}
