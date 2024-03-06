# OEECalculator NuGet Package

## Overview

The OEECalculator NuGet package provides a simple and efficient way to calculate Overall Equipment Effectiveness (OEE) metrics for production processes. This package includes a `OEECalculator` class with methods to calculate key OEE factors and the overall OEE value.

## Installation

To install the OEECalculator NuGet package, you can use the Package Manager Console with the following command:

```bash
Install-Package OeeCalculator
```

Or you can use the .NET CLI:

```bash
dotnet add package OeeCalculator
```

## Usage

### `OEECalculator` Class

#### `CalculateAvailability(double runTime, double plannedProductionTime)`

Calculates the availability factor of the OEE.

- **Parameters:**
  - `runTime`: The actual runtime of the production process.
  - `plannedProductionTime`: The planned production time.

- **Returns:**
  - Type: `double`
  - The availability factor as a double value.

#### `CalculatePerformance(double idealCycleTime, double totalCount, double runTime)`

Calculates the performance factor of the OEE.

- **Parameters:**
  - `idealCycleTime`: The ideal cycle time.
  - `totalCount`: The total count of items produced.
  - `runTime`: The actual runtime of the production process.

- **Returns:**
  - Type: `double`
  - The performance factor as a double value.

#### `CalculateQuality(double goodCount, double totalCount)`

Calculates the quality factor of the OEE.

- **Parameters:**
  - `goodCount`: The count of good items produced.
  - `totalCount`: The total count of items produced.

- **Returns:**
  - Type: `double`
  - The quality factor as a double value.

#### `CalculateOEE(double availability, double performance, double quality)`

Calculates the overall OEE value.

- **Parameters:**
  - `availability`: The availability factor.
  - `performance`: The performance factor.
  - `quality`: The quality factor.

- **Returns:**
  - Type: `double`
  - The overall OEE value as a double value.

## Example

```csharp
using OeeCalculator;

class Program
{
    static void Main()
    {
        // Example usage
        double runTime = 500;
        double plannedProductionTime = 600;
        double availability = OEECalculator.CalculateAvailability(runTime, plannedProductionTime);

        double idealCycleTime = 5;
        double totalCount = 1000;
        double performance = OEECalculator.CalculatePerformance(idealCycleTime, totalCount, runTime);

        double goodCount = 950;
        double quality = OEECalculator.CalculateQuality(goodCount, totalCount);

        double overallOEE = OEECalculator.CalculateOEE(availability, performance, quality);
    }
}
```

## License

This package is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute it as needed. Contributions are welcome!