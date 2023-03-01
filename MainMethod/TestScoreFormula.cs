using System;

namespace MainMethod
{
	class ScoreImprovement
	{
		public int ScoreIncrease(int Input)
        {
			double increase = (Input) * 6 + 3.5;
			int testscore = Convert.ToInt32(increase);
			return testscore;
        }
		public int ScoreIncrease(double Input2)
		{
			double increase = (Input2) * 6 + 3.5;
			int testscore = Convert.ToInt32(increase);
			return testscore;
		}
		public int ScoreIncrease(string Input3)
		{
			int testScore2 = Int32.Parse(Input3);
			double increase = (testScore2) * 6 + 3.5;
			int testscore = Convert.ToInt32(increase);
			return testscore;
		}
	}
} 
