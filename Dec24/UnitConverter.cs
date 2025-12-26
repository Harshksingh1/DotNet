using System;

class UnitConverter
{
    // METHOD 1: Two-unit conversion
    public string Convert(double value, string fromUnit, string toUnit)
    {
        switch (fromUnit)
        {
            case "meter":
                if (toUnit == "kilometer")
                    return "In Kilometer: " + (value * 0.001);
                break;

            case "kilometer":
                if (toUnit == "meter")
                    return "In Meter: " + (value * 1000);
                break;

            case "miles":
                if (toUnit == "feet")
                    return "In Feet: " + (value * 5280);
                break;

            case "feet":
                if (toUnit == "miles")
                    return "In Miles: " + (value / 5280);
                break;

            case "gram":
                if (toUnit == "kilogram")
                    return "In Kilogram: " + (value * 0.001);
                break;

            case "kilogram":
                if (toUnit == "gram")
                    return "In Gram: " + (value * 1000);
                break;

            case "pound":
                if (toUnit == "ounce")
                    return "In Ounce: " + (value * 16);
                break;

            case "ounce":
                if (toUnit == "pound")
                    return "In Pound: " + (value / 16);
                break;

            case "c":
                if (toUnit == "f")
                    return "In Fahrenheit: " + (value * 9.0 / 5 + 32);
                if (toUnit == "k")
                    return "In Kelvin: " + (value + 273.15);
                break;

            case "f":
                if (toUnit == "c")
                    return "In Celsius: " + ((value - 32) * 5.0 / 9);
                break;

            case "k":
                if (toUnit == "c")
                    return "In Celsius: " + (value - 273.15);
                break;

            default:
                return "Invalid unit";
        }

        return "Invalid conversion";
    }

    // METHOD 2: Single-unit conversion (OVERLOADED METHOD)
    public string Convert(double value, string fromUnit)
    {
        switch (fromUnit)
        {
            case "meter":
                return "In Kilometer: " + (value * 0.001);

            case "kilometer":
                return "In Meter: " + (value * 1000);

            case "miles":
                return "In Feet: " + (value * 5280);

            case "feet":
                return "In Miles: " + (value / 5280);

            case "gram":
                return "In Kilogram: " + (value * 0.001);

            case "kilogram":
                return "In Gram: " + (value * 1000);

            case "pound":
                return "In Ounce: " + (value * 16);

            case "ounce":
                return "In Pound: " + (value / 16);

            default:
                return "Invalid unit";
        }
    }
}
