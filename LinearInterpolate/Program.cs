namespace LinearInterpolate
{
	internal class Program
	{
		
		static double[] x = { 1, 2, 3, 4, 5 }; // x-axis values
		static double[] y = { 10, 20, 30, 40, 50 }; // y-axis values

		static void Main()
		{
			double[] input = { 2.5, 3.7, 4.2 }; // input values to predict

			for (int i = 0; i < input.Length; i++)
			{
				double prediction = Interpolate(input[i]);
				Console.WriteLine("Prediction for input {0}: {1}", input[i], prediction);
			}
		}

		static double Interpolate(double xi)
		{
			int i = 0;
			while (i < x.Length - 1 && x[i + 1] < xi)
			{
				i++;
			}

			double x0 = x[i];
			double x1 = x[i + 1];
			double y0 = y[i];
			double y1 = y[i + 1];

			return y0 + (y1 - y0) * (xi - x0) / (x1 - x0);
		}
	}
}