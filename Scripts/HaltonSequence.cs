namespace SpaceGame.Scripts;

public class HaltonSequence {

	public float Sequence(int radix, int index) {

		float result = 0;
		float digitalWeight = 1;
		
		
		while (index > 0) {
			digitalWeight = digitalWeight / radix;
			int nominator = index % radix;
			result += nominator * digitalWeight;
			index = index / radix;
		}
		
		return result;
	}
	
	
}