using System.Linq;

namespace SpaceGame.Scripts.HTN;

public class Planner {

	private Domain root = new Domain();
	
	private Task[] planQueue;
	
	
	
	// the planning logic will be in this funciton, 
	public void Plan() {
		
		
		planQueue.Append(new Task());
		
		
	}

	private void Decompose(Task task) {
		
	}
	
	private void Evaluate(Task task)
	{
		
	}

	public Task[] GetAvailableTasks() {

		// this needs to be updated
		
		return new Task[0];



	}
	
	
	
}