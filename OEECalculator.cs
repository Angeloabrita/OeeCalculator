namespace OeeCalculator
{
    /// <summary>
    /// Provides methods for calculating Overall Equipment Effectiveness (OEE) metrics.
    /// </summary>
    public class OEECalculator
    {
        /// <summary>
        /// Calculates the availability factor of the OEE.
        /// </summary>
        /// <param name="runTime">The actual runtime of the production process.</param>
        /// <param name="plannedProductionTime">The planned production time.</param>
        /// <returns>The availability factor as a double value.</returns>
        public static double CalculateAvailability(double runTime, double plannedProductionTime)
        {
            return runTime / plannedProductionTime;
        }

        /// <summary>
        /// Calculates the performance factor of the OEE.
        /// </summary>
        /// <param name="idealCycleTime">The ideal cycle time.</param>
        /// <param name="totalCount">The total count of items produced.</param>
        /// <param name="runTime">The actual runtime of the production process.</param>
        /// <returns>The performance factor as a double value.</returns>
        public static double CalculatePerformance(double idealCycleTime, double totalCount, double runTime)
        {
            return (idealCycleTime * totalCount) / runTime;
        }

        /// <summary>
        /// Calculates the quality factor of the OEE.
        /// </summary>
        /// <param name="goodCount">The count of good items produced.</param>
        /// <param name="totalCount">The total count of items produced.</param>
        /// <returns>The quality factor as a double value.</returns>
        public static double CalculateQuality(double goodCount, double totalCount)
        {
            return goodCount / totalCount;
        }

        /// <summary>
        /// Calculates the overall OEE value.
        /// </summary>
        /// <param name="availability">The availability factor.</param>
        /// <param name="performance">The performance factor.</param>
        /// <param name="quality">The quality factor.</param>
        /// <returns>The overall OEE value as a double value.</returns>
        public static double CalculateOEE(double availability, double performance, double quality)
        {
            return availability * performance * quality;
        }
    }
}
